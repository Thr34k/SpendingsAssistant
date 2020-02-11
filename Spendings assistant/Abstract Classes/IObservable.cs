using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spendings_assistant
{
    interface IObservable
    {
        void Add(IObserver observer);
        void Remove(IObserver observer);

        void Notify(Change p);
    }
}
