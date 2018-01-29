using System;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;
using Discord.Commands;
using System.Diagnostics;
using System.Linq;
using IdiotBOT.Config; //Set to your config
using System.Net.Http;
using System.Net;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.IO;
using IdiotBOT; //Set to your bot


namespace IdiotBOT.Modules.Admin
{
    public class deleteMessages : ModuleBase
    {
        [Command("purge", RunMode = RunMode.Async)]
        public async Task purgeFuction(int amount)
        {
            string channelID = Context.Channel.Id.ToString();
            

            if (channelID == "SET YOUR CHANNEL ID HERE" || channelID == "SET YOUR CHANNELID HERE") //You can add more or only one here
            {
                await Context.Message.DeleteAsync();
                
                if(Context.User.Id == SET USERS HERE || Context.User.Id == SET USERS HERE)// No "" Only the ID of the person on Discord
                {

                    if (amount == 1)
                    {
                        var messages = await Context.Channel.GetMessagesAsync(amount + 1).Flatten();
                        await Context.Channel.DeleteMessagesAsync(messages);

                    }
                    else if (amount == 2)
                    {
                        var messages = await Context.Channel.GetMessagesAsync(amount + 1).Flatten();
                        await Context.Channel.DeleteMessagesAsync(messages);

                    }
                    else if (amount == 3)
                    {
                        var messages = await Context.Channel.GetMessagesAsync(amount + 1).Flatten();
                        await Context.Channel.DeleteMessagesAsync(messages);

                    }
                    else if (amount == 4)
                    {
                        var messages = await Context.Channel.GetMessagesAsync(amount + 1).Flatten();
                        await Context.Channel.DeleteMessagesAsync(messages);

                    }
                    else if (amount == 5)
                    {
                        var messages = await Context.Channel.GetMessagesAsync(amount + 1).Flatten();
                        await Context.Channel.DeleteMessagesAsync(messages);

                    }
                    else if (amount == 6)
                    {
                        var messages = await Context.Channel.GetMessagesAsync(amount + 1).Flatten();
                        await Context.Channel.DeleteMessagesAsync(messages);

                    }
                    else if (amount == 7)
                    {
                        var messages = await Context.Channel.GetMessagesAsync(amount + 1).Flatten();
                        await Context.Channel.DeleteMessagesAsync(messages);

                    }
                    else if (amount == 8)
                    {
                        var messages = await Context.Channel.GetMessagesAsync(amount + 1).Flatten();
                        await Context.Channel.DeleteMessagesAsync(messages);

                    }
                    else if (amount == 9)
                    {
                        var messages = await Context.Channel.GetMessagesAsync(amount + 1).Flatten();
                        await Context.Channel.DeleteMessagesAsync(messages);

                    }
                    else if (amount == 10)
                    {
                        var messages = await Context.Channel.GetMessagesAsync(amount + 1).Flatten();
                        await Context.Channel.DeleteMessagesAsync(messages);

                    }
                    else
                    {
                        await ReplyAsync("Use a number as your arguments. Ex " + BotConfig.Load().Prefix + "<amount>");
                        return;
                    }
                }
                else
                {
                    await Context.Message.DeleteAsync();
                    await ReplyAsync("***```You don't have access!```***");
                    return;
                }

            }
            else
            {
                await Context.Message.DeleteAsync();
                await ReplyAsync("***```Wrong Channel!```***");
                return;
            }

        }
        [Command("bigpurge", RunMode = RunMode.Async)]
        public async Task bigPurge()
        {
            string channelID = Context.Channel.Id.ToString();


            if (channelID == "CHANNEL ID HERE")
            {
                await Context.Message.DeleteAsync();

                if (Context.User.Id == USER ID HERE)
                {

                    
                    var messages = await Context.Channel.GetMessagesAsync(101).Flatten();
                    await Context.Channel.DeleteMessagesAsync(messages);

                    
                }
                else
                {
                    await Context.Message.DeleteAsync();
                    await ReplyAsync("***```You don't have access!```***");
                    return;
                }

            }
            else
            {
                await Context.Message.DeleteAsync();
                await ReplyAsync("***```Wrong Channel!```***");
                return;
            }
        }


    }
}
