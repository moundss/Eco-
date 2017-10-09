using System.Windows.Forms;

namespace Ecoplustest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // var connectstat=new BootConfig();
            //if (connectstat.Connecter())MessageBox.Show(@"connecté");

            MessageBox.Show(@"connecté");
        }
    }
}