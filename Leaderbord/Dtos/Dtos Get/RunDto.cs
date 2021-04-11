using System;
using Leaderboard.Models;

namespace Leaderboard.Dtos
{
    public record RunDto
    {
         public Game game { get; init; }
        public User user { get; init; }
        public Category category { get; init; }
        public DateTimeOffset date { get; init; }
        public int hours { get; init; }
        public int minutes { get; init; }
        public int seconds { get; init; }
        public DateTimeOffset creationDate { get; init; }
    }
}