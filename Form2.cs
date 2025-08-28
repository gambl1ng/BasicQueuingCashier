using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BasicQueuingCashier
{
    public partial class Form2 : Form
    {
        private Timer timer;
        private CashierClass cashierInstance; // Dito tatanggapin ang instance ng CashierClass
        private System.Windows.Forms.Label RunQueue; // Siguraduhin na ito ang pangalan ng label sa designer

        // Ang bagong constructor na tumatanggap ng CashierClass object
        public Form2(CashierClass cashier)
        {
            InitializeComponent();
            this.cashierInstance = cashier; // I-assign ang instance sa local variable

            // Itong code sa loob ng constructor ang mag-a-update ng display
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += UpdateQueueDisplay;
            timer.Start();

            // Mag-subscribe din sa event ng CashierClass para sa real-time updates
            this.cashierInstance.OnQueueUpdated += UpdateQueueDisplayDirectly;
        }

        // Ang default constructor ay dapat na nandoon para sa designer
        // public Form2()
        // {
        //     InitializeComponent();
        // }

        // Ito ang method na tatawagin ng timer
        public void UpdateQueueDisplay(object sender, EventArgs e)
        {
            // Gamitin ang CashierClass instance para makuha ang queue
            Queue<string> cashierQueue = cashierInstance.CashierQueue;

            // I-update ang text ng RunQueue label
            if (RunQueue != null)
            {
                RunQueue.Text = cashierQueue.Count > 0 ? cashierQueue.Peek() : " ";
            }
        }

        // Isang mas direktang method na tatawagin ng event
        public void UpdateQueueDisplayDirectly(Queue<string> queue)
        {
            if (RunQueue != null)
            {
                RunQueue.Text = queue.Count > 0 ? queue.Peek() : " ";
            }
        }
    }
}