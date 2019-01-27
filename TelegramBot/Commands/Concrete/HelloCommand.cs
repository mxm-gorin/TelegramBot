using Telegram.Bot;
using Telegram.Bot.Types;
using TelegramBot.Commands.Contract;

namespace TelegramBot.Commands.Concrete
{
    public class HelloCommand : ICommand
    {
        public void Execute(Message message, TelegramBotClient botClient)
        {
            if (message.Text != "/start" && message.Text != "Вернуться в главное меню") return;

            var keyboard = new Telegram.Bot.Types.ReplyMarkups.ReplyKeyboardMarkup
            {
                Keyboard = new[]
                {
                    new[]
                    {
                        new KeyboardButton("Дизайн"),
                        new KeyboardButton("Контент план"),
                        new KeyboardButton("Консультация")
                    },

                    new[]
                    {
                        new KeyboardButton("Анимация"),
                        new KeyboardButton("Навигация"),
                        new KeyboardButton("Связаться")
                    }
                },
                ResizeKeyboard = true
            };

            botClient.SendTextMessageAsync(
                message.Chat.Id,
                $"Привет, {message.Chat.FirstName}!" +
                "\n" +
                "\nОчень рада что Вас заинтересовали мои услуги 💕" +
                "\n" +
                "\n     Я" +
                "\n" +
                "\n💫 создам дизайн профиля за <b>3 дня</b>" +
                "\n💫 привлеку оформлением твою <b>целевую аудиторию</b>" +
                "\n💫 <b>сэкономлю</b> бюджет" +
                "\n💫 придумаю концепцию, которая <b>не выйдет из моды</b>" +
                "\n💫 окажу дальнейшую <b>поддержку</b>" +
                "\n💫 сделаю женский <b>бизнес успешным</b>" +
                "\n" +
                "\nскорее выбирайте интересующий Вас раздел, чтобы узнать больше 🚀" +
                "\n" +
                "\n✖ <i>не размещаю рекламу</i>" +
                "\n✖ <i>не работаю по бартеру</i>",
                replyMarkup: keyboard,
                parseMode: Telegram.Bot.Types.Enums.ParseMode.Html);

            //{
            //    var keyboard = new Telegram.Bot.Types.ReplyMarkups.InlineKeyboardMarkup(
            //    new InlineKeyboardButton[][]
            //    {
            //       new []
            //       {
            //          new InlineKeyboardButton("раз","callback1"),
            //          new InlineKeyboardButton("два","callback2"),
            //          new InlineKeyboardButton("три","callback3"),
            //          new InlineKeyboardButton("четыре","callback4")
            //       },

            //        new []
            //        {
            //           new InlineKeyboardButton("раз","callback5"),
            //           new InlineKeyboardButton("два","callback6"),
            //           new InlineKeyboardButton("три","callback7"),
            //           new InlineKeyboardButton("четыре","callback8")
            //        }
            //    });

            //    bot.SendTextMessageAsync(chatId, "Приветствие", replyMarkup: keyboard);
            //}
        }
    }
}