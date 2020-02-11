using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spendings_assistant
{
    interface IObserver
    {
        void Update(Change c);
    }
}
