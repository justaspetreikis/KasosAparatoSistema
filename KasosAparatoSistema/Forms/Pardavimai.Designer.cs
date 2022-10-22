namespace KasosAparatoSistema
{
    partial class Pardavimai
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
            this.tb_iveskiteBarkoda = new System.Windows.Forms.TextBox();
            this.label_iveskitBarkoda = new System.Windows.Forms.Label();
            this.label_prekesInfo = new System.Windows.Forms.Label();
            this.button_ieskoti = new System.Windows.Forms.Button();
            this.label_pavadinimas = new System.Windows.Forms.Label();
            this.label_kaina = new System.Windows.Forms.Label();
            this.tb_pavadinimas = new System.Windows.Forms.TextBox();
            this.tb_kaina = new System.Windows.Forms.TextBox();
            this.label_vienetuKiekis = new System.Windows.Forms.Label();
            this.tb_vienetuKiekis = new System.Windows.Forms.TextBox();
            this.button_prideti = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_suma = new System.Windows.Forms.Label();
            this.tb_suma = new System.Windows.Forms.TextBox();
            this.button_pirkti = new System.Windows.Forms.Button();
            this.clock = new System.Windows.Forms.Label();
            this.dataGridViewPpardavimai = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_gristi = new System.Windows.Forms.Button();
            this.tb_vartotojas = new System.Windows.Forms.TextBox();
            this.lb_vartotojas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPpardavimai)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_iveskiteBarkoda
            // 
            this.tb_iveskiteBarkoda.Location = new System.Drawing.Point(12, 36);
            this.tb_iveskiteBarkoda.Name = "tb_iveskiteBarkoda";
            this.tb_iveskiteBarkoda.Size = new System.Drawing.Size(203, 27);
            this.tb_iveskiteBarkoda.TabIndex = 0;
            // 
            // label_iveskitBarkoda
            // 
            this.label_iveskitBarkoda.Location = new System.Drawing.Point(12, 9);
            this.label_iveskitBarkoda.Name = "label_iveskitBarkoda";
            this.label_iveskitBarkoda.Size = new System.Drawing.Size(126, 25);
            this.label_iveskitBarkoda.TabIndex = 1;
            this.label_iveskitBarkoda.Text = "Įveskite barkodą";
            // 
            // label_prekesInfo
            // 
            this.label_prekesInfo.Location = new System.Drawing.Point(13, 66);
            this.label_prekesInfo.Name = "label_prekesInfo";
            this.label_prekesInfo.Size = new System.Drawing.Size(136, 25);
            this.label_prekesInfo.TabIndex = 2;
            this.label_prekesInfo.Text = "Prekės informacija";
            // 
            // button_ieskoti
            // 
            this.button_ieskoti.Location = new System.Drawing.Point(230, 36);
            this.button_ieskoti.Name = "button_ieskoti";
            this.button_ieskoti.Size = new System.Drawing.Size(94, 29);
            this.button_ieskoti.TabIndex = 3;
            this.button_ieskoti.Text = "Ieškoti";
            this.button_ieskoti.UseVisualStyleBackColor = true;
            this.button_ieskoti.Click += new System.EventHandler(this.button_ieskoti_Click);
            // 
            // label_pavadinimas
            // 
            this.label_pavadinimas.Location = new System.Drawing.Point(13, 95);
            this.label_pavadinimas.Name = "label_pavadinimas";
            this.label_pavadinimas.Size = new System.Drawing.Size(100, 26);
            this.label_pavadinimas.TabIndex = 4;
            this.label_pavadinimas.Text = "Pavadinimas";
            // 
            // label_kaina
            // 
            this.label_kaina.Location = new System.Drawing.Point(13, 128);
            this.label_kaina.Name = "label_kaina";
            this.label_kaina.Size = new System.Drawing.Size(100, 26);
            this.label_kaina.TabIndex = 5;
            this.label_kaina.Text = "Kaina";
            // 
            // tb_pavadinimas
            // 
            this.tb_pavadinimas.Location = new System.Drawing.Point(118, 94);
            this.tb_pavadinimas.Name = "tb_pavadinimas";
            this.tb_pavadinimas.ReadOnly = true;
            this.tb_pavadinimas.Size = new System.Drawing.Size(125, 27);
            this.tb_pavadinimas.TabIndex = 6;
            // 
            // tb_kaina
            // 
            this.tb_kaina.Location = new System.Drawing.Point(119, 127);
            this.tb_kaina.Name = "tb_kaina";
            this.tb_kaina.ReadOnly = true;
            this.tb_kaina.Size = new System.Drawing.Size(125, 27);
            this.tb_kaina.TabIndex = 7;
            // 
            // label_vienetuKiekis
            // 
            this.label_vienetuKiekis.Location = new System.Drawing.Point(13, 172);
            this.label_vienetuKiekis.Name = "label_vienetuKiekis";
            this.label_vienetuKiekis.Size = new System.Drawing.Size(136, 25);
            this.label_vienetuKiekis.TabIndex = 8;
            this.label_vienetuKiekis.Text = "Vienetų kiekis";
            // 
            // tb_vienetuKiekis
            // 
            this.tb_vienetuKiekis.Location = new System.Drawing.Point(119, 172);
            this.tb_vienetuKiekis.Name = "tb_vienetuKiekis";
            this.tb_vienetuKiekis.ReadOnly = true;
            this.tb_vienetuKiekis.Size = new System.Drawing.Size(125, 27);
            this.tb_vienetuKiekis.TabIndex = 9;
            // 
            // button_prideti
            // 
            this.button_prideti.Location = new System.Drawing.Point(13, 213);
            this.button_prideti.Name = "button_prideti";
            this.button_prideti.Size = new System.Drawing.Size(94, 29);
            this.button_prideti.TabIndex = 10;
            this.button_prideti.Text = "Pridėti";
            this.button_prideti.UseVisualStyleBackColor = true;
            this.button_prideti.Click += new System.EventHandler(this.button_prideti_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_suma
            // 
            this.label_suma.Location = new System.Drawing.Point(470, 457);
            this.label_suma.Name = "label_suma";
            this.label_suma.Size = new System.Drawing.Size(48, 26);
            this.label_suma.TabIndex = 13;
            this.label_suma.Text = "Suma";
            // 
            // tb_suma
            // 
            this.tb_suma.Location = new System.Drawing.Point(536, 456);
            this.tb_suma.Name = "tb_suma";
            this.tb_suma.ReadOnly = true;
            this.tb_suma.Size = new System.Drawing.Size(64, 27);
            this.tb_suma.TabIndex = 14;
            this.tb_suma.TextChanged += new System.EventHandler(this.tb_suma_TextChanged);
            // 
            // button_pirkti
            // 
            this.button_pirkti.Location = new System.Drawing.Point(536, 489);
            this.button_pirkti.Name = "button_pirkti";
            this.button_pirkti.Size = new System.Drawing.Size(94, 29);
            this.button_pirkti.TabIndex = 15;
            this.button_pirkti.Text = "Pirkti";
            this.button_pirkti.UseVisualStyleBackColor = true;
            this.button_pirkti.Click += new System.EventHandler(this.button_Baigti_Click);
            // 
            // clock
            // 
            this.clock.Location = new System.Drawing.Point(492, 9);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(147, 25);
            this.clock.TabIndex = 12;
            this.clock.Text = "0000-00-00 00:00:00";
            // 
            // dataGridViewPpardavimai
            // 
            this.dataGridViewPpardavimai.AllowUserToAddRows = false;
            this.dataGridViewPpardavimai.AllowUserToDeleteRows = false;
            this.dataGridViewPpardavimai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPpardavimai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewPpardavimai.Location = new System.Drawing.Point(13, 262);
            this.dataGridViewPpardavimai.Name = "dataGridViewPpardavimai";
            this.dataGridViewPpardavimai.ReadOnly = true;
            this.dataGridViewPpardavimai.RowHeadersWidth = 51;
            this.dataGridViewPpardavimai.RowTemplate.Height = 29;
            this.dataGridViewPpardavimai.Size = new System.Drawing.Size(626, 188);
            this.dataGridViewPpardavimai.TabIndex = 16;
            this.dataGridViewPpardavimai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Laikas";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 160;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Prekė";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Kaina";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Kiekis";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 80;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Suma";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // button_gristi
            // 
            this.button_gristi.Location = new System.Drawing.Point(19, 489);
            this.button_gristi.Name = "button_gristi";
            this.button_gristi.Size = new System.Drawing.Size(171, 29);
            this.button_gristi.TabIndex = 17;
            this.button_gristi.Text = "Grižti į pasirinkimus";
            this.button_gristi.UseVisualStyleBackColor = true;
            this.button_gristi.Click += new System.EventHandler(this.button_gristi_Click);
            // 
            // tb_vartotojas
            // 
            this.tb_vartotojas.Location = new System.Drawing.Point(529, 36);
            this.tb_vartotojas.Name = "tb_vartotojas";
            this.tb_vartotojas.ReadOnly = true;
            this.tb_vartotojas.Size = new System.Drawing.Size(110, 27);
            this.tb_vartotojas.TabIndex = 18;
            // 
            // lb_vartotojas
            // 
            this.lb_vartotojas.Location = new System.Drawing.Point(442, 34);
            this.lb_vartotojas.Name = "lb_vartotojas";
            this.lb_vartotojas.Size = new System.Drawing.Size(81, 25);
            this.lb_vartotojas.TabIndex = 19;
            this.lb_vartotojas.Text = "Vartotojas";
            // 
            // Pardavimai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 530);
            this.Controls.Add(this.lb_vartotojas);
            this.Controls.Add(this.tb_vartotojas);
            this.Controls.Add(this.button_gristi);
            this.Controls.Add(this.dataGridViewPpardavimai);
            this.Controls.Add(this.button_pirkti);
            this.Controls.Add(this.tb_suma);
            this.Controls.Add(this.label_suma);
            this.Controls.Add(this.clock);
            this.Controls.Add(this.button_prideti);
            this.Controls.Add(this.tb_vienetuKiekis);
            this.Controls.Add(this.label_vienetuKiekis);
            this.Controls.Add(this.tb_kaina);
            this.Controls.Add(this.tb_pavadinimas);
            this.Controls.Add(this.label_kaina);
            this.Controls.Add(this.label_pavadinimas);
            this.Controls.Add(this.button_ieskoti);
            this.Controls.Add(this.label_prekesInfo);
            this.Controls.Add(this.label_iveskitBarkoda);
            this.Controls.Add(this.tb_iveskiteBarkoda);
            this.Name = "Pardavimai";
            this.Text = "Pardavimai";
            this.Load += new System.EventHandler(this.Pardavimai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPpardavimai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb_iveskiteBarkoda;
        private Label label_iveskitBarkoda;
        private Label label_prekesInfo;
        private Button button_ieskoti;
        private Label label_pavadinimas;
        private Label label_kaina;
        private TextBox tb_pavadinimas;
        private TextBox tb_kaina;
        private Label label_vienetuKiekis;
        private TextBox tb_vienetuKiekis;
        private Button button_prideti;
        private System.Windows.Forms.Timer timer1;
        private Label label_suma;
        private TextBox tb_suma;
        private Button button_pirkti;
        private Label clock;
        private DataGridView dataGridViewPpardavimai;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button button_gristi;
        private TextBox tb_vartotojas;
        private Label lb_vartotojas;
    }
}