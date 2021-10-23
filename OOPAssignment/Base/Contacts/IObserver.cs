using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment
{
    public interface IObserver<T> where T : class
    {
        void Update(T provider);
        List<T> GetObservables();
    }
}
