using Telegram.Bot;
using Telegram.Bot.Types;

namespace TelegramBot.Commands.Contract
{
    public interface ICommand
    {
        void Execute(Message message, TelegramBotClient botClient);
    }
}