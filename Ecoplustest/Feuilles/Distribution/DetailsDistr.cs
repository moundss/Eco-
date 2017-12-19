using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecoplustest.Feuilles.Distribution
{
    public partial class DetailsDistr : Form
    {
        public static string[] ExploitStrings;
        public DetailsDistr()
        {
            InitializeComponent();  
        }

        private void DatailsDistr_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var selectexpl= new SelectExplt();
            selectexpl.ShowDialog();
            ;
        }
    }
}
