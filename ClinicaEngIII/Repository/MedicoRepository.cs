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
    public class MedicoRepository
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["db_consultorio"].ConnectionString;

        public string PersistMedico(Medico medico)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Insert-Medico]";
                cmd.Parameters.AddWithValue("@CRM", medico.Crm);
                cmd.Parameters.AddWithValue("@Nome", medico.Crm);
                cmd.Parameters.AddWithValue("@Idade", medico.Idade);
                cmd.Parameters.AddWithValue("@Sexo", medico.Sexo);
                cmd.Parameters.AddWithValue("@Area", medico.Area);
                cmd.Parameters.AddWithValue("@Salario", medico.Salario);
                cmd.Parameters.AddWithValue("@HorarioAtendimento", medico.HrAtendimento);
                cmd.Parameters.AddWithValue("@Telefone", medico.Telefone);
                cmd.Parameters.AddWithValue("@Endereco", medico.Endereco);

                cmd.ExecuteNonQuery();

                con.Close();
                return "Sucesso";
            }
            catch (Exception)
            {
                return "Erro!";
                //throw;
            }

        }

        public void SelectMedico(Medico medico)
        {
            try
            {

                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Select-Medico]";

                cmd.Parameters.AddWithValue("@CRM", medico.Crm);
                cmd.Parameters.AddWithValue("@Nome", medico.Nome);

                SqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();

                string Crm = rdr["CRM"].ToString();
                string Nome = rdr["Nome"].ToString();
                string Idade = rdr["Idade"].ToString();
                string Sexo = rdr["Sexo"].ToString();
                string Area = rdr["Area"].ToString();
                string Salario = rdr["Salario"].ToString();
                string HorarioAtendimento = rdr["HorarioAtendimento"].ToString();
                string Telefone = rdr["Telefone"].ToString();
                string Endereco = rdr["Endereco"].ToString();

                con.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void UpdateMedico(Medico medico)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Update-Medico]";
                cmd.Parameters.AddWithValue("@CRM", medico.Crm);
                cmd.Parameters.AddWithValue("@Nome", medico.Crm);
                cmd.Parameters.AddWithValue("@Idade", medico.Idade);
                cmd.Parameters.AddWithValue("@Sexo", medico.Sexo);
                cmd.Parameters.AddWithValue("@Area", medico.Area);
                cmd.Parameters.AddWithValue("@Salario", medico.Salario);
                cmd.Parameters.AddWithValue("@HorarioAtendimento", medico.HrAtendimento);
                cmd.Parameters.AddWithValue("@Telefone", medico.Telefone);
                cmd.Parameters.AddWithValue("@Endereco", medico.Endereco);

                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
