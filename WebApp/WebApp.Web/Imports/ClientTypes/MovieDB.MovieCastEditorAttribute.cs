using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace WebApp.MovieDB;

public partial class MovieCastEditorAttribute : CustomEditorAttribute
{
    public const string Key = "WebApp.MovieDB.MovieCastEditor";

    public MovieCastEditorAttribute()
        : base(Key)
    {
    }
}