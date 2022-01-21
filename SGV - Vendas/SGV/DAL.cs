using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SGV
{
    class DAL
    {
        public static MySqlConnection conexao;

        public static MySqlConnection conexaoBanco()
        {
            conexao = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=db_gestaovenda");
            conexao.Open();
            return conexao;
        }

        #region consulta
        public static DataTable Consulta(string comandoConsulta)
        {
            try
            {
                MySqlDataAdapter da = null;
                DataTable dt = new DataTable();
                using (var cmd = conexaoBanco().CreateCommand())
                {
                    cmd.CommandText = comandoConsulta;
                    da = new MySqlDataAdapter(cmd.CommandText, conexaoBanco());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }
        #endregion

        // Inserção

        public static void novaInsercao(string sql)
        {
            try
            {
                using (var cmd = conexaoBanco().CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();                   
                    conexaoBanco().Close();
                }
            }
            catch (MySqlException ex)
            {
                //MessageBox.Show("Já existe este produto");
                MessageBox.Show(ex.ToString());
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
