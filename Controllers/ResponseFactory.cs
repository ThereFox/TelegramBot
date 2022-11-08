using ConsoleApp2.Models;
using ConsoleApp2.Controllers.Commands;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace ConsoleApp2.Controllers
{
    public class ResponseFactory
    {

        private CommandBuilder commandBuilder;

        public ResponseFactory()
        {
            commandBuilder = new();
        }

        public async Task<string> getRespons(Message message)
        {

            if (isEmptyData(message.Text))
            {
                throw new InvalidDataException();
            }

            if (isCommand(message.Text) == false)
            {
                return "is not a commandName";
            }

            ICommand command;

            try
            {
                command = commandBuilder.getCommandByName(message.Text.Trim());
            }
            catch (InvalidDataException ex)
            {
                return ex.Message;
            }

            return await command.ExecuteAsync();
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
