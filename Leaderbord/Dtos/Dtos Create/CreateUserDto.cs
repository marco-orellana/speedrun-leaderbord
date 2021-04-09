using System.Collections.Generic;

namespace Leaderbord.Dtos.Dtos_Create
{
    public class CreateUserDto
    {
        public string username { get; init; }
        public string Country { get; init; }
        public List<SocialDto> socials { get; init; }
    }
}