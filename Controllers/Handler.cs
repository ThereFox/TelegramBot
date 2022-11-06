using Telegram.Bot.Types;
using Telegram.Bot;

namespace ConsoleApp2.Controllers
{
    public class Handler
    {
        private ResponseFactory _responseFactory;

        public Handler()
        {
            _responseFactory = new ResponseFactory();
        }

        public async Task Handl(ITelegramBotClient client, Update update, CancellationToken token)
        {
            var response = await _responseFactory.getRespons(update.Message);

            ChatId chatId = update.Message.Chat.Id;

            await client.SendTextMessageAsync(chatId, response);
        }
        public async Task ErrorHandl(ITelegramBotClient client, Exception exeption, CancellationToken token)
        {
            await Task.CompletedTask;
            Console.WriteLine(exeption.Message.ToString());
        }
    }
}
