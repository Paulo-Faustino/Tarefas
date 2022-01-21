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

namespace SGV
{
    
    public partial class Clientes : Form
    {
        int modo;
        string cmd = "select * from cliente";
        public Clientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(txtnome.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Campo obrigatório");
                return;
            }
            string sql;
            if (modo == 1)
            {
                sql = "insert into cliente values(null,'" + txtnome.Text + "','" + masktel.Text + "','" + txtmorada.Text + "')";
                DAL.novaInsercao(sql);
                dgvcliente.DataSource = DAL.Consulta(cmd);
                MessageBox.Show("Novo Registo inserido com sucesso");
            }
            else
            {
                sql = "update cliente set nome = '" + txtnome.Text + "',morada = '" + txtmorada.Text + "',telefone = '" + masktel.Text + "' where id =  '"+txtid.Text+"'";
                DAL.novaInsercao(sql);
                dgvcliente.DataSource = DAL.Consulta(cmd);
                MessageBox.Show("Registo alterado inserido com sucesso");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {           
            dgvcliente.DataSource = DAL.Consulta(cmd);
            dgvcliente.Columns[0].Width = 60;
            dgvcliente.Columns[1].Width = 160;
            dgvcliente.Columns[2].Width = 120;
            dgvcliente.Columns[3].Width = 220;
        }

        private void dgvcliente_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contlinha = dgv.SelectedRows.Count;
            if(contlinha > 0)
            {
                txtid.Text = dgv.SelectedRows[0].Cells[0].Value.ToString();
                DataTable dt = new DataTable();
                string sql = "select * from cliente where id = '"+txtid.Text+"'";
                dt = DAL.Consulta(sql);
                txtnome.Text = dt.Rows[0].Field<string>("nome").ToString();
                txtmorada.Text = dt.Rows[0].Field<string>("morada").ToString();
                masktel.Text = dt.Rows[0].Field<string>("telefone").ToString();
            }
        }

        private void tbnnew_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtmorada.Clear();
            txtnome.Clear();
            masktel.Clear();
            modo = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja Eliminar ? ", "Eliminar Cliente", MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
            {
                try
                {
                    string delete = "delete from cliente where id = '" + txtid.Text + "'";
                    DAL.novaInsercao(delete);

                    MessageBox.Show("Cliente eliminado com sucesso");
                    dgvcliente.DataSource = DAL.Consulta(cmd);
                }
                catch (Exception)
                {
                    MessageBox.Show("O cliente já fez uma compra");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtnome.Clear();
            txtmorada.Clear();
            
        }
    }
}
