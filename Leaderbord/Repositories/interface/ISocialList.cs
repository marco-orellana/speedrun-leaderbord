using System;
using System.Collections.Generic;
using Leaderboard.Models;

namespace Leaderbord.Repositories
{
    public interface ISocialList
    {
        Socials GetSocial(Guid id);
        IEnumerable<Socials> GetSocials();
    }
}