using System;
using System.Collections.Generic;
using System.Linq;
using Leaderboard.Models;
using Leaderboard.Dtos;

namespace Leaderbord.Repositories
{
    public class UserList : IUserList
    {
        public readonly List<User> userList = new()
        {
            new User
            {
                Id = Guid.NewGuid(),
                username = "Gosfi",
                Country = "Canada",
                socials = new List<SocialDto>() { new SocialDto { socialMediaName = "Youtube", url = "https://www.youtube.com/" } },
                AccountCreationDate = DateTimeOffset.UtcNow,
                type = enums.AccountType.ADMIN
            }
        };
        public void CreateUser(User user)
        {
            userList.Add(user);
        }

        public User GetUser(Guid id)
        {
            return userList.Where(user => user.Id == id).SingleOrDefault();
        }

        public IEnumerable<User> GetUsers()
        {
            return userList;
        }
    }
}