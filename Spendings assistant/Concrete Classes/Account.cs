using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spendings_assistant
{
    class Account : IObservable
    {
        List<IObserver> observers;

        public string name;
        public float balance;

        public Account(string n, float b)
        {
            observers = new List<IObserver>();
            name = n;
            balance = b;
        }

        public void Add(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Notify(Change c)
        {
            foreach (IObserver observer in observers) //foreach observer in the list of observers
            {
                observer.Update(c); //Call the observers Update methed, passing change c
            }
        }

        public void Remove(IObserver observer)
        {
            observers.Remove(observer);
        }

        float GetState() 
        {
            return balance;
        }

        public float SetState(Change c) 
        {
            //return p.price >= 0 ? balance += p.price : balance -= p.price;
            return balance = balance + c.value;
        }
    }
}
