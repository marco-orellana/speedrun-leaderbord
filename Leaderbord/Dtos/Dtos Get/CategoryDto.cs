using System.Collections.Generic;

namespace Leaderboard.Dtos
{
    public record CategoryDto
    {
        public GameDto AssociatedGame { get; init; }
        public string categoryName { get; init; }
        public string categoryRules { get; init; }
        public List<RunDto> runs { get; init; }
    }
}