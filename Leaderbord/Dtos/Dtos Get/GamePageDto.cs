using System.Collections.Generic;
using Leaderboard.Dtos;

namespace Leaderbord.Dtos.Dtos_Get
{
    public record GamePageDto
    {
        public GameDto game { get; init; }
        public List<CategoryDto> Categories { get; set; }
        public List<UserDto> Moderators { get; init; }
    }
}