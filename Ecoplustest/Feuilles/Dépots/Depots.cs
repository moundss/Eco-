using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecoplustest.Feuilles
{
    public partial class Depots : Form
    {
        public Depots()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            var details =new Depots_details();

            details.ShowDialog();

        }
    }
}
