using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaEngIII.Repository
{
    public class MedicoRepository
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["bd_consultorio"].ConnectionString;
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
                cmd.Parameters.AddWithValue("@Nome", medico.Nome);
                cmd.Parameters.AddWithValue("@Idade", medico.Idade);
                cmd.Parameters.AddWithValue("@Sexo", medico.Sexo);
                cmd.Parameters.AddWithValue("@Area", medico.Area);
                cmd.Parameters.AddWithValue("@Salario", medico.Salario);
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

        public DataGridView SelectMedico(string crm, string nome, DataGridView grid)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Select-Medico]";
                cmd.Parameters.AddWithValue("@Nome", nome);
                cmd.Parameters.AddWithValue("@CRM", crm);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    // monta o array de valores...
                    object[] values = new object[rdr.FieldCount];

                    // adiciona as colunas no grid...
                    if (grid.Rows.Count == 0)
                        for (int i = 0; i < rdr.FieldCount; i++)
                            grid.Columns.Add(rdr.GetName(i).ToString(), rdr.GetName(i).ToString());

                    // varre as colunas para preencher os valores...
                    for (int i = 0; i < rdr.FieldCount; i++)
                        values[i] = rdr.GetValue(i);

                    // adiciona no grid...
                    grid.Rows.Add(values);
                }

                con.Close();
                return grid;
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
                cmd.Parameters.AddWithValue("@Nome", medico.Nome);
                cmd.Parameters.AddWithValue("@Idade", medico.Idade);
                cmd.Parameters.AddWithValue("@Sexo", medico.Sexo);
                cmd.Parameters.AddWithValue("@Area", medico.Area);
                cmd.Parameters.AddWithValue("@Salario", medico.Salario);
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
