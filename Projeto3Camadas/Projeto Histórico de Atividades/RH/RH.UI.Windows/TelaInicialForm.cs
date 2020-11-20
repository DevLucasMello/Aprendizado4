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
    public partial class TelaInicialForm : Form
    {
        public TelaInicialForm()
        {
            InitializeComponent();            
        }

        private void entrarButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm frm = new LoginForm();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }

        private void cadastrarButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            InclusaoFuncionarioForm frm = new InclusaoFuncionarioForm();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }

        private void sairButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
