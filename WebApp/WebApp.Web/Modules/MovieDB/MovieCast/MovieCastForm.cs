using Serenity.ComponentModel;

namespace WebApp.MovieDB.Forms;

[FormScript("MovieDB.MovieCast")]
[BasedOnRow(typeof(MovieCastRow), CheckNames = true)]
public class MovieCastForm
{
    public int PersonId { get; set; }
    public string Character { get; set; }
}