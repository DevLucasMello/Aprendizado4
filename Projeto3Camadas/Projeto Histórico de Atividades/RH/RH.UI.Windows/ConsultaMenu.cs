using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RH.Models;
using RH.Db;

namespace RH.UI.Windows
{
    public partial class ConsultaMenu : Form
    {
        public int buscaRE;
        public ConsultaMenu()
        {
            InitializeComponent();
        }

        public ConsultaMenu(int contemRE)
        {
            InitializeComponent();
            buscaRE = contemRE;
        }

        private void consultarDiaButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelecaoDia frm = new SelecaoDia(buscaRE);
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }

        private void consultarPeriodoButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultaPeriodo frm = new ConsultaPeriodo(buscaRE);
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }

        private void retornarButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            InserirAtividadeForm frm = new InserirAtividadeForm(buscaRE);
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }

        private void ConsultaMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
