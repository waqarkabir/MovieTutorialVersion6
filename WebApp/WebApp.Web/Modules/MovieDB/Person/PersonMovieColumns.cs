using Serenity.ComponentModel;
using System;
using System.ComponentModel;
using WebApp.Modules.MovieDB;

namespace WebApp.MovieDB.Columns;

[ColumnsScript]
[BasedOnRow(typeof(MovieCastRow), CheckNames = false)]
public class PersonMovieColumns
{
    [Width(200)]
    public string MovieTitle { get; set; }

    [Width(200)]
    public string Character { get; set; }
}