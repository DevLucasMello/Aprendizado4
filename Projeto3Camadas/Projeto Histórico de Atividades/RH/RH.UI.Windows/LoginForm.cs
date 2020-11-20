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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            senhaTextBox.PasswordChar = '*';
        }

        private void entrarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(reTextBox.Text) || string.IsNullOrWhiteSpace(senhaTextBox.Text))
                {
                    MessageBox.Show("Favor preencher RE e senha.");
                }
                else
                {
                    Funcionario func = new Funcionario();

                    func.RecebeRE = Convert.ToInt32(reTextBox.Text);
                    func.RecebeSenha = senhaTextBox.Text;

                    FuncionarioDb db = new FuncionarioDb();

                    if (db.Buscar(func.RecebeRE, func.RecebeSenha))
                    {
                        this.Hide();
                        ModificaFuncionario frm = new ModificaFuncionario(db.salvaRE);
                        frm.Closed += (s, args) => this.Close();
                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show("RE ou senha Inválidos!");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Erro...");
            }
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

        private void reTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void senhaTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
