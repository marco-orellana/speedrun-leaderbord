using System;
using System.Collections.Generic;

namespace Leaderbord.Dtos
{
    public record UserDto
    {
        public Guid Id { get; init; }
        public string username { get; init; }
        public string Country { get; init; }
        public List<SocialDto> socials{get; init;}
        public DateTime AccountCreationDate { get; init; }
    }
}