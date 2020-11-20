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
    public partial class ConsultaPeriodo : Form
    {
        public int buscaRE;
        public int periodo;
        Funcionario func;
        FuncionarioDb db;
        public ConsultaPeriodo()
        {
            InitializeComponent();
        }
        public ConsultaPeriodo(int contemRE)
        {
            InitializeComponent();
            buscaRE = contemRE;
            periodo = 0;
            func = new Funcionario();
            db = new FuncionarioDb();
            
        }

        private void retornarButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultaMenu frm = new ConsultaMenu(buscaRE);
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }
        private void mesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void anoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void sairButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void consultarButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mesComboBox.Text) || string.IsNullOrWhiteSpace(anoComboBox.Text) || string.IsNullOrWhiteSpace(periodoComboBox.Text))
            {
                MessageBox.Show("Necessário selecionar o Mês e o Ano.");
            }
            else
            {
                func.Mes = mesComboBox.Text.Substring(0, 2);
                func.Ano = anoComboBox.Text;
                func.RE = buscaRE;
                periodo = Convert.ToInt32(periodoComboBox.Text.Substring(0, 2));
            }
            if(periodo == 01)
            {                
                ExibirGridEntrada();
            }
            else if (periodo == 02)
            {                
                ExibirGridSaida();
            }
        }

        private void ConsultaPeriodo_Load(object sender, EventArgs e)
        {            
            //Tronando a Grid visível
            pontoDataGridView.Visible = true;
            //Extendendo a Grid por todo o panel
            pontoDataGridView.Dock = DockStyle.Fill;
        }        

        private void ExibirGridEntrada()//Método para tornar visível assim que o formulário é iniciado
        {
            //Tronando a Grid visível
            pontoDataGridView.Visible = true;
            //Extendendo a Grid por todo o panel
            pontoDataGridView.Dock = DockStyle.Fill;

            //DataSource recebe e exibe a lista de clientes que é o retorno do método Listar da classe ClienteDb
            pontoDataGridView.DataSource = db.ConsultaPontoEntrada(func);

            for (var i = 0; i < 10; i++)
            {
                pontoDataGridView.Columns.RemoveAt(1);
            }            
            pontoDataGridView.Columns.RemoveAt(2);
            pontoDataGridView.Columns[0].HeaderText = "Dia";
            pontoDataGridView.Columns[1].HeaderText = "Hora";

            //Tirar a seleção da Grid
            pontoDataGridView.CurrentRow.Selected = false;

            //Selecionando toda a linha da Grid
            pontoDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //Não tornando a Grid apenas leitura
            pontoDataGridView.ReadOnly = true;

            //Ocupe toda a tela da Grid
            pontoDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Excluir o seletor de linhas
            pontoDataGridView.RowHeadersVisible = false;

            //Remover o estilo do Windows da Grid
            pontoDataGridView.EnableHeadersVisualStyles = false;            
        }

        private void ExibirGridSaida()//Método para tornar visível assim que o formulário é iniciado
        {
            //Tronando a Grid visível
            pontoDataGridView.Visible = true;
            //Extendendo a Grid por todo o panel
            pontoDataGridView.Dock = DockStyle.Fill;

            //DataSource recebe e exibe a lista de clientes que é o retorno do método Listar da classe ClienteDb
            pontoDataGridView.DataSource = db.ConsultaPontoSaida(func);

            for (var i = 0; i < 10; i++)
            {
                pontoDataGridView.Columns.RemoveAt(1);
            }
            pontoDataGridView.Columns.RemoveAt(2);
            pontoDataGridView.Columns[0].HeaderText = "Dia";
            pontoDataGridView.Columns[1].HeaderText = "Hora";

            //Tirar a seleção da Grid
            pontoDataGridView.CurrentRow.Selected = false;

            //Selecionando toda a linha da Grid
            pontoDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //Não tornando a Grid apenas leitura
            pontoDataGridView.ReadOnly = true;

            //Ocupe toda a tela da Grid
            pontoDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Excluir o seletor de linhas
            pontoDataGridView.RowHeadersVisible = false;

            //Remover o estilo do Windows da Grid
            pontoDataGridView.EnableHeadersVisualStyles = false;
        }

        private void imprimirButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Botão Não Configurado");
        }
    }
}
