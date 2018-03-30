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

//Steven Williams
//Discord Purge Command
namespace IdiotBOT.Modules.Admin
{
    public class deleteMessages : ModuleBase
    {
        [Command("purge", RunMode = RunMode.Async)]
        [Alias("d")]
        [RequireBotPermission(GuildPermission.ManageMessages)]
        [RequireUserPermission(GuildPermission.ManageMessages)]
        public async Task purgeFuction(int amount)
        {

                await Context.Message.DeleteAsync();
                

                   
                 var messages = await Context.Channel.GetMessagesAsync(amount + 1).Flatten();
                 await Context.Channel.DeleteMessagesAsync(messages);
                   

            }


        }

    }
}
