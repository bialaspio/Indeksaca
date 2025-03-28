
namespace Indeksaca_v01
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listViewFile = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lv1 = new System.Windows.Forms.ListView();
            this.Pobierz = new System.Windows.Forms.Button();
            this.lv0 = new System.Windows.Forms.ListView();
            this.Przenies = new System.Windows.Forms.Button();
            this.BT_Crt_PDF = new System.Windows.Forms.Button();
            this.lOperatNr = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_Path_dir = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_EdytujOperat = new System.Windows.Forms.Button();
            this.bt_DodajOperat = new System.Windows.Forms.Button();
            this.BT_Szukaj_operat = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lb_iloscs_stron = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_indeksacja = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_szukaj_operat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CB_nr_operat = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btPowieksz = new System.Windows.Forms.Button();
            this.btPomniejsz = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tb_path_pdf_out = new System.Windows.Forms.TextBox();
            this.bt_path_pdf_out = new System.Windows.Forms.Button();
            this.pb_gen_PDF = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.CB_rodzaj_dok = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbKataster = new System.Windows.Forms.GroupBox();
            this.tb_nr_w_roku = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_teryt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_typ_dok_kat = new System.Windows.Forms.ComboBox();
            this.lbRok = new System.Windows.Forms.Label();
            this.tb_rok = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TB_Tom = new System.Windows.Forms.TextBox();
            this.TB_index_set = new System.Windows.Forms.TextBox();
            this.TB_numer_set = new System.Windows.Forms.TextBox();
            this.TB_id_set = new System.Windows.Forms.TextBox();
            this.lb_tom = new System.Windows.Forms.Label();
            this.lb_index_w_set = new System.Windows.Forms.Label();
            this.lb_nr_set = new System.Windows.Forms.Label();
            this.ld_idset = new System.Windows.Forms.Label();
            this.gb_TypDokumentu = new System.Windows.Forms.GroupBox();
            this.rb_Mapa = new System.Windows.Forms.RadioButton();
            this.rb_DokKat = new System.Windows.Forms.RadioButton();
            this.rb_Operat = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb_SetCombo = new System.Windows.Forms.ComboBox();
            this.cb_TomCombo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pb_Info = new System.Windows.Forms.ProgressBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lb_Info = new System.Windows.Forms.Label();
            this.LB_co_robi = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.gbKataster.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gb_TypDokumentu.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewFile
            // 
            this.listViewFile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewFile.HideSelection = false;
            this.listViewFile.Location = new System.Drawing.Point(15, 39);
            this.listViewFile.Name = "listViewFile";
            this.listViewFile.Size = new System.Drawing.Size(129, 656);
            this.listViewFile.SmallImageList = this.imageList1;
            this.listViewFile.TabIndex = 1;
            this.listViewFile.UseCompatibleStateImageBehavior = false;
            this.listViewFile.SelectedIndexChanged += new System.EventHandler(this.listViewFile_SelectedIndexChanged);
            this.listViewFile.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewFile_MouseDoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lv1
            // 
            this.lv1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lv1.AllowDrop = true;
            this.lv1.AutoArrange = false;
            this.lv1.BackColor = System.Drawing.Color.White;
            this.lv1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lv1.HideSelection = false;
            this.lv1.HotTracking = true;
            this.lv1.HoverSelection = true;
            this.lv1.Location = new System.Drawing.Point(885, 39);
            this.lv1.MultiSelect = false;
            this.lv1.Name = "lv1";
            this.lv1.Size = new System.Drawing.Size(141, 656);
            this.lv1.StateImageList = this.imageList1;
            this.lv1.TabIndex = 2;
            this.lv1.UseCompatibleStateImageBehavior = false;
            this.lv1.View = System.Windows.Forms.View.Tile;
            this.lv1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lv1_ItemDrag);
            this.lv1.SelectedIndexChanged += new System.EventHandler(this.listView_p1_SelectedIndexChanged);
            this.lv1.DragDrop += new System.Windows.Forms.DragEventHandler(this.lv1_DragDrop);
            this.lv1.DragEnter += new System.Windows.Forms.DragEventHandler(this.lv1_DragEnter);
            // 
            // Pobierz
            // 
            this.Pobierz.Location = new System.Drawing.Point(914, 10);
            this.Pobierz.Name = "Pobierz";
            this.Pobierz.Size = new System.Drawing.Size(90, 23);
            this.Pobierz.TabIndex = 9;
            this.Pobierz.Text = "Pobierz";
            this.Pobierz.UseVisualStyleBackColor = true;
            this.Pobierz.Click += new System.EventHandler(this.Pobierz_Click);
            // 
            // lv0
            // 
            this.lv0.HideSelection = false;
            this.lv0.Location = new System.Drawing.Point(885, 39);
            this.lv0.Name = "lv0";
            this.lv0.Size = new System.Drawing.Size(141, 656);
            this.lv0.TabIndex = 11;
            this.lv0.UseCompatibleStateImageBehavior = false;
            // 
            // Przenies
            // 
            this.Przenies.Location = new System.Drawing.Point(43, 10);
            this.Przenies.Name = "Przenies";
            this.Przenies.Size = new System.Drawing.Size(75, 23);
            this.Przenies.TabIndex = 15;
            this.Przenies.Text = "Przenieś";
            this.Przenies.UseVisualStyleBackColor = true;
            this.Przenies.Click += new System.EventHandler(this.button2_Click);
            // 
            // BT_Crt_PDF
            // 
            this.BT_Crt_PDF.Location = new System.Drawing.Point(890, 39);
            this.BT_Crt_PDF.Name = "BT_Crt_PDF";
            this.BT_Crt_PDF.Size = new System.Drawing.Size(133, 23);
            this.BT_Crt_PDF.TabIndex = 16;
            this.BT_Crt_PDF.Text = "Generuj PDF";
            this.BT_Crt_PDF.UseVisualStyleBackColor = true;
            this.BT_Crt_PDF.Click += new System.EventHandler(this.BT_Crt_PDF_Click);
            // 
            // lOperatNr
            // 
            this.lOperatNr.AutoSize = true;
            this.lOperatNr.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lOperatNr.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lOperatNr.Location = new System.Drawing.Point(11, 15);
            this.lOperatNr.Name = "lOperatNr";
            this.lOperatNr.Size = new System.Drawing.Size(198, 39);
            this.lOperatNr.TabIndex = 17;
            this.lOperatNr.Text = "         Operat";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lOperatNr);
            this.groupBox1.Location = new System.Drawing.Point(730, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 53);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operat nr:";
            // 
            // tb_Path_dir
            // 
            this.tb_Path_dir.Location = new System.Drawing.Point(179, 11);
            this.tb_Path_dir.Name = "tb_Path_dir";
            this.tb_Path_dir.Size = new System.Drawing.Size(671, 20);
            this.tb_Path_dir.TabIndex = 103;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_EdytujOperat);
            this.groupBox2.Controls.Add(this.bt_DodajOperat);
            this.groupBox2.Controls.Add(this.BT_Szukaj_operat);
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.TB_szukaj_operat);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.CB_nr_operat);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(4, -3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1293, 78);
            this.groupBox2.TabIndex = 104;
            this.groupBox2.TabStop = false;
            // 
            // bt_EdytujOperat
            // 
            this.bt_EdytujOperat.Enabled = false;
            this.bt_EdytujOperat.Location = new System.Drawing.Point(430, 16);
            this.bt_EdytujOperat.Name = "bt_EdytujOperat";
            this.bt_EdytujOperat.Size = new System.Drawing.Size(98, 21);
            this.bt_EdytujOperat.TabIndex = 115;
            this.bt_EdytujOperat.Text = "Edytuj Operat";
            this.bt_EdytujOperat.UseVisualStyleBackColor = true;
            this.bt_EdytujOperat.Click += new System.EventHandler(this.bt_EdytujOperat_Click);
            // 
            // bt_DodajOperat
            // 
            this.bt_DodajOperat.Location = new System.Drawing.Point(430, 44);
            this.bt_DodajOperat.Name = "bt_DodajOperat";
            this.bt_DodajOperat.Size = new System.Drawing.Size(98, 21);
            this.bt_DodajOperat.TabIndex = 114;
            this.bt_DodajOperat.Text = "Dodaj Operat";
            this.bt_DodajOperat.UseVisualStyleBackColor = true;
            this.bt_DodajOperat.Click += new System.EventHandler(this.bt_DodajOperat_Click);
            // 
            // BT_Szukaj_operat
            // 
            this.BT_Szukaj_operat.Location = new System.Drawing.Point(337, 15);
            this.BT_Szukaj_operat.Name = "BT_Szukaj_operat";
            this.BT_Szukaj_operat.Size = new System.Drawing.Size(75, 23);
            this.BT_Szukaj_operat.TabIndex = 107;
            this.BT_Szukaj_operat.Text = "Szukaj";
            this.BT_Szukaj_operat.UseVisualStyleBackColor = true;
            this.BT_Szukaj_operat.Click += new System.EventHandler(this.BT_Szukaj_operat_Click_1);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lb_iloscs_stron);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.lb_indeksacja);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Location = new System.Drawing.Point(546, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(166, 60);
            this.groupBox7.TabIndex = 113;
            this.groupBox7.TabStop = false;
            // 
            // lb_iloscs_stron
            // 
            this.lb_iloscs_stron.AutoSize = true;
            this.lb_iloscs_stron.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_iloscs_stron.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_iloscs_stron.ForeColor = System.Drawing.Color.Red;
            this.lb_iloscs_stron.Location = new System.Drawing.Point(13, 22);
            this.lb_iloscs_stron.Name = "lb_iloscs_stron";
            this.lb_iloscs_stron.Size = new System.Drawing.Size(59, 31);
            this.lb_iloscs_stron.TabIndex = 112;
            this.lb_iloscs_stron.Text = "000";
            this.lb_iloscs_stron.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 110;
            this.label5.Text = "Zrobione";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lb_indeksacja
            // 
            this.lb_indeksacja.AutoSize = true;
            this.lb_indeksacja.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_indeksacja.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_indeksacja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lb_indeksacja.Location = new System.Drawing.Point(91, 23);
            this.lb_indeksacja.Name = "lb_indeksacja";
            this.lb_indeksacja.Size = new System.Drawing.Size(59, 31);
            this.lb_indeksacja.TabIndex = 111;
            this.lb_indeksacja.Text = "000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 109;
            this.label4.Text = "Pozostało";
            // 
            // TB_szukaj_operat
            // 
            this.TB_szukaj_operat.Location = new System.Drawing.Point(94, 16);
            this.TB_szukaj_operat.Name = "TB_szukaj_operat";
            this.TB_szukaj_operat.Size = new System.Drawing.Size(231, 20);
            this.TB_szukaj_operat.TabIndex = 106;
            this.TB_szukaj_operat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_szukaj_operat_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 105;
            this.label8.Text = "Numer operatu:";
            // 
            // CB_nr_operat
            // 
            this.CB_nr_operat.FormattingEnabled = true;
            this.CB_nr_operat.Location = new System.Drawing.Point(11, 44);
            this.CB_nr_operat.Name = "CB_nr_operat";
            this.CB_nr_operat.Size = new System.Drawing.Size(401, 21);
            this.CB_nr_operat.TabIndex = 104;
            this.CB_nr_operat.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btPowieksz);
            this.groupBox5.Controls.Add(this.tb_Path_dir);
            this.groupBox5.Controls.Add(this.btPomniejsz);
            this.groupBox5.Controls.Add(this.pictureBox2);
            this.groupBox5.Controls.Add(this.Przenies);
            this.groupBox5.Controls.Add(this.Pobierz);
            this.groupBox5.Controls.Add(this.listViewFile);
            this.groupBox5.Controls.Add(this.lv1);
            this.groupBox5.Controls.Add(this.lv0);
            this.groupBox5.Controls.Add(this.panel1);
            this.groupBox5.Location = new System.Drawing.Point(3, 82);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1039, 715);
            this.groupBox5.TabIndex = 106;
            this.groupBox5.TabStop = false;
            // 
            // btPowieksz
            // 
            this.btPowieksz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btPowieksz.Location = new System.Drawing.Point(856, 10);
            this.btPowieksz.Name = "btPowieksz";
            this.btPowieksz.Size = new System.Drawing.Size(23, 23);
            this.btPowieksz.TabIndex = 112;
            this.btPowieksz.Text = "+";
            this.btPowieksz.UseVisualStyleBackColor = true;
            this.btPowieksz.Click += new System.EventHandler(this.btPowieksz_Click);
            // 
            // btPomniejsz
            // 
            this.btPomniejsz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btPomniejsz.Location = new System.Drawing.Point(150, 10);
            this.btPomniejsz.Name = "btPomniejsz";
            this.btPomniejsz.Size = new System.Drawing.Size(23, 23);
            this.btPomniejsz.TabIndex = 111;
            this.btPomniejsz.Text = "-";
            this.btPomniejsz.UseVisualStyleBackColor = true;
            this.btPomniejsz.Click += new System.EventHandler(this.btPomniejsz_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1028, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(11, 10);
            this.pictureBox2.TabIndex = 114;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(150, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 656);
            this.panel1.TabIndex = 110;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(723, 650);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tb_path_pdf_out);
            this.groupBox6.Controls.Add(this.bt_path_pdf_out);
            this.groupBox6.Controls.Add(this.pb_gen_PDF);
            this.groupBox6.Controls.Add(this.BT_Crt_PDF);
            this.groupBox6.Location = new System.Drawing.Point(5, 796);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1037, 68);
            this.groupBox6.TabIndex = 107;
            this.groupBox6.TabStop = false;
            // 
            // tb_path_pdf_out
            // 
            this.tb_path_pdf_out.Location = new System.Drawing.Point(112, 14);
            this.tb_path_pdf_out.Name = "tb_path_pdf_out";
            this.tb_path_pdf_out.Size = new System.Drawing.Size(911, 20);
            this.tb_path_pdf_out.TabIndex = 104;
            // 
            // bt_path_pdf_out
            // 
            this.bt_path_pdf_out.Location = new System.Drawing.Point(13, 12);
            this.bt_path_pdf_out.Name = "bt_path_pdf_out";
            this.bt_path_pdf_out.Size = new System.Drawing.Size(93, 23);
            this.bt_path_pdf_out.TabIndex = 104;
            this.bt_path_pdf_out.Text = "Wczytaj katalog";
            this.bt_path_pdf_out.UseVisualStyleBackColor = true;
            this.bt_path_pdf_out.Click += new System.EventHandler(this.bt_path_pdf_out_Click);
            // 
            // pb_gen_PDF
            // 
            this.pb_gen_PDF.Location = new System.Drawing.Point(8, 39);
            this.pb_gen_PDF.Name = "pb_gen_PDF";
            this.pb_gen_PDF.Size = new System.Drawing.Size(873, 23);
            this.pb_gen_PDF.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(199, 795);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 9);
            this.label3.TabIndex = 108;
            this.label3.Text = "Piotr Białas";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 495);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(237, 287);
            this.richTextBox1.TabIndex = 114;
            this.richTextBox1.Text = "";
            // 
            // CB_rodzaj_dok
            // 
            this.CB_rodzaj_dok.FormattingEnabled = true;
            this.CB_rodzaj_dok.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CB_rodzaj_dok.Location = new System.Drawing.Point(5, 32);
            this.CB_rodzaj_dok.Name = "CB_rodzaj_dok";
            this.CB_rodzaj_dok.Size = new System.Drawing.Size(227, 21);
            this.CB_rodzaj_dok.TabIndex = 10;
            this.CB_rodzaj_dok.SelectedIndexChanged += new System.EventHandler(this.CB_rodzaj_dok_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Rodzaj dokumentu :";
            // 
            // gbKataster
            // 
            this.gbKataster.Controls.Add(this.tb_nr_w_roku);
            this.gbKataster.Controls.Add(this.label7);
            this.gbKataster.Controls.Add(this.tb_teryt);
            this.gbKataster.Controls.Add(this.label6);
            this.gbKataster.Controls.Add(this.label1);
            this.gbKataster.Controls.Add(this.cb_typ_dok_kat);
            this.gbKataster.Controls.Add(this.lbRok);
            this.gbKataster.Controls.Add(this.tb_rok);
            this.gbKataster.Enabled = false;
            this.gbKataster.Location = new System.Drawing.Point(6, 192);
            this.gbKataster.Name = "gbKataster";
            this.gbKataster.Size = new System.Drawing.Size(235, 127);
            this.gbKataster.TabIndex = 13;
            this.gbKataster.TabStop = false;
            this.gbKataster.Text = "Kataster";
            // 
            // tb_nr_w_roku
            // 
            this.tb_nr_w_roku.Location = new System.Drawing.Point(82, 90);
            this.tb_nr_w_roku.Name = "tb_nr_w_roku";
            this.tb_nr_w_roku.Size = new System.Drawing.Size(88, 20);
            this.tb_nr_w_roku.TabIndex = 11;
            this.tb_nr_w_roku.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Nr w roku";
            // 
            // tb_teryt
            // 
            this.tb_teryt.Location = new System.Drawing.Point(82, 42);
            this.tb_teryt.Name = "tb_teryt";
            this.tb_teryt.Size = new System.Drawing.Size(137, 20);
            this.tb_teryt.TabIndex = 9;
            this.tb_teryt.Text = "041406_5.0003";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "TERYT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Typ dok. kat.";
            // 
            // cb_typ_dok_kat
            // 
            this.cb_typ_dok_kat.FormattingEnabled = true;
            this.cb_typ_dok_kat.Items.AddRange(new object[] {
            "Feldbuchy",
            "Obliczenia do zarysów",
            "Zarysy katastralne",
            "Zarysy katastralne 1_4 arkusza",
            "Zarysy katastralne 1_2 arkusza"});
            this.cb_typ_dok_kat.Location = new System.Drawing.Point(82, 17);
            this.cb_typ_dok_kat.Name = "cb_typ_dok_kat";
            this.cb_typ_dok_kat.Size = new System.Drawing.Size(137, 21);
            this.cb_typ_dok_kat.TabIndex = 6;
            // 
            // lbRok
            // 
            this.lbRok.AutoSize = true;
            this.lbRok.Location = new System.Drawing.Point(50, 68);
            this.lbRok.Name = "lbRok";
            this.lbRok.Size = new System.Drawing.Size(27, 13);
            this.lbRok.TabIndex = 5;
            this.lbRok.Text = "Rok";
            // 
            // tb_rok
            // 
            this.tb_rok.Location = new System.Drawing.Point(82, 66);
            this.tb_rok.Name = "tb_rok";
            this.tb_rok.Size = new System.Drawing.Size(88, 20);
            this.tb_rok.TabIndex = 0;
            this.tb_rok.Text = "2010";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TB_Tom);
            this.panel2.Controls.Add(this.TB_index_set);
            this.panel2.Controls.Add(this.TB_numer_set);
            this.panel2.Controls.Add(this.TB_id_set);
            this.panel2.Controls.Add(this.lb_tom);
            this.panel2.Controls.Add(this.lb_index_w_set);
            this.panel2.Controls.Add(this.lb_nr_set);
            this.panel2.Controls.Add(this.ld_idset);
            this.panel2.Location = new System.Drawing.Point(6, 325);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 164);
            this.panel2.TabIndex = 117;
            // 
            // TB_Tom
            // 
            this.TB_Tom.Location = new System.Drawing.Point(98, 91);
            this.TB_Tom.Name = "TB_Tom";
            this.TB_Tom.Size = new System.Drawing.Size(100, 20);
            this.TB_Tom.TabIndex = 7;
            // 
            // TB_index_set
            // 
            this.TB_index_set.Enabled = false;
            this.TB_index_set.Location = new System.Drawing.Point(98, 67);
            this.TB_index_set.Name = "TB_index_set";
            this.TB_index_set.Size = new System.Drawing.Size(100, 20);
            this.TB_index_set.TabIndex = 6;
            // 
            // TB_numer_set
            // 
            this.TB_numer_set.Location = new System.Drawing.Point(98, 43);
            this.TB_numer_set.Name = "TB_numer_set";
            this.TB_numer_set.Size = new System.Drawing.Size(100, 20);
            this.TB_numer_set.TabIndex = 5;
            // 
            // TB_id_set
            // 
            this.TB_id_set.Location = new System.Drawing.Point(98, 19);
            this.TB_id_set.Name = "TB_id_set";
            this.TB_id_set.Size = new System.Drawing.Size(100, 20);
            this.TB_id_set.TabIndex = 4;
            // 
            // lb_tom
            // 
            this.lb_tom.AutoSize = true;
            this.lb_tom.Location = new System.Drawing.Point(61, 94);
            this.lb_tom.Name = "lb_tom";
            this.lb_tom.Size = new System.Drawing.Size(31, 13);
            this.lb_tom.TabIndex = 3;
            this.lb_tom.Text = "Tom:";
            // 
            // lb_index_w_set
            // 
            this.lb_index_w_set.AutoSize = true;
            this.lb_index_w_set.Location = new System.Drawing.Point(28, 70);
            this.lb_index_w_set.Name = "lb_index_w_set";
            this.lb_index_w_set.Size = new System.Drawing.Size(64, 13);
            this.lb_index_w_set.TabIndex = 2;
            this.lb_index_w_set.Text = "Index w set:";
            // 
            // lb_nr_set
            // 
            this.lb_nr_set.AutoSize = true;
            this.lb_nr_set.Location = new System.Drawing.Point(34, 46);
            this.lb_nr_set.Name = "lb_nr_set";
            this.lb_nr_set.Size = new System.Drawing.Size(58, 13);
            this.lb_nr_set.TabIndex = 1;
            this.lb_nr_set.Text = "Numer set:";
            // 
            // ld_idset
            // 
            this.ld_idset.AutoSize = true;
            this.ld_idset.Location = new System.Drawing.Point(54, 22);
            this.ld_idset.Name = "ld_idset";
            this.ld_idset.Size = new System.Drawing.Size(38, 13);
            this.ld_idset.TabIndex = 0;
            this.ld_idset.Text = "ID set:";
            // 
            // gb_TypDokumentu
            // 
            this.gb_TypDokumentu.Controls.Add(this.rb_Mapa);
            this.gb_TypDokumentu.Controls.Add(this.rb_DokKat);
            this.gb_TypDokumentu.Controls.Add(this.rb_Operat);
            this.gb_TypDokumentu.Enabled = false;
            this.gb_TypDokumentu.Location = new System.Drawing.Point(6, 21);
            this.gb_TypDokumentu.Name = "gb_TypDokumentu";
            this.gb_TypDokumentu.Size = new System.Drawing.Size(235, 73);
            this.gb_TypDokumentu.TabIndex = 118;
            this.gb_TypDokumentu.TabStop = false;
            this.gb_TypDokumentu.Text = "Typ Dokumentu";
            // 
            // rb_Mapa
            // 
            this.rb_Mapa.AutoSize = true;
            this.rb_Mapa.Location = new System.Drawing.Point(10, 49);
            this.rb_Mapa.Name = "rb_Mapa";
            this.rb_Mapa.Size = new System.Drawing.Size(52, 17);
            this.rb_Mapa.TabIndex = 2;
            this.rb_Mapa.TabStop = true;
            this.rb_Mapa.Text = "Mapa";
            this.rb_Mapa.UseVisualStyleBackColor = true;
            // 
            // rb_DokKat
            // 
            this.rb_DokKat.AutoSize = true;
            this.rb_DokKat.Location = new System.Drawing.Point(10, 32);
            this.rb_DokKat.Name = "rb_DokKat";
            this.rb_DokKat.Size = new System.Drawing.Size(128, 17);
            this.rb_DokKat.TabIndex = 1;
            this.rb_DokKat.TabStop = true;
            this.rb_DokKat.Text = "Dokument katastralny";
            this.rb_DokKat.UseVisualStyleBackColor = true;
            // 
            // rb_Operat
            // 
            this.rb_Operat.AutoSize = true;
            this.rb_Operat.Location = new System.Drawing.Point(10, 15);
            this.rb_Operat.Name = "rb_Operat";
            this.rb_Operat.Size = new System.Drawing.Size(57, 17);
            this.rb_Operat.TabIndex = 0;
            this.rb_Operat.TabStop = true;
            this.rb_Operat.Text = "Operat";
            this.rb_Operat.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb_SetCombo);
            this.groupBox3.Controls.Add(this.cb_TomCombo);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.CB_rodzaj_dok);
            this.groupBox3.Location = new System.Drawing.Point(6, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(235, 97);
            this.groupBox3.TabIndex = 119;
            this.groupBox3.TabStop = false;
            // 
            // cb_SetCombo
            // 
            this.cb_SetCombo.Enabled = false;
            this.cb_SetCombo.FormattingEnabled = true;
            this.cb_SetCombo.Location = new System.Drawing.Point(136, 70);
            this.cb_SetCombo.Name = "cb_SetCombo";
            this.cb_SetCombo.Size = new System.Drawing.Size(95, 21);
            this.cb_SetCombo.TabIndex = 16;
            this.cb_SetCombo.SelectedIndexChanged += new System.EventHandler(this.cb_SetCombo_SelectedIndexChanged);
            // 
            // cb_TomCombo
            // 
            this.cb_TomCombo.Enabled = false;
            this.cb_TomCombo.FormattingEnabled = true;
            this.cb_TomCombo.Location = new System.Drawing.Point(5, 70);
            this.cb_TomCombo.Name = "cb_TomCombo";
            this.cb_TomCombo.Size = new System.Drawing.Size(102, 21);
            this.cb_TomCombo.TabIndex = 15;
            this.cb_TomCombo.SelectedIndexChanged += new System.EventHandler(this.cb_TomCombo_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(133, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Set:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Tom:";
            // 
            // pb_Info
            // 
            this.pb_Info.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pb_Info.Location = new System.Drawing.Point(15, 871);
            this.pb_Info.Name = "pb_Info";
            this.pb_Info.Size = new System.Drawing.Size(1027, 19);
            this.pb_Info.TabIndex = 109;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.panel2);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.gbKataster);
            this.groupBox4.Controls.Add(this.richTextBox1);
            this.groupBox4.Controls.Add(this.gb_TypDokumentu);
            this.groupBox4.Location = new System.Drawing.Point(1048, 82);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(249, 808);
            this.groupBox4.TabIndex = 120;
            this.groupBox4.TabStop = false;
            // 
            // lb_Info
            // 
            this.lb_Info.AutoSize = true;
            this.lb_Info.Location = new System.Drawing.Point(43, 873);
            this.lb_Info.Name = "lb_Info";
            this.lb_Info.Size = new System.Drawing.Size(16, 13);
            this.lb_Info.TabIndex = 110;
            this.lb_Info.Text = "...";
            // 
            // LB_co_robi
            // 
            this.LB_co_robi.AutoSize = true;
            this.LB_co_robi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LB_co_robi.Location = new System.Drawing.Point(18, 873);
            this.LB_co_robi.Name = "LB_co_robi";
            this.LB_co_robi.Size = new System.Drawing.Size(25, 13);
            this.LB_co_robi.TabIndex = 109;
            this.LB_co_robi.Text = "Info";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1307, 909);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lb_Info);
            this.Controls.Add(this.LB_co_robi);
            this.Controls.Add(this.pb_Info);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TMCE Indeksacaja V.002.a";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.gbKataster.ResumeLayout(false);
            this.gbKataster.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gb_TypDokumentu.ResumeLayout(false);
            this.gb_TypDokumentu.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listViewFile;
        private System.Windows.Forms.Button Pobierz;
        private System.Windows.Forms.ListView lv0;
        private System.Windows.Forms.ListView lv1;
        private System.Windows.Forms.Button Przenies;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button BT_Crt_PDF;
        private System.Windows.Forms.Label lOperatNr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_Path_dir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ProgressBar pb_gen_PDF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_indeksacja;
        private System.Windows.Forms.Label lb_iloscs_stron;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox tb_path_pdf_out;
        private System.Windows.Forms.Button bt_path_pdf_out;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btPomniejsz;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ComboBox CB_nr_operat;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox CB_rodzaj_dok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbKataster;
        private System.Windows.Forms.TextBox tb_nr_w_roku;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_teryt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_typ_dok_kat;
        private System.Windows.Forms.Label lbRok;
        private System.Windows.Forms.TextBox tb_rok;
        private System.Windows.Forms.Button BT_Szukaj_operat;
        private System.Windows.Forms.TextBox TB_szukaj_operat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ld_idset;
        private System.Windows.Forms.TextBox TB_Tom;
        private System.Windows.Forms.TextBox TB_index_set;
        private System.Windows.Forms.TextBox TB_numer_set;
        private System.Windows.Forms.TextBox TB_id_set;
        private System.Windows.Forms.Label lb_tom;
        private System.Windows.Forms.Label lb_index_w_set;
        private System.Windows.Forms.Label lb_nr_set;
        private System.Windows.Forms.Button bt_DodajOperat;
        private System.Windows.Forms.GroupBox gb_TypDokumentu;
        private System.Windows.Forms.RadioButton rb_Mapa;
        private System.Windows.Forms.RadioButton rb_DokKat;
        private System.Windows.Forms.RadioButton rb_Operat;
        private System.Windows.Forms.Button bt_EdytujOperat;
        private System.Windows.Forms.Button btPowieksz;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cb_SetCombo;
        private System.Windows.Forms.ComboBox cb_TomCombo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ProgressBar pb_Info;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lb_Info;
        private System.Windows.Forms.Label LB_co_robi;
    }
}

