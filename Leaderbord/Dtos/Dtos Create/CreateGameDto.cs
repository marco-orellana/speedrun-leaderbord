using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Leaderboard.Dtos.Dtos_Create
{
    public record CreateGameDto
    {
        [Required]
        public string Name { get; init; }
        [Required]
        public int YearOfRelease { get; init; }
        public List<string> consolesReleasedOn { get; init; }
    }
}