import { Decorators, EntityGrid, first, localText, LookupEditor, QuickSearchField} from '@serenity-is/corelib';
import { MovieColumns, MovieRow, MovieService } from '@/ServerTypes/MovieDB';
import { MovieListRequest } from '@/ServerTypes/Modules/MovieDB.Movie.MovieListRequest';
import { MovieDialog } from './MovieDialog';

@Decorators.registerClass('WebApp.MovieDB.MovieGrid')
export class MovieGrid extends EntityGrid<MovieRow, any> {
    protected getColumnsKey() { return MovieColumns.columnsKey; }
    protected getDialogType() { return MovieDialog; }
    protected getRowDefinition() { return MovieRow; }
    protected getService() { return MovieService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
    protected getQuickSearchFields(): QuickSearchField[] {
        const fields = MovieRow.Fields;
        return [
            { name: "", title : "All" },
            { name: fields.Description, title: fields.Description },
            { name: fields.Storyline, title: fields.Storyline },
            { name: fields.Year, title: fields.Year }
        ];
    }

    protected getQuickFilters() {
        let items = super.getQuickFilters();

        const genreListFilter = first(items, x =>
            x.field == MovieRow.Fields.GenreList);

        genreListFilter.handler = h => {
            const request = (h.request as MovieListRequest);
            const values = (h.widget as LookupEditor).values;
            request.Genres = values.map(x => parseInt(x, 10));
            h.handled = true;
        };

        return items;
    }
}