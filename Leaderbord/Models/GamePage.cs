using System.Collections.Generic;
using Leaderboard.Dtos;
using System;

namespace Leaderboard.Models
{
    public record GamePage
    {
        public Guid Id { get; init; }
        public Game game { get; init; }
        public List<Category> Categories { get; set; }
        public List<User> Moderators { get; init; }
    }
}