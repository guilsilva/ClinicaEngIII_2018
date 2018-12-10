using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaEngIII.Repository
{
    class SecretariaRepository
    {
        public string Nome;
        public int Idade;
        public string Sexo;
        public string Telefone;
        public string Endereco;
        public string Cpf;
        public double Salario;
        public string HrTrab;
        public string Ramal;
        private string connectionString = ConfigurationManager.ConnectionStrings["bd_consultorio"].ConnectionString;
        public string PersistSecretaria(Secretaria sec)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Insert-Secretaria]";
                cmd.Parameters.AddWithValue("@Nome", sec.Nome);
                cmd.Parameters.AddWithValue("@Idade", sec.Idade);
                cmd.Parameters.AddWithValue("@Sexo", sec.Sexo);
                cmd.Parameters.AddWithValue("@Salario", sec.Salario);
                cmd.Parameters.AddWithValue("@HorasTrabalhadas", sec.HrTrabalho);
                cmd.Parameters.AddWithValue("@Ramal", sec.Ramal);
                cmd.Parameters.AddWithValue("@Telefone", sec.Telefone);
                cmd.Parameters.AddWithValue("@Endereco", sec.Endereco);
                cmd.Parameters.AddWithValue("@Cpf", sec.Cpf);

                cmd.ExecuteNonQuery();

                con.Close();
                return "Sucesso";
            }
            catch (Exception)
            {
                return "Erro!";
            }

        }

        public bool SelectSecretaria(string cpf, string nome)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "[dbo].[Select-Secretaria]";
                cmd.Parameters.AddWithValue("@Nome", nome);
                cmd.Parameters.AddWithValue("@Cpf", cpf);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    this.Cpf = rdr["Nome"].ToString();
                    this.Nome = rdr["Cpf"].ToString();
                    this.Idade = int.Parse(rdr["Idade"].ToString());
                    this.Sexo = rdr["Sexo"].ToString();
                    this.Telefone = rdr["Telefone"].ToString();
                    this.Endereco = rdr["Endereco"].ToString();
                }

                con.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public string UpdateSecretaria(Secretaria sec)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Update-Secretaria]";
                cmd.Parameters.AddWithValue("@Nome", sec.Nome);
                cmd.Parameters.AddWithValue("@Idade", sec.Idade);
                cmd.Parameters.AddWithValue("@Sexo", sec.Sexo);
                cmd.Parameters.AddWithValue("@Salario", sec.Salario);
                cmd.Parameters.AddWithValue("@HorasTrabalhadas", sec.HrTrabalho);
                cmd.Parameters.AddWithValue("@Ramal", sec.Ramal);
                cmd.Parameters.AddWithValue("@Telefone", sec.Telefone);
                cmd.Parameters.AddWithValue("@Endereco", sec.Endereco);
                cmd.Parameters.AddWithValue("@CPF", sec.Cpf);

                cmd.ExecuteNonQuery();

                con.Close();
                return "Sucesso!";
            }
            catch (Exception)
            {
                return "Erro!";
                throw;
            }
        }
    }
}
