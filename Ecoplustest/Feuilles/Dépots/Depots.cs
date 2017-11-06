using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ecoplus.domain.core.Aggregats;
using Ecoplus.domain.core.Dtos;
using Ecoplus.domain.core.Interfaces.Repository;
using Ecoplus.Infrastructure.Repository;

namespace Ecoplustest.Feuilles
{
    public partial class Depots : Form
    {
        IDepotRepositories _depot=new DepotRepositories();
        public static  int Id = 0;
        public static Depot LeDepot;
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
            var details = new Depots_details();
            Id = 0;
            details.ShowDialog();
            Rafraichir();

        }

        private void Depots_Load(object sender, EventArgs e)
        {
            Rafraichir();

        }

        private void Rafraichir()
        {
            dataGridView1.Refresh();
            var results = _depot.Listedepot();


            dataGridView1.DataSource = results;
        }

        private void update_Click(object sender, EventArgs e)
        {
           
             var details = new Depots_details();
            if (dataGridView1.CurrentRow == null) return;
            Id=(int) dataGridView1.CurrentRow.Cells[0].Value;

            var libelle = !string.IsNullOrWhiteSpace(dataGridView1.CurrentRow.Cells[1].Value.ToString()) 
                ? dataGridView1.CurrentRow.Cells[1].Value.ToString() 
                : " ";
            var qte = (float) dataGridView1.CurrentRow.Cells[3].Value >= 0
                ? (float) dataGridView1.CurrentRow.Cells[3].Value
                : 0;
            var qtelimit = (float) dataGridView1.CurrentRow.Cells[2].Value >= 0
                ? (float)dataGridView1.CurrentRow.Cells[2].Value
                : 0;
            var local = !string.IsNullOrWhiteSpace(dataGridView1.CurrentRow.Cells[4].Value.ToString())
                ? dataGridView1.CurrentRow.Cells[4].Value.ToString()
                : " ";
            var semence = !string.IsNullOrWhiteSpace(dataGridView1.CurrentRow.Cells[5].Value.ToString())
                ? dataGridView1.CurrentRow.Cells[5].Value.ToString()
                : " ";

            LeDepot =new Depot(libelle,qte,qtelimit,local,semence);
            details.ShowDialog();
            Rafraichir();
        }
    }
}
