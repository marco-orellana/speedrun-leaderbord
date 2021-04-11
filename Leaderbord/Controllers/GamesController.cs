using System;
using System.Collections.Generic;
using System.Linq;
using Leaderboard.Models;
using Leaderboard.Dtos;
using Leaderboard.Dtos.Dtos_Create;
using Leaderboard.Extension_methods;
using Leaderbord.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Leaderboard.Controllers
{
    [ApiController]
    [Route("games")]
    public class GamesController : ControllerBase
    {
        private readonly IGamesList repository;

        public GamesController(IGamesList provider)
        {
            repository = provider;
        }

        [HttpGet]
        public IEnumerable<GameDto> GetGames()
        {
            var games = repository.GetGames().Select(game => game.AsDto());
            return games;
        }

        [HttpGet("{id}")]
        public ActionResult<GameDto> GetGame(Guid id)
        {
            var game = repository.GetGame(id);
            if (game is null)
            {
                return NotFound();
            }
            return game.AsDto();
        }

        [HttpPost]
        public ActionResult<GameDto> CreateGame(CreateGameDto gameDto)
        {
            Game game = new()
            {
                Id = Guid.NewGuid(),
                Name = gameDto.Name,
                YearOfRelease = gameDto.YearOfRelease,
                consolesReleasedOn = gameDto.consolesReleasedOn
            };
            repository.CreateGame(game);

            return CreatedAtAction(nameof(GetGame), new{id = game.Id}, game.AsDto());
        }

    }
}