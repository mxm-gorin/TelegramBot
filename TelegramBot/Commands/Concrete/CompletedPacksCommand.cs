using System.Threading;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using TelegramBot.Commands.Contract;

namespace TelegramBot.Commands.Concrete
{
    public class CompletedPacksCommand : ICommand
    {
        public void Execute(Message message, TelegramBotClient botClient)
        {
            if (message.Text != "Готовые наборы") return;

            var keyboard = new Telegram.Bot.Types.ReplyMarkups.ReplyKeyboardMarkup
            {
                Keyboard = new[]
                {
                   new[]
                   {
                       new KeyboardButton("Вернуться к готовым решениям"),
                       new KeyboardButton("Вернуться в главное меню")
                   },
                },
                ResizeKeyboard = true
            };

            botClient.SendTextMessageAsync(
                message.Chat.Id,
                "Приобретая конкретный набор, Вы получаете:" +
                "\n" +
                "\n✔ шаблоны в формате PNG" +
                "\n✔ шрифты, используемые в дизайне" +
                "\n✔ видеоинструкцию, благодаря которой сможете подставлять свои фото и писать свой текст" +
                "\n✔ мою дальнейшую поддержку" +
                "\n" +
                "\n➕ изменение цвета набора - <b>+500</b> рублей к общей стоимости" +
                "\n➕ шаблоны в формате PSD (редактируемые на ПК) – <b>по двойной стоимости набора</b>",
                replyMarkup: keyboard,
                parseMode: Telegram.Bot.Types.Enums.ParseMode.Html);

            botClient.SendChatActionAsync(
                message.Chat.Id,
                ChatAction.UploadPhoto);

            Thread.Sleep(1000);
            botClient.SendPhotoAsync(
                message.Chat.Id,
                "https://lh5.googleusercontent.com/Pa4uR35-fiB4DKuIGEvNlsxpjE9d5tTlBmMFKKFohnjRqmM9SuZzxnaRq8UaJ6WC90SUJU_AUkYsd_o2mb28=w1921-h911");

            botClient.SendChatActionAsync(
                message.Chat.Id,
                ChatAction.UploadPhoto);

            Thread.Sleep(1000);
            botClient.SendPhotoAsync(
                message.Chat.Id,
                "https://lh3.googleusercontent.com/y-mr_2GZwDNBcQgUHor6hwNr8DU0kOk2DbtfoP-v5ipavrsIjbGXJHpgZDOrqqmnPXc6fOhXTUGIN6gFiL25=w1903-h892");

            botClient.SendChatActionAsync(
                message.Chat.Id,
                ChatAction.UploadPhoto);

            Thread.Sleep(1000);
            botClient.SendPhotoAsync(
                message.Chat.Id,
                "https://lh5.googleusercontent.com/8D4QOARQuUfqU7WtiAzduLDhJfOntmiuDqYqQ763Ki17Qz5lG4MG8tBj-8_slgY2Ut9jEG8usXHGRND0V2QM=w1921-h852");

            botClient.SendChatActionAsync(
                message.Chat.Id,
                ChatAction.UploadPhoto);

            Thread.Sleep(1000);
            botClient.SendPhotoAsync(
                message.Chat.Id,
                "https://lh5.googleusercontent.com/bL929HGBfBBats8ai2Lp0yfyVVOx9IPgdCmkUxsiBXxbKJBKRP8YmNiypDL7OPqrB1IZzO7M_wDVTGqATri0=w1921-h852");

            botClient.SendChatActionAsync(
                message.Chat.Id,
                ChatAction.UploadPhoto);

            Thread.Sleep(1000);
            botClient.SendPhotoAsync(
                message.Chat.Id,
                "https://lh5.googleusercontent.com/QMtxZYliCLmcrbXyOrbIR97-85wZcCujDV2YOHr_NLLaFD9uORBEmop4uvL64QTCEsW5yk9EwjrJk2R4FArY=w1921-h852");
        }
    }
}
