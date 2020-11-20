using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using RH.Models;
using RH.Db;

namespace RH.UI.Windows
{
    public partial class InclusaoFuncionarioForm : Form
    {
        public InclusaoFuncionarioForm()
        {
            InitializeComponent();            
        }

        private void retornarButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaInicialForm frm = new TelaInicialForm();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }

        private void sairButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nomeTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void reTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void senhaTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }        

        private void horarioTrabalhoEntradaTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void horarioTrabalhoSaidaTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }        

        private void diasSemanaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cadastrarButton_Click(object sender, EventArgs e)
        {
            Funcionario func = new Funcionario();

            try
            {
                if (string.IsNullOrWhiteSpace(reTextBox.Text) || string.IsNullOrWhiteSpace(nomeTextBox.Text) || string.IsNullOrWhiteSpace(senhaTextBox.Text) || string.IsNullOrWhiteSpace(horarioTrabalhoEntradaTextBox.Text.Remove(2, 1)) || string.IsNullOrWhiteSpace(horarioTrabalhoSaidaTextBox.Text.Remove(2, 1)))
                {
                    MessageBox.Show("Um ou mais campos estão vazios!!");
                }                
                else
                {
                    func.RE = Convert.ToInt32(reTextBox.Text);
                    func.Nome = nomeTextBox.Text.ToUpper();
                    func.Senha = senhaTextBox.Text;                    
                    func.HorarioTrabalhoEntrada = Convert.ToDateTime(horarioTrabalhoEntradaTextBox.Text);
                    func.HorarioTrabalhoSaida = Convert.ToDateTime(horarioTrabalhoSaidaTextBox.Text);
                    func.DiasSemana = Convert.ToInt32(diasSemanaComboBox.Text);

                    FuncionarioDb db = new FuncionarioDb();

                    db.Incluir(func);

                    LimparCampos();
                }                
            }
            catch
            {
                MessageBox.Show("Erro!!");
            }            
        }

        public void LimparCampos()
        {

            reTextBox.Clear();
            nomeTextBox.Clear();
            senhaTextBox.Clear();            
            horarioTrabalhoEntradaTextBox.Clear();
            horarioTrabalhoSaidaTextBox.Clear();            
            diasSemanaComboBox.SelectedIndex = 0;


            nomeTextBox.Focus();
        }

        private void limparButton_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void InclusaoFuncionarioForm_Load(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}
