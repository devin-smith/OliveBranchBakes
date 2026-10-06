using System.Windows.Forms;

namespace OliveBranchBakes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxProjectName.Text     = ProjectInformation.ProjectName;
            textBoxStudentName.Text     = ProjectInformation.StudentName;
            textBoxPhase.Text           = ProjectInformation.Phase;
            textBoxClass.Text           = ProjectInformation.ClassName;
            textBoxDate.Text            = ProjectInformation.CurrentDate;
            richTextBoxDescription.Text = ProjectInformation.Description;
        }
    }
}
