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
    public partial class Produtos : Form
    {
       
        public Produtos()
        {
            InitializeComponent();
        }

        private void btncategoria_Click(object sender, EventArgs e)
        {
            Categoria cat = new Categoria();
            cat.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            string sql = "select * from categoria";
            cbxcategoria.DataSource = DAL.Consulta(sql);
            cbxcategoria.DisplayMember = "nome";
            cbxcategoria.ValueMember = "Id";

            //Gridview

            string sqlgrid = "SELECT `id`,`nome`,`descricao`,`preco`,`quantidade`,`categoria_id`,`usuario_id` FROM `produto`";
            dgvproduto.DataSource = DAL.Consulta(sqlgrid);

            //formatando o grid
            dgvproduto.Columns[0].Width = 40;
            dgvproduto.Columns[1].Width = 125;
            dgvproduto.Columns[2].Width = 170;
            dgvproduto.Columns[3].Width = 90;
            dgvproduto.Columns[4].Width = 70;
            dgvproduto.Columns[5].Width = 160;
            dgvproduto.Columns[6].Width = 160;

        }

        public bool validarcontrol()
        {
            if(txtnome.Text == string.Empty.Trim() || txtpreco.Text == string.Empty.Trim())
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 id_usuario = variaveisGlobais.user;
                decimal preco = decimal.Parse((txtpreco.Text).ToString());
                int qtd = int.Parse(Math.Round(nudqtd.Value, 0).ToString());
                if (validarcontrol())
                {
                    string sql = "INSERT INTO produto VALUES (NULL, '" + txtnome.Text + "', '" + txtdescricao.Text + "', " + preco + ", " + qtd + ", current_timestamp(), NULL, '" + cbxcategoria.SelectedValue + "', "+id_usuario+")";
                    DAL.novaInsercao(sql);
                    MessageBox.Show("Produto inserido com sucesso");
                    string sqlgrid = "SELECT `id`,`nome`,`descricao`,`preco`,`quantidade`,`categoria_id`,`usuario_id` FROM `produto`";
                    dgvproduto.DataSource = DAL.Consulta(sqlgrid);
                }
                else
                {
                    MessageBox.Show("Campos obrigátorios");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Preencha correctamente os campos");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            decimal preco = decimal.Parse(txtpreco.Text);
            int qtd = int.Parse(Math.Round(nudqtd.Value, 0).ToString());
            string sql = "update produto set nome = '" + txtnome.Text + "', descricao = '"+txtdescricao.Text+"', preco = '"+preco+"', quantidade = '"+qtd+"', categoria_id = '"+cbxcategoria.SelectedValue+"' where id = '" + txtid.Text + "' ";
            try
            {
                DAL.novaInsercao(sql);
                MessageBox.Show("Dados actualizados com sucesso");

                string sqlgrid = "SELECT `id`,`nome`,`descricao`,`preco`,`quantidade`,`categoria_id`,`usuario_id` FROM `produto`";
                dgvproduto.DataSource = DAL.Consulta(sqlgrid);
            }
            catch (Exception Ex)
            {
                //MessageBox.Show(Ex.ToString());
                MessageBox.Show("erro");
            }
        }

        private void dgvproduto_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contlinha = dgv.SelectedRows.Count;
            if (contlinha > 0)
            {
                txtid.Text = dgv.SelectedRows[0].Cells[0].Value.ToString();
                DataTable dt = new DataTable();
                string sql = "SELECT `id`,`nome`,`descricao`,`preco`,`quantidade`,`categoria_id`,`usuario_id` FROM `produto` where id = '"+txtid.Text+"'";
                dt = DAL.Consulta(sql);
                txtnome.Text = dt.Rows[0].Field<string>("nome").ToString();
                txtdescricao.Text = dt.Rows[0].Field<string>("descricao").ToString();
                txtpreco.Text = dt.Rows[0].Field<decimal>("preco").ToString();
                nudqtd.Value = dt.Rows[0].Field<Int32>("quantidade");
                cbxcategoria.SelectedValue = dt.Rows[0].Field<Int32>("categoria_id").ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtdescricao.Clear();
            txtid.Clear();
            txtpreco.Clear();
            cbxcategoria.SelectedValue = -1;
            nudqtd.Value = 0;
            txtnome.Clear();
        }

        private void btndelte_Click(object sender, EventArgs e)
        {
            string sql = "delete from produto where id = '" + txtid.Text + "'";
            DialogResult res = MessageBox.Show("Deseja eliminar esse produto ?", "Eliminar Registo", MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
            {
                DAL.novaInsercao(sql);
                MessageBox.Show("Registo eliminado com sucesso");
                string sqlgrid = "SELECT `id`,`nome`,`descricao`,`preco`,`quantidade`,`categoria_id`,`usuario_id` FROM `produto`";
                dgvproduto.DataSource = DAL.Consulta(sqlgrid);
            }
        }
    }
}
