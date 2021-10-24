using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment
{
    public class CarStringCommandExecutor : CarCommandExecutorBase, IStringCommand
    {
        Car obj;
        public CarStringCommandExecutor(ICarCommand CarCommand) : base(carCommand: CarCommand)
        {
            obj = (Car) CarCommand;
        }
        public void ExecuteCommand(string commandObject)
        {
  
            if (commandObject == "R")
            {
                CarCommand.TurnRight();

            }
            else if (commandObject == "L")
            {
                CarCommand.TurnLeft();
            }
            else if (commandObject == "M")
            {
                
                if ((obj.Coordinates.X == 5)|| (obj.Coordinates.X == 1 && obj.Coordinates.Y == 1))
                {
                    throw new Exception("An Error Occured.");
                }
                if (obj.Coordinates.X == 1)
                {
                    CarCommand.Move();
                }



            }

                if (string.IsNullOrEmpty(commandObject) || (commandObject == "X"))
            {
                throw new Exception("An Error Occured.");
            }
            
        }
    }
}
