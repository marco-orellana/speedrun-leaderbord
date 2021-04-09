using System;
using System.Collections.Generic;
using Leaderboard.Models;
using System.Linq;

namespace Leaderbord.Repositories
{
    public class GamesList : IGamesList
    {
        private readonly List<Game> gameList = new List<Game>()
        {
            new Game
            {
                Id = Guid.NewGuid(),
                Name = "Mario Kart 64",
                YearOfRelease = 1996,
                consolesReleasedOn = new List<string>(){ "Nintendo 64", "Wii virtual console", "Wii U Virtual Console" }
            },
            new Game
            {
                Id = Guid.NewGuid(),
                Name = "Banjo-Kazooie",
                YearOfRelease = 1998,
               consolesReleasedOn = new List<string>(){ "Nintendo 64", "Xbox 360", "Xbox one", "Xbox series X/S" }
            },
            new Game
            {
                Id = Guid.NewGuid(),
                Name = "Super Mario Bros.",
                YearOfRelease = 1985,
                consolesReleasedOn = new List<string>(){ "NES", "SNES", "GBA", "Wii Virtual console", "Wii", "3DS Virtual console", "Famicom disk system", "Wii U virtual console", "NES classic", "Switch", "SNES classic" }
            }
        };

        public IEnumerable<Game> GetGames()
        {
            return gameList;
        }

        public Game GetGame(Guid id)
        {
            return gameList.Where(game => game.Id == id).SingleOrDefault();
        }

        public void CreateGame(Game game)
        {
            gameList.Add(game);
        }
    }
}