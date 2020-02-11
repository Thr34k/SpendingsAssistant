using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;

namespace Spendings_assistant
{
    public partial class UserControl1 : UserControl
    {
        Account John;
        History johnHistory;

        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            John = new Account("John", 2000f); //Create a new account with name John and starting balance of 2000kr
            johnHistory = new History(John); //Create a new history for the account
            John.Add(johnHistory); //Add the new account history to the new accounts list of observers
            curbalanceNum.Value = (decimal)John.balance; //Refresh the value of the current balance shown
            if (!historyView.Items.ContainsKey(johnHistory.newEntry)) //if the history-view does not contain the newest entry,
            {
                historyView.Items.Add(johnHistory.newEntry); //Add the newest entry to the history-view
            }
            accountNameLabel.Text = John.name;//Set the account name label to be the accounts name
            RefreshChart(); //Refresh the balance overview chart
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {   //Get a reference to the name, price and date of the new account change
            string newChangeName = newChangeNametxt.Text; 
            float newChangePrice = (float)newChangePriceNum.Value;
            DateTime newChangeDate = DateTime.Now;
            //Create a new account change
            Change newPurchase = new Change(newChangeName, newChangePrice, newChangeDate);
            John.Notify(newPurchase); //Notify the account of the new change
            curbalanceNum.Value = (decimal)John.balance; //Update account 
            if (!historyView.Items.ContainsKey(johnHistory.newEntry)) //if the history does not contain the newest entry,
            {
                historyView.Items.Add(johnHistory.newEntry); //Add the newest entry to the history
            }
            RefreshChart(); //Refresh the chart
        }

        void RefreshChart()
        {
            ChartValues<float> vals = new ChartValues<float>(); //Create a new collaction of chart values
            foreach (Change c in johnHistory.accountChanges) //for each change in the account history's list of changes
            {
                vals.Add(c.value); //Add changes' values to the new chart values
            }
            balanceOverview.Series.Clear(); //Clear the current plot in the balance overview
            SeriesCollection series = new SeriesCollection //Create a new collection of series
            {
                new LineSeries //Add a new line series to the new collection using the new chart values
                {
                    Title = "Series 1",
                    Values = vals
                }
            };
            foreach (LineSeries lineS in series) //foreach line series in the series collection,
            {
                balanceOverview.Series.Add(lineS); //Add it to the balanceOverviews series collection
            }
        }
    }
}
