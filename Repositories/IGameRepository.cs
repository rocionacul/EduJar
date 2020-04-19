using EdujarBackend.Models.Schema;

namespace EdujarBackend.Repositories
{
    public interface IGameRepository
    {
        Game GetBaseGameData(int gameId);
        bool CreateGame(Game game);
    }
}