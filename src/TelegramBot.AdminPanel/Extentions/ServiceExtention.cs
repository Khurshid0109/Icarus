using Icarus.Data.IRepositories.Users;
using Icarus.Data.Repositories.Users;
using Icarus.Service.Interfaces.Users;
using Icarus.Service.Services.Users;

namespace TelegramBot.AdminPanel.Extentions;

public static class ServiceExtention
{
    public static void CustomExtention(this IServiceCollection services)
    {
        services.AddScoped<IUserService,UserService>();
        services.AddScoped<IUserRepository,UserRepository>();

        services.AddScoped<IBotUserRepository,BotUserRepository>();
        services.AddScoped<IBotUserService,BotUserService>();
    }
}
