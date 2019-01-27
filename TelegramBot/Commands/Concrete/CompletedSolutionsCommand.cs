using Telegram.Bot;
using Telegram.Bot.Types;
using TelegramBot.Commands.Contract;

namespace TelegramBot.Commands.Concrete
{
    public class CompletedSolutionsCommand : ICommand
    {
        public void Execute(Message message, TelegramBotClient botClient)
        {
            if (message.Text == "Готовые решения" || message.Text == "Вернуться к готовым решениям")
            {
                var keyboard = new Telegram.Bot.Types.ReplyMarkups.ReplyKeyboardMarkup
                {
                    Keyboard = new[]
                    {
                        new[]
                        {
                            new KeyboardButton("Готовые наборы"),
                            new KeyboardButton("Журнал"),
                        },

                        new[]
                        {
                            new KeyboardButton("Вернуться в раздел дизайн"),
                            new KeyboardButton("Вернуться в главное меню"),
                        }
                    },
                    ResizeKeyboard = true
                };

                botClient.SendTextMessageAsync(
                    message.Chat.Id,
                    "В данном разделе представлены готовые наборы шаблонов, которые подойдут практически под любую тематику аккаунта." +
                    " Приобреcти данные наборы может неограниченное количество человек.",
                    replyMarkup: keyboard,
                    parseMode: Telegram.Bot.Types.Enums.ParseMode.Html);
            }
        }

    }
}