namespace KasosAparatoSistema
{
    partial class PrekiuIvedimas
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_prideti = new System.Windows.Forms.Button();
            this.button_istrinti = new System.Windows.Forms.Button();
            this.txt_barkodas = new System.Windows.Forms.TextBox();
            this.txt_kaina = new System.Windows.Forms.TextBox();
            this.txt_pavadinimas = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prekesRepozitorijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prekesRepozitorijaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.prekiuListasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_vartotojas = new System.Windows.Forms.TextBox();
            this.button_grižti = new System.Windows.Forms.Button();
            this.lb_vartotojas = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prekesRepozitorijaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prekesRepozitorijaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prekiuListasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(42, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barkodas";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(340, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kategorija";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(340, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kaina";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(42, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pavadinimas";
            // 
            // button_prideti
            // 
            this.button_prideti.Location = new System.Drawing.Point(744, 116);
            this.button_prideti.Name = "button_prideti";
            this.button_prideti.Size = new System.Drawing.Size(94, 29);
            this.button_prideti.TabIndex = 4;
            this.button_prideti.Text = "Pridėti";
            this.button_prideti.UseVisualStyleBackColor = true;
            this.button_prideti.Click += new System.EventHandler(this.button_prideti_Click);
            // 
            // button_istrinti
            // 
            this.button_istrinti.Location = new System.Drawing.Point(744, 169);
            this.button_istrinti.Name = "button_istrinti";
            this.button_istrinti.Size = new System.Drawing.Size(94, 29);
            this.button_istrinti.TabIndex = 5;
            this.button_istrinti.Text = "Ištrinti";
            this.button_istrinti.UseVisualStyleBackColor = true;
            this.button_istrinti.Click += new System.EventHandler(this.button_istrinti_Click);
            // 
            // txt_barkodas
            // 
            this.txt_barkodas.Location = new System.Drawing.Point(132, 15);
            this.txt_barkodas.Name = "txt_barkodas";
            this.txt_barkodas.Size = new System.Drawing.Size(148, 27);
            this.txt_barkodas.TabIndex = 6;
            this.txt_barkodas.TextChanged += new System.EventHandler(this.txt_barkodas_TextChanged);
            // 
            // txt_kaina
            // 
            this.txt_kaina.Location = new System.Drawing.Point(419, 15);
            this.txt_kaina.Name = "txt_kaina";
            this.txt_kaina.Size = new System.Drawing.Size(151, 27);
            this.txt_kaina.TabIndex = 8;
            // 
            // txt_pavadinimas
            // 
            this.txt_pavadinimas.Location = new System.Drawing.Point(132, 59);
            this.txt_pavadinimas.Name = "txt_pavadinimas";
            this.txt_pavadinimas.Size = new System.Drawing.Size(148, 27);
            this.txt_pavadinimas.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(12, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(726, 322);
            this.dataGridView1.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Darbuotojas";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Barkodas";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Pavadinimas";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Kaina";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Kategorija";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // prekesRepozitorijaBindingSource
            // 
            this.prekesRepozitorijaBindingSource.DataSource = typeof(KasosAparatoSistema.Repozitorijos.PrekesRepozitorija);
            // 
            // prekesRepozitorijaBindingSource1
            // 
            this.prekesRepozitorijaBindingSource1.DataSource = typeof(KasosAparatoSistema.Repozitorijos.PrekesRepozitorija);
            // 
            // prekiuListasBindingSource
            // 
            this.prekiuListasBindingSource.DataMember = "PrekiuListas";
            this.prekiuListasBindingSource.DataSource = this.prekesRepozitorijaBindingSource;
            // 
            // tb_vartotojas
            // 
            this.tb_vartotojas.Location = new System.Drawing.Point(786, 12);
            this.tb_vartotojas.Name = "tb_vartotojas";
            this.tb_vartotojas.ReadOnly = true;
            this.tb_vartotojas.Size = new System.Drawing.Size(110, 27);
            this.tb_vartotojas.TabIndex = 12;
            // 
            // button_grižti
            // 
            this.button_grižti.Location = new System.Drawing.Point(744, 400);
            this.button_grižti.Name = "button_grižti";
            this.button_grižti.Size = new System.Drawing.Size(159, 34);
            this.button_grižti.TabIndex = 13;
            this.button_grižti.Text = "Grįžti į pasirinkimus";
            this.button_grižti.UseVisualStyleBackColor = true;
            this.button_grižti.Click += new System.EventHandler(this.button_grižti_Click);
            // 
            // lb_vartotojas
            // 
            this.lb_vartotojas.Location = new System.Drawing.Point(683, 12);
            this.lb_vartotojas.Name = "lb_vartotojas";
            this.lb_vartotojas.Size = new System.Drawing.Size(81, 25);
            this.lb_vartotojas.TabIndex = 15;
            this.lb_vartotojas.Text = "Vartotojas";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(419, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 16;
            // 
            // PrekiuIvedimas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 446);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lb_vartotojas);
            this.Controls.Add(this.button_grižti);
            this.Controls.Add(this.tb_vartotojas);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_pavadinimas);
            this.Controls.Add(this.txt_kaina);
            this.Controls.Add(this.txt_barkodas);
            this.Controls.Add(this.button_istrinti);
            this.Controls.Add(this.button_prideti);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PrekiuIvedimas";
            this.Text = "Prekiu Įvedimas";
            this.Load += new System.EventHandler(this.KasosAparatoValdymas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prekesRepozitorijaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prekesRepozitorijaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prekiuListasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button_prideti;
        private Button button_istrinti;
        private TextBox txt_barkodas;
        private TextBox txt_kaina;
        private TextBox txt_pavadinimas;
        private DataGridView dataGridView1;
        private BindingSource prekesRepozitorijaBindingSource;
        private BindingSource prekesRepozitorijaBindingSource1;
        private BindingSource prekiuListasBindingSource;
        private TextBox tb_vartotojas;
        private Button button_grižti;
        private Label lb_vartotojas;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private ComboBox comboBox1;
    }
}