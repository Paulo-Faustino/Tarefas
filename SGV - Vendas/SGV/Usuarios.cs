using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace SGV
{
    public partial class Usuarios : Form
    {
        string id;
        public Usuarios()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            //Populando a cbx estado
            Dictionary<Int32, string> dicEstado = new Dictionary<Int32, string>();
            dicEstado.Add(1, "Ativo");
            dicEstado.Add(0, "Inativo");
            

            cbxestado.DataSource = new BindingSource(dicEstado, null);
            cbxestado.DisplayMember = "Value";
            cbxestado.ValueMember = "Key";

            //Populando a cbx perfil
            Dictionary<string, string> dicPerfil = new Dictionary<string, string>();
            dicPerfil.Add("Padrao", "Padrao");
            dicPerfil.Add("Admin", "Administrador");

            cbxperfil.DataSource = new BindingSource(dicPerfil, null);
            cbxperfil.DisplayMember = "value";
            cbxperfil.ValueMember = "key";

            //preenchendo o grid
            string sql = "select * from usuario";
            dgvusuario.DataSource = DAL.Consulta(sql);
        }

        private void dgvusuario_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contlinha = dgv.SelectedRows.Count;
            if (contlinha > 0)
            {
                id = dgv.SelectedRows[0].Cells[0].Value.ToString();
                DataTable dt = new DataTable();
                string sql = "SELECT * from usuario where id = '" + id + "'";
                dt = DAL.Consulta(sql);
                txtnome.Text = dt.Rows[0].Field<string>("nome").ToString();
                txtusuario.Text = dt.Rows[0].Field<string>("usuario").ToString();
                txtsenha.Text = dt.Rows[0].Field<string>("senha").ToString();
                cbxestado.SelectedValue = dt.Rows[0].Field<int>("estado");
                cbxperfil.SelectedValue = dt.Rows[0].Field<string>("perfil");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            int estado = int.Parse(cbxestado.SelectedValue.ToString());
            string perfil = cbxperfil.SelectedValue.ToString();
            string sql = "INSERT INTO `usuario` VALUES (NULL, '"+txtnome.Text+"', '"+txtusuario.Text+"', '"+txtsenha.Text+"', '"+perfil+"', '"+estado+"', current_timestamp(), NULL);";
            try
            {
                DAL.novaInsercao(sql);
                MessageBox.Show("Dados inseridos com sucesso");
                string sql1 = "select * from usuario";
                dgvusuario.DataSource = DAL.Consulta(sql1);
            }
            catch (Exception)
            {
                MessageBox.Show("erro");
            }
        }

        private void btnalter_Click(object sender, EventArgs e)
        {

        }

        private void btnclean_Click(object sender, EventArgs e)
        {
            txtnome.Clear();
            txtsenha.Clear();
            txtusuario.Clear();
            cbxperfil.SelectedIndex = -1;
            cbxestado.SelectedIndex = -1;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string delete = "delete from usuario where id = "+ id;
            try
            {
                DialogResult res = MessageBox.Show("Tem certeza? ", "Eliminar Usuário", MessageBoxButtons.YesNo);
                if(res == DialogResult.Yes)
                {
                    DAL.novaInsercao(delete);
                    MessageBox.Show("Registo apagado com sucesso");
                    string sql = "select * from usuario";
                    dgvusuario.DataSource = DAL.Consulta(sql);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("não apagou");
            }
        }
    }
}
