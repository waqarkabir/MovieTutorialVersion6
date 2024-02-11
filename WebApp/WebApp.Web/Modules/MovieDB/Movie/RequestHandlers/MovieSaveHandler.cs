using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<WebApp.MovieDB.MovieRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = WebApp.MovieDB.MovieRow;

namespace WebApp.MovieDB;

public interface IMovieSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class MovieSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IMovieSaveHandler
{
    private readonly IServiceResolver<IMovieCastDeleteHandler> movieCastDelete;
    private readonly IServiceResolver<IMovieCastSaveHandler> movieCastSave;
    public MovieSaveHandler(IRequestContext context,
        IServiceResolver<IMovieCastDeleteHandler> movieCastDelete,
        IServiceResolver<IMovieCastSaveHandler> movieCastSave) : base(context)
    {
        this.movieCastDelete = movieCastDelete ?? throw new ArgumentNullException(nameof(movieCastDelete));
        this.movieCastSave = movieCastSave ?? throw new ArgumentNullException(nameof(movieCastSave));
    }

    protected override void AfterSave()
    {
        base.AfterSave();

        if (Row.CastList == null)
        {
            return;
        }

        var mc = MovieCastRow.Fields;
        var oldList = IsCreate ? new List<MovieCastRow>()
            : Connection.List<MovieCastRow>(mc.MovieId == Row.MovieId.Value);

        var oldById = oldList.ToDictionary(x => x.MovieCastId.Value);
        var newById = Row.CastList.ToLookup(x => x.MovieCastId);

        foreach (var row in oldList.Where(x => !newById.Contains(x.MovieCastId)))
        {
            movieCastDelete.Resolve().Delete(UnitOfWork, new() { EntityId = row.MovieCastId });
        }

        foreach (var row in Row.CastList)
        {
            var entity = row.Clone();
            entity.MovieId = Row.MovieId.Value;

            if (row.MovieCastId == null || !oldById.ContainsKey(row.MovieCastId.Value))
            {
                entity.MovieCastId = null;
                movieCastSave.Resolve().Create(UnitOfWork, new() { Entity = entity });
            }
            else
            {
                movieCastSave.Resolve().Update(UnitOfWork, new() { Entity = entity });
            }
        }
    }
}