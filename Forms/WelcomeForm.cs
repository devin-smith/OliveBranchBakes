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
    public partial class WelcomeForm : BaseForm
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void labelWelcome_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerOrderForm orderForm = new CustomerOrderForm();
            orderForm.ShowDialog();
        }

        private void buttonAccount_Click(object sender, EventArgs e)
        {
            CustomerAccountForm accountForm = new CustomerAccountForm();
            accountForm.ShowDialog();
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            AdminLoginForm adminForm = new AdminLoginForm();
            adminForm.ShowDialog();
        }
    }
}
