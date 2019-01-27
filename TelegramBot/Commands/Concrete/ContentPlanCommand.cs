using Telegram.Bot;
using Telegram.Bot.Types;
using TelegramBot.Commands.Contract;

namespace TelegramBot.Commands.Concrete
{
    public class ContentPlanCommand : ICommand
    {
        public void Execute(Message message, TelegramBotClient botClient)
        {
            if (message.Text == "Контент план")
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
                    "➕ <b>раз в месяц</b> у себя в профиле я делюсь контент-планом на 30 дней <b>БЕСПЛАТНО</b>" +
                    "\n" +
                    "\n✅ для того, чтобы получить его <b>расширенную версию</b>, нужно <b>оформить подписку на журнал</b> (это даст возможность также получать рекомендации по написанию каждого из постов с примерами написания этого поста у успешного блогера)" +
                    "\n" +
                    "\n➕ если Вас интересует контент-план, который будет составлен <b>индивидуально</b> для Вашего профиля (с учётом особенности выбранной ниши), то стоимость его на 30 идей составляет <b>450</b> рублей",
                    replyMarkup: keyboard,
                    parseMode: Telegram.Bot.Types.Enums.ParseMode.Html);
            }
        }
    }
}