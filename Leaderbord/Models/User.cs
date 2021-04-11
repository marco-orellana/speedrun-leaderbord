using System;
using System.Collections.Generic;
using Leaderboard.Dtos;
using Leaderbord.enums;

namespace Leaderboard.Models
{
    public record User
    {
        public Guid Id { get; init; }
        public string username { get; init; }
        public string Country { get; init; }
        public List<SocialDto> socials { get; init; }
        public DateTimeOffset AccountCreationDate { get; init; }
        public AccountType type {get; init;}
    }
}