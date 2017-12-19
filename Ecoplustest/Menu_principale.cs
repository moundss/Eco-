using System.Windows.Forms;
using Ecoplustest.Feuilles;
using Ecoplustest.Feuilles.Distribution;

namespace Ecoplustest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // var connectstat=new BootConfig();
            //if (connectstat.Connecter())MessageBox.Show(@"connecté");

           // MessageBox.Show(@"connecté");
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
          var mnDepots=new Depots();
            mnDepots.ShowDialog();
        }

        private void button5_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            var mnExploitant= new Exploitants();
            mnExploitant.ShowDialog();
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            var maDistribution=new Distribution();
            maDistribution.ShowDialog();
        }
    }
}