using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace WebApp.MovieDB;

public partial class PersonMovieGridAttribute : CustomEditorAttribute
{
    public const string Key = "WebApp.MovieDB.PersonMovieGrid";

    public PersonMovieGridAttribute()
        : base(Key)
    {
    }
}