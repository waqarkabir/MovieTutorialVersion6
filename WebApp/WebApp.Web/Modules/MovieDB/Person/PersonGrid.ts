import { PersonColumns, PersonRow, PersonService } from '@/ServerTypes/MovieDB';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { PersonDialog } from './PersonDialog';

@Decorators.registerClass('WebApp.MovieDB.PersonGrid')
export class PersonGrid extends EntityGrid<PersonRow, any> {
    protected getColumnsKey() { return PersonColumns.columnsKey; }
    protected getDialogType() { return PersonDialog; }
    protected getRowDefinition() { return PersonRow; }
    protected getService() { return PersonService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}