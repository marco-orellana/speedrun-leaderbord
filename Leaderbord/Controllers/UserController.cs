using System;
using System.Collections.Generic;
using System.Linq;
using Leaderbord.Dtos;
using Leaderbord.Dtos.Dtos_Create;
using Leaderbord.Extension_methods;
using Leaderbord.Models;
using Leaderbord.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Leaderbord.Controllers
{
    [ApiController]
    [Route("users")]
    public class UserController : ControllerBase
    {
        private readonly IUserList repository;

        public UserController(IUserList provider)
        {
            repository = provider;
        }

        [HttpGet]
        public IEnumerable<UserDto> GetUsers()
        {
            var users = repository.GetUsers().Select(user => user.AsDto());
            return users;
        }

        [HttpGet("{id}")]
        public ActionResult<UserDto> GetUser(Guid id)
        {
            var user = repository.GetUser(id);
            if(user is null)
            {
                return NotFound();
            }
            return user.AsDto();
        }

        [HttpPost]
        public ActionResult<UserDto> CreateUser(CreateUserDto userDto)
        {
            User user = new()
            {
              Id = Guid.NewGuid(),
              username = userDto.username,
              Country = userDto.Country,
              socials = userDto.socials,
              AccountCreationDate = DateTimeOffset.UtcNow
            };
            repository.CreateUser(user);
            return CreatedAtAction(nameof(GetUser), new{id = user.Id}, user.AsDto());
        }
    }
}