using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicQueuingCashier
{
    public partial class CashierWindowQueueForm : Form
    {
        private CashierClass cashier; 
        public CashierWindowQueueForm(CashierClass cashier)
        {
            InitializeComponent();
            this.cashier = cashier;
            this.cashier.OnQueueUpdated += UpdateQueueList;
        }
        public CashierWindowQueueForm()
        {
            InitializeComponent();
        }
        private void UpdateQueueList(Queue<string> queue)
        {
            listCashierQueue.Items.Clear();
            foreach (string number in queue)
            {
                listCashierQueue.Items.Add(number);
            }
        }
        private void btnNext_Click_1(object sender, EventArgs e)
        {
            this.cashier.Dequeue();
        }
    }
}