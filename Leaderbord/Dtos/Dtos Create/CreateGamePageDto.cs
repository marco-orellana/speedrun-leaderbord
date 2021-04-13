using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Leaderboard.Dtos;

namespace Leaderbord.Dtos.Dtos_Create
{
    public record CreateGamePageDto
    {
        [Required]
        public GameDto game { get; init; }
        [Required]
        public List<CategoryDto> Categories { get; set; }
        public List<UserDto> Moderators { get; init; }
    }
}