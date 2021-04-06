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
        private readonly GamesList repository;

        public GamesController()
        {
            repository = GamesList.Instance;
        }

        [HttpGet]
        public IEnumerable<Game> GetGames()
        {
            var games = repository.GetGames();
            return games;
        }

        [HttpGet("{id}")]
        public Game GetGame(Guid id)
        {
            var game = repository.GetItem(id);
            return game;
        }
    }
}