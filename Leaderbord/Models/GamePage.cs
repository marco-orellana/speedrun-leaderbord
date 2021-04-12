using System.Collections.Generic;
using Leaderboard.Dtos;
using System;

namespace Leaderboard.Models
{
    public record GamePage
    {
        public Guid Id { get; init; }
        public GameDto game { get; init; }
        public List<CategoryDto> Categories { get; set; }
        public List<UserDto> Moderators { get; init; }
    }
}