using Telegram.Bot;
using Telegram.Bot.Types;
using TelegramBot.Commands.Contract;

namespace TelegramBot.Commands.Concrete
{
    public class DesignCommand : ICommand
    {
        public void Execute(Message message, TelegramBotClient botClient)
        {
            {
                if (message.Text == "Дизайн" || message.Text == "Вернуться в раздел дизайн")
                {
                    var keyboard = new Telegram.Bot.Types.ReplyMarkups.ReplyKeyboardMarkup
                    {
                        Keyboard = new[]
                        {
                            new[]
                            {
                                new KeyboardButton("Готовые решения"),
                                new KeyboardButton("Индивидуальная разработка"),
                            },

                            new[]
                            {
                                new KeyboardButton("Вернуться в главное меню"),
                            },
                        },
                        ResizeKeyboard = true
                    };

                    botClient.SendTextMessageAsync(
                        message.Chat.Id,
                        "если Вы:" +
                        "\n     ✅ ограничены в бюджете" +
                        "\n     ✅ только начинаете работать над профилем" +
                        "\n     ✅ не знаете, чего хотите" +
                        "\n" +
                        "то Вам подойдёт раздел <b>ГОТОВЫЕ РЕШЕНИЯ</b>" +
                        "\n" +
                        "\nесли Вы:" +
                        "\n     ✅ бренд или стремитесь им быть" +
                        "\n     ✅ мечтаете о фирменном дизайне" +
                        "\n     ✅ хотите, чтобы Ваш аккаунт узнавали среди тысячи других " +
                        "\nто Вам подойдёт раздел <b>ИНДИВИДУАЛЬНАЯ РАЗРАБОТКА</b>",
                        replyMarkup: keyboard,
                        parseMode: Telegram.Bot.Types.Enums.ParseMode.Html);

                }
            }
        }
    }
}