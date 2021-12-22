using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _34___herenca
{
    public partial class Form1 :Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aluno obj_aluno = new Aluno();
            Professor obj_prof = new Professor();    

            //===== Aluno
            
            obj_aluno.nome = txtnAluno.Text;
            obj_aluno.morada = txtmAluno.Text;
            obj_aluno.idade = int.Parse(numericAluno.Value.ToString());
            if (radioButton1.Checked == true)
            {
                obj_aluno.sexo = "Masculino";
            }
            else
            {
                obj_aluno.sexo = "Femenino";
            }
            obj_aluno.numeroProcesso = int.Parse(txtnuAluno.Text);

            //==== Professor
            obj_prof.nome = txtnProfessor.Text;
            obj_prof.morada = txtmProfessor.Text;
            obj_prof.idade = int.Parse(numericProfessor.Value.ToString());
            if (radioButton4.Checked == true)
            {
                obj_prof.sexo = "Masculino";
            }
            else
            {
                obj_prof.sexo = "Femenino";
            }

            obj_prof.disciplia = txtDisciplina.Text;
           

            //==== Recebendo Valores ====

            //Professor
            lnProf.Text = obj_prof.nome;
            lmProf.Text = obj_prof.morada;
            liProf.Text = numericAluno.ToString();
            lsProf.Text = obj_prof.sexo;
            ldProf.Text = obj_prof.disciplia;
            liProf.Text = obj_prof.idade.ToString();

            //Aluno
            lnAluno.Text = obj_aluno.nome;
            lmAluno.Text = obj_aluno.morada;
            liAluno.Text = obj_aluno.idade.ToString();
            lsAluno.Text = obj_aluno.sexo;
            lnpAluno.Text = obj_aluno.numeroProcesso.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
