import { Decorators, UpdatableAttribute } from '@serenity-is/corelib';
import { GridEditorBase } from '@serenity-is/extensions';
import { MovieCastColumns, MovieCastRow, PersonRow } from '@/ServerTypes/MovieDB';
import { MovieCastEditDialog } from './MovieCastEditDialog';

@Decorators.registerEditor('WebApp.MovieDB.MovieCastEditor')
export class MovieCastEditor extends GridEditorBase<MovieCastRow  > {
    protected getColumnsKey() { return MovieCastColumns.columnsKey; }
    protected getLocalTextPrefix() { return MovieCastRow.localTextPrefix; }
    protected getDialogType() { return MovieCastEditDialog}

    constructor(container: JQuery) {
        super(container);
    }

    protected getAddButtonCaption() {
        return "Add";
    }

    protected validateEntity(row: MovieCastRow, id: number) {
        if (!super.validateEntity(row, id)) {
            return false;
        }

        var itemId = id ?? row[this.getIdProperty()];
        PersonRow.getLookupAsync().then(x => {
            var item = this.view?.getItemById(itemId);
            if (item) {
                item.PersonFullName = x.itemById[row.PersonId].FullName;
                this.view.updateItem(itemId, item);
            }
        });

        return true;
    }
}