namespace KasosAparatoSistema.Forms
{
    partial class Registracija
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
            this.button_registruotis = new System.Windows.Forms.Button();
            this.button_grizti = new System.Windows.Forms.Button();
            this.label_VartotojoVardas = new System.Windows.Forms.Label();
            this.label_IvestiSlaptazodo = new System.Windows.Forms.Label();
            this.label_PakartotiSlaptazodi = new System.Windows.Forms.Label();
            this.tb_naujasPrisijungimoVardas = new System.Windows.Forms.TextBox();
            this.tb_NaujasSlaptazodis = new System.Windows.Forms.TextBox();
            this.tb_PakartotiSlaptazodi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_registruotis
            // 
            this.button_registruotis.Location = new System.Drawing.Point(266, 228);
            this.button_registruotis.Name = "button_registruotis";
            this.button_registruotis.Size = new System.Drawing.Size(117, 29);
            this.button_registruotis.TabIndex = 0;
            this.button_registruotis.Text = "Registruotis";
            this.button_registruotis.UseVisualStyleBackColor = true;
            this.button_registruotis.Click += new System.EventHandler(this.button_registruotis_Click);
            // 
            // button_grizti
            // 
            this.button_grizti.Location = new System.Drawing.Point(389, 228);
            this.button_grizti.Name = "button_grizti";
            this.button_grizti.Size = new System.Drawing.Size(117, 29);
            this.button_grizti.TabIndex = 1;
            this.button_grizti.Text = "Grįžti atgal";
            this.button_grizti.UseVisualStyleBackColor = true;
            this.button_grizti.Click += new System.EventHandler(this.button_grizti_Click);
            // 
            // label_VartotojoVardas
            // 
            this.label_VartotojoVardas.Location = new System.Drawing.Point(121, 96);
            this.label_VartotojoVardas.Name = "label_VartotojoVardas";
            this.label_VartotojoVardas.Size = new System.Drawing.Size(144, 23);
            this.label_VartotojoVardas.TabIndex = 2;
            this.label_VartotojoVardas.Text = "Vartotojo Vardas";
            // 
            // label_IvestiSlaptazodo
            // 
            this.label_IvestiSlaptazodo.Location = new System.Drawing.Point(121, 136);
            this.label_IvestiSlaptazodo.Name = "label_IvestiSlaptazodo";
            this.label_IvestiSlaptazodo.Size = new System.Drawing.Size(144, 23);
            this.label_IvestiSlaptazodo.TabIndex = 3;
            this.label_IvestiSlaptazodo.Text = "Slaptažodis";
            // 
            // label_PakartotiSlaptazodi
            // 
            this.label_PakartotiSlaptazodi.Location = new System.Drawing.Point(121, 177);
            this.label_PakartotiSlaptazodi.Name = "label_PakartotiSlaptazodi";
            this.label_PakartotiSlaptazodi.Size = new System.Drawing.Size(144, 23);
            this.label_PakartotiSlaptazodi.TabIndex = 4;
            this.label_PakartotiSlaptazodi.Text = "Pakartoti Slaptažodį";
            // 
            // tb_naujasPrisijungimoVardas
            // 
            this.tb_naujasPrisijungimoVardas.Location = new System.Drawing.Point(266, 96);
            this.tb_naujasPrisijungimoVardas.Name = "tb_naujasPrisijungimoVardas";
            this.tb_naujasPrisijungimoVardas.Size = new System.Drawing.Size(240, 27);
            this.tb_naujasPrisijungimoVardas.TabIndex = 5;
            // 
            // tb_NaujasSlaptazodis
            // 
            this.tb_NaujasSlaptazodis.Location = new System.Drawing.Point(266, 136);
            this.tb_NaujasSlaptazodis.Name = "tb_NaujasSlaptazodis";
            this.tb_NaujasSlaptazodis.Size = new System.Drawing.Size(240, 27);
            this.tb_NaujasSlaptazodis.TabIndex = 6;
            // 
            // tb_PakartotiSlaptazodi
            // 
            this.tb_PakartotiSlaptazodi.Location = new System.Drawing.Point(266, 177);
            this.tb_PakartotiSlaptazodi.Name = "tb_PakartotiSlaptazodi";
            this.tb_PakartotiSlaptazodi.Size = new System.Drawing.Size(240, 27);
            this.tb_PakartotiSlaptazodi.TabIndex = 7;
            // 
            // Registracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_PakartotiSlaptazodi);
            this.Controls.Add(this.tb_NaujasSlaptazodis);
            this.Controls.Add(this.tb_naujasPrisijungimoVardas);
            this.Controls.Add(this.label_PakartotiSlaptazodi);
            this.Controls.Add(this.label_IvestiSlaptazodo);
            this.Controls.Add(this.label_VartotojoVardas);
            this.Controls.Add(this.button_grizti);
            this.Controls.Add(this.button_registruotis);
            this.Name = "Registracija";
            this.Text = "Registracija";
            this.Load += new System.EventHandler(this.Registracija_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_registruotis;
        private Button button_grizti;
        private Label label_VartotojoVardas;
        private Label label_IvestiSlaptazodo;
        private Label label_PakartotiSlaptazodi;
        private TextBox tb_naujasPrisijungimoVardas;
        private TextBox tb_NaujasSlaptazodis;
        private TextBox tb_PakartotiSlaptazodi;
    }
}