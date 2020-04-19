using System;
using System.Collections.Generic;
using EdujarBackend.Models.Schema;
using EdujarBackend.Repositories;

namespace EdujarBackend.Services
{
    public class GameLogicService : IGameLogicService
    {
        public void CreateGame()
        {
            new GameRepository().CreateGame(new Game
            {
                Name = "Holiwis",
                Description = "Una descripcion wasa",
                Objective = "Alto objective"
            });
        }

        public Game GetGameData(int gameConfigId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Game> ListAvailableGames(int userId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateGameMetadata(int gameConfigId)
        {
            throw new NotImplementedException();
        }
    }
}