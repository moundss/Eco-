using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ecoplus.domain.core.Aggregats;
using Ecoplus.domain.core.Interfaces.Repository;
using Ecoplus.Infrastructure.Repository;

namespace Ecoplustest.Feuilles
{
    public partial class Depots_details : Form
    {
        private IDepotRepositories _depotRepositories= new DepotRepositories();
        public Depots_details()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var design = textBox1.Text;
            var qte = textBox2.Text;
            var qteLi = textBox3.Text;
            var localisation = textBox4.Text;
            var ledepot= new Depot(Guid.NewGuid(),design,float.Parse(qte),
                float.Parse(qteLi),localisation);

            _depotRepositories.Enregistrer(ledepot);
            
             MessageBox.Show(@"Enregistrer avec succes");
            Close();
        }
    }
}
