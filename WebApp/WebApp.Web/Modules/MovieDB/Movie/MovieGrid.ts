import { Decorators, EntityGrid, QuickSearchField} from '@serenity-is/corelib';
import { MovieColumns, MovieRow, MovieService } from '@/ServerTypes/MovieDB';
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
}