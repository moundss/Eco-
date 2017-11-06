using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        public int Monid;
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
            if (button1.Text == @"Enregistrer")
            {
            var design = textBox1.Text;
            var qte = textBox2.Text;
            var qteLi = textBox3.Text;
            var localisation = textBox4.Text;
            var semence = textBox5.Text;
            var ledepot= new Depot(design,float.Parse(qte),
                float.Parse(qteLi),localisation,semence);

            var result=  _depotRepositories.Enregistrer(ledepot);
            
             MessageBox.Show(@"Enregistré avec succes");
            Close();
            }

            if (button1.Text == @"Modifier")
            {
                var design = textBox1.Text;
                var qte = textBox2.Text;
                var qteLi = textBox3.Text;
                var localisation = textBox4.Text;
                var semence = textBox5.Text;
                var ledepot = new Depot(design, float.Parse(qte),
                    float.Parse(qteLi), localisation, semence);
                //Depots.LeDepot.Modifier(Monid,Depots.LeDepot);

                var result = _depotRepositories.Modifier(Monid, ledepot);

                MessageBox.Show(@"Modifié avec succes");
                Close();
                
            }
        }

        private void Depots_details_Load(object sender, EventArgs e)
        {
            Monid = Depots.Id;
            if (Monid==0) return;
            if (Monid != 0) button1.Text = @"Modifier";
            label6.Text = Monid.ToString();
            textBox1.Text = Depots.LeDepot.Libelle;
            textBox2.Text = Depots.LeDepot.Qte.ToString(CultureInfo.InvariantCulture);
            textBox3.Text = Depots.LeDepot.Qtelimit.ToString(CultureInfo.InvariantCulture);
            textBox4.Text = Depots.LeDepot.Localisation;
            textBox5.Text = Depots.LeDepot.Semence;
        }

        private void Depots_details_FormClosed(object sender, FormClosedEventArgs e)
        {
            Monid = 0;
        }
    }
}
