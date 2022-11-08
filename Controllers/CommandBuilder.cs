using ConsoleApp2.Controllers.Commands;
using ConsoleApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Controllers
{
    public class CommandBuilder
    {
        public ICommand getCommandByName(string commandName)
        {
                switch (commandName)
                {
                    case "/joke":
                        return new APICommand();
                    default:
                        throw new InvalidDataException("Такой команды нет");
                }
        }
    }
}
