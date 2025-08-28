using System;
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
        private CashierClass cashierInstance;

        public CashierWindowQueueForm()
        {
            InitializeComponent();
        }

        public CashierWindowQueueForm(CashierClass cashier)
        {
            InitializeComponent();
            this.cashierInstance = cashier;
            this.cashierInstance.OnQueueUpdated += UpdateQueueList;
        }

        private void UpdateQueueList(Queue<string> queue)
        {
            if (this.listCashierQueue.InvokeRequired)
            {
                this.listCashierQueue.Invoke((MethodInvoker)delegate
                {
                    listCashierQueue.Items.Clear();
                    foreach (string number in queue)
                    {
                        listCashierQueue.Items.Add(number);
                    }
                });
            }
            else
            {
                listCashierQueue.Items.Clear();
                foreach (string number in queue)
                {
                    listCashierQueue.Items.Add(number);
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.cashierInstance.Dequeue();
        }
    }
}