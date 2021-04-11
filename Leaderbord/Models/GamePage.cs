using System.Collections.Generic;
using Leaderboard.Dtos;

namespace Leaderboard.Models
{
    public record GamePage
    {
        public Game game { get; init; }
        public List<CategoryDto> Categories { get; set; }
        public List<UserDto> Moderators { get; init; }
    }
}