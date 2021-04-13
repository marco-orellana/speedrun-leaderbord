using Leaderboard.Models;
using Leaderboard.Dtos;
using Leaderbord.Models;
using Leaderbord.Dtos.Dtos_Get;

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

        public static RunDto AsDto(this Run run)
        {
            return new RunDto()
            {
                game = run.game,
                user = run.user,
                category = run.category,
                hours = run.hours,
                minutes = run.minutes,
                seconds = run.seconds
            };
        }

        public static CategoryDto AsDto(this Category category)
        {
            return new CategoryDto()
            {
                AssociatedGame = category.AssociatedGame,
                categoryName = category.categoryName,
                categoryRules = category.categoryRules,
                runs = category.runs
            };
        }

        public static GamePageDto AsDto(this GamePage gamePage)
        {
            return new GamePageDto()
            {
                game = gamePage.game,
                Categories = gamePage.Categories,
                Moderators = gamePage.Moderators
            };
        }
    }
}