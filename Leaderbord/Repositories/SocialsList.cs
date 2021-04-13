using System;
using System.Collections.Generic;
using Leaderboard.Models;
using System.Linq;

namespace Leaderbord.Repositories
{
    public class SocialsList : ISocialList
    {
        public readonly List<Socials> socials = new List<Socials>();

        public Socials GetSocial(Guid id)
        {
            return socials.Where(social => social.Id == id).SingleOrDefault();
        }

        public IEnumerable<Socials> GetSocials()
        {
            return socials;
        }
    }
}