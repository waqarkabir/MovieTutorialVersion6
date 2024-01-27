import { MovieColumns, MovieRow, MovieService } from '@/ServerTypes/MovieDB';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
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
}