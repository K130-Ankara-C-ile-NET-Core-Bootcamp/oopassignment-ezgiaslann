using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment
{
    public class Surface : ISurface, ICollidableSurface, IObserver<CarInfo>
    {
        #region Properties
        public long Width => _width;

        public long Height => _height;

        private long _width;
        private long _height;
        public List<CarInfo> CarInfoList { get; set; }
        #endregion

        #region Ctor
        public Surface(long width, long height)
        {
            CarInfoList = new List<CarInfo>();
            _width = width;
            _height = height;
        }
        #endregion


        #region Methods
        public List<CarInfo> GetObservables()
        {
            return new List<CarInfo>(CarInfoList);
        }

        public bool IsCoordinatesEmpty(Coordinates coordinates)
        {
            return true;
        }

        public bool IsCoordinatesInBounds(Coordinates coordinates)
        {
            return true;
        }

        public void Update(CarInfo provider)
        {
            //Refenrence Type
            var res = CarInfoList.FirstOrDefault(x => x.CarId == provider.CarId);
            if (res != null)
                res = provider;
            else
                CarInfoList.Add(provider);
        }
        #endregion
    }
}
