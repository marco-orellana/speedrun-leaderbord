using System;
using Leaderboard.Dtos;

namespace Leaderbord.Dtos.Dtos_Create
{
    public record CreateRunDto
    {
        public GameDto game { get; init; }
        public UserDto user { get; init; }
        public CategoryDto category { get; init; }
        public DateTimeOffset date { get; init; }
        public int hours { get; init; }
        public int minutes { get; init; }
        public int seconds { get; init; }
    }
}