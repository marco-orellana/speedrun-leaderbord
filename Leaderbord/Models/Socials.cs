using System;

namespace Leaderboard.Models
{
    public record Socials
    {
        public Guid Id { get; init; }
        public string socialMediaName { get; init; }
        public string url { get; init; }
    }
}