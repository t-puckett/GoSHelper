using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.Interactivity;
using System.Threading.Tasks;
using DSharpPlus.EventArgs;
using System;

namespace GoSBot
{
    class Program
    {
        static DiscordClient discord;
        static CommandsNextModule commands;
        static InteractivityModule interactive;

        static void Main(string[] args)
        {
            MainAsync(args).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        static async Task MainAsync(string[] args)
        {

            discord = new DiscordClient(new DiscordConfiguration
            {
                Token = "NTk3NTE4NzUzNDE2MjE2NTk2.XSJSJg.Qvw5_HlTi0xggw9DYi3KgBkh3yY",
                TokenType = TokenType.Bot,
                UseInternalLogHandler = true,
                AutoReconnect = true,
                LogLevel = LogLevel.Debug
            });
            commands = discord.UseCommandsNext(new CommandsNextConfiguration
            {
                StringPrefix = ">>"
            });
            interactive = discord.UseInteractivity(new InteractivityConfiguration
            {

            });
            
            commands.RegisterCommands<Commands>();
            await discord.ConnectAsync();
            await Task.Delay(-1);
        }
        

    }
}