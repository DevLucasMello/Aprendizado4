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
    public partial class ModificaFuncionario : Form
    {
        public int buscaRE;
        public bool checkAlterar;
        public bool checkExcluir;
        FuncionarioDb db;
        Funcionario func;
        public ModificaFuncionario()
        {
            InitializeComponent();
        }

        public ModificaFuncionario(int contemRE)
        {
            InitializeComponent();
            buscaRE = contemRE;
            db = new FuncionarioDb();
            func = new Funcionario();
            checkAlterar = false;
            checkExcluir = false;
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

        //Métodos para ação dos Botões
        /*---------------------------------------------------------------------------*/
        private void atividadesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            InserirAtividadeForm frm = new InserirAtividadeForm(buscaRE);
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }

        private void sairButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void alterarButton_Click(object sender, EventArgs e)
        {
            checkExcluir = false;
            
            EscritaCampos();         

            if (checkAlterar)
            {
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

                        db.Alterar(func);
                        checkAlterar = false;
                        LeituraCampos();
                    }                    
                }
                catch
                {
                    checkAlterar = false;
                    MessageBox.Show("Erro!!");                    
                }
            }
            else
            {
                MessageBox.Show("Altere os campos que deseja e clique em Alterar Novamente!");
                checkAlterar = true;
            }
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            checkAlterar = false;
            if (checkExcluir)
            {
                try
                {
                    func.RE = Convert.ToInt32(reTextBox.Text);                    

                    if (db.Excluir(func.RE))
                    {
                        MessageBox.Show("Excluído com Sucesso!");
                        this.Hide();
                        TelaInicialForm frm = new TelaInicialForm();
                        frm.Closed += (s, args) => this.Close();
                        frm.Show();
                    }                                                           
                }
                catch(Exception erro)
                {
                    checkExcluir = false;
                    MessageBox.Show("Erro!!" + "\n\n" + erro);
                }
            }
            else
            {
                MessageBox.Show("Cheque os dados e clique em Excluir Novamente!");
                senhaTextBox.UseSystemPasswordChar = false;                
                checkExcluir = true;
                PreencherCampos();
            }
        }        

        private void ModificaFuncionario_Load(object sender, EventArgs e)
        {
            PreencherCampos();

            LeituraCampos();
        }
        /*---------------------------------------------------------------------------*/


        //Métodos para armazenamento de Informações
        /*-------------------------------------------------------------------*/
        public void PreencherCampos()
        {
            func = db.RetornarDados(buscaRE);

            reTextBox.Text = func.RE.ToString();
            nomeTextBox.Text = func.Nome;
            senhaTextBox.Text = func.Senha;            
            diasSemanaComboBox.Text = func.DiasSemana.ToString();
            horarioTrabalhoEntradaTextBox.Text = func.HorarioTrabalhoEntrada.ToString("HH:mm tt");
            horarioTrabalhoSaidaTextBox.Text = func.HorarioTrabalhoSaida.ToString("HH:mm tt");
        }

        public void LeituraCampos()
        {
            reTextBox.ReadOnly = true;
            nomeTextBox.ReadOnly = true;
            senhaTextBox.ReadOnly = true;            
            diasSemanaComboBox.Enabled = false;
            horarioTrabalhoEntradaTextBox.ReadOnly = true;
            horarioTrabalhoSaidaTextBox.ReadOnly = true;
            senhaTextBox.UseSystemPasswordChar = true;            
        }

        public void EscritaCampos()
        {
            senhaTextBox.UseSystemPasswordChar = false;            
            nomeTextBox.ReadOnly = false;
            senhaTextBox.ReadOnly = false;            
            diasSemanaComboBox.Enabled = true;
            horarioTrabalhoEntradaTextBox.ReadOnly = false;
            horarioTrabalhoSaidaTextBox.ReadOnly = false;
            senhaTextBox.UseSystemPasswordChar = false;            
        }        
        /*-------------------------------------------------------------------*/
    }
}
