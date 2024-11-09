using DjinniAIReplyBot.Application.Abstractions.ExternalServices;
using DjinniAIReplyBot.Infrastructure.ExternalServices;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Telegram.Bot;

namespace DjinniAIReplyBot.Infrastructure.Extensions;

public static class DependencyContainerExtensions
{
    public static void AddDependencies(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSingleton<TelegramBotClient>(_ =>
        {
            var token = configuration["TelegramBotToken"];
            if (string.IsNullOrEmpty(token))
            {
                throw new InvalidOperationException("Telegram bot token is not configured.");
            }
            return new TelegramBotClient(token);
        });
        
        services.AddScoped<ITelegramService, TelegramService>();

    }
}