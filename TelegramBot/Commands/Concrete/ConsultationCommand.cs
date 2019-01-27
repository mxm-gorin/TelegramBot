using Telegram.Bot;
using Telegram.Bot.Types;
using TelegramBot.Commands.Contract;

namespace TelegramBot.Commands.Concrete
{
    public class ConsultationCommand : ICommand
    {
        public void Execute(Message message, TelegramBotClient botClient)
        {
            if (message.Text == "Консультация")
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
                    "я консультирую по вопросам:" +
                    "\n➕ работы в Photoshop" +
                    "\n➕ работы в мобильных приложениях" +
                    "\n➕ создания шаблонов" +
                    "\n➕ создания простых и сложных анимаций" +
                    "\n➕ продвижении профиля" +
                    "\n➕ визуальной концепции профиля" +
                    "\n➕ УТП и личного бренда" +
                    "\n" +
                    "\nесли тебе нужна индивидуальная консультация, то нам предстоит:" +
                    "\n✅ определение темы консультации" +
                    "\n✅ согласование вопросов, рассматриваемых на консультации" +
                    "\n✅ разбор профиля" +
                    "\n✅ анализ конкурентов" +
                    "\n✅ выявление полезных ресурсов по твоей сфере" +
                    "\n" +
                    "\nя гарантирую:" +
                    "\n✅ непрерывный поток полезной информации" +
                    "\n✅ раскрытие своих секретов и фишек" +
                    "\n✅ много полезных материалов для развития твоего профиля" +
                    "\n" +
                    "\n<b>СТОИМОСТЬ:</b> 2400 рублей / 1 час " +
                    "\n" +
                    "\n➕ одного часа вполне достаточно для конкретной проблемы" +
                    "\n➕ для работы необходимо иметь WhatsApp на телефоне и TeamViewer на ПК" +
                    "\n➕ по другим темам консультации уточняйте...",
                    replyMarkup: keyboard,
                    parseMode: Telegram.Bot.Types.Enums.ParseMode.Html);
            }
        }
    }
}