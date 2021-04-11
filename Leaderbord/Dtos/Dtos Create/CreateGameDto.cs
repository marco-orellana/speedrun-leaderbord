using System.Collections.Generic;

namespace Leaderboard.Dtos.Dtos_Create
{
    public record CreateGameDto
    {
        public string Name { get; init; }
        public int YearOfRelease { get; init; }
        public List<string> consolesReleasedOn { get; init; }
    }
}