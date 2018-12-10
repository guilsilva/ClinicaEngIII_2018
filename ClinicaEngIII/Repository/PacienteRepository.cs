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
    public class PacienteRepository
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["bd_consultorio"].ConnectionString;
        public string PersistMedico(Paciente paciente)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Insert-Paciente]";
                cmd.Parameters.AddWithValue("@Nome", paciente.Nome);
                cmd.Parameters.AddWithValue("@CPF", paciente.Cpf);
                cmd.Parameters.AddWithValue("@Idade", paciente.Idade);
                cmd.Parameters.AddWithValue("@Sexo", paciente.Sexo);
                cmd.Parameters.AddWithValue("@Telefone", paciente.Telefone);
                cmd.Parameters.AddWithValue("@Endereco", paciente.Endereco);

                cmd.ExecuteNonQuery();

                con.Close();
                return "Sucesso";
            }
            catch (Exception)
            {
                return "Erro!";
            }

        }

        public void SelectPaciente(string cpf, string nome)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "[dbo].[Select-Paciente]";
                cmd.Parameters.AddWithValue("@Nome", nome);
                cmd.Parameters.AddWithValue("@Cpf", cpf);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string Nome = rdr["Nome"].ToString();
                    string Cpf = rdr["Cpf"].ToString();
                    int Idade = int.Parse(rdr["Idade"].ToString());
                    string Sexo = rdr["Sexo"].ToString();
                    string Telefone = rdr["Telefone"].ToString();
                    string Endereco = rdr["Endereco"].ToString();
                }
                con.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public int SelectPKPaciente(string Nome, string CPF)
        {
            
            try
            {
                int pk = 0;
                SqlConnection con = new SqlConnection(connectionString);


                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "[dbo].[Select-PK-Paciente]";
                cmd.Parameters.AddWithValue("@Nome", Nome);
                cmd.Parameters.AddWithValue("@Cpf", CPF);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                
                while (rdr.Read())
                {
                    pk = int.Parse(rdr["pk_PacienteId"].ToString());
                }
                con.Close();
                return pk;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public string UpdatePaciente(Paciente paciente)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Update-Paciente]";
                cmd.Parameters.AddWithValue("@Nome", paciente.Nome);
                cmd.Parameters.AddWithValue("@CPF", paciente.Cpf);
                cmd.Parameters.AddWithValue("@Idade", paciente.Idade);
                cmd.Parameters.AddWithValue("@Sexo", paciente.Sexo);
                cmd.Parameters.AddWithValue("@Telefone", paciente.Telefone);
                cmd.Parameters.AddWithValue("@Endereco", paciente.Endereco);

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
