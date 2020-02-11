using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;

namespace Spendings_assistant
{
    class History : IObserver
    {
        Account account;
        public List<Change> accountChanges;
        public string newEntry = "";

        public History(Account a)
        {
            this.account = a;
            accountChanges = new List<Change>();
            
        }

        public void Update(Change c)
        {
            if (accountChanges.Count <= 0) //if there are no changes in the account history
            {
                accountChanges.Add(c); //Add the new change to the history
                account.SetState(c); //Set the new state of the account
                newEntry = GetNewEntry(c); //Get the newest entry to be added to the historyview
                return;
            }

            if (!accountChanges.Contains(c)) 
            {
                accountChanges.Add(c); //Add the new change to the history
                account.SetState(c); //Set the new state of the account
                newEntry = GetNewEntry(c); //Get the newest entry to be added to the historyview
            }
        }

        public string GetNewEntry(Change newChange)
        {
            newEntry = "";
            if (newChange.value > 0f) //if the new change is a positive value
            {
                return newEntry = newChange.date + ": Deposit " + newChange.name + " made, balance increased by " + Math.Abs(newChange.value);
            }
            else if (newChange.value < 0f) //if the new change is negative value
            {
                return newEntry = newChange.date + ": Withdrawal " + newChange.name + " made, balance decreased by " + Math.Abs(newChange.value);
            }
            else //if the new change is 0
            {
                return newEntry = "New change is 0, no changes to balance made";
            }
        }
    }
}
