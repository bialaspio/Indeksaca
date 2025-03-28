
namespace Indeksaca_v01
{
    partial class form_DodajOperat
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
            this.lb_DodOperNumer = new System.Windows.Forms.Label();
            this.tb_DodOperNumerOperatu = new System.Windows.Forms.TextBox();
            this.tb_DodOperOMZ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_DodOperDodajOperat = new System.Windows.Forms.Button();
            this.cbJednostka = new System.Windows.Forms.ComboBox();
            this.cbObreb = new System.Windows.Forms.ComboBox();
            this.tb_DodOperPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_DodOperOtworzSciezke = new System.Windows.Forms.Button();
            this.cd_DodOperRodzajDokumentu = new System.Windows.Forms.ComboBox();
            this.lb_DodOperRodzajDokumentu = new System.Windows.Forms.Label();
            this.gbKataster = new System.Windows.Forms.GroupBox();
            this.tb_DodOperNrWRoku = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_DodOperTypDokKat = new System.Windows.Forms.ComboBox();
            this.lbRok = new System.Windows.Forms.Label();
            this.tb_DodOperRok = new System.Windows.Forms.TextBox();
            this.gbKataster.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_DodOperNumer
            // 
            this.lb_DodOperNumer.AutoSize = true;
            this.lb_DodOperNumer.Location = new System.Drawing.Point(78, 42);
            this.lb_DodOperNumer.Name = "lb_DodOperNumer";
            this.lb_DodOperNumer.Size = new System.Drawing.Size(77, 13);
            this.lb_DodOperNumer.TabIndex = 0;
            this.lb_DodOperNumer.Text = "Numer operatu";
            // 
            // tb_DodOperNumerOperatu
            // 
            this.tb_DodOperNumerOperatu.Location = new System.Drawing.Point(161, 40);
            this.tb_DodOperNumerOperatu.Name = "tb_DodOperNumerOperatu";
            this.tb_DodOperNumerOperatu.Size = new System.Drawing.Size(258, 20);
            this.tb_DodOperNumerOperatu.TabIndex = 1;
            // 
            // tb_DodOperOMZ
            // 
            this.tb_DodOperOMZ.Location = new System.Drawing.Point(161, 67);
            this.tb_DodOperOMZ.Name = "tb_DodOperOMZ";
            this.tb_DodOperOMZ.Size = new System.Drawing.Size(258, 20);
            this.tb_DodOperOMZ.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Oznaczenie materialu zasobu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Jednostka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Obręb";
            // 
            // bt_DodOperDodajOperat
            // 
            this.bt_DodOperDodajOperat.Location = new System.Drawing.Point(347, 263);
            this.bt_DodOperDodajOperat.Name = "bt_DodOperDodajOperat";
            this.bt_DodOperDodajOperat.Size = new System.Drawing.Size(75, 23);
            this.bt_DodOperDodajOperat.TabIndex = 8;
            this.bt_DodOperDodajOperat.Text = "Dodaj";
            this.bt_DodOperDodajOperat.UseVisualStyleBackColor = true;
            this.bt_DodOperDodajOperat.Click += new System.EventHandler(this.bt_DodOperDodajOperat_Click);
            // 
            // cbJednostka
            // 
            this.cbJednostka.FormattingEnabled = true;
            this.cbJednostka.Location = new System.Drawing.Point(162, 94);
            this.cbJednostka.Name = "cbJednostka";
            this.cbJednostka.Size = new System.Drawing.Size(258, 21);
            this.cbJednostka.TabIndex = 9;
            this.cbJednostka.SelectedIndexChanged += new System.EventHandler(this.cbJednostka_SelectedIndexChanged);
            // 
            // cbObreb
            // 
            this.cbObreb.FormattingEnabled = true;
            this.cbObreb.Location = new System.Drawing.Point(162, 122);
            this.cbObreb.Name = "cbObreb";
            this.cbObreb.Size = new System.Drawing.Size(258, 21);
            this.cbObreb.TabIndex = 10;
            // 
            // tb_DodOperPath
            // 
            this.tb_DodOperPath.Location = new System.Drawing.Point(161, 150);
            this.tb_DodOperPath.Name = "tb_DodOperPath";
            this.tb_DodOperPath.Size = new System.Drawing.Size(180, 20);
            this.tb_DodOperPath.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ścieżka do operatu";
            // 
            // bt_DodOperOtworzSciezke
            // 
            this.bt_DodOperOtworzSciezke.Location = new System.Drawing.Point(345, 148);
            this.bt_DodOperOtworzSciezke.Name = "bt_DodOperOtworzSciezke";
            this.bt_DodOperOtworzSciezke.Size = new System.Drawing.Size(75, 23);
            this.bt_DodOperOtworzSciezke.TabIndex = 13;
            this.bt_DodOperOtworzSciezke.Text = "Otwórz";
            this.bt_DodOperOtworzSciezke.UseVisualStyleBackColor = true;
            this.bt_DodOperOtworzSciezke.Click += new System.EventHandler(this.bt_DodOperOtworzSciezke_Click);
            // 
            // cd_DodOperRodzajDokumentu
            // 
            this.cd_DodOperRodzajDokumentu.FormattingEnabled = true;
            this.cd_DodOperRodzajDokumentu.Items.AddRange(new object[] {
            "Operat",
            "Dokument katastralny",
            "Mapa"});
            this.cd_DodOperRodzajDokumentu.Location = new System.Drawing.Point(162, 12);
            this.cd_DodOperRodzajDokumentu.Name = "cd_DodOperRodzajDokumentu";
            this.cd_DodOperRodzajDokumentu.Size = new System.Drawing.Size(258, 21);
            this.cd_DodOperRodzajDokumentu.TabIndex = 15;
            this.cd_DodOperRodzajDokumentu.SelectedIndexChanged += new System.EventHandler(this.cd_DodOperRodzajDokumentu_SelectedIndexChanged);
            // 
            // lb_DodOperRodzajDokumentu
            // 
            this.lb_DodOperRodzajDokumentu.AutoSize = true;
            this.lb_DodOperRodzajDokumentu.Location = new System.Drawing.Point(59, 15);
            this.lb_DodOperRodzajDokumentu.Name = "lb_DodOperRodzajDokumentu";
            this.lb_DodOperRodzajDokumentu.Size = new System.Drawing.Size(96, 13);
            this.lb_DodOperRodzajDokumentu.TabIndex = 14;
            this.lb_DodOperRodzajDokumentu.Text = "Rodzaj dokumentu";
            // 
            // gbKataster
            // 
            this.gbKataster.Controls.Add(this.tb_DodOperNrWRoku);
            this.gbKataster.Controls.Add(this.label7);
            this.gbKataster.Controls.Add(this.label5);
            this.gbKataster.Controls.Add(this.cb_DodOperTypDokKat);
            this.gbKataster.Controls.Add(this.lbRok);
            this.gbKataster.Controls.Add(this.tb_DodOperRok);
            this.gbKataster.Enabled = false;
            this.gbKataster.Location = new System.Drawing.Point(13, 177);
            this.gbKataster.Name = "gbKataster";
            this.gbKataster.Size = new System.Drawing.Size(409, 50);
            this.gbKataster.TabIndex = 16;
            this.gbKataster.TabStop = false;
            this.gbKataster.Text = "Kataster";
            // 
            // tb_DodOperNrWRoku
            // 
            this.tb_DodOperNrWRoku.Location = new System.Drawing.Point(356, 18);
            this.tb_DodOperNrWRoku.Name = "tb_DodOperNrWRoku";
            this.tb_DodOperNrWRoku.Size = new System.Drawing.Size(42, 20);
            this.tb_DodOperNrWRoku.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(298, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Nr w roku";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Typ dok. kat.";
            // 
            // cb_DodOperTypDokKat
            // 
            this.cb_DodOperTypDokKat.FormattingEnabled = true;
            this.cb_DodOperTypDokKat.Items.AddRange(new object[] {
            "Feldbuchy",
            "Obliczenia do zarysów",
            "Zarysy katastralne",
            "Zarysy katastralne 1_4 arkusza",
            "Zarysy katastralne 1_2 arkusza"});
            this.cb_DodOperTypDokKat.Location = new System.Drawing.Point(82, 17);
            this.cb_DodOperTypDokKat.Name = "cb_DodOperTypDokKat";
            this.cb_DodOperTypDokKat.Size = new System.Drawing.Size(126, 21);
            this.cb_DodOperTypDokKat.TabIndex = 6;
            // 
            // lbRok
            // 
            this.lbRok.AutoSize = true;
            this.lbRok.Location = new System.Drawing.Point(218, 19);
            this.lbRok.Name = "lbRok";
            this.lbRok.Size = new System.Drawing.Size(27, 13);
            this.lbRok.TabIndex = 5;
            this.lbRok.Text = "Rok";
            // 
            // tb_DodOperRok
            // 
            this.tb_DodOperRok.Location = new System.Drawing.Point(250, 17);
            this.tb_DodOperRok.Name = "tb_DodOperRok";
            this.tb_DodOperRok.Size = new System.Drawing.Size(42, 20);
            this.tb_DodOperRok.TabIndex = 0;
            // 
            // form_DodajOperat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 294);
            this.Controls.Add(this.gbKataster);
            this.Controls.Add(this.cd_DodOperRodzajDokumentu);
            this.Controls.Add(this.lb_DodOperRodzajDokumentu);
            this.Controls.Add(this.bt_DodOperOtworzSciezke);
            this.Controls.Add(this.tb_DodOperPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbObreb);
            this.Controls.Add(this.cbJednostka);
            this.Controls.Add(this.bt_DodOperDodajOperat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_DodOperOMZ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_DodOperNumerOperatu);
            this.Controls.Add(this.lb_DodOperNumer);
            this.Name = "form_DodajOperat";
            this.Text = "Dodawanie operatu";
            this.gbKataster.ResumeLayout(false);
            this.gbKataster.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_DodOperNumer;
        private System.Windows.Forms.TextBox tb_DodOperNumerOperatu;
        private System.Windows.Forms.TextBox tb_DodOperOMZ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button bt_DodOperDodajOperat;
        private System.Windows.Forms.ComboBox cbJednostka;
        private System.Windows.Forms.ComboBox cbObreb;
        private System.Windows.Forms.TextBox tb_DodOperPath;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button bt_DodOperOtworzSciezke;
        private System.Windows.Forms.ComboBox cd_DodOperRodzajDokumentu;
        private System.Windows.Forms.Label lb_DodOperRodzajDokumentu;
        private System.Windows.Forms.GroupBox gbKataster;
        private System.Windows.Forms.TextBox tb_DodOperNrWRoku;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_DodOperTypDokKat;
        private System.Windows.Forms.Label lbRok;
        private System.Windows.Forms.TextBox tb_DodOperRok;
    }
}