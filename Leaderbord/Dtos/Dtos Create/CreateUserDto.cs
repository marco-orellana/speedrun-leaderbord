using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Leaderboard.Dtos.Dtos_Create
{
    public class CreateUserDto
    {
        [Required]
        public string username { get; init; }
        public string Country { get; init; }
        public List<SocialDto> socials { get; init; }
    }
}