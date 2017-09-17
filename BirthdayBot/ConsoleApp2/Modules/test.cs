using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;

namespace BirthdayBot.Modules
{
    public class test : ModuleBase<SocketCommandContext>
    {
        [Command("test")]
        public async Task aosf()
        {
            await Context.Channel.SendMessageAsync("Bot Is Working Properly");
        }
    }
}
