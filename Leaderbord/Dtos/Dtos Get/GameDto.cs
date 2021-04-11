using System;
using System.Collections.Generic;

namespace Leaderboard.Dtos
{
    public record GameDto
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
        public int YearOfRelease { get; init; }
        public List<string> consolesReleasedOn { get; init; }
    }
}