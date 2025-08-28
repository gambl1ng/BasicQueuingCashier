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
    public partial class Form2 : Form
    {
        private CashierClass cashierInstance;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(CashierClass cashier)
        {
            InitializeComponent();
            this.cashierInstance = cashier;
            this.cashierInstance.OnQueueUpdated += UpdateQueueDisplay;
        }

        public void UpdateQueueDisplay(Queue<string> queue)
        {
            if (RunQueue.InvokeRequired)
            {
                RunQueue.Invoke((MethodInvoker)delegate
                {
                    RunQueue.Text = queue.Count > 0 ? queue.Peek() : " ";
                });
            }
            else
            {
                RunQueue.Text = queue.Count > 0 ? queue.Peek() : " ";
            }
        }
    }
}