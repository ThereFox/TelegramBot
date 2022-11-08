using Telegram.Bot;
using Telegram.Bot.Types;
using ConsoleApp2.Models;
using ConsoleApp2.View;


namespace ConsoleApp2.Controllers
{
    public class BotRuntime
    {
        private ITelegramBotClient Client;


        public async Task Run()
        {
            var token = Config.getSettings().Token;
            Client = getBot(token);

            setInitSettings();

            await runAsync();
        }

        private TelegramBotClient getBot(string token)
        {
            return new TelegramBotClient(token);
        }

        private void setInitSettings()
        {
            var Handler = new Handler();

            Client.StartReceiving(Handler.GetMessageHandler, Handler.ErrorHandl);
        }

        private async Task runAsync()
        {
            while (true)
            {
                await Task.Delay(100);
            }
        }

    }
}
