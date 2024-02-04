﻿import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { MovieKind } from "../Modules/MovieDB.Movie.MovieKind";
import { MovieRow } from "./MovieRow";

export interface MovieColumns {
    MovieId: Column<MovieRow>;
    Title: Column<MovieRow>;
    Description: Column<MovieRow>;
    Storyline: Column<MovieRow>;
    Year: Column<MovieRow>;
    ReleaseDate: Column<MovieRow>;
    Runtime: Column<MovieRow>;
    GenreName: Column<MovieRow>;
    Kind: Column<MovieRow>;
}

export class MovieColumns extends ColumnsBase<MovieRow> {
    static readonly columnsKey = 'MovieDB.Movie';
    static readonly Fields = fieldsProxy<MovieColumns>();
}

[MovieKind]; // referenced types