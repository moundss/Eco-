using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ecoplus.domain.core.Dtos;
using Ecoplus.domain.core.Interfaces.Repository;
using Ecoplus.Infrastructure.Repository;

namespace Ecoplustest.Feuilles.Distribution
{
    public partial class SelectExplt : Form
    {
        private readonly IExploitantRepositories _exploitants=new ExploitantRepositories();
        private List<ExploitantSimpleDtos> _laSource;
        public SelectExplt()
        {
            InitializeComponent();
        }

        private void SelectExplt_Load(object sender, EventArgs e)
        {
           
            _laSource = _exploitants.ListeSimple();
            var mesdepartement = (_laSource.Select(simpleDtose => simpleDtose.Departement)).Distinct();
            var district = (_laSource.Select(simpleDtose => simpleDtose.District).Distinct());
            var mesnature= (_laSource.Select(simpleDtose => simpleDtose.Nature).Distinct());
            dataGridView1.Refresh();
            dataGridView1.DataSource = _laSource;
            dataGridView1.Columns[0].HeaderText = @"ID";
            dataGridView1.Columns[1].HeaderText = @"Désignation";
            dataGridView1.Columns[2].HeaderText = @"Département";
            dataGridView1.Columns[3].HeaderText = @"District";
            dataGridView1.Columns[4].HeaderText = @"Nature";

           
            combDepartmnt.DataSource=mesdepartement.ToList();
            combDepartmnt.Text = @"Choix Département";
            combDistrict.DataSource = district.ToList();
            combDistrict.Text = @"Choix District";
            combNature.DataSource = mesnature.ToList();
            combNature.Text = @"Choix Nature";
        }

        private void combDepartmnt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combDepartmnt.SelectedIndex <= 0) return;
            var critere = _laSource.Where(simpleDtose =>  simpleDtose.Departement == combDepartmnt.SelectedIndex.ToString())
                .ToList();
            dataGridView1.DataSource = critere;
        }
    }
}
