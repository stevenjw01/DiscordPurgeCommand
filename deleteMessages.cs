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
            

            if(Context.User.Id == USER ID HERE || Context.User.Id == USER ID HERE) // NO "" ONLY USER ID NUMBER BLANK
                {
                  
                   var messages = await Context.Channel.GetMessagesAsync(amount + 1).Flatten();
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
