﻿namespace KasosAparatoSistema
{
    partial class Prisijungimas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonPrisijungti = new System.Windows.Forms.Button();
            this.tbVartotojoVardas = new System.Windows.Forms.TextBox();
            this.tbSlaptazodis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_registracija = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPrisijungti
            // 
            this.buttonPrisijungti.Location = new System.Drawing.Point(250, 247);
            this.buttonPrisijungti.Name = "buttonPrisijungti";
            this.buttonPrisijungti.Size = new System.Drawing.Size(94, 29);
            this.buttonPrisijungti.TabIndex = 0;
            this.buttonPrisijungti.Text = "Prisijungti";
            this.buttonPrisijungti.UseVisualStyleBackColor = true;
            this.buttonPrisijungti.Click += new System.EventHandler(this.buttonPrisijungti_Click);
            // 
            // tbVartotojoVardas
            // 
            this.tbVartotojoVardas.Location = new System.Drawing.Point(250, 142);
            this.tbVartotojoVardas.Name = "tbVartotojoVardas";
            this.tbVartotojoVardas.Size = new System.Drawing.Size(203, 27);
            this.tbVartotojoVardas.TabIndex = 1;
            // 
            // tbSlaptazodis
            // 
            this.tbSlaptazodis.Location = new System.Drawing.Point(250, 190);
            this.tbSlaptazodis.Name = "tbSlaptazodis";
            this.tbSlaptazodis.PasswordChar = '*';
            this.tbSlaptazodis.Size = new System.Drawing.Size(203, 27);
            this.tbSlaptazodis.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(84, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vartotojo vardas";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(84, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Slaptažodis";
            // 
            // button_registracija
            // 
            this.button_registracija.Location = new System.Drawing.Point(359, 247);
            this.button_registracija.Name = "button_registracija";
            this.button_registracija.Size = new System.Drawing.Size(94, 29);
            this.button_registracija.TabIndex = 5;
            this.button_registracija.Text = "Registracija";
            this.button_registracija.UseVisualStyleBackColor = true;
            this.button_registracija.Click += new System.EventHandler(this.button_registracija_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(61, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(414, 56);
            this.label3.TabIndex = 6;
            this.label3.Text = "KASOS APARATO SISTEMA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Prisijungimas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 462);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_registracija);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSlaptazodis);
            this.Controls.Add(this.tbVartotojoVardas);
            this.Controls.Add(this.buttonPrisijungti);
            this.Name = "Prisijungimas";
            this.Text = "Prisijungimas";
            this.Load += new System.EventHandler(this.Prisijungimas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonPrisijungti;
        private TextBox tbVartotojoVardas;
        private TextBox tbSlaptazodis;
        private Label label1;
        private Label label2;
        private Button button_registracija;
        private Label label3;
    }
}