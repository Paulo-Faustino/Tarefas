namespace SGV
{
    partial class Produtos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncategoria = new System.Windows.Forms.Button();
            this.dgvproduto = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btndelte = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.nudqtd = new System.Windows.Forms.NumericUpDown();
            this.cbxcategoria = new System.Windows.Forms.ComboBox();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduto)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudqtd)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btncategoria);
            this.panel1.Controls.Add(this.dgvproduto);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 696);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btncategoria
            // 
            this.btncategoria.Location = new System.Drawing.Point(887, 44);
            this.btncategoria.Name = "btncategoria";
            this.btncategoria.Size = new System.Drawing.Size(168, 37);
            this.btncategoria.TabIndex = 8;
            this.btncategoria.Text = "Nova Categoria";
            this.btncategoria.UseVisualStyleBackColor = true;
            this.btncategoria.Click += new System.EventHandler(this.btncategoria_Click);
            // 
            // dgvproduto
            // 
            this.dgvproduto.AllowUserToAddRows = false;
            this.dgvproduto.AllowUserToDeleteRows = false;
            this.dgvproduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproduto.Location = new System.Drawing.Point(12, 350);
            this.dgvproduto.Name = "dgvproduto";
            this.dgvproduto.ReadOnly = true;
            this.dgvproduto.RowHeadersVisible = false;
            this.dgvproduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvproduto.Size = new System.Drawing.Size(1067, 334);
            this.dgvproduto.TabIndex = 7;
            this.dgvproduto.SelectionChanged += new System.EventHandler(this.dgvproduto_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btndelte);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.txtpreco);
            this.groupBox1.Controls.Add(this.nudqtd);
            this.groupBox1.Controls.Add(this.cbxcategoria);
            this.groupBox1.Controls.Add(this.txtdescricao);
            this.groupBox1.Controls.Add(this.txtnome);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(49, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1007, 254);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Produtos";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 37);
            this.button2.TabIndex = 16;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(110, 26);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(51, 27);
            this.txtid.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "ID";
            // 
            // btndelte
            // 
            this.btndelte.Location = new System.Drawing.Point(576, 200);
            this.btndelte.Name = "btndelte";
            this.btndelte.Size = new System.Drawing.Size(169, 37);
            this.btndelte.TabIndex = 13;
            this.btndelte.Text = "Eliminar";
            this.btndelte.UseVisualStyleBackColor = true;
            this.btndelte.Click += new System.EventHandler(this.btndelte_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 37);
            this.button1.TabIndex = 12;
            this.button1.Text = "Novo Produto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(387, 200);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(169, 37);
            this.btnNew.TabIndex = 11;
            this.btnNew.Text = "Salvar Alterações";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtpreco
            // 
            this.txtpreco.Location = new System.Drawing.Point(667, 137);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(281, 27);
            this.txtpreco.TabIndex = 10;
            // 
            // nudqtd
            // 
            this.nudqtd.Location = new System.Drawing.Point(667, 99);
            this.nudqtd.Name = "nudqtd";
            this.nudqtd.Size = new System.Drawing.Size(281, 27);
            this.nudqtd.TabIndex = 9;
            // 
            // cbxcategoria
            // 
            this.cbxcategoria.FormattingEnabled = true;
            this.cbxcategoria.Location = new System.Drawing.Point(667, 57);
            this.cbxcategoria.Name = "cbxcategoria";
            this.cbxcategoria.Size = new System.Drawing.Size(281, 29);
            this.cbxcategoria.TabIndex = 8;
            // 
            // txtdescricao
            // 
            this.txtdescricao.Location = new System.Drawing.Point(110, 105);
            this.txtdescricao.Multiline = true;
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(302, 59);
            this.txtdescricao.TabIndex = 7;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(110, 65);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(302, 27);
            this.txtnome.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(553, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Preço";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(553, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "Categoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(553, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descrição";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(427, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produtos";
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1082, 696);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudqtd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncategoria;
        private System.Windows.Forms.DataGridView dgvproduto;
        private System.Windows.Forms.Button btndelte;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.NumericUpDown nudqtd;
        private System.Windows.Forms.ComboBox cbxcategoria;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtpreco;
    }
}