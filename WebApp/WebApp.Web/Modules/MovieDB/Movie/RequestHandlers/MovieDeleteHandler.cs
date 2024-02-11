using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = WebApp.MovieDB.MovieRow;

namespace WebApp.MovieDB;

public interface IMovieDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class MovieDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IMovieDeleteHandler
{
    public IServiceResolver<IMovieCastDeleteHandler> movieCastDelete;
    public MovieDeleteHandler(IRequestContext context,
        IServiceResolver<IMovieCastDeleteHandler> movieCastDelete)
            : base(context)
    {
        this.movieCastDelete = movieCastDelete ?? throw new ArgumentNullException(nameof(movieCastDelete));
    }

    protected override void OnBeforeDelete()
    {
        base.OnBeforeDelete();

        var mc = MovieCastRow.Fields;
        foreach (var detailID in Connection.Query<Int32>(
            new SqlQuery()
            .From(mc)
            .Select(mc.MovieCastId)
            .Where(mc.MovieId == Row.MovieId.Value)))
        {
            movieCastDelete.Resolve().Delete(this.UnitOfWork, new()
            {
                EntityId = detailID
            });
        }
    }
}