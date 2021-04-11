using System;
using System.Collections.Generic;
using Leaderboard.Dtos;

namespace Leaderboard.Models
{
    public record Category
    {
        public GameDto AssociatedGame { get; init; }
        public string categoryName { get; init; }
        public string categoryRules { get; init; }
        public List<RunDto> runs { get; init; }
        public DateTimeOffset creationDate { get; init; }
    }
}