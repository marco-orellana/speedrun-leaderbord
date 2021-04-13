using System;
using Leaderboard.Models;

namespace Leaderboard.Dtos
{
    public record RunDto
    {
        public GameDto game { get; init; }
        public UserDto user { get; init; }
        public CategoryDto category { get; init; }
        public int hours { get; init; }
        public int minutes { get; init; }
        public int seconds { get; init; }
    }
}