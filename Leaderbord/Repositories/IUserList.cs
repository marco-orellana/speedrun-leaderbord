using System;
using System.Collections.Generic;
using Leaderbord.Models;

namespace Leaderbord.Repositories
{
    public interface IUserList
    {
        User GetUser(Guid id);
        IEnumerable<User> GetUsers();
        void CreateUser(User user);
    }
}