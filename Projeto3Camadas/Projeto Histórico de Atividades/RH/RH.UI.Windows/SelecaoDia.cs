using RH.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RH.UI.Windows
{
    public partial class SelecaoDia : Form
    {
        public string informaDia;
        public int buscaRE;
        Funcionario func;
        public SelecaoDia()
        {
            InitializeComponent();            
        }
        public SelecaoDia(int contemRE)
        {
            InitializeComponent();
            buscaRE = contemRE;
            func = new Funcionario();
        }

        private void diaTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void consultarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(diaTextBox.Text.Remove(2, 1).Remove(4, 1)))
                {
                    MessageBox.Show("O dia precisa ser preenchido!!");
                }
                else
                {
                    func.RecebeDia = Convert.ToDateTime(diaTextBox.Text);                   
                }
            }
            catch
            {
                MessageBox.Show("Erro!!");
            }

            this.Hide();
            ConsultaDia frm = new ConsultaDia(buscaRE, func.RecebeDia);
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }

        private void retornarButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultaMenu frm = new ConsultaMenu(buscaRE);
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }

        private void limparButton_Click(object sender, EventArgs e)
        {
            diaTextBox.Clear();
            diaTextBox.Focus();
        }

        private void SelecaoDia_Load(object sender, EventArgs e)
        {
            informaDia = DateTime.Now.ToString();
            diaTextBox.Text = informaDia;
        }
    }
}
