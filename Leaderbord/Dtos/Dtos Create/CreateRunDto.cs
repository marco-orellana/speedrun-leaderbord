using System;
using System.ComponentModel.DataAnnotations;
using Leaderboard.Dtos;

namespace Leaderbord.Dtos.Dtos_Create
{
    public record CreateRunDto
    {
        [Required]
        public GameDto game { get; init; }
        [Required]
        public UserDto user { get; init; }
        [Required]
        public CategoryDto category { get; init; }
        public DateTimeOffset date { get; init; }
        [Required]
        public int hours { get; init; }
        [Required]
        public int minutes { get; init; }
        [Required]
        public int seconds { get; init; }
    }
}