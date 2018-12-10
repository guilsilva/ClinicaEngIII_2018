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
    public class MateriaisRepository
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["bd_consultorio"].ConnectionString;
        
        public string PersistMateriais(Materiais materiais)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Insert-Materiais]";
                cmd.Parameters.AddWithValue("@Nome", materiais.Nome);
                cmd.Parameters.AddWithValue("@Validade", materiais.Validade);
                cmd.Parameters.AddWithValue("@Descricao", materiais.Descricao);
                cmd.Parameters.AddWithValue("@Quantidade", materiais.Quantidade);
                cmd.Parameters.AddWithValue("@TipoMaterial", materiais.Tipo_Material);
              
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

        public DataGridView SelectMateriais(string nome, DataGridView grid)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "[dbo].[Select-Materiais]";
                cmd.CommandType = CommandType.StoredProcedure;
                
                cmd.Parameters.AddWithValue("@Nome", nome);

                con.Open();

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    // monta o array de valores...
                    object[] values = new object[rdr.FieldCount];

                    // adiciona as colunas no grid...
                    if (grid.Rows.Count == 0)
                        for (int i = 0; i < rdr.FieldCount; i++)
                            grid.Columns.Add(rdr.GetName(i), rdr.GetName(i));

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
        public void UpdateMateriais(Materiais materiais) 
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Update-Materiais]";
                cmd.Parameters.AddWithValue("@Nome", materiais.Nome);
                cmd.Parameters.AddWithValue("@Validade", materiais.Validade);
                cmd.Parameters.AddWithValue("@Descricao", materiais.Descricao);
                cmd.Parameters.AddWithValue("@Quantidade", materiais.Quantidade);
                cmd.Parameters.AddWithValue("@TipoMaterial", materiais.Tipo_Material);

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
