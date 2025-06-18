namespace ListaTarefas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvTafefas = new System.Windows.Forms.DataGridView();
            this.grbAdicionar = new System.Windows.Forms.GroupBox();
            this.dtpDataLimite = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.lblPrioridades = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txbPrioridade = new System.Windows.Forms.TextBox();
            this.txbNomeTarefas = new System.Windows.Forms.TextBox();
            this.lblNomeTarefa = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTafefas)).BeginInit();
            this.grbAdicionar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTafefas
            // 
            this.dgvTafefas.AllowUserToAddRows = false;
            this.dgvTafefas.AllowUserToDeleteRows = false;
            this.dgvTafefas.AllowUserToResizeColumns = false;
            this.dgvTafefas.AllowUserToResizeRows = false;
            this.dgvTafefas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTafefas.BackgroundColor = System.Drawing.Color.White;
            this.dgvTafefas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTafefas.Location = new System.Drawing.Point(53, 249);
            this.dgvTafefas.Name = "dgvTafefas";
            this.dgvTafefas.ReadOnly = true;
            this.dgvTafefas.Size = new System.Drawing.Size(709, 197);
            this.dgvTafefas.TabIndex = 8;
            this.dgvTafefas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTafefas_CellContentClick);
            // 
            // grbAdicionar
            // 
            this.grbAdicionar.Controls.Add(this.dtpDataLimite);
            this.grbAdicionar.Controls.Add(this.lblData);
            this.grbAdicionar.Controls.Add(this.lblPrioridades);
            this.grbAdicionar.Controls.Add(this.btnAdicionar);
            this.grbAdicionar.Controls.Add(this.txbPrioridade);
            this.grbAdicionar.Controls.Add(this.txbNomeTarefas);
            this.grbAdicionar.Controls.Add(this.lblNomeTarefa);
            this.grbAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbAdicionar.Location = new System.Drawing.Point(53, 74);
            this.grbAdicionar.Name = "grbAdicionar";
            this.grbAdicionar.Size = new System.Drawing.Size(709, 169);
            this.grbAdicionar.TabIndex = 7;
            this.grbAdicionar.TabStop = false;
            this.grbAdicionar.Text = "Adicionar";
            // 
            // dtpDataLimite
            // 
            this.dtpDataLimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataLimite.Location = new System.Drawing.Point(125, 59);
            this.dtpDataLimite.Name = "dtpDataLimite";
            this.dtpDataLimite.Size = new System.Drawing.Size(179, 26);
            this.dtpDataLimite.TabIndex = 10;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Futura Bk BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(17, 66);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(102, 18);
            this.lblData.TabIndex = 8;
            this.lblData.Text = "Data Limite:";
            // 
            // lblPrioridades
            // 
            this.lblPrioridades.AutoSize = true;
            this.lblPrioridades.Font = new System.Drawing.Font("Futura Bk BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrioridades.Location = new System.Drawing.Point(341, 23);
            this.lblPrioridades.Name = "lblPrioridades";
            this.lblPrioridades.Size = new System.Drawing.Size(94, 18);
            this.lblPrioridades.TabIndex = 7;
            this.lblPrioridades.Text = "Prioridade:";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.Black;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Futura Bk BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Location = new System.Drawing.Point(17, 106);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(674, 30);
            this.btnAdicionar.TabIndex = 6;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txbPrioridade
            // 
            this.txbPrioridade.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrioridade.Location = new System.Drawing.Point(435, 19);
            this.txbPrioridade.Name = "txbPrioridade";
            this.txbPrioridade.Size = new System.Drawing.Size(150, 27);
            this.txbPrioridade.TabIndex = 3;
            // 
            // txbNomeTarefas
            // 
            this.txbNomeTarefas.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomeTarefas.Location = new System.Drawing.Point(154, 19);
            this.txbNomeTarefas.Name = "txbNomeTarefas";
            this.txbNomeTarefas.Size = new System.Drawing.Size(150, 27);
            this.txbNomeTarefas.TabIndex = 1;
            this.txbNomeTarefas.TextChanged += new System.EventHandler(this.txbNomeTarefas_TextChanged);
            // 
            // lblNomeTarefa
            // 
            this.lblNomeTarefa.AutoSize = true;
            this.lblNomeTarefa.Font = new System.Drawing.Font("Futura Bk BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeTarefa.Location = new System.Drawing.Point(15, 23);
            this.lblNomeTarefa.Name = "lblNomeTarefa";
            this.lblNomeTarefa.Size = new System.Drawing.Size(144, 18);
            this.lblNomeTarefa.TabIndex = 0;
            this.lblNomeTarefa.Text = "Nome da Tarefa: ";
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Futura Bk BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(319, 25);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(193, 29);
            this.lblLogo.TabIndex = 9;
            this.lblLogo.Text = "Lista de Tarefas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(247, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 483);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.dgvTafefas);
            this.Controls.Add(this.grbAdicionar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Lista de Tarefas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTafefas)).EndInit();
            this.grbAdicionar.ResumeLayout(false);
            this.grbAdicionar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvTafefas;
        private System.Windows.Forms.GroupBox grbAdicionar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox txbPrioridade;
        private System.Windows.Forms.TextBox txbNomeTarefas;
        private System.Windows.Forms.Label lblNomeTarefa;
        private System.Windows.Forms.Label lblPrioridades;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtpDataLimite;
    }
}

