using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Form1 : Form
    {
        BLL logica = null;
        MODEL atributo = null;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showInGrid();
            showCourse();
            txtcodigo.Visible = false;
            label7.Visible = false;

        }

        #region mostrar a tabela na gridview
        private void showInGrid()
        {
            logica = new BLL();
            try
            {
                dataGridView1.DataSource = logica.recieveTable();
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        #endregion

        #region exibir cursos na combobox
        // receber o curso e exibir na combobox 
 
        private void showCourse()
        {
            logica = new BLL();
            try
            {
                cbxcurso.DataSource = logica.recieveCourse().Tables[0];
                cbxcurso.DisplayMember = "nome";
                cbxcurso.ValueMember = "id_curso";
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        #endregion

        #region inserir Dados na base de dados
        private void Cadastrar()
        {
            logica = new BLL();
            atributo = new MODEL();
            try
            {
                atributo.nome = txtnome.Text;
                atributo.curso = (int)cbxcurso.SelectedValue;
                atributo.morada = txtmorada.Text;
                atributo.email = txtemail.Text;
                atributo.telefone = txttel.Text;
                logica.takeData(atributo);
                MessageBox.Show("Dados cadastados com sucesso");
                cleanControls();
                Form1_Load(null, null);
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        #endregion

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cadastrar();   
            this.btnSave.Enabled = false;
        }

        #region duplo click para colocar os dados nos controles
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtnome.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtmorada.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txttel.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtemail.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtcodigo.Visible = true;
            label7.Visible = true;
            btnSave.Enabled = false;
            btnDelete.Enabled = true;
            btnAlter.Enabled = true;
            habilitarControles();
            tabControl1.SelectedIndex = 0;
        }
        #endregion
        //Elimar dados 
        #region eliminar dados
        private void Delete()
        {
            logica = new BLL();
            try
            {
                logica.takeDataToDelete(int.Parse(txtcodigo.Text));
                MessageBox.Show("Dados eliminados com sucesso");
                cleanControls();
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        #endregion

        private void cleanControls()
        {
            txtnome.Clear();
            txtmorada.Clear();
            txtemail.Clear();
            txttel.Clear();
        }

        private void habilitarControles()
        {
            txtnome.Enabled = true;
            txtmorada.Enabled = true;
            txtemail.Enabled = true;
            txttel.Enabled = true;
            cbxcurso.Enabled = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            cleanControls();
            btnSave.Enabled = true;
            habilitarControles();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
            txtcodigo.Visible = true;
            label7.Visible = true;
            Form1_Load(null, null);
        }

        #region alterar dados
        private void alterarDados()
        {
            logica = new BLL();
            atributo = new MODEL();
            try
            {
                atributo.codigo = int.Parse(txtcodigo.Text);
                atributo.nome = txtnome.Text;
                atributo.curso = (int)cbxcurso.SelectedValue;
                atributo.morada = txtmorada.Text;
                atributo.email = txtemail.Text;
                atributo.telefone = txttel.Text;
                logica.takeDateToAlter(atributo);
                MessageBox.Show("Dados Alterados com Sucesso!", "Alterar Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cleanControls();
                tabControl1.SelectedIndex = 1;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.ToString());
            }
         }
#endregion 

        private void btnAlter_Click(object sender, EventArgs e)
        {
            alterarDados();
            Form1_Load(null, null);
            
        }

        #region pesquisar dados
        private void researchResults()
        {
            logica = new BLL();
            try
            {
                dataGridView1.DataSource = logica.ResearchData(txtpesquisa.Text);
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        #endregion

        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {
            researchResults();
        }
    }
}
