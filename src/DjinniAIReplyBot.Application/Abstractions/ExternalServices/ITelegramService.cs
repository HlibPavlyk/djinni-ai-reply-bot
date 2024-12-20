using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace DjinniAIReplyBot.Application.Abstractions.ExternalServices;

public interface ITelegramService
{
    Task SendMessageAsync(long chatId, string message,  ParseMode parseMode = ParseMode.None);
    Task SendMessageAsync(long chatId, string message, InlineKeyboardMarkup replyMarkup);
    Task EditMessageReplyMarkupAsync(long chatId, int messageId, InlineKeyboardMarkup? replyMarkup = null);
    Task DeleteMessageAsync(long chatId, int messageId);
    Task<byte[]> GetDocumentAsync(string fileId);
}