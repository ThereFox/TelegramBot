using Telegram.Bot;
using Telegram.Bot.Types;
using ConsoleApp2.Models;


namespace ConsoleApp2.Controllers
{
    public class BotRuntime
    {
        private ITelegramBotClient Client;

        public BotRuntime()
        {

        }

        public async Task Run()
        {
            var config = Config.getSettings().Token;
            Client = new TelegramBotClient(config);

            var Handler = new Handler();

            Client.StartReceiving(Handler.Handl, Handler.ErrorHandl);


            while (true)
            {
                await Task.Delay(100);
            }
        }

    }
}
