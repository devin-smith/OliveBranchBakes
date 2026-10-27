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
    public partial class AdminLoginForm : BaseForm
    {
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void buttonPreviousConsole_Click(object sender, EventArgs e)
        {
            AdminConsoleForm consoleForm = new AdminConsoleForm();
            consoleForm.ShowDialog();
        }
    }
}
