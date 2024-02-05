using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace WebApp;

public partial class GenreListFormatterAttribute : CustomFormatterAttribute
{
    public const string Key = "WebApp.GenreListFormatter";

    public GenreListFormatterAttribute()
        : base(Key)
    {
    }
}