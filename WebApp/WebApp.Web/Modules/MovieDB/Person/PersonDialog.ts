import { PersonForm, PersonRow, PersonService } from '@/ServerTypes/MovieDB';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('WebApp.MovieDB.PersonDialog')
export class PersonDialog extends EntityDialog<PersonRow, any> {
    protected getFormKey() { return PersonForm.formKey; }
    protected getRowDefinition() { return PersonRow; }
    protected getService() { return PersonService.baseUrl; }

    protected form = new PersonForm(this.idPrefix);
}