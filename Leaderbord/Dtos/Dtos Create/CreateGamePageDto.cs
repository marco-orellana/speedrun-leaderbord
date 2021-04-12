using System.Collections.Generic;
using Leaderboard.Dtos;

namespace Leaderbord.Dtos.Dtos_Create
{
    public record CreateGamePageDto
    {
        public GameDto game { get; init; }
        public List<CategoryDto> Categories { get; set; }
        public List<UserDto> Moderators { get; init; }
    }
}