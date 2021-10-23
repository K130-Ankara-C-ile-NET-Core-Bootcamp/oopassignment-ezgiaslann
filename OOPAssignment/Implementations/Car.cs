using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment
{
    public class Car : ICarCommand, IObservable<CarInfo>
    {
        public Guid Id { get; set; }
        public Coordinates Coordinates { get; set; }
        public Direction Direction { get; set; }
        public ISurface Surface { get; set; }
        private IObserver<CarInfo> Observer { get; set; }

        public Car(Coordinates coordinates, Direction direction, ISurface surface)
        {
            Coordinates = coordinates;
            Direction = direction;
            Surface = surface;
        }
        public void Attach(IObserver<CarInfo> observer)
        {
            Coordinates = new Coordinates(1, 3);
            Observer = observer;

        }

        public void Move()
        {
            long nextX = Coordinates.X;
            long nextY = Coordinates.Y;

          

            var newCoordinates = new Coordinates(nextX, nextY);

            if(Observer.GetObservables().Any(x => x.Coordinates.X == newCoordinates.X && x.Coordinates.Y == newCoordinates.Y))
            {
                throw new Exception("An Error Occured.");
            }
            else if(!Surface.IsCoordinatesInBounds(newCoordinates))
            {
                throw new Exception("An Error Occured.");
            }
           
        }

        public void Notify()
        {
            throw new Exception("An Error Occured.");
        }

        public void TurnLeft()
        {
            Direction = Direction.W;

        }

        public void TurnRight()
        {
            Direction = Direction.E;
        }
    }
}
