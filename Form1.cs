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
    public partial class QueuingForm : Form
    {
        private CashierWindowQueueForm cashierform;
        private CashierClass cashier;
        private Form2 serving;

        public QueuingForm()
        {
            InitializeComponent();

            cashier = CashierClass.Instance;

            cashierform = new CashierWindowQueueForm(cashier);
            serving = new Form2(cashier);
            cashierform.Show();
            serving.Show();
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            if (this.lblQueue != null)
            {
                lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            }
        }

        private void lblQueue_Click(object sender, EventArgs e)
        {
            
        }
    }
}