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
    public class ConsultaRepository
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["db_consultorio"].ConnectionString;

        public string PersistConsulta(Consulta Consulta)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Insert-Consulta]";
                cmd.Parameters.AddWithValue("@Paciente", Consulta.IdPaciente);
                cmd.Parameters.AddWithValue("@Medico", Consulta.IdMedico);
                cmd.Parameters.AddWithValue("@Sala", Consulta.Sala);
                cmd.Parameters.AddWithValue("@TipoConsulta", Consulta.TipoConsulta);
                cmd.Parameters.AddWithValue("@DtHr", Consulta.DtHr);
                cmd.Parameters.AddWithValue("@TipoExame", Consulta.TipoExame);
                cmd.Parameters.AddWithValue("@Receita", Consulta.Receita);
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

        public void SelectConsulta(Consulta Consulta)
        {
            try
            {

                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Select-Consulta]";

                cmd.Parameters.AddWithValue("@Paciente", Consulta.IdPaciente);
                cmd.Parameters.AddWithValue("@Medico", Consulta.IdMedico);

                SqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();

                string Paciente = rdr["Paciente"].ToString();
                string Medico = rdr["Medico"].ToString();
                string Sala = rdr["Sala"].ToString();
                string TipoConsulta = rdr["TipoConsulta"].ToString();
                string DtHr = rdr["DtHr"].ToString();
                string TipoExame = rdr["TipoExame"].ToString();
                string Receita = rdr["Receita"].ToString();


                con.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void UpdateConsulta(Consulta Consulta)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Update-Consulta]";
                cmd.Parameters.AddWithValue("@Paciente", Consulta.IdPaciente);
                cmd.Parameters.AddWithValue("@Medico", Consulta.IdMedico);
                cmd.Parameters.AddWithValue("@Sala", Consulta.Sala);
                cmd.Parameters.AddWithValue("@TipoConsulta", Consulta.TipoConsulta);
                cmd.Parameters.AddWithValue("@DtHr", Consulta.DtHr);
                cmd.Parameters.AddWithValue("@TipoExame", Consulta.TipoExame);
                cmd.Parameters.AddWithValue("@Receita", Consulta.Receita);

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
