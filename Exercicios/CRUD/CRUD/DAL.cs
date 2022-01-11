using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace CRUD
{
    class DAL
    {
        MySqlConnection con = null;
        MySqlCommand cmd = null;
        MySqlDataAdapter da = null;
        DataTable dt = null;
        DataSet ds = null;
        MySqlDataReader dr = null;

        #region Exibir os valores do curso na GridView

        public DataTable takeTable()
        {
            con = new MySqlConnection();
            con.ConnectionString = CONEXAO.stringConexao;
            cmd = new MySqlCommand();
            cmd.Connection = con;
            da = new MySqlDataAdapter();
            dt = new DataTable();

            try
            {
                cmd.CommandText = "select * from formador";
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            catch(MySqlException erro)
            {
                throw erro;
            }
            catch(Exception erro)
            {
                throw erro;
            }
        }

        #endregion

        #region pegar os cursos existentes
        public DataSet takeCourse()
        {
            con = new MySqlConnection();
            con.ConnectionString = CONEXAO.stringConexao;
            cmd = new MySqlCommand();
            cmd.Connection = con;
            da = new MySqlDataAdapter();
            ds = new DataSet();
            try
            {
                cmd.CommandText = "select * from curso";
                da.SelectCommand = cmd;
                da.Fill(ds);
                return ds;
            }catch(MySqlException erro)
            {
                throw erro;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        #endregion

        #region Cadastramento
        public void cadastro(MODEL atributo)
        {
            con = new MySqlConnection();
            con.ConnectionString = CONEXAO.stringConexao;
            cmd = new MySqlCommand();
            cmd.Connection = con;
            try
            {
                con.Open();
                cmd.CommandText = "insert into formador values(null,@nome,@curso,@morada,@tel,@email)";
                cmd.Parameters.AddWithValue("@nome", atributo.nome);
                cmd.Parameters.AddWithValue("@curso", atributo.curso);
                cmd.Parameters.AddWithValue("@morada", atributo.morada);
                cmd.Parameters.AddWithValue("@tel", atributo.telefone);
                cmd.Parameters.AddWithValue("@email", atributo.email);
                cmd.ExecuteNonQuery();
            }
            catch(MySqlException erro)
            {
                throw erro;
            }
            catch(Exception erro)
            {
                throw erro;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region Eliminar Dados
        public void deleteData(int codigo)
        {
            con = new MySqlConnection();
            con.ConnectionString = CONEXAO.stringConexao;
            cmd = new MySqlCommand();
            cmd.Connection = con;
            try
            {
                con.Open();
                cmd.CommandText = "delete from formador where id = @codigo";
                cmd.Parameters.AddWithValue("@codigo",codigo);
            }
            catch (MySqlException erro)
            {
                throw erro;
            }
            catch(Exception erro)
            {
                throw erro;
            }
            finally
            {
                con.Close();
            }

        }
        #endregion

        #region Alterar 

        public void Alterar(MODEL mformador)
        {
            con = new MySqlConnection();
            cmd = new MySqlCommand();
            con.ConnectionString = CONEXAO.stringConexao;
            cmd.Connection = con;
            try
            {
                con.Open();
                cmd.CommandText = "UPDATE `formador` SET `nome` = @nome, `morada` = @morada, `telefone` = @tel, `email` = @email WHERE `formador`.`id` = @id";
                cmd.Parameters.AddWithValue("@id", mformador.codigo);
                cmd.Parameters.AddWithValue("@nome", mformador.nome);
                cmd.Parameters.AddWithValue("@curso", mformador.curso);
                cmd.Parameters.AddWithValue("@morada", mformador.morada);
                cmd.Parameters.AddWithValue("@email", mformador.email);
                cmd.Parameters.AddWithValue("@tel", mformador.telefone);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException erro)
            {
                throw erro;
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
            #endregion
          }

        }
}
