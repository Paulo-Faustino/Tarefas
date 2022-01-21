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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            login log = new login(this);
            log.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnusuario_Click(object sender, EventArgs e)
        {
            if (variaveisGlobais.perfil == "Admin")
            {
                Usuarios user = new Usuarios();
                panel4.Controls.Clear();
                user.TopLevel = false;
                panel4.Controls.Add(user);
                user.Show();
            }
            else
            {
                MessageBox.Show("Acesso Restrito");
            }
        }

        private void btlogado_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnvenda_Click(object sender, EventArgs e)
        {
            vendas venda = new vendas();
            panel4.Controls.Clear();
            venda.TopLevel = false;
            panel4.Controls.Add(venda);
            venda.Show();
        }

        private void btncliente_Click(object sender, EventArgs e)
        {
            if(variaveisGlobais.perfil == "Admin")
            {
                Clientes cli = new Clientes();
                panel4.Controls.Clear();
                cli.TopLevel = false;
                panel4.Controls.Add(cli);
                cli.Show();
            }
            else
            {
                MessageBox.Show("Acesso Restrito");
                this.Enabled = true;
            }
        }

        private void btnproduto_Click(object sender, EventArgs e)
        {
           if(variaveisGlobais.perfil == "Admin")
            {
                Produtos prod = new Produtos();
                panel4.Controls.Clear();
                prod.TopLevel = false;
                panel4.Controls.Add(prod);
                prod.Show();
            }
            else
            {
                MessageBox.Show("Acesso Restrito");
            }
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            home casa = new home();
            panel4.Controls.Clear();
            casa.TopLevel = false;
            panel4.Controls.Add(casa);
            casa.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
