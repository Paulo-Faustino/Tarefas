namespace SGV
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lb_acessonivel = new System.Windows.Forms.Label();
            this.lb_acessonome = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btlogado = new System.Windows.Forms.Button();
            this.btnvenda = new System.Windows.Forms.Button();
            this.btnusuario = new System.Windows.Forms.Button();
            this.btncliente = new System.Windows.Forms.Button();
            this.btnproduto = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_acessonivel
            // 
            this.lb_acessonivel.AutoSize = true;
            this.lb_acessonivel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_acessonivel.ForeColor = System.Drawing.Color.White;
            this.lb_acessonivel.Location = new System.Drawing.Point(88, 75);
            this.lb_acessonivel.Name = "lb_acessonivel";
            this.lb_acessonivel.Size = new System.Drawing.Size(25, 23);
            this.lb_acessonivel.TabIndex = 4;
            this.lb_acessonivel.Text = "...";
            // 
            // lb_acessonome
            // 
            this.lb_acessonome.AutoSize = true;
            this.lb_acessonome.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_acessonome.ForeColor = System.Drawing.Color.White;
            this.lb_acessonome.Location = new System.Drawing.Point(3, 39);
            this.lb_acessonome.Name = "lb_acessonome";
            this.lb_acessonome.Size = new System.Drawing.Size(25, 23);
            this.lb_acessonome.TabIndex = 3;
            this.lb_acessonome.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nível:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seja Bem-Vindo:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.lb_acessonivel);
            this.panel1.Controls.Add(this.btlogado);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lb_acessonome);
            this.panel1.Controls.Add(this.btnvenda);
            this.panel1.Controls.Add(this.btnusuario);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btncliente);
            this.panel1.Controls.Add(this.btnproduto);
            this.panel1.Controls.Add(this.btnhome);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 700);
            this.panel1.TabIndex = 3;
            // 
            // btlogado
            // 
            this.btlogado.FlatAppearance.BorderSize = 0;
            this.btlogado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btlogado.ForeColor = System.Drawing.Color.White;
            this.btlogado.Image = global::SGV.Properties.Resources.logar;
            this.btlogado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btlogado.Location = new System.Drawing.Point(5, 634);
            this.btlogado.Name = "btlogado";
            this.btlogado.Size = new System.Drawing.Size(185, 54);
            this.btlogado.TabIndex = 6;
            this.btlogado.Text = "      Sair";
            this.btlogado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btlogado.UseVisualStyleBackColor = true;
            this.btlogado.Click += new System.EventHandler(this.btlogado_Click);
            // 
            // btnvenda
            // 
            this.btnvenda.FlatAppearance.BorderSize = 0;
            this.btnvenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvenda.ForeColor = System.Drawing.Color.White;
            this.btnvenda.Image = ((System.Drawing.Image)(resources.GetObject("btnvenda.Image")));
            this.btnvenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnvenda.Location = new System.Drawing.Point(5, 419);
            this.btnvenda.Name = "btnvenda";
            this.btnvenda.Size = new System.Drawing.Size(185, 52);
            this.btnvenda.TabIndex = 5;
            this.btnvenda.Text = "        Vendas";
            this.btnvenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnvenda.UseVisualStyleBackColor = true;
            this.btnvenda.Click += new System.EventHandler(this.btnvenda_Click);
            // 
            // btnusuario
            // 
            this.btnusuario.FlatAppearance.BorderSize = 0;
            this.btnusuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnusuario.ForeColor = System.Drawing.Color.White;
            this.btnusuario.Image = ((System.Drawing.Image)(resources.GetObject("btnusuario.Image")));
            this.btnusuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnusuario.Location = new System.Drawing.Point(5, 483);
            this.btnusuario.Name = "btnusuario";
            this.btnusuario.Size = new System.Drawing.Size(185, 54);
            this.btnusuario.TabIndex = 4;
            this.btnusuario.Text = "      Usuários";
            this.btnusuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnusuario.UseVisualStyleBackColor = true;
            this.btnusuario.Click += new System.EventHandler(this.btnusuario_Click);
            // 
            // btncliente
            // 
            this.btncliente.FlatAppearance.BorderSize = 0;
            this.btncliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncliente.ForeColor = System.Drawing.Color.White;
            this.btncliente.Image = ((System.Drawing.Image)(resources.GetObject("btncliente.Image")));
            this.btncliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncliente.Location = new System.Drawing.Point(5, 353);
            this.btncliente.Name = "btncliente";
            this.btncliente.Size = new System.Drawing.Size(185, 52);
            this.btncliente.TabIndex = 3;
            this.btncliente.Text = "      Clientes";
            this.btncliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncliente.UseVisualStyleBackColor = true;
            this.btncliente.Click += new System.EventHandler(this.btncliente_Click);
            // 
            // btnproduto
            // 
            this.btnproduto.FlatAppearance.BorderSize = 0;
            this.btnproduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproduto.ForeColor = System.Drawing.Color.White;
            this.btnproduto.Image = ((System.Drawing.Image)(resources.GetObject("btnproduto.Image")));
            this.btnproduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproduto.Location = new System.Drawing.Point(5, 280);
            this.btnproduto.Name = "btnproduto";
            this.btnproduto.Size = new System.Drawing.Size(185, 62);
            this.btnproduto.TabIndex = 2;
            this.btnproduto.Text = "     Produtos";
            this.btnproduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnproduto.UseVisualStyleBackColor = true;
            this.btnproduto.Click += new System.EventHandler(this.btnproduto_Click);
            // 
            // btnhome
            // 
            this.btnhome.FlatAppearance.BorderSize = 0;
            this.btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhome.ForeColor = System.Drawing.Color.White;
            this.btnhome.Image = ((System.Drawing.Image)(resources.GetObject("btnhome.Image")));
            this.btnhome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhome.Location = new System.Drawing.Point(5, 213);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(185, 52);
            this.btnhome.TabIndex = 1;
            this.btnhome.Text = "        Home";
            this.btnhome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnhome.UseVisualStyleBackColor = true;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(196, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1082, 700);
            this.panel4.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 700);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnvenda;
        private System.Windows.Forms.Button btnusuario;
        private System.Windows.Forms.Button btncliente;
        private System.Windows.Forms.Button btnproduto;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lb_acessonivel;
        public System.Windows.Forms.Label lb_acessonome;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Button btlogado;
    }
}

