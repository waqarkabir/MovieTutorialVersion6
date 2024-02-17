import { PersonMovieColumns, PersonRow, PersonService } from '@/ServerTypes/MovieDB';
import { MovieCastRow, MovieCastService } from '../../ServerTypes/MovieDB';
import { Decorators, EntityGrid } from '@serenity-is/corelib';

@Decorators.registerEditor('WebApp.MovieDB.PersonMovieGrid')
export class PersonMovieGrid extends EntityGrid<MovieCastRow, any> {
    protected getColumnsKey() { return PersonMovieColumns.columnsKey; }
    protected getRowDefinition() { return MovieCastRow; }
    protected getService() { return MovieCastService.baseUrl; }
    private _personId: number;
    constructor(container: JQuery) {
        super(container);
    }

    get personId() {
        return this._personId;
    }

    protected getButtons(){
        return null;
    }

    protected getInitialTitle() {
        return null;
    }

    protected usePager() {
        return null;
    }

    protected getGridCanLoad() {
        return this.personId != null;
    }

    set personId(value: number) {
        if (this._personId!=value) {
            this._personId = value;
            this.setEquality(MovieCastRow.Fields.PersonId, value);
            this.refresh();
        }
    }
}