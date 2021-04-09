using System;
using System.Collections.Generic;
using Leaderbord.Dtos;
using Leaderbord.enums;

namespace Leaderbord.Models
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