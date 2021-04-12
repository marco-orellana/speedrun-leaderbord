using System;
using Leaderboard.Models;

namespace Leaderbord.Models
{
    public record Run
    {
        public Guid Id { get; init; }
        public Game game { get; init; }
        public User user { get; init; }
        public Category category { get; init; }
        public DateTime date { get; init; }
        public int hours { get; init; }
        public int minutes { get; init; }
        public int seconds { get; init; }
        public DateTimeOffset creationDate { get; init; }
    }
}