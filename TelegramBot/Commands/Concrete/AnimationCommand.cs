using System.Threading;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using TelegramBot.Commands.Contract;

namespace TelegramBot.Commands.Concrete
{
    public class AnimationCommand : ICommand
    {
        public void Execute(Message message, TelegramBotClient botClient)
        {

            if (message.Text == "Анимация")
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
                    "✅ привлекает больше внимания" +
                    "\n✅ повышает активность" +
                    "\n✅ поднимает процент вовлечения" +
                    "\n✅ лучше продаётся" +
                    "\n✅ повышает узнаваемость бренда",
                    replyMarkup: keyboard);


                botClient.SendChatActionAsync(
                    message.Chat.Id,
                    ChatAction.UploadVideo);

                Thread.Sleep(1000);

                botClient.SendVideoAsync(
                    message.Chat.Id,
                    video: "https://im4.ezgif.com/tmp/ezgif-4-776ba0550f6c.gif",
                    caption: "1500 рублей");

                botClient.SendChatActionAsync(
                    message.Chat.Id,
                    ChatAction.UploadVideo);

                Thread.Sleep(1000);

                botClient.SendVideoAsync(
                    message.Chat.Id,
                    video: "https://im4.ezgif.com/tmp/ezgif-4-ddc4cf107fd6.gif",
                    caption: "2500 рублей");

                botClient.SendChatActionAsync(
                    message.Chat.Id,
                    ChatAction.UploadVideo);

                Thread.Sleep(1000);
                
                botClient.SendVideoAsync(
                    message.Chat.Id,
                    video: "https://im4.ezgif.com/tmp/ezgif-4-4a4d84ce767a.gif",
                    caption: "5200 рублей");

            }
        }
    }
}
