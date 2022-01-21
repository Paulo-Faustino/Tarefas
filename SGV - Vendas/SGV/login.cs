using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGV
{
    public partial class login : Form
    {
        Form1 form1;
        DataTable dt = new DataTable();
        public login(Form1 pegaLog)
        {
            InitializeComponent();
            form1 = pegaLog;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public bool estaValidado()
        {
            if (txtuser.Text.Trim() == String.Empty || txtsenha.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Campos obrigatórios", "Preencher os campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            
            string user = txtuser.Text;
            string pass = txtsenha.Text;        
            if (estaValidado())
            {
                string comando = "select * from usuario where usuario = '" + user + "' and senha = '" + pass + "' and estado = 1";
                dt = DAL.Consulta(comando);
                if (dt.Rows.Count == 1)
                {
                    form1.lb_acessonome.Text = dt.Rows[0].ItemArray[2].ToString();
                    form1.lb_acessonivel.Text = dt.Rows[0].Field<string>("perfil");
                    form1.btlogado.Image = Properties.Resources.sair;
                    variaveisGlobais.perfil = dt.Rows[0].Field<string>("perfil").ToString();
                    variaveisGlobais.user = int.Parse(dt.Rows[0].Field<Int32>("id").ToString());
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuário inválido");

                }
            }
        }
    }
}
