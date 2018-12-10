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
    public class ExameRepository
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["db_consultorio"].ConnectionString;

        public string PersistExame(Exame Exame)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Insert-Exame]";
                cmd.Parameters.AddWithValue("@TipoExame", Exame.TipoExame);
                cmd.Parameters.AddWithValue("@HrDt", Exame.HrDt);
                cmd.Parameters.AddWithValue("@MedicoId", Exame.IdMedico);
                cmd.Parameters.AddWithValue("@PacienteId", Exame.IdPaciente);
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

        public void SelectExame(Exame Exame)
        {
            try
            {

                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Select-Exame]";

                cmd.Parameters.AddWithValue("@Exame", Exame.Exame);

                SqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();

                string TipoExame = rdr["TipoExame"].ToString();
                string NomeExame = rdr["Exame"].ToString();
                string HrDt = rdr["HrDt"].ToString();
                string MedicoId = rdr["fk_MedicoId"].ToString();
                string PacienteId = rdr["fk_PacienteId"].ToString();
               

                con.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void UpdateExame(Exame Exame)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Update-Exame]";
                cmd.Parameters.AddWithValue("@TipoExame", Exame.TipoExame);
                cmd.Parameters.AddWithValue("@Exame", Exame.Exame);
                cmd.Parameters.AddWithValue("@HrDt", Exame.HrDt);
                cmd.Parameters.AddWithValue("@MedicoId", Exame.IdMedico);
                cmd.Parameters.AddWithValue("@PacienteId", Exame.IdPaciente);

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
