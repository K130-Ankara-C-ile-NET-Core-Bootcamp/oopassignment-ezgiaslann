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
            
        }

        public void Move()
        {
        }

        public void Notify()
        {
        }

        public void TurnLeft()
        {
        }

        public void TurnRight()
        {
        }
    }
}
