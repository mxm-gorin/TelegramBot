using System.Threading;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using TelegramBot.Commands.Contract;

namespace TelegramBot.Commands.Concrete
{
    public class ContactCommand : ICommand
    {
        public void Execute(Message message, TelegramBotClient botClient)
        {

            if (message.Text == "Связаться")
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
                    "Если Вы" +
                    "\n" +
                    "\n✅ не нашли ответы на интересующие Вас вопросы " +
                    "\n✅ нуждаетесь в помощи с выбором услуги" +
                    "\n✅ хотите сделать заказ" +
                    "\n" +
                    "\nможете связаться со мной",
                    replyMarkup: keyboard);

                Thread.Sleep(120);

                botClient.SendTextMessageAsync(
                    message.Chat.Id,
                    "[whatsap.me/eyenbuy](https://whatsap.me/eyenbuy)",
                    parseMode: ParseMode.Markdown);
            }

        }
    }
}