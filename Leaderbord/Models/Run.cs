using System;
using Leaderboard.Dtos;

namespace Leaderbord.Models
{
    public record Run
    {
        public Guid Id { get; init; }
        public GameDto game { get; init; }
        public UserDto user { get; init; }
        public CategoryDto category { get; init; }
        public DateTime date { get; init; }
        public int hours { get; init; }
        public int minutes { get; init; }
        public int seconds { get; init; }
        public DateTimeOffset creationDate { get; init; }
    }
}