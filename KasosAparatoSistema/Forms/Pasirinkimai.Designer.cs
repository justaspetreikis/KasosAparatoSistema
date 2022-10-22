namespace KasosAparatoSistema.Forms
{
    partial class form_pasirinkimai
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
            this.button_prekiuIvedimas = new System.Windows.Forms.Button();
            this.button_KasosAparatas = new System.Windows.Forms.Button();
            this.button_VisuPardavimuAtaskaita = new System.Windows.Forms.Button();
            this.button_dienosPardavimųAtaskaita = new System.Windows.Forms.Button();
            this.butto_atsijungti = new System.Windows.Forms.Button();
            this.tb_vartotojas = new System.Windows.Forms.TextBox();
            this.lb_vartotojas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_prekiuIvedimas
            // 
            this.button_prekiuIvedimas.Location = new System.Drawing.Point(87, 118);
            this.button_prekiuIvedimas.Name = "button_prekiuIvedimas";
            this.button_prekiuIvedimas.Size = new System.Drawing.Size(174, 60);
            this.button_prekiuIvedimas.TabIndex = 0;
            this.button_prekiuIvedimas.Text = "Prekių įvedimas";
            this.button_prekiuIvedimas.UseVisualStyleBackColor = true;
            this.button_prekiuIvedimas.Click += new System.EventHandler(this.button_prekiuIvedimas_Click);
            // 
            // button_KasosAparatas
            // 
            this.button_KasosAparatas.Location = new System.Drawing.Point(375, 118);
            this.button_KasosAparatas.Name = "button_KasosAparatas";
            this.button_KasosAparatas.Size = new System.Drawing.Size(174, 60);
            this.button_KasosAparatas.TabIndex = 1;
            this.button_KasosAparatas.Text = "Kasos Aparatas";
            this.button_KasosAparatas.UseVisualStyleBackColor = true;
            this.button_KasosAparatas.Click += new System.EventHandler(this.button_KasosAparatas_Click);
            // 
            // button_VisuPardavimuAtaskaita
            // 
            this.button_VisuPardavimuAtaskaita.Location = new System.Drawing.Point(87, 268);
            this.button_VisuPardavimuAtaskaita.Name = "button_VisuPardavimuAtaskaita";
            this.button_VisuPardavimuAtaskaita.Size = new System.Drawing.Size(174, 60);
            this.button_VisuPardavimuAtaskaita.TabIndex = 2;
            this.button_VisuPardavimuAtaskaita.Text = "Visų Pardavimų Ataskaita";
            this.button_VisuPardavimuAtaskaita.UseVisualStyleBackColor = true;
            this.button_VisuPardavimuAtaskaita.Click += new System.EventHandler(this.button_VisuPardavimuAtaskaita_Click);
            // 
            // button_dienosPardavimųAtaskaita
            // 
            this.button_dienosPardavimųAtaskaita.Location = new System.Drawing.Point(375, 268);
            this.button_dienosPardavimųAtaskaita.Name = "button_dienosPardavimųAtaskaita";
            this.button_dienosPardavimųAtaskaita.Size = new System.Drawing.Size(174, 60);
            this.button_dienosPardavimųAtaskaita.TabIndex = 3;
            this.button_dienosPardavimųAtaskaita.Text = "Vienos Dienos Pardavimų Ataskaita";
            this.button_dienosPardavimųAtaskaita.UseVisualStyleBackColor = true;
            this.button_dienosPardavimųAtaskaita.Click += new System.EventHandler(this.button_sesijosPardavimųAtaskaita_Click);
            // 
            // butto_atsijungti
            // 
            this.butto_atsijungti.Location = new System.Drawing.Point(506, 459);
            this.butto_atsijungti.Name = "butto_atsijungti";
            this.butto_atsijungti.Size = new System.Drawing.Size(94, 29);
            this.butto_atsijungti.TabIndex = 4;
            this.butto_atsijungti.Text = "Atsijungti";
            this.butto_atsijungti.UseVisualStyleBackColor = true;
            this.butto_atsijungti.Click += new System.EventHandler(this.butto_atsijungti_Click);
            // 
            // tb_vartotojas
            // 
            this.tb_vartotojas.Location = new System.Drawing.Point(506, 12);
            this.tb_vartotojas.Name = "tb_vartotojas";
            this.tb_vartotojas.ReadOnly = true;
            this.tb_vartotojas.Size = new System.Drawing.Size(110, 27);
            this.tb_vartotojas.TabIndex = 13;
            // 
            // lb_vartotojas
            // 
            this.lb_vartotojas.Location = new System.Drawing.Point(419, 12);
            this.lb_vartotojas.Name = "lb_vartotojas";
            this.lb_vartotojas.Size = new System.Drawing.Size(81, 25);
            this.lb_vartotojas.TabIndex = 14;
            this.lb_vartotojas.Text = "Vartotojas";
            // 
            // form_pasirinkimai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 517);
            this.Controls.Add(this.lb_vartotojas);
            this.Controls.Add(this.tb_vartotojas);
            this.Controls.Add(this.butto_atsijungti);
            this.Controls.Add(this.button_dienosPardavimųAtaskaita);
            this.Controls.Add(this.button_VisuPardavimuAtaskaita);
            this.Controls.Add(this.button_KasosAparatas);
            this.Controls.Add(this.button_prekiuIvedimas);
            this.Name = "form_pasirinkimai";
            this.Text = "Pasirinkimai";
            this.Load += new System.EventHandler(this.form_pasirinkimai_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_prekiuIvedimas;
        private Button button_KasosAparatas;
        private Button button_VisuPardavimuAtaskaita;
        private Button button_dienosPardavimųAtaskaita;
        private Button butto_atsijungti;
        private TextBox tb_vartotojas;
        private Label lb_vartotojas;
    }
}