using Telegram.Bot;
using Telegram.Bot.Types;
using TelegramBot.Commands.Contract;

namespace TelegramBot.Commands.Concrete
{
    public class LeadingCommand : ICommand
    {
        public void Execute(Message message, TelegramBotClient botClient)
        {

            if (message.Text == "Ведение")
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
                    "❔ хотите красивый профиль, но не умеете пользоваться редакторами?" +
                    "\n❔ хотите продвигать бизнес в Инстаграм, делегируя это специалисту?" +
                    "\n❔ хотите, чтобы профиль жил и процветал, но регулярные обновления отнимают слишком много времени?" +
                    "\n" +
                    "\nтогда Вы обратились по адресу 👌" +
                    "\n" +
                    "\nя" +
                    "\n✅ подберу цветовую гамму профиля" +
                    "\n✅ составлю рубрики для постинга" +
                    "\n✅ подберу схему постинга" +
                    "\n✅ обработаю фото" +
                    "\n✅ отсортирую фото" +
                    "\n✅ определю лучшее время постинга для конкретных рубрик" +
                    "\n✅ продублирую посты в сторис" +
                    "\n✅ подберу рабочие хэштеги к каждому посту" +
                    "\n" +
                    "\n▫ 15 постов в месяц - 5500 рублей" +
                    "\n▫ 30 постов в месяц - 10200 рублей" +
                    "\n▫ написание 15 постов в месяц - 4200 рублей" +
                    "\n▫ написание 30 постов в месяц - 7500 рублей" +
                    "\n" +
                    "\n➕ создание <b>дополнительных</b> сторис <b>оплачивается</b>(1 шт - 300 рублей)" +
                    "\n➕ при ведении профиля с шаблонами, <b>шаблоны</b> оплачиваются <b>отдельно</b>(готовые наборы или разработка индивидуальных)" +
                    "\n➕ <b>в случае отказа</b> от моих услуг, все <b>материалы передаются</b> клиенту + я провожу <b>консультацию</b>(для продолжения ведения профиля в том же стиле)",
                    replyMarkup: keyboard,
                    parseMode: Telegram.Bot.Types.Enums.ParseMode.Html);
            }
        }
    }
}