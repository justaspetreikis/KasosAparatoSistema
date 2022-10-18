namespace KasosAparatoSistema
{
    partial class KasosAparatoValdymas
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
            this.txt_kategorija = new System.Windows.Forms.TextBox();
            this.txt_kaina = new System.Windows.Forms.TextBox();
            this.txt_pavadinimas = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_ikeltiSarasa = new System.Windows.Forms.Button();
            this.prekesRepozitorijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prekesRepozitorijaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.prekiuListasBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pavadinimas";
            // 
            // button_prideti
            // 
            this.button_prideti.Location = new System.Drawing.Point(677, 116);
            this.button_prideti.Name = "button_prideti";
            this.button_prideti.Size = new System.Drawing.Size(94, 29);
            this.button_prideti.TabIndex = 4;
            this.button_prideti.Text = "Pridėti";
            this.button_prideti.UseVisualStyleBackColor = true;
            this.button_prideti.Click += new System.EventHandler(this.button_prideti_Click);
            // 
            // button_istrinti
            // 
            this.button_istrinti.Location = new System.Drawing.Point(677, 170);
            this.button_istrinti.Name = "button_istrinti";
            this.button_istrinti.Size = new System.Drawing.Size(94, 29);
            this.button_istrinti.TabIndex = 5;
            this.button_istrinti.Text = "Ištrinti";
            this.button_istrinti.UseVisualStyleBackColor = true;
            this.button_istrinti.Click += new System.EventHandler(this.button_istrinti_Click);
            // 
            // txt_barkodas
            // 
            this.txt_barkodas.Location = new System.Drawing.Point(116, 20);
            this.txt_barkodas.Name = "txt_barkodas";
            this.txt_barkodas.Size = new System.Drawing.Size(125, 27);
            this.txt_barkodas.TabIndex = 6;
            // 
            // txt_kategorija
            // 
            this.txt_kategorija.Location = new System.Drawing.Point(419, 62);
            this.txt_kategorija.Name = "txt_kategorija";
            this.txt_kategorija.Size = new System.Drawing.Size(125, 27);
            this.txt_kategorija.TabIndex = 7;
            // 
            // txt_kaina
            // 
            this.txt_kaina.Location = new System.Drawing.Point(419, 23);
            this.txt_kaina.Name = "txt_kaina";
            this.txt_kaina.Size = new System.Drawing.Size(125, 27);
            this.txt_kaina.TabIndex = 8;
            // 
            // txt_pavadinimas
            // 
            this.txt_pavadinimas.Location = new System.Drawing.Point(116, 62);
            this.txt_pavadinimas.Name = "txt_pavadinimas";
            this.txt_pavadinimas.Size = new System.Drawing.Size(125, 27);
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
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(12, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(659, 322);
            this.dataGridView1.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Barkdodas";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Pavadinimas";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Kaina";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Kategorija";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // button_ikeltiSarasa
            // 
            this.button_ikeltiSarasa.Location = new System.Drawing.Point(677, 224);
            this.button_ikeltiSarasa.Name = "button_ikeltiSarasa";
            this.button_ikeltiSarasa.Size = new System.Drawing.Size(94, 56);
            this.button_ikeltiSarasa.TabIndex = 11;
            this.button_ikeltiSarasa.Text = "Įkelti Sarašą";
            this.button_ikeltiSarasa.UseVisualStyleBackColor = true;
            this.button_ikeltiSarasa.Click += new System.EventHandler(this.button_ikeltiSarasa_Click);
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
            // KasosAparatoValdymas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_ikeltiSarasa);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_pavadinimas);
            this.Controls.Add(this.txt_kaina);
            this.Controls.Add(this.txt_kategorija);
            this.Controls.Add(this.txt_barkodas);
            this.Controls.Add(this.button_istrinti);
            this.Controls.Add(this.button_prideti);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KasosAparatoValdymas";
            this.Text = "Form2";
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
        private TextBox txt_kategorija;
        private TextBox txt_kaina;
        private TextBox txt_pavadinimas;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button button_ikeltiSarasa;
        private BindingSource prekesRepozitorijaBindingSource;
        private BindingSource prekesRepozitorijaBindingSource1;
        private BindingSource prekiuListasBindingSource;
    }
}