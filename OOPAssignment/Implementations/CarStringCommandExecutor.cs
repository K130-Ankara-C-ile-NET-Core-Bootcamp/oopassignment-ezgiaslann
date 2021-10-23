using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment
{
    public class CarStringCommandExecutor : CarCommandExecutorBase, IStringCommand
    {
        public CarStringCommandExecutor(ICarCommand CarCommand) : base(carCommand: CarCommand)
        {

        }
        public void ExecuteCommand(string commandObject)
        {
            if (string.IsNullOrEmpty(commandObject) || (commandObject == "X"))
            {
                throw new Exception("An Error Occured.");
            }
        }
    }
}
