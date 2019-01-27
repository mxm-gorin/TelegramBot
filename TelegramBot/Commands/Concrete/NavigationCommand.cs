using Telegram.Bot;
using Telegram.Bot.Types;
using TelegramBot.Commands.Contract;

namespace TelegramBot.Commands.Concrete
{
    public class NavigationCommand : ICommand
    {
        public void Execute(Message message, TelegramBotClient botClient)
        {

            if (message.Text == "Навигация")
            {
                var keyboard = new Telegram.Bot.Types.ReplyMarkups.ReplyKeyboardMarkup
                {
                    Keyboard = new[]
                    {
                        new[]
                        {

                            new KeyboardButton("Вернуться в главное меню"),
                        },

                    },
                    ResizeKeyboard = true
                };

                botClient.SendTextMessageAsync(
                    message.Chat.Id,
                    "📌 примеры моих работ [#enb_client](https://www.instagram.com/explore/tags/enb_client/)" +
                    "\n" +
                    "\n📌 отзывы о работе со мной [#enb_отзывы](https://www.instagram.com/explore/tags/enb_отзывы/)" +
                    "\n" +
                    "\n📌 ежемесячный бесплатный разбор профиля [#настяразбираетиобозревает](https://www.instagram.com/explore/tags/настяразбираетиобозревает/)" +
                    "\n" +
                    "\n📌 уроки по работе на мобильном устройстве [#enb_уроки](https://www.instagram.com/explore/tags/enb_уроки/)" +
                    "\n" +
                    "\n📌 мои неудачи при работе с клиентами [#честнаябольдизайнера](https://www.instagram.com/explore/tags/честнаябольдизайнера/)" +
                    "\n" +
                    "\n📌 идеология моего профиля [#enb_длякого](https://www.instagram.com/explore/tags/enb_длякого/)",
                    disableWebPagePreview: true,
                    replyMarkup: keyboard,
                    parseMode: Telegram.Bot.Types.Enums.ParseMode.Markdown);
            }
        }
    }
}