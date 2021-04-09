using System;
using System.Collections.Generic;
using Leaderboard.Models;

namespace Leaderbord.Repositories
{
     public interface IGamesList
    {
        Game GetGame(Guid id);
        IEnumerable<Game> GetGames();
        void CreateGame(Game game);
    }
}