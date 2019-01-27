using System.Threading;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using TelegramBot.Commands.Contract;

namespace TelegramBot.Commands.Concrete
{
    public class IndividualDevelopment : ICommand
    {
        public void Execute(Message message, TelegramBotClient botClient)
        {
            if (message.Text == "Индивидуальная разработка")
            {
                var keyboard = new Telegram.Bot.Types.ReplyMarkups.ReplyKeyboardMarkup
                {
                    Keyboard = new[]
                    {
                        new[]
                        {
                            new KeyboardButton("Вернуться в раздел дизайн"),
                            new KeyboardButton("Вернуться в главное меню"),
                        },
                    },
                    ResizeKeyboard = true
                };

                botClient.SendTextMessageAsync(
                    message.Chat.Id,
                    "пакет <b>МИНИМАЛЬНЫЙ</b>" +
                    "\n" +
                    "\n✅ определение ЦА и её потребностей" +
                    "\n✅ проработка рубрик в профиле" +
                    "\n✅ подбор цветовой схемы" +
                    "\n✅ дизайн профиля на 9 постов" +
                    "\n✅ feed - имитация" +
                    "\n✅ шрифты" +
                    "\n✅ видеоинструкция, благодаря которой Вы сможете подставлять свои фото и писать тексты" +
                    "\n✅ моя дальнейшая поддержка" +
                    "\n" +
                    "\n<b>СТОИМОСТЬ:</b> 6200 рублей",
                    replyMarkup: keyboard,
                    parseMode: Telegram.Bot.Types.Enums.ParseMode.Html);

                botClient.SendChatActionAsync(
                    message.Chat.Id,
                    ChatAction.Typing);

                Thread.Sleep(1000);

                botClient.SendTextMessageAsync(
                    message.Chat.Id,
                    "пакет <b>СТАНДАРТ</b>" +
                    "\n" +
                    "\n✅ определение ЦА и её потребностей" +
                    "\n✅ проработка рубрик в профиле" +
                    "\n✅ подбор цветовой схемы" +
                    "\n✅ дизайн профиля на 12 постов" +
                    "\n✅ feed - имитация" +
                    "\n✅ шрифты" +
                    "\n✅ видеоинструкция, благодаря которой Вы сможете подставлять свои фото и писать тексты" +
                    "\n✅ моя дальнейшая поддержка" +
                    "\n" +
                    "\n<b>СТОИМОСТЬ: 7200 рублей</b>",
                    parseMode: Telegram.Bot.Types.Enums.ParseMode.Html);

                botClient.SendChatActionAsync(
                    message.Chat.Id,
                    ChatAction.Typing);

                Thread.Sleep(1000);

                botClient.SendTextMessageAsync(
                    message.Chat.Id,
                    "пакет <b>ВСЁ ВКЛЮЧЕНО</b>" +
                    "\n" +
                    "\n✅ определение ЦА и её потребностей" +
                    "\n✅ места обитания ЦА для успешной рекламы" +
                    "\n✅ создание цепляющей шапки аккаунта" +
                    "\n✅ написание рабочих хэштегов" +
                    "\n✅ проработка рубрик в профиле" +
                    "\n✅ подбор цветовой схемы" +
                    "\n✅ дизайн профиля на 9 постов" +
                    "\n✅ 2 шаблона для сторис" +
                    "\n✅ 5 обложек для вечных сторис" +
                    "\n✅ feed - имитация" +
                    "\n✅ рекомендации по постингу" +
                    "\n✅ рекомендации по фотоконтенту" +
                    "\n✅ шрифты" +
                    "\n✅ видеоинструкция, благодаря которой Вы сможете подставлять свои фото и писать тексты" +
                    "\n✅ моя дальнейшая поддержка" +
                    "\n" +
                    "\n<b>СТОИМОСТЬ:</b> 7500 рублей",
                    parseMode: Telegram.Bot.Types.Enums.ParseMode.Html);

                botClient.SendChatActionAsync(
                    message.Chat.Id,
                    ChatAction.Typing);

                Thread.Sleep(1000);

                botClient.SendTextMessageAsync(
                    message.Chat.Id,
                    "пакет <b>ВСЁ ВКЛЮЧЕНО+</b>" +
                    "\n" +
                    "\n✅ определение ЦА и её потребностей" +
                    "\n✅ места обитания ЦА для успешной рекламы" +
                    "\n✅ создание цепляющей шапки аккаунта" +
                    "\n✅ написание рабочих хэштегов" +
                    "\n✅ проработка рубрик в профиле" +
                    "\n✅ подбор цветовой схемы" +
                    "\n✅ 2 mood - борда(по желанию)" +
                    "\n✅ дизайн профиля на 12 постов" +
                    "\n✅ 2 шаблона для сторис" +
                    "\n✅ 5 обложек для вечных сторис" +
                    "\n✅ feed - имитация" +
                    "\n✅ рекомендации по постингу" +
                    "\n✅ рекомендации по фотоконтенту" +
                    "\n✅ шрифты" +
                    "\n✅ видеоинструкция, благодаря которой Вы сможете подставлять свои фото и писать тексты" +
                    "\n✅ моя дальнейшая поддержка" +
                    "\n" +
                    "\n<b>СТОИМОСТЬ:</b> 8500 рублей",
                    parseMode: Telegram.Bot.Types.Enums.ParseMode.Html);

                botClient.SendChatActionAsync(
                    message.Chat.Id,
                    ChatAction.Typing);

                Thread.Sleep(1000);

                botClient.SendTextMessageAsync(
                    message.Chat.Id,
                    "➕ для использования моих материалов <b>достаточно мобильного устройства</b>" +
                    "\n➕ все приложения будут указаны в видеоинструкции" +
                    "\n➕ материалы в формате PSD (редактируемые на ПК) оплачиваются <b>по двойной стоимости</b>",
                    parseMode: Telegram.Bot.Types.Enums.ParseMode.Html);

                botClient.SendChatActionAsync(
                    message.Chat.Id,
                    ChatAction.Typing);

                Thread.Sleep(500);

                botClient.SendTextMessageAsync(
                    message.Chat.Id,
                    "Примеры индивидуальных дизайнов 🔻",
                    parseMode: Telegram.Bot.Types.Enums.ParseMode.Html);

                botClient.SendChatActionAsync(
                    message.Chat.Id,
                    ChatAction.UploadPhoto);

                Thread.Sleep(500);

                botClient.SendPhotoAsync(
                    message.Chat.Id,
                    "https://lh6.googleusercontent.com/OeeUotqK7SG_vCrU5gEG_WWAAzbILCwKF-dM7tRqhJ3_Q5iBlWArIcjf9gdxBFlBtMrsrI96hZ0Rz9-hkpRs=w1921-h911");

                botClient.SendChatActionAsync(
                    message.Chat.Id,
                    ChatAction.UploadPhoto);

                Thread.Sleep(1000);

                botClient.SendPhotoAsync(
                    message.Chat.Id,
                    "https://lh3.googleusercontent.com/nB64NJ8XlA9r6Zv4O9e8AGXvke-rvxBxmzSLfQdFDtNcC3e1MfYeMZjZNB_4_JofInW8gbhhxhBHuHrwLNin=w1921-h911");

                botClient.SendChatActionAsync(
                    message.Chat.Id,
                    ChatAction.UploadPhoto);

                Thread.Sleep(1000);

                botClient.SendPhotoAsync(
                    message.Chat.Id,
                    "https://lh6.googleusercontent.com/ph2_LJy2R38kIHTDBuCN6fo7T-b9VfCvi91qQb0lFDmXtBOvOQm4Md2GLyq17Ft2CGDih3ZBn8ew4GxP9T75=w1921-h911");

                botClient.SendChatActionAsync(
                    message.Chat.Id,
                    ChatAction.UploadPhoto);

                Thread.Sleep(1000);

                botClient.SendPhotoAsync(
                    message.Chat.Id,
                    "https://lh6.googleusercontent.com/FP6vV_Ivx7-L9ntAtRpIAfw393dtsvscBm7IKs_wSOy7sMsDNXnATgw7eWQhzBoAdmY5RcTa3E5dnjLIsrQs=w1921-h911");

                botClient.SendChatActionAsync(
                    message.Chat.Id,
                    ChatAction.UploadPhoto);

                Thread.Sleep(1000);

                botClient.SendPhotoAsync(
                    message.Chat.Id,
                    "https://lh5.googleusercontent.com/8EVYEzmZqEGNWjn_8laOyrwDFU--G5ohvTCZ721Kr8h8LIORqmyK9fDmu5x2ncksD6DXes9v4px9cxUotKrt=w1921-h911");

                botClient.SendChatActionAsync(
                    message.Chat.Id,
                    ChatAction.UploadPhoto);

                Thread.Sleep(1000);

                botClient.SendPhotoAsync(
                    message.Chat.Id,
                    "https://lh4.googleusercontent.com/i9P8G9fD2O6MoqbGTZu5_fqhLnPXeLIUcZUEJRYSVd7sGmSspMn22sVfnLg0NGBLF-CzbqQ64tTBh0nUrgzt=w1921-h911");

                botClient.SendChatActionAsync(
                    message.Chat.Id,
                    ChatAction.UploadPhoto);

                Thread.Sleep(1000);

                botClient.SendPhotoAsync(
                    message.Chat.Id,
                    "https://lh5.googleusercontent.com/U_GbYe_7839NDA0IEwKbiIqBz43QEjAPnhy30BIi9IcsZKXygVYGDFdli7MBbR4mB1KHLY4i576WulMy9hwU=w1921-h911");

                botClient.SendChatActionAsync(
                    message.Chat.Id,
                    ChatAction.UploadPhoto);

                Thread.Sleep(1000);

                botClient.SendPhotoAsync(
                    message.Chat.Id,
                    "https://lh5.googleusercontent.com/nZ96Cu5n8I17YXzOEAjKbgJ2-kIYkqPybJULkHg9Krn4pYNeAMg6RY8kn8Kp--OZAMGfRM64hDTUGORPQ1Kj=w1921-h911");

                botClient.SendChatActionAsync(
                    message.Chat.Id,
                    ChatAction.UploadPhoto);

                Thread.Sleep(1000);

                botClient.SendPhotoAsync(
                    message.Chat.Id,
                    "https://lh6.googleusercontent.com/dEtcB24XmcUN2Is9Pa8keBhNiTsJu9EUuwM2KZfb-PybkSZ1uP59NEekkaOT2Pjd8OLsKP-nxwCoDXoZqvtG=w1921-h911");

                botClient.SendChatActionAsync(
                    message.Chat.Id,
                    ChatAction.UploadPhoto);

                Thread.Sleep(1000);

                botClient.SendPhotoAsync(
                    message.Chat.Id,
                    "https://lh5.googleusercontent.com/Sw1edRan3RHBIlBJWNE2hzGDvdvyPCgTBQNcQi4qSTRSoG_x5Qmok6IFpqV4QVoEcEruHiQ7k3f6W44Mlwt6=w1921-h911");

                botClient.SendChatActionAsync(
                    message.Chat.Id,
                    ChatAction.UploadPhoto);

                Thread.Sleep(1000);

                botClient.SendPhotoAsync(
                    message.Chat.Id,
                    "https://lh4.googleusercontent.com/JVEww3P7tHqGSAeytxo_f_Ev0R84Q5dGUdfQbZBbEwQB_pIRAzeQbmrpFIXKf0F8_0IXfapBJHpbJe7ERoG2=w1921-h911");

            }
        }
    }
}