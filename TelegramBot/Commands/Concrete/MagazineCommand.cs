using System.Threading;
using Telegram.Bot;
using Telegram.Bot.Types;
using TelegramBot.Commands.Contract;

namespace TelegramBot.Commands.Concrete
{
    public class MagazineCommand : ICommand
    {
        public void Execute(Message message, TelegramBotClient botClient)
        {
            if (message.Text == "Журнал")
            {
                var keyboard = new Telegram.Bot.Types.ReplyMarkups.ReplyKeyboardMarkup
                {
                    Keyboard = new[]
                    {
                        new[]
                        {
                            new KeyboardButton("Вернуться в раздел дизайн"),
                            new KeyboardButton("Вернуться в главное меню")
                        },
                    },
                    ResizeKeyboard = true
                };

                botClient.SendTextMessageAsync(
                    message.Chat.Id,
                    "Мой журнал – это настоящая находка для начинающих девушек-предпринимательниц 🎉 Оформить подписку можно как и подписку на обычный журнал – на месяц/квартал/год." +
                    "\nВ каждом выпуске журнала 🎁:" +
                    "\n" +
                    "\n✔20 авторских шаблонов" +
                    "\n✔шрифты" +
                    "\n✔пресеты" +
                    "\n✔чек-лист" +
                    "\n✔урок" +
                    "\n✔контент-план на месяц" +
                    "\n✔ежедневные письма с рекомендациями по написанию поста" +
                    "\n✔видеоинструкция" +
                    "\n" +
                    "\n<b>Оплата</b> журнала происходит <b>помесячно</b>. Минимальный период подписки – 1 месяц." +
                    "\nКаждый месяц – <b>НОВЫЕ</b> материалы 🍨 По окончании месяца, файлы удаляются, чтобы скачать их могло <b>ограниченное количество человек</b>. <i>Новый месяц – новые шаблоны, шрифты, контент - план, пресеты, уроки и письма</i>.",
                    replyMarkup: keyboard,
                    parseMode: Telegram.Bot.Types.Enums.ParseMode.Html);

                Thread.Sleep(1000);

                botClient.SendTextMessageAsync(
                    message.Chat.Id,
                    "Для того, чтобы оформить подписку, необходимо:" +
                    "\n" +
                    "\nОплатить 1220 рублей(минимальный период – 1 месяц)" +
                    "\nОтправить свой email" +
                    "\nОтправить ссылку на свой рабочий профиль");
            }
        }
    }
}