using Leaderboard.Models;
using Leaderboard.Dtos;

namespace Leaderboard.Extension_methods
{
    public static class ExtensionsMethods
    {
        public static GameDto AsDto(this Game game)
        {
            return new GameDto()
            {
                Id = game.Id,
                Name = game.Name,
                YearOfRelease = game.YearOfRelease,
                consolesReleasedOn = game.consolesReleasedOn
            };
        }

        public static UserDto AsDto(this User user)
        {
            return new UserDto()
            {
                Id = user.Id,
                username = user.username,
                Country = user.Country,
                socials = user.socials,
                AccountCreationDate = user.AccountCreationDate
            };
        }

        public static SocialDto AsDto(this Socials social)
        {
            return new SocialDto()
            {
                socialMediaName = social.socialMediaName,
                url = social.url
            };
        }
    }
}