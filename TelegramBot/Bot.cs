using System.Collections.Generic;
using System.Threading.Tasks;
using Telegram.Bot;
using TelegramBot.Commands.Concrete;
using TelegramBot.Commands.Contract;

namespace TelegramBot
{
    public static class Bot
    {
        private static TelegramBotClient _botClient;
        public static List<ICommand> Commands;

        public static async Task<TelegramBotClient> Get()
        {
            if (_botClient != null) return _botClient;

            Commands = new List<ICommand>()
            {
                new HelloCommand(),
                new DesignCommand(),
                new CompletedSolutionsCommand(),
                new CompletedPacksCommand(),
                new AnimationCommand(),
                new MagazineCommand(),
                new ConsultationCommand(),
                new ContentPlanCommand(),
                new IndividualDevelopment(),
                new LeadingCommand(),
                new NavigationCommand(),
                new ContactCommand(),
            };

            _botClient = new TelegramBotClient(AppSettings.Key);
            var hook = string.Format(AppSettings.Url, "api/message/update");
            await _botClient.SetWebhookAsync(hook);

            return _botClient;
        }
    }
}