using Discord;
using Discord.Interactions;
using Discord.WebSocket;

namespace Boolean;

public class BotInfo(DiscordSocketClient client, BotConfig config) : InteractionModuleBase<SocketInteractionContext>
{
    [SlashCommand("guilds", "Gets the number of servers the bot is in.")]
    public async Task Guilds()
    {
        var embed = new EmbedBuilder()
        {
            Title = "Guilds",
            Description = $"I am currently in **{client.Guilds.Count}** guilds."
        }.WithColor(config.BotTheme);
        
        await RespondAsync(embed: embed.Build(), ephemeral: true);
    }
}