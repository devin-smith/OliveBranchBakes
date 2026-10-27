using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OliveBranchBakes.Forms
{
    public class BaseForm : Form
    {
        public BaseForm()
        {
            // Standard form
            this.BackColor = Color.FromArgb(250, 246, 235);
            this.ForeColor = Color.FromArgb(89, 62, 44);
            this.Font = new Font("Segoe UI", 11);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(1000, 700);
        }
    }
}
