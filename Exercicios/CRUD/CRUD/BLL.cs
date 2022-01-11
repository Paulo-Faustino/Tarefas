using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace CRUD
{
    class BLL
    {
        DAL prof = null;

        #region receber a tabela formador
        public DataTable recieveTable()
        {
            prof = new DAL();
            try
            {
                return prof.takeTable();
            }
            catch(Exception erro)
            {
                throw erro;
            }
        }
        #endregion

        #region receber os cursos
        public DataSet recieveCourse()
        {
            prof = new DAL();
            try
            {
                return prof.takeCourse();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        #endregion

        #region receber valor do form
        public void takeData(MODEL campo)
        {
            prof = new DAL();
            try
            {
                prof.cadastro(campo);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        #endregion

        #region eliminar dados
        public void takeDataToDelete(int cod)
        {
            prof = new DAL();
            try
            {
                prof.deleteData(cod);
            }
            catch(Exception erro)
            {
                throw erro;
            }
        }
        #endregion

        #region alterar dados da tabela
        public void takeDateToAlter(MODEL formador)
        {
            prof = new DAL();
            try
            {
                prof.Alterar(formador);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        #endregion
    }
}
