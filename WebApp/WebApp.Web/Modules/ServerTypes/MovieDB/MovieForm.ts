import { StringEditor, TextAreaEditor, IntegerEditor, DateEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface MovieForm {
    Title: StringEditor;
    Description: TextAreaEditor;
    Storyline: TextAreaEditor;
    Year: IntegerEditor;
    ReleaseDate: DateEditor;
    Runtime: IntegerEditor;
}

export class MovieForm extends PrefixedContext {
    static readonly formKey = 'MovieDB.Movie';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!MovieForm.init)  {
            MovieForm.init = true;

            var w0 = StringEditor;
            var w1 = TextAreaEditor;
            var w2 = IntegerEditor;
            var w3 = DateEditor;

            initFormType(MovieForm, [
                'Title', w0,
                'Description', w1,
                'Storyline', w1,
                'Year', w2,
                'ReleaseDate', w3,
                'Runtime', w2
            ]);
        }
    }
}