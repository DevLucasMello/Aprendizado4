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
    public partial class InserirAtividadeForm : Form
    {
        public int buscaRE;
        FuncionarioDb db;
        Funcionario func;
        public InserirAtividadeForm()
        {
            InitializeComponent();
        }

        public InserirAtividadeForm(int contemRE)
        {
            InitializeComponent();
            buscaRE = contemRE;
            db = new FuncionarioDb();
            func = new Funcionario();
        }        

        private void consultarButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultaMenu frm = new ConsultaMenu(buscaRE);
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }        

        private void nomeTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void reTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void atividadeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataInicioTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void codigoTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void horaInicioTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void horaFimTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void semanaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sairButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void inserirButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(dataInicioTextBox.Text.Remove(2, 1).Remove(4,1)) || string.IsNullOrWhiteSpace(atividadeTextBox.Text) || string.IsNullOrWhiteSpace(horaInicioTextBox.Text.Remove(2,1)) || string.IsNullOrWhiteSpace(horaFimTextBox.Text.Remove(2,1)) || string.IsNullOrWhiteSpace(semanaComboBox.Text))
                {
                    MessageBox.Show("Um ou mais campos estão vazios!!");
                }
                else
                {
                    func.RE = Convert.ToInt32(reTextBox.Text);
                    func.Nome = nomeTextBox.Text.ToUpper();
                    func.DataInicioAtividade = Convert.ToDateTime(dataInicioTextBox.Text);
                    func.HoraInicioAtividade = Convert.ToDateTime(horaInicioTextBox.Text);
                    func.HoraFimAtividade = Convert.ToDateTime(horaFimTextBox.Text);
                    func.Semana = semanaComboBox.Text;
                    func.Atividade = atividadeTextBox.Text;

                    //MessageBox.Show("" + func.RE + "\n" + func.Nome + "\n" + func.InicioAtividade + "\n" + func.FimAtividade + "\n" + func.Atividade);

                    db.InserirAtividade(func);

                    LimparCampos();
                    codigoTextBox.Text = db.BuscarCodigo().ToString();
                }
            }
            catch
            {
                MessageBox.Show("Erro!!");
            }
        }

        private void InserirAtividadeForm_Load(object sender, EventArgs e)
        {            
            codigoTextBox.Text = db.BuscarCodigo().ToString();
            PreencherCampos();
        }

        public void PreencherCampos()
        {
            func = db.RetornarDados(buscaRE);

            reTextBox.Text = func.RE.ToString();
            nomeTextBox.Text = func.Nome;
            codigoTextBox.ReadOnly = true;
            reTextBox.ReadOnly = true;
            nomeTextBox.ReadOnly = true;
            dataInicioTextBox.Focus();
        }

        public void LimparCampos()
        {

            dataInicioTextBox.Clear();            
            atividadeTextBox.Clear();
            dataInicioTextBox.Clear();
            horaInicioTextBox.Clear();
            horaFimTextBox.Clear();
            semanaComboBox.Text = "";

            dataInicioTextBox.Focus();            
        }
        private void limparButton_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}
