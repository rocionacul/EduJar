using System.Collections.Generic;
using EdujarBackend.Models.Schema;

namespace EdujarBackend.Services
{
    public interface IGameLogicService
    {
        IEnumerable<Game> ListAvailableGames(int userId);
        Game GetGameData(int gameConfigId);
        //TODO Define GameMetadata
        bool UpdateGameMetadata(int gameConfigId/*, GameMetadata metadata*/);
        void CreateGame();
    }
}