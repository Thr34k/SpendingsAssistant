using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spendings_assistant
{
    struct Change
    {
        public Change(string n, float p, DateTime d)
        {
            this.name = n;
            this.value = p;
            this.date = d;
        }

        public string name;
        public float value;
        public DateTime date;
    }
}
