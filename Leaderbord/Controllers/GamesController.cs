using System;
using System.Collections.Generic;
using Leaderboard.Models;
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
        public IEnumerable<Game> GetGames()
        {
            var games = repository.GetGames();
            return games;
        }

        [HttpGet("{id}")]
        public ActionResult<Game> GetGame(Guid id)
        {
            var game = repository.GetGame(id);
            if(game is null)
            {
                return NotFound();
            }
            return game;
        }
    }
}