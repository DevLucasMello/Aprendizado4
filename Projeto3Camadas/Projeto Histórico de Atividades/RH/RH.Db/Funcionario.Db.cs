using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RH.Models;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace RH.Db
{
    public class FuncionarioDb
    {
        //Declaração de variáveis        
        Funcionario func;
        public int salvaRE;        
        public long ultimoCod;
        public string dataAtividade;
        List<long> codAt;
        
        //Método Construtor
        public FuncionarioDb()
        {            
            func = new Funcionario();
            salvaRE = 0;            
            ultimoCod = 0;            
            codAt = new List<long>();
        }
        
        public void Incluir(Funcionario func)
        {
            try
            {          
                var cn = new MySqlConnection(Db.Conexao);

                string sql = "INSERT INTO Funcionario(RE,nome,senha,diasSemana,horarioTrabalhoEntrada,horarioTrabalhoSaida)" +
                    " values(@RE,@Nome,@Senha,@DiasSemana,@HorarioTrabalhoEntrada,@HorarioTrabalhoSaida)";

                var cmd = new MySqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@RE", func.RE);
                cmd.Parameters.AddWithValue("@Nome", func.Nome);
                cmd.Parameters.AddWithValue("@Senha", func.Senha);                
                cmd.Parameters.AddWithValue("@DiasSemana", func.DiasSemana);
                cmd.Parameters.AddWithValue("@HorarioTrabalhoEntrada", func.HorarioTrabalhoEntrada);
                cmd.Parameters.AddWithValue("@HorarioTrabalhoSaida", func.HorarioTrabalhoSaida);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("Inserido com sucesso!!!");
            }
            catch
            {
                MessageBox.Show("" + func.RE + "\n" + func.Nome + "\n" + func.Senha + "\n" + func.DiasSemana + "\n" + func.HorarioTrabalhoEntrada + "\n" + func.HorarioTrabalhoSaida);
            }
        }
        
        public bool Buscar(int RecebeRE, string RecebeSenha)
        {
            string sql = @"SELECT RE,senha FROM Funcionario WHERE RE=@RE";

            var cn = new MySqlConnection(Db.Conexao);

            var cmd = new MySqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@RE", RecebeRE);            

            cn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                func = new Funcionario();
                func.RE = Convert.ToInt32(reader["RE"]);                
                func.Senha = reader["senha"].ToString();                
            }            

            reader.Close();
            cn.Close();

            salvaRE = func.RE;

            if (RecebeRE == func.RE && RecebeSenha == func.Senha)
            {
                return true;
            }

            else
            {
                return false;
            }            
        }        
        
        public Funcionario RetornarDados(int contemRE)
        {
            string sql = @"SELECT RE,nome,senha,diasSemana,horarioTrabalhoEntrada,horarioTrabalhoSaida FROM Funcionario WHERE RE=@RE";

            var cn = new MySqlConnection(Db.Conexao);

            var cmd = new MySqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@RE", contemRE);

            
            Funcionario func = null;

            cn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            
            if (reader.Read())
            {                
                func = new Funcionario();
                func.RE = Convert.ToInt32(reader["RE"]);
                func.Nome = reader["nome"].ToString();
                func.Senha = reader["senha"].ToString();                
                func.DiasSemana = Convert.ToInt32(reader["diasSemana"]);
                func.HorarioTrabalhoEntrada = Convert.ToDateTime("2020/07/07 " + reader["horarioTrabalhoEntrada"]);
                func.HorarioTrabalhoSaida = Convert.ToDateTime("2020/07/07 " + reader["horarioTrabalhoSaida"]);
            }

            reader.Close();
            cn.Close();         

            return func;
        }
        
        public void Alterar(Funcionario func)
        {
            try
            {
                var cn = new MySqlConnection(Db.Conexao);

                string sql = "UPDATE Funcionario SET nome=@Nome, senha=@Senha, diasSemana=@diasSemana, horarioTrabalhoEntrada=@HorarioTrabalhoEntrada, horarioTrabalhoSaida=@HorarioTrabalhoSaida WHERE RE=@RE";

                var cmd = new MySqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@RE", func.RE);
                cmd.Parameters.AddWithValue("@Nome", func.Nome);
                cmd.Parameters.AddWithValue("@Senha", func.Senha);                
                cmd.Parameters.AddWithValue("@DiasSemana", func.DiasSemana);
                cmd.Parameters.AddWithValue("@HorarioTrabalhoEntrada", func.HorarioTrabalhoEntrada);
                cmd.Parameters.AddWithValue("@HorarioTrabalhoSaida", func.HorarioTrabalhoSaida);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("Alterado com sucesso!!!");
            }
            catch
            {
                MessageBox.Show("" + func.RE + "\n" + func.Nome + "\n" + func.Senha + "\n" + func.DiasSemana + "\n" + func.HorarioTrabalhoEntrada + "\n" + func.HorarioTrabalhoSaida);
            }
        }

        public bool Excluir(int RE)
        {
            var cn = new MySqlConnection(Db.Conexao);

            string sql = "DELETE FROM Funcionario WHERE RE=@RE";

            var cmd = new MySqlCommand(sql, cn);
            
            cmd.Parameters.AddWithValue("@RE", RE);

            cn.Open();
            var numero = cmd.ExecuteNonQuery();
            cn.Close();

            if(numero > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void InserirAtividade(Funcionario func)
        {
            try
            {
                var cn = new MySqlConnection(Db.Conexao);

                string sql = "INSERT INTO Atividade(RE,nome,dtInicio,hrInicio,hrFim,semana,ativ) values(@RE,@Nome,@DtInicio,@HrInicio,@HrFim,@Semana,@Ativ)";

                var cmd = new MySqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@RE", func.RE);
                cmd.Parameters.AddWithValue("@Nome", func.Nome);
                cmd.Parameters.AddWithValue("@DtInicio", func.DataInicioAtividade);
                cmd.Parameters.AddWithValue("@HrInicio", func.HoraInicioAtividade);
                cmd.Parameters.AddWithValue("@HrFim", func.HoraFimAtividade);
                cmd.Parameters.AddWithValue("@Semana", func.Semana);
                cmd.Parameters.AddWithValue("@Ativ", func.Atividade);                

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("Inserido com sucesso!!!");
            }
            catch
            {
                MessageBox.Show("" + func.RE + "\n" + func.Nome + "\n" + func.DataInicioAtividade + "\n" + func.HoraInicioAtividade + "\n" + func.HoraFimAtividade + "\n" + func.Atividade + "\n" + func.Semana);
            }
        }

        public long BuscarCodigo()
        {
            string sql = @"SELECT codAtividade FROM Atividade";

            var cn = new MySqlConnection(Db.Conexao);

            var cmd = new MySqlCommand(sql, cn);            

            cn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {                
                ultimoCod = Convert.ToInt64(reader["codAtividade"]);                
            }            

            reader.Close();
            cn.Close();            
            
            return ultimoCod + 1;                       
        }

        public List<long> RetornarAtividades(DateTime diaAtiv, int contemRE)
        {            
            string sql = @"SELECT codAtividade FROM Atividade WHERE dtInicio=@DtInicio and RE=@RE";

            var cn = new MySqlConnection(Db.Conexao);

            var cmd = new MySqlCommand(sql, cn);

            dataAtividade = diaAtiv.ToString("yyyy/MM/dd");

            cmd.Parameters.AddWithValue("@DtInicio", dataAtividade);
            cmd.Parameters.AddWithValue("@RE", contemRE);

            cn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                func.Codigo = Convert.ToInt64(reader["codAtividade"]);
                codAt.Add(func.Codigo);
            }

            reader.Close();
            cn.Close();

            return codAt;             
        }
        
        public Funcionario MostrarAtividade(Funcionario func)
        {
            string sql = @"SELECT hrInicio,hrFim,semana,ativ FROM Atividade WHERE codAtividade=@CodAtividade";

            var cn = new MySqlConnection(Db.Conexao);

            var cmd = new MySqlCommand(sql, cn);            

            cmd.Parameters.AddWithValue("@CodAtividade", func.Codigo);                      

            cn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();


            if (reader.Read())
            {
                func.HoraInicioAtividade = Convert.ToDateTime("2020/07/07 " + reader["hrInicio"]);
                func.HoraFimAtividade = Convert.ToDateTime("2020/07/07 " + reader["hrFim"]);
                func.Semana = reader["semana"].ToString();
                func.Atividade = reader["ativ"].ToString();                
            }

            reader.Close();
            cn.Close();

            return func;
        }

        public void AlterarAtividade(Funcionario func)
        {
            try
            {
                var cn = new MySqlConnection(Db.Conexao);

                string sql = "UPDATE Atividade SET codAtividade=@CodAtividade, dtInicio=@DtInicio, hrInicio=@HrInicio, hrFim=@HrFim, semana=@Semana, ativ=@Ativ WHERE codAtividade=@CodAtividade";

                var cmd = new MySqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@CodAtividade", func.Codigo);                
                cmd.Parameters.AddWithValue("@DtInicio", func.DataInicioAtividade);
                cmd.Parameters.AddWithValue("@HrInicio", func.HoraInicioAtividade);
                cmd.Parameters.AddWithValue("@HrFim", func.HoraFimAtividade);
                cmd.Parameters.AddWithValue("@Semana", func.Semana);
                cmd.Parameters.AddWithValue("@Ativ", func.Atividade);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("Alterado com sucesso!!!");
            }
            catch
            {
                MessageBox.Show("" + func.Codigo + "\n" + func.DataInicioAtividade + "\n" + func.HoraInicioAtividade + "\n" + func.HoraFimAtividade + "\n" + func.Atividade + "\n" + func.Semana);
            }
        }

        public void ExcluirAtividade(Funcionario func)
        {
            try
            {
                var cn = new MySqlConnection(Db.Conexao);

                string sql = "DELETE FROM Atividade WHERE codAtividade=@CodAtividade";

                var cmd = new MySqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@CodAtividade", func.Codigo);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();                

                MessageBox.Show("Excluído com sucesso!!!");
            }
            catch
            {
                MessageBox.Show("Erro!!");
            }
        }

        public List<DateTime> ConsultaPontoEntrada(Funcionario func)
        {
            List<DateTime> ponto = new List<DateTime>();
            string dataE = "";
            string horaE = "";

            try
            {
                string sql = @"SELECT dtInicio,hrInicio FROM Atividade WHERE dtInicio like @DtInicio and RE=@RE";

                var cn = new MySqlConnection(Db.Conexao);

                var cmd = new MySqlCommand(sql, cn);

                string dtInicio = func.Ano + "-" + func.Mes + "%";                

                cmd.Parameters.AddWithValue("@DtInicio", dtInicio);
                cmd.Parameters.AddWithValue("@RE", func.RE);

                cn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {                    
                    dataE = reader["dtInicio"].ToString().Remove(10,9);//13/07/2020 00:00:00
                    horaE = reader["hrInicio"].ToString();                    
                    func.Entrada = Convert.ToDateTime(dataE + " " + horaE);
                    ponto.Add(func.Entrada);                    
                }

                reader.Close();
                cn.Close();
            }
            catch
            {
                MessageBox.Show("Erro!!!");                
            }
            return ponto;
        }



        public List<DateTime> ConsultaPontoSaida(Funcionario func)
        {
            List<DateTime> ponto = new List<DateTime>();
            string dataS = "";
            string horaS = "";

            try
            {
                string sql = @"SELECT dtInicio,hrFim FROM Atividade WHERE dtInicio like @DtInicio and RE=@RE";

                var cn = new MySqlConnection(Db.Conexao);

                var cmd = new MySqlCommand(sql, cn);

                string dtInicio = func.Ano + "-" + func.Mes + "%";

                cmd.Parameters.AddWithValue("@DtInicio", dtInicio);
                cmd.Parameters.AddWithValue("@RE", func.RE);

                cn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dataS = reader["dtInicio"].ToString().Remove(10, 9);//13/07/2020 00:00:00
                    horaS = reader["hrFim"].ToString();
                    func.Saida = Convert.ToDateTime(dataS + " " + horaS);
                    ponto.Add(func.Saida);
                }

                reader.Close();
                cn.Close();
            }
            catch
            {
                MessageBox.Show("Erro!!!");
            }
            return ponto;
        }
    }
}
