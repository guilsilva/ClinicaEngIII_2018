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
    public class AnamneseRepository
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["db_consultorio"].ConnectionString;

        public string PersistAnamnese(Anamnese anamnese)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Insert-Anamnese]";
                cmd.Parameters.AddWithValue("@pk_AnamneseId", anamnese.pk_AnamneseId);
                cmd.Parameters.AddWithValue("@Doencas", anamnese.Doencas);
                cmd.Parameters.AddWithValue("@Drogas", anamnese.Drogas);
                cmd.Parameters.AddWithValue("@Cirurgias", anamnese.Cirurgias);
                cmd.Parameters.AddWithValue("@Medicamentos", anamnese.Medicamentos);
                cmd.Parameters.AddWithValue("@Alergias", anamnese.Alergias);
                cmd.Parameters.AddWithValue("@TipoSanguineo", anamnese.TipoSanguineo);
                cmd.Parameters.AddWithValue("@fk_PacienteId", anamnese.fk_PacienteId);

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

        public void SelectAnamnese(Anamnese anamnese)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Select-Anamnese]";

                cmd.Parameters.AddWithValue("@CPF", anamnese.Cpf);
                cmd.Parameters.AddWithValue("@Nome", anamnese.Nome);

                SqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();

                string pk_AnamneseId = rdr["pk_AnamneseId"].ToString();
                string Doencas = rdr["Doencas"].ToString();
                string Drogas = rdr["Drogas"].ToString();
                string Cirurgias = rdr["Cirurgias"].ToString();
                string Medicamentos = rdr["Medicamentos"].ToString();
                string Alergias = rdr["Alergias"].ToString();
                string TipoSanguineo = rdr["TipoSanguineo"].ToString();
                string fk_PacienteId = rdr["fk_PacienteId"].ToString();

                con.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void UpdateAnamnese(Anamnese anamnese)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Update-Anamnese]";
                cmd.Parameters.AddWithValue("@pk_AnamneseId", anamnese.pk_AnamneseId);
                cmd.Parameters.AddWithValue("@Doencas", anamnese.Doencas);
                cmd.Parameters.AddWithValue("@Drogas", anamnese.Drogas);
                cmd.Parameters.AddWithValue("@Cirurgias", anamnese.Cirurgias);
                cmd.Parameters.AddWithValue("@Medicamentos", anamnese.Medicamentos);
                cmd.Parameters.AddWithValue("@Alergias", anamnese.Alergias);
                cmd.Parameters.AddWithValue("@TipoSanguineo", anamnese.TipoSanguineo);
                cmd.Parameters.AddWithValue("@fk_PacienteId", anamnese.fk_PacienteId);

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
