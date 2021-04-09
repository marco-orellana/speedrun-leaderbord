using System;
using System.Collections.Generic;
using System.Linq;
using Leaderboard.Models;
using Leaderbord.Dtos;
using Leaderbord.Extension_methods;
using Leaderbord.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Leaderbord.Controllers
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
            if(game is null)
            {
                return NotFound();
            }
            return game.AsDto();
        }

        
    }
}