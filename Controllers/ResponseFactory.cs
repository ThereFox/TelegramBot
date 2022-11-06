using Telegram.Bot;
using Telegram.Bot.Types;

namespace ConsoleApp2.Controllers
{
    public class ResponseFactory
    {
        public ResponseFactory()
        {

        }

        public async Task<string> getRespons(Message message)
        {

            if (isEmptyData(message.Text))
            {
                throw new InvalidDataException();
            }

            if (isCommand(message.Text) == false)
            {
                return "is not a command";
            }

            return await executeCommand(message.Text.Trim());
        }

        private async Task<string> getCommandResult(string command)
        {

        }

        private async Task<string> executeCommand(string command)
        {
            APICommand APICommand = new();
            return await APICommand.Execute();
        }
        private bool isEmptyData(string message)
        {
            return String.IsNullOrWhiteSpace(message);
        }
        private bool isCommand(string message)
        {
            return message.Trim().First() == '/';
        }

    }

}
