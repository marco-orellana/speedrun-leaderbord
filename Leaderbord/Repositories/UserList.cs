using System;
using System.Collections.Generic;
using System.Linq;
using Leaderbord.Models;

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
                socials = new List<Dtos.SocialDto>(),
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