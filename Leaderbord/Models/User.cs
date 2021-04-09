using System;
using System.Collections.Generic;
using Leaderbord.Dtos;

namespace Leaderbord.Models
{
    public record User
    {
        public Guid Id { get; init; }
        public string username { get; init; }
        public string Country { get; init; }
        public List<SocialDto> socials{get; init;}
        public DateTime AccountCreationDate { get; init; }
    }
}