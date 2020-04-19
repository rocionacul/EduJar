using EdujarBackend.Models.Contexts;
using EdujarBackend.Models.Schema;

namespace EdujarBackend.Repositories
{
    public class GameRepository : IGameRepository
    {
        private readonly SqliteContext _context = new SqliteContext();

        public Game GetBaseGameData(int gameId)
        {
            return _context.Games.Find(gameId);
        }

        public bool CreateGame(Game game)
        {
            _context.Games.Add(game);
            var result = _context.SaveChanges();
            return result > 0;
        }
    }
}