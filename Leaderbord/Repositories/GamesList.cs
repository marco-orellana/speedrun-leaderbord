using System;
using System.Collections.Generic;
using Leaderboard.Models;
using System.Linq;

namespace Leaderbord.Repositories
{
    public class GamesList: IGamesList
    {
        private readonly List<Game> gameList = new()
        {
            new Game { Id = Guid.NewGuid(), Name = "Mario Kart 64", YearOfRelease = 1996 },
            new Game { Id = Guid.NewGuid(), Name = "Banjo-Kazooie", YearOfRelease = 1998 },
            new Game { Id = Guid.NewGuid(), Name = "Super Mario Bros.", YearOfRelease = 1985 }
        };

        public IEnumerable<Game> GetGames()
        {
            return gameList;
        }

        public Game GetGame(Guid id)
        {
            return gameList.Where(game => game.Id == id).SingleOrDefault();
        }
    }
}