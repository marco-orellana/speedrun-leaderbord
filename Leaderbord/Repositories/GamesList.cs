using System;
using System.Collections.Generic;
using Leaderboard.Models;
using System.Linq;

namespace Leaderbord.Repositories
{

    public class GamesList
    {
        #region Singleton
        private static GamesList instance = null;

        public static GamesList Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GamesList();
                }
                return instance;
            }
        }
        #endregion
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

        public Game GetItem(Guid id)
        {
            return gameList.Where(game => game.Id == id).SingleOrDefault();
        }
    }
}