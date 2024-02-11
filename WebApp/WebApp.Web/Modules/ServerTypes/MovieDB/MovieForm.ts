import { MovieCastEditor } from "@/MovieDB/MovieCast/MovieCastEditor";
import { StringEditor, TextAreaEditor, IntegerEditor, DateEditor, EnumEditor, LookupEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";
import { MovieKind } from "../Modules/MovieDB.Movie.MovieKind";

export interface MovieForm {
    Title: StringEditor;
    Description: TextAreaEditor;
    CastList: MovieCastEditor;
    Storyline: TextAreaEditor;
    Year: IntegerEditor;
    ReleaseDate: DateEditor;
    Runtime: IntegerEditor;
    Kind: EnumEditor;
    GenreList: LookupEditor;
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
            var w2 = MovieCastEditor;
            var w3 = IntegerEditor;
            var w4 = DateEditor;
            var w5 = EnumEditor;
            var w6 = LookupEditor;

            initFormType(MovieForm, [
                'Title', w0,
                'Description', w1,
                'CastList', w2,
                'Storyline', w1,
                'Year', w3,
                'ReleaseDate', w4,
                'Runtime', w3,
                'Kind', w5,
                'GenreList', w6
            ]);
        }
    }
}

[MovieKind]; // referenced types