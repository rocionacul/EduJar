using EdujarBackend.Services;
using Microsoft.AspNetCore.Mvc;

namespace EdujarBackend.Controllers
{
    [Route("api/games")]
    [ApiController]
    public class GameLogicController : ControllerBase
    {
        private readonly IGameLogicService _gameLogicService;

        public GameLogicController(IGameLogicService logicService)
        {
            _gameLogicService = new GameLogicService();
        }

        [HttpPost]
        public IActionResult Add()
        {
            _gameLogicService.CreateGame();
            return Ok();
        }
    }
}
