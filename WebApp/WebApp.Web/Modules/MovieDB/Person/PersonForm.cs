using Serenity.ComponentModel;
using Serenity.Demo.Northwind;
using System;
using WebApp.Modules.MovieDB;

namespace WebApp.MovieDB.Forms;

[FormScript("MovieDB.Person")]
[BasedOnRow(typeof(PersonRow), CheckNames = true)]
public class PersonForm
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public string BirthPlace { get; set; }
    public Modules.MovieDB.Gender Gender { get; set; }
    public int Height { get; set; }
}