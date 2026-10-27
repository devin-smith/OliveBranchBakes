using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OliveBranchBakes.Forms
{
    public partial class CustomerOrderForm : BaseForm
    {
        public CustomerOrderForm()
        {
            InitializeComponent();
        }

        private void labelQuantity_Click(object sender, EventArgs e)
        {

        }

        private void labelProduct_Click(object sender, EventArgs e)
        {

        }

        private void numericQuantity_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonOrderSummary_Click(object sender, EventArgs e)
        {
            OrderSummaryForm summaryForm = new OrderSummaryForm();
            summaryForm.ShowDialog();
        }
    }
}
