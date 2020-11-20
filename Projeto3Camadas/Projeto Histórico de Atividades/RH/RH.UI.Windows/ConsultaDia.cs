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
using System.Linq.Expressions;

namespace RH.UI.Windows
{
    public partial class ConsultaDia : Form
    {
        public int buscaRE;
        public bool edit;
        public bool delete;        
        public DateTime buscaDia;
        public Funcionario func;
        public FuncionarioDb db;
        public ConsultaDia()
        {
            InitializeComponent();
        }

        public ConsultaDia(int contemRE, DateTime contemDia)
        {
            InitializeComponent();
            buscaRE = contemRE;
            buscaDia = contemDia;
            edit = false;
            delete = false;            
            func = new Funcionario();
            db = new FuncionarioDb();
        }

        private void retornarButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelecaoDia frm = new SelecaoDia(buscaRE);
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }

        private void sairButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void diaTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void horaEntradaTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void horaSaidaTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void atividadeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void consultarButton_Click(object sender, EventArgs e)
        {
            try
            {                
                if (string.IsNullOrWhiteSpace(codAtivcomboBox.Text))
                {
                    MessageBox.Show("Selecione uma Atividade ou Atividade Inexistente.");                    
                    codAtivcomboBox.Enabled = true;
                }
                else
                {
                    func.Codigo = Convert.ToInt64(codAtivcomboBox.Text);
                    db.MostrarAtividade(func);

                    horaEntradaTextBox.Text = func.HoraInicioAtividade.ToString("HH:mm tt");
                    horaSaidaTextBox.Text = func.HoraFimAtividade.ToString("HH:mm tt");
                    semanaComboBox.Text = func.Semana;
                    atividadeTextBox.Text = func.Atividade;
                }                
            }
            catch
            {
                MessageBox.Show("Erro!!!");
            }
        }        

        private void ConsultaDia_Load(object sender, EventArgs e)
        {
            ConsultarDados();       
        }

        private void alterarButton_Click(object sender, EventArgs e)
        {
            codAtivcomboBox.Enabled = false;
            try
            {
                if (string.IsNullOrWhiteSpace(codAtivcomboBox.Text))
                {
                    MessageBox.Show("Necessário Consultar antes de Alterar.");
                }
                else if(!edit)
                {
                    EditarDados();
                    edit = true;
                    MessageBox.Show("Modifique os campos que deseja e clique em Alterar");
                }
                else if (edit)
                {
                    func.Codigo = Convert.ToInt64(codAtivcomboBox.Text);
                    func.DataInicioAtividade = Convert.ToDateTime(diaTextBox.Text);
                    func.HoraInicioAtividade = Convert.ToDateTime(horaEntradaTextBox.Text);
                    func.HoraFimAtividade = Convert.ToDateTime(horaSaidaTextBox.Text);
                    func.Semana = semanaComboBox.Text;
                    func.Atividade = atividadeTextBox.Text;

                    //MessageBox.Show("" + func.RE + "\n" + func.Nome + "\n" + func.InicioAtividade + "\n" + func.FimAtividade + "\n" + func.Atividade);

                    db.AlterarAtividade(func);
                    codAtivcomboBox.Items.Remove(codAtivcomboBox.Text);                    
                    foreach (var a in db.RetornarAtividades(buscaDia, buscaRE))
                    {
                        codAtivcomboBox.Items.Add(a.ToString());
                    }
                    codAtivcomboBox.Items.Remove(codAtivcomboBox.Text);
                    codAtivcomboBox.Text = "";
                    semanaComboBox.Text = "";
                    horaEntradaTextBox.Clear();
                    horaSaidaTextBox.Clear();
                    atividadeTextBox.Clear();
                    diaTextBox.ReadOnly = true;
                    horaEntradaTextBox.ReadOnly = true;
                    horaSaidaTextBox.ReadOnly = true;
                    atividadeTextBox.ReadOnly = true;
                    codAtivcomboBox.Enabled = false;
                    semanaComboBox.Enabled = false;                    
                    edit = false;                    
                }
            }
            catch
            {
                MessageBox.Show("Erro!!!");
            }
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            codAtivcomboBox.Enabled = false;
            try
            {
                if (string.IsNullOrWhiteSpace(codAtivcomboBox.Text))
                {
                    MessageBox.Show("Necessário Consultar antes de Excluir.");
                }
                else if (!delete)
                {
                    ExcluirDados();
                    delete = true;
                    MessageBox.Show("Check os dados e clique em Excluir");
                }
                else if (delete)
                {
                    func.Codigo = Convert.ToInt64(codAtivcomboBox.Text);                  

                    db.ExcluirAtividade(func);
                    codAtivcomboBox.Items.Remove(codAtivcomboBox.Text);                    
                    codAtivcomboBox.Text = "";
                    semanaComboBox.Text = "";
                    horaEntradaTextBox.Clear();
                    horaSaidaTextBox.Clear();
                    atividadeTextBox.Clear();
                    delete = false;                    
                }                
            }
            catch
            {
                MessageBox.Show("Erro!!!");
            }
        }

        public void EditarDados()
        {
            diaTextBox.ReadOnly = false;
            horaEntradaTextBox.ReadOnly = false;
            horaSaidaTextBox.ReadOnly = false;
            semanaComboBox.Enabled = true;
            atividadeTextBox.ReadOnly = false;
        }

        public void ExcluirDados()
        {
            diaTextBox.ReadOnly = true;
            horaEntradaTextBox.ReadOnly = true;
            horaSaidaTextBox.ReadOnly = true;
            semanaComboBox.Enabled = false;
            atividadeTextBox.ReadOnly = true;
        }

        public void ConsultarDados()
        {          
            diaTextBox.Text = buscaDia.ToString();

            diaTextBox.ReadOnly = true;
            horaEntradaTextBox.ReadOnly = true;
            horaSaidaTextBox.ReadOnly = true;
            atividadeTextBox.ReadOnly = true;
            codAtivcomboBox.Enabled = true;
            semanaComboBox.Enabled = false;
            horaEntradaTextBox.Clear();
            horaSaidaTextBox.Clear();
            semanaComboBox.Text = "";
            atividadeTextBox.Clear();

            foreach (var a in db.RetornarAtividades(buscaDia, buscaRE))
            {
                codAtivcomboBox.Items.Add(a.ToString());
            }
        }
    }
}
