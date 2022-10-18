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
            this.prekiuList = new System.Windows.Forms.ListBox();
            this.clock = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_suma = new System.Windows.Forms.Label();
            this.tb_suma = new System.Windows.Forms.TextBox();
            this.button_Baigti = new System.Windows.Forms.Button();
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
            this.label_prekesInfo.Location = new System.Drawing.Point(12, 100);
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
            this.label_pavadinimas.Location = new System.Drawing.Point(12, 125);
            this.label_pavadinimas.Name = "label_pavadinimas";
            this.label_pavadinimas.Size = new System.Drawing.Size(100, 26);
            this.label_pavadinimas.TabIndex = 4;
            this.label_pavadinimas.Text = "Pavadinimas";
            // 
            // label_kaina
            // 
            this.label_kaina.Location = new System.Drawing.Point(12, 155);
            this.label_kaina.Name = "label_kaina";
            this.label_kaina.Size = new System.Drawing.Size(100, 26);
            this.label_kaina.TabIndex = 5;
            this.label_kaina.Text = "Kaina";
            // 
            // tb_pavadinimas
            // 
            this.tb_pavadinimas.Location = new System.Drawing.Point(118, 122);
            this.tb_pavadinimas.Name = "tb_pavadinimas";
            this.tb_pavadinimas.ReadOnly = true;
            this.tb_pavadinimas.Size = new System.Drawing.Size(125, 27);
            this.tb_pavadinimas.TabIndex = 6;
            // 
            // tb_kaina
            // 
            this.tb_kaina.Location = new System.Drawing.Point(118, 155);
            this.tb_kaina.Name = "tb_kaina";
            this.tb_kaina.ReadOnly = true;
            this.tb_kaina.Size = new System.Drawing.Size(125, 27);
            this.tb_kaina.TabIndex = 7;
            // 
            // label_vienetuKiekis
            // 
            this.label_vienetuKiekis.Location = new System.Drawing.Point(12, 212);
            this.label_vienetuKiekis.Name = "label_vienetuKiekis";
            this.label_vienetuKiekis.Size = new System.Drawing.Size(136, 25);
            this.label_vienetuKiekis.TabIndex = 8;
            this.label_vienetuKiekis.Text = "Vienetų kiekis";
            // 
            // tb_vienetuKiekis
            // 
            this.tb_vienetuKiekis.Location = new System.Drawing.Point(12, 240);
            this.tb_vienetuKiekis.Name = "tb_vienetuKiekis";
            this.tb_vienetuKiekis.ReadOnly = true;
            this.tb_vienetuKiekis.Size = new System.Drawing.Size(125, 27);
            this.tb_vienetuKiekis.TabIndex = 9;
            // 
            // button_prideti
            // 
            this.button_prideti.Location = new System.Drawing.Point(12, 273);
            this.button_prideti.Name = "button_prideti";
            this.button_prideti.Size = new System.Drawing.Size(94, 29);
            this.button_prideti.TabIndex = 10;
            this.button_prideti.Text = "Pridėti";
            this.button_prideti.UseVisualStyleBackColor = true;
            this.button_prideti.Click += new System.EventHandler(this.button_prideti_Click);
            // 
            // prekiuList
            // 
            this.prekiuList.FormattingEnabled = true;
            this.prekiuList.ItemHeight = 20;
            this.prekiuList.Location = new System.Drawing.Point(202, 212);
            this.prekiuList.Name = "prekiuList";
            this.prekiuList.Size = new System.Drawing.Size(266, 124);
            this.prekiuList.TabIndex = 11;
            // 
            // clock
            // 
            this.clock.Location = new System.Drawing.Point(404, 9);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(64, 25);
            this.clock.TabIndex = 12;
            this.clock.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_suma
            // 
            this.label_suma.Location = new System.Drawing.Point(350, 343);
            this.label_suma.Name = "label_suma";
            this.label_suma.Size = new System.Drawing.Size(48, 26);
            this.label_suma.TabIndex = 13;
            this.label_suma.Text = "Suma";
            // 
            // tb_suma
            // 
            this.tb_suma.Location = new System.Drawing.Point(404, 342);
            this.tb_suma.Name = "tb_suma";
            this.tb_suma.ReadOnly = true;
            this.tb_suma.Size = new System.Drawing.Size(64, 27);
            this.tb_suma.TabIndex = 14;
            this.tb_suma.TextChanged += new System.EventHandler(this.tb_suma_TextChanged);
            // 
            // button_Baigti
            // 
            this.button_Baigti.Location = new System.Drawing.Point(374, 385);
            this.button_Baigti.Name = "button_Baigti";
            this.button_Baigti.Size = new System.Drawing.Size(94, 29);
            this.button_Baigti.TabIndex = 15;
            this.button_Baigti.Text = "Baigti";
            this.button_Baigti.UseVisualStyleBackColor = true;
            // 
            // Pardavimai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 501);
            this.Controls.Add(this.button_Baigti);
            this.Controls.Add(this.tb_suma);
            this.Controls.Add(this.label_suma);
            this.Controls.Add(this.clock);
            this.Controls.Add(this.prekiuList);
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
        private ListBox prekiuList;
        private Label clock;
        private System.Windows.Forms.Timer timer1;
        private Label label_suma;
        private TextBox tb_suma;
        private Button button_Baigti;
    }
}