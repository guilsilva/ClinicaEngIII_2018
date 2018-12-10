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
        private string connectionString = ConfigurationManager.ConnectionStrings["bd_consultorio"].ConnectionString;

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
            }
        }

        public void SelectAnamnese(string nome, string cpf)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Select-Anamnese]";

                cmd.Parameters.AddWithValue("@CPF", cpf);
                cmd.Parameters.AddWithValue("@Nome", nome);
                
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string Doencas = rdr["Doencas"].ToString();
                    string Drogas = rdr["Drogas"].ToString();
                    string Cirurgias = rdr["Cirurgias"].ToString();
                    string Medicamentos = rdr["Medicamentos"].ToString();
                    string Alergias = rdr["Alergias"].ToString();
                    string Gravida = rdr["Gravidez"].ToString();
                    string TipoSanguineo = rdr["TipoSanguineo"].ToString();
                }

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
