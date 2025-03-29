using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text.pdf;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Runtime.InteropServices;
using NLog;
using Npgsql;


namespace Indeksaca_v01
{
    public partial class Form1 : Form
    {
        private static readonly NLog.Logger _loger = LogManager.GetLogger("mojeLogowanieNazwa");
        readonly ImageList myImageListLarge = new ImageList();
        readonly ImageList myImageListLarge_P1 = new ImageList();

        int licz_dokument;
        int count = 0;
        int count_p1 = 0;

        public string ImageNewName = "";

        //        FolderBrowserDialog fbd = new FolderBrowserDialog();
        string dir_name;
        private static readonly OpenFileDialog openFileDialog = new OpenFileDialog()
        {
            Multiselect = true,
            ValidateNames = true,
            Filter = "JPG|*.jpg|JPEG|*.jpeg|PNG|*.png"
        };
        OpenFileDialog ofd = openFileDialog;

        FolderBrowserDialog ofd_dir = new FolderBrowserDialog();
        FolderBrowserDialog ofd_path_pdf_out = new FolderBrowserDialog();

        FileInfo fi;

        double zoom = -0.75;

        int h = 1;
        int w = 1;
        
public class pliki_wielostonocowe
        {
            public string plik_nazawa { get; set; }
            public string plik_nazawa_merge { get; set; }
        }

        public class row_toperat_str
        {
            public int Id { get; set; }
            public int Idoperat { get; set; }
            public string Nazwa { get; set; }
            public int Idcategory { get; set; }
            public int Idset { get; set; }
            public string Setnumber { get; set; }
            public string Timeofmodified { get; set; }
            public int Indexinset { get; set; }
            public int Idjpg { get; set; }
            public string Tom { get; set; }
        }

        bool load_from_file = false;

        List<row_toperat_str> lv01_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv02_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv03_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv04_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv05_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv06_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv07_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv08_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv09_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv10_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv11_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv12_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv13_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv14_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv15_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv16_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv17_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv18_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv19_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv20_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv21_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv22_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv23_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv24_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv25_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv26_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv27_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv28_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv29_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv30_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv31_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv32_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv33_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv34_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv35_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv36_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv37_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv38_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv39_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv40_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv41_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv42_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv43_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv44_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv45_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv46_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv47_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv48_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv49_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv50_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv51_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv52_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv53_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv54_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv55_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv56_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv57_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv58_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv59_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv60_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv61_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv62_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv63_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv64_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv65_toperat_pliki = new List<row_toperat_str>();
        List<row_toperat_str> lv66_toperat_pliki = new List<row_toperat_str>();

        public Form1()
        {
            _loger.Info("Start aplikacji");
            InitializeComponent();
            CB_rodzaj_dok.Items.Add("1 Akt notarialny");
            CB_rodzaj_dok.Items.Add("2 Akt własności ziemi");
            CB_rodzaj_dok.Items.Add("3 Analiza materiałów źródłowych");
            CB_rodzaj_dok.Items.Add("4 Arkusz danych ewidencyjnych budynków");
            CB_rodzaj_dok.Items.Add("5 Arkusz danych ewidencyjnych lokali");
            CB_rodzaj_dok.Items.Add("6 Artykuł matrykuły lub matrykuła");
            CB_rodzaj_dok.Items.Add("7 Decyzja");
            CB_rodzaj_dok.Items.Add("8 Dokument inny");
            CB_rodzaj_dok.Items.Add("9 Dokument wyjściowy");
            CB_rodzaj_dok.Items.Add("10 Dokumentacja obliczeniowa");
            CB_rodzaj_dok.Items.Add("11 Dziennik pomiarowy");
            CB_rodzaj_dok.Items.Add("12 Dziennik robót, prac");
            CB_rodzaj_dok.Items.Add("13 Księga budynkowa");
            CB_rodzaj_dok.Items.Add("14 Księga parcel");
            CB_rodzaj_dok.Items.Add("15 Mapa gleboznawczej klasyfikacji gruntów");
            CB_rodzaj_dok.Items.Add("16 Mapa inna");
            CB_rodzaj_dok.Items.Add("17 Mapa katastralna, stanu prawnego");
            CB_rodzaj_dok.Items.Add("18 Mapa powykonawcza, wynikowa pracy");
            CB_rodzaj_dok.Items.Add("19 Mapa uzupełniająca");
            CB_rodzaj_dok.Items.Add("20 Mapa wywiadu");
            CB_rodzaj_dok.Items.Add("21 Mapa z projektem podziału");
            CB_rodzaj_dok.Items.Add("22 Mapa z wstępnym projektem podziału");
            CB_rodzaj_dok.Items.Add("23 Miejscowy plan zagospodarowania przestrzennego");
            CB_rodzaj_dok.Items.Add("24 Odpowiedź na zgłoszenie pracy geodezyjnej");
            CB_rodzaj_dok.Items.Add("25 Opinia");
            CB_rodzaj_dok.Items.Add("26 Opis i mapa, wypis i wyrys");
            CB_rodzaj_dok.Items.Add("27 Opis topograficzny");
            CB_rodzaj_dok.Items.Add("28 Orzeczenie, wyrok sądu");
            CB_rodzaj_dok.Items.Add("29 Oświadczenie");
            CB_rodzaj_dok.Items.Add("30 Postanowienie");
            CB_rodzaj_dok.Items.Add("31 Protokół badania księgi wieczystej, odpis");
            CB_rodzaj_dok.Items.Add("32 Protokół graniczny");
            CB_rodzaj_dok.Items.Add("33 Protokół inny");
            CB_rodzaj_dok.Items.Add("34 Protokół katastralny, parcelowy");
            CB_rodzaj_dok.Items.Add("35 Raport inny");
            CB_rodzaj_dok.Items.Add("36 Raport pomiarowy rtk/rtn");
            CB_rodzaj_dok.Items.Add("37 Rejestr archiwalny");
            CB_rodzaj_dok.Items.Add("38 Rejestr inny");
            CB_rodzaj_dok.Items.Add("39 Rejestr przed/po scaleniowy");
            CB_rodzaj_dok.Items.Add("40 Skorowidz/wykaz działek");
            CB_rodzaj_dok.Items.Add("41 Skorowidz/wykaz właścicieli");
            CB_rodzaj_dok.Items.Add("42 Spis treści");
            CB_rodzaj_dok.Items.Add("43 Sprawozdanie techniczne");
            CB_rodzaj_dok.Items.Add("44 Strona tytułowa");
            CB_rodzaj_dok.Items.Add("45 Szkic inny");
            CB_rodzaj_dok.Items.Add("46 Szkic katastralny, podstawowy");
            CB_rodzaj_dok.Items.Add("47 Szkic osnowy");
            CB_rodzaj_dok.Items.Add("48 Szkic polowy");
            CB_rodzaj_dok.Items.Add("49 Szkic przeglądowy");
            CB_rodzaj_dok.Items.Add("50 Transformacja punktów");
            CB_rodzaj_dok.Items.Add("51 Ugoda");
            CB_rodzaj_dok.Items.Add("52 Upoważnienie, pełnomocnictwo");
            CB_rodzaj_dok.Items.Add("53 Wniosek inny");
            CB_rodzaj_dok.Items.Add("54 Wniosek o przyjęcie dokumentacji do zasobu");
            CB_rodzaj_dok.Items.Add("55 Wykaz synchronizacyjny");
            CB_rodzaj_dok.Items.Add("56 Wykaz współrzędnych");
            CB_rodzaj_dok.Items.Add("57 Wykaz wywłaszczeniowy");
            CB_rodzaj_dok.Items.Add("58 Wykaz zmian danych ewidencyjnych");
            CB_rodzaj_dok.Items.Add("59 Zarys katastralny");
            CB_rodzaj_dok.Items.Add("60 Zarys pomiarowy");
            CB_rodzaj_dok.Items.Add("61 Zaświadczenie");
            CB_rodzaj_dok.Items.Add("62 Zawiadomienie o wykonaniu zgłoszonych prac");
            CB_rodzaj_dok.Items.Add("63 Zawiadomienie z wydziału kw");
            CB_rodzaj_dok.Items.Add("64 Zawiadomienie, powiadomienie");
            CB_rodzaj_dok.Items.Add("65 Zgłoszenie pracy geodezyjnej");
            CB_rodzaj_dok.Items.Add("66 Zwrotne potwierdzenie odbioru");


            // listViewFile.SmallImageList = myImageListSmall;
            listViewFile.SmallImageList = myImageListLarge;
            this.KeyPreview = true;

            tb_path_pdf_out.Text = Directory.GetCurrentDirectory() + @"\pdf_out";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ukryj_ListView();
            lv1.Visible = true;
           // lb_Info.BackColor = System.Drawing.Color.Transparent;
           // LB_co_robi.BackColor = System.Drawing.Color.Transparent;
        }

        public NpgsqlConnection polacz_z_baza()
        {
            var cs = "Host=__host__;Username=__username__;Password=__passwd__;Database=__dbname__";
            var con = new NpgsqlConnection(cs);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd połączenia z bazą danych: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            return con;
        }

        private void BT_Szukaj_operat_Click_1(object sender, EventArgs e)
        {
            lOperatNr.Text = "         Operat";
            wyszukaj_operat();
        }

        private void TB_szukaj_operat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lOperatNr.Text = "         Operat";
                wyszukaj_operat();
            }
        }

        public void wyszukaj_operat()
        {
            CB_nr_operat.Items.Clear();
            CB_nr_operat.Items.Add("Wybierz");
            if (TB_szukaj_operat.TextLength > 0)
            {
                var con = polacz_z_baza();
                NpgsqlCommand cmd = new NpgsqlCommand(string.Format(@"select * from pandora.toperat where numer like '%{0}%' ;", TB_szukaj_operat.Text), con);
                NpgsqlDataReader row_toperat = cmd.ExecuteReader();

                while (row_toperat.Read())
                {
                    CB_nr_operat.Items.Add(row_toperat[2]);
                }
                con.Close();

                if (CB_nr_operat.Items.Count > 1)
                {
                    CB_nr_operat.SelectedIndex = 0;
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show(string.Format("Nie udało sie odszukać operatu dla frazy: {0}. \n Czy chcsz wprowadzić operat do bazy ?", TB_szukaj_operat.Text), "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    _loger.Info("Brak operatu z numerem "+ TB_szukaj_operat.Text);
                    if (dialogResult == DialogResult.Yes)
                    {
                        _loger.Info("Wybrando TAK dla wprowadzenia nowego operatu do bazy");
                        try
                        {
                            form_DodajOperat DFO = new form_DodajOperat();
                            DFO.Show();
                        }
                        catch
                        {
                            _loger.Error("Nie udało otworzyć okna do wrowadzanie nowego operatu ");
                            MessageBox.Show("Nie można otworzyć okna do wprowadzenia nowego operatu", "Err Create path", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        
                    }
                }
            }
            else
            {
                MessageBox.Show("Wprowadz numer operatu, który chcesz wyszukuać.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Wybranie operatu w combobox-ie 
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int dlugos_naz_oper;
            dlugos_naz_oper = CB_nr_operat.Text.Length;

            listViewFile.Clear();

            if (dlugos_naz_oper > 0)
            {
                if (dlugos_naz_oper < 18)
                {
                    lOperatNr.Font = new Font("Arial", 25);
                }
                else if (dlugos_naz_oper < 25)
                {
                    lOperatNr.Font = new Font("Arial", 15);
                }
                else if (dlugos_naz_oper < 30)
                {
                    lOperatNr.Font = new Font("Arial", 12);
                }
                else if (dlugos_naz_oper < 40)
                {
                    lOperatNr.Font = new Font("Arial", 10);
                }
                else if (dlugos_naz_oper < 50)
                {
                    lOperatNr.Font = new Font("Arial", 9);
                }
                else
                {
                    lOperatNr.Font = new Font("Arial", 8);
                }
            }
            
            if (CB_nr_operat.Text != "Wybierz")
                lOperatNr.Text = CB_nr_operat.Text;
            lOperatNr.Refresh();


            string operat_typ = "";
            var con = polacz_z_baza();
            NpgsqlCommand cmd = new NpgsqlCommand(string.Format(@"select ""path"",typdokumentu from pandora.toperat where numer like '{0}' ;", lOperatNr.Text), con);
            NpgsqlDataReader paht_operat = cmd.ExecuteReader();

            while (paht_operat.Read())
            {
                tb_Path_dir.Text = string.Format(@"E:\OPERATY_SWC\{0}", paht_operat[0].ToString());
                operat_typ = paht_operat[1].ToString();
            }
            con.Close();

            // wczytuje dane do lity do rodzielenia 

            if (CB_nr_operat.Text != "Wybierz")
                wczytaj_dane(operat_typ);

            dir_name = lOperatNr.Text;
        }

        

        //----------------------------------------------------------------------------------------------------------------------------------------------
        // Wczytanie danych do listy do rodzielenia  
        //----------------------------------------------------------------------------------------------------------------------------------------------

        public void wczytaj_dane(string operat_typ)
        {
            if (operat_typ == "operat") 
            {
                rb_Operat.Checked = true;
            }
            else if (operat_typ == "dok_kat")
            {
                rb_DokKat.Checked = true;
            }
            else if (operat_typ == "mapa")
            {
                rb_Mapa.Checked = true;
            }


            // czyszczenie listy

            if (lOperatNr.Text != "         Operat" && lOperatNr.Text != "Wybierz")
            {
                if (tb_Path_dir.Text != null)
                {
                    richTextBox1.Text = tb_Path_dir.Text;
                    _loger.Info("Sprawdzenie czy istnieje śceieżka dla operatu " + lOperatNr.Text);
                    _loger.Info("Sprawdzana ścieżka :" + tb_Path_dir.Text + "\\" + lOperatNr.Text);
                    
                    // Ściezka istnieje w systemie plików  
                    if (System.IO.Directory.Exists(tb_Path_dir.Text + "\\" + lOperatNr.Text))
                    {
                        // spraqwdznie czy w ściezce są pliki  
                        DirectoryInfo Files_from_operat = new DirectoryInfo(tb_Path_dir.Text + "\\" + lOperatNr.Text);
                        _loger.Info("Pobranie nazw pliów dla operatu :" + lOperatNr.Text);
                        FileInfo[] Files = Files_from_operat.GetFiles("*.jpg"); //Getting Text files
                        
                        if (Files.Length == 0)
                        {
                            if (kopiuj_pliki_z_respozytorium())
                            {
                                wczytaj_dane_do_ViewFile();
                            }
                        }
                        else if (Files.Length > 0)
                        {
                            wczytaj_dane_do_ViewFile();
                        }
                    }
                    // Brak ścieżki w systemie plików  
                    else
                    {
                        if (dodaj_sciezke_do_operatu())
                        {
                            if (kopiuj_pliki_z_respozytorium())
                            {
                                wczytaj_dane_do_ViewFile();
                            }
                            else
                            {
                             //   MessageBox.Show(String.Format("Bląd kopiowania operatu {0}", lOperatNr.Text), "Err");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Nie zdefiniowano ścieżki dla operatu !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (listViewFile.Items.Count > 0)
            {
                listViewFile.Items[0].Selected = true;
                //tb_Path_dir.Text = Path.GetDirectoryName(ofd.FileName);
                sprawdz_save(lOperatNr.Text);
                lb_indeksacja.Text = zlicz_zaindeksowane().ToString();
                lb_iloscs_stron.Text = listViewFile.Items.Count.ToString();
                _loger.Info("Wczytano do listy plików :" + lb_iloscs_stron.Text);
                _loger.Info("Ilość zaindeksowanych przy wczytaniu:" + lb_indeksacja.Text);
                //utworz_plik(lOperatNr.Text);
                
            }
        }

// dodanie do systemu plików na E 
        public bool dodaj_sciezke_do_operatu()
        {
            _loger.Info("Ścieżka nie istnieje");
            DialogResult dialogResult = MessageBox.Show("Nie odnaleziono określonej ścieżki.\n Czy utworzyć katalogi dla ścieżki?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            _loger.Info("Pytanie o utworzenie ścieżki");
            if (dialogResult == DialogResult.Yes)
            {
                _loger.Info("Próba utworzenia ścieżki w systemie plików");
                try
                {
                    Directory.CreateDirectory(tb_Path_dir.Text + "\\" + lOperatNr.Text);
                    _loger.Info("Utworzono ścieżkę: " + tb_Path_dir.Text + "\\" + lOperatNr.Text);
                    return true;
                }
                catch
                {
                    _loger.Error("Nie udało się utworzyć ścieżki: " + tb_Path_dir.Text + "\\" + lOperatNr.Text);
                    MessageBox.Show("Nie udało się utworzyć ścieżki: " + tb_Path_dir.Text + "\\" + lOperatNr.Text, "Err Create path", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        public bool kopiuj_pliki_z_respozytorium()
        {
            string path_to_operat_souce;
            string start_path_operat_find;
            string file_path_scr;
            string file_path_dest;

            _loger.Info("Nowy pusty katalog, dlatego brak plików jpg");
            DialogResult dialogResult_kopiuj = MessageBox.Show("Nie odnaleziono plików dla danego operatu.\n Czy wyszukać i przekopiować potrzebne pliki?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            _loger.Info("Pytanie o próbę wyszukania i skopiowania plików");
            if (dialogResult_kopiuj == DialogResult.Yes)
            {
                var con = polacz_z_baza();
                NpgsqlCommand cmd = new NpgsqlCommand(string.Format(@"select ""path"" from pandora.operaty_all_csv where operat like '{0}' ;", lOperatNr.Text), con);
                NpgsqlDataReader paht_operat = cmd.ExecuteReader();
                string tmp_path = "";
                while (paht_operat.Read())
                {
                    tmp_path = paht_operat[0].ToString();
                }
                con.Close();

                start_path_operat_find = tmp_path + @"\";
                _loger.Info("Zgoda na wyszukanie plików");
                path_to_operat_souce = FindGitPath(lOperatNr.Text, start_path_operat_find);
                _loger.Info("Ścieżka wyszukiwania operatu: " + start_path_operat_find);
                if (path_to_operat_souce != "")
                {
                    DirectoryInfo d = new DirectoryInfo(path_to_operat_souce);
                    _loger.Info("Pobranie nazw plików dla operatu: " + lOperatNr.Text);
                    FileInfo[] Files = d.GetFiles("*.jpg");

                    string str = "";
                    int ilosc_plikow = Files.Length;

                    pb_Info.Minimum = 1;
                    pb_Info.Maximum = ilosc_plikow + 1;
                    pb_Info.Value = 1;
                    pb_Info.Step = 1;

                    foreach (FileInfo file in Files)
                    {
                        str = str + ", " + file.Name;
                        richTextBox1.Text += file.Name + "\n";
                        try
                        {
                            _loger.Info("Start kopiowania pliku" + file);
                            pb_Info.Value++;
                            file_path_scr = System.IO.Path.Combine(path_to_operat_souce, file.Name);
                            file_path_dest = System.IO.Path.Combine(tb_Path_dir.Text + @"\" + lOperatNr.Text, file.Name);
                            File.Copy(file_path_scr, file_path_dest);
                            lb_Info.Text = "Kopiuje: " + file_path_scr + " do " + file_path_dest;
                            lb_Info.Refresh();

                            _loger.Info("Koniec kopiowania pliku" + file);
                        }
                        catch
                        {
                            _loger.Info("Nie można przekopiować pliku" + file + "prawdopodobnie już istnieje w docelowej ścieżce");
                            DialogResult dialogResult_czy_napisac = MessageBox.Show(string.Format("Plik o nazwie {0} już istnieje!!!\nZastąpić istniejący plik?", Path.GetFileName(file.Name)), "Info copy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            _loger.Info("Pytanie o nadpisanie pliku " + file);
                            if (dialogResult_czy_napisac == DialogResult.Yes)
                            {
                                _loger.Info("Zgoda na nadpisanie pliku " + tb_Path_dir.Text + @"\" + lOperatNr.Text + @"\" + Path.GetFileName(file.ToString()));
                                try
                                {
                                    File.Copy(file.Name, tb_Path_dir.Text + @"\" + lOperatNr.Text, true);
                                    lb_Info.Text = "Kopiuje: " + file.Name + " do " + tb_Path_dir.Text + @"\" + lOperatNr.Text;
                                    lb_Info.Refresh();
                                    _loger.Info("Nadpisanie pliku " + tb_Path_dir.Text + @"\" + lOperatNr.Text + @"\" + Path.GetFileName(file.ToString()));
                                }
                                catch
                                {
                                    _loger.Error("Błąd kopiowania pliku " + tb_Path_dir.Text + @"\" + lOperatNr.Text + @"\" + Path.GetFileName(file.ToString()));
                                    MessageBox.Show(string.Format("Nie udało się przekopiować pliku {0}", file.Name), "Err Copy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    lb_Info.Text = "...";
                                    lb_Info.Refresh();
                                    return false;
                                }
                            }
                        }
                    }
                    lb_Info.Text = "...";
                    lb_Info.Refresh();
                    return true;
                }
                else
                {
                    MessageBox.Show(string.Format("Nie udało się w systemie plików odszukać operatu {0}.", lOperatNr.Text), "Brak operatu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------
        public void wczytaj_dane_do_ViewFile()
        {
            czysc_lv();
            _loger.Info("Ścieżka istnieje");
            string[] jpg_files = Directory.GetFiles(tb_Path_dir.Text + "\\" + lOperatNr.Text, "*.jpg");
            _loger.Info("Pobranie listy plików dla operatu" + lOperatNr.Text);
            //richTextBox1.Text = jpg_files.ToString();
            Cursor = Cursors.WaitCursor;
            foreach (string fileName in jpg_files)
            {
                fi = new FileInfo(fileName);
                FileInfo fileinfo = new FileInfo(fileName);

                using (FileStream stream = new FileStream(fi.FullName, FileMode.Open, FileAccess.Read))
                {
                    myImageListLarge.Images.Add(Image.FromStream(stream).GetThumbnailImage(50, 50, new Image.GetThumbnailImageAbort(() => false), IntPtr.Zero));
                    _loger.Info("Wczytanie pliku : " + fi.FullName);
                }

                listViewFile.LargeImageList = myImageListLarge;
                listViewFile.Items.Add(new ListViewItem
                {
                    ImageIndex = count,
                    Text = fi.Name,
                    Tag = fi.FullName
                });
                _loger.Info("Dodane pliku " + fi.FullName + "do listy do indeksacji");
                count++;
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
           // CB_rodzaj_dok.SelectedIndex = 0;
            Cursor = Cursors.Default;
        }
        
        //--------------------------------------------------------------------------------------------------------------------------------------------------

        public static string FindGitPath(string firstFilter, string initialPath)
        {
            string gitPath = string.Empty;
            
            try
            {
                foreach (var f in Directory.GetDirectories(initialPath, firstFilter))
                {
                   gitPath = f;
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Path is not accessible ");
            }
            return gitPath;
        }


        //--------------------------------------------------------------------------------------------------------------------------------------------------

        private void listViewFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewFile.SelectedItems.Count > 0)
            {
                _loger.Info("Zaznaczono :" +listViewFile.SelectedItems[0].Text);
                /*
                 729; 656
                 723; 650
                 */
                var item = listViewFile.SelectedItems[0];
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Width= 723;
                pictureBox1.Height = 650;
                panel1.Width = 729;
                panel1.Height = 650;
                panel1.AutoScroll = false;
                pictureBox1.Location = new Point (0,0);
                zoom = -0.75;

                pictureBox1.ImageLocation = item.Tag.ToString();
                pictureBox2.ImageLocation = item.Tag.ToString();
                pictureBox1.Enabled = true;
                btPomniejsz.Enabled = true;
                btPowieksz.Enabled = true;
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------
        // Segregowanie plików na poszczególne dokumenty według zapisu wa bazie        
        public void Dodaj_zkategoryzowana_strone_do_dokumentu(List<row_toperat_str> lv,int id )
        {
            _loger.Info("Rozpoczęto czytanie z bazy kategoryzacji dokumentu :" + listViewFile.SelectedItems[0].Tag);
            string select_query = string.Format(@"select *from pandora.toperatpliki where id = {0};", id);
            var con = polacz_z_baza();
            //string aaa = string.Format(@"select *from pandora.toperatpliki where idoperat  in (select idoperat from pandora.toperat where numer like '{0}') and nazwa like replace(LOWER('%{1}'),'jpg','pdf');", lOperatNr.Text, lv43.Items[i].Text);
            NpgsqlCommand cmd = new NpgsqlCommand(select_query, con);
            NpgsqlDataReader row_toperatpliki = cmd.ExecuteReader();


            while (row_toperatpliki.Read())
            {
                lv.Add(new row_toperat_str()
                {
                    Id = (int)row_toperatpliki[0],
                    Idoperat = (int)row_toperatpliki[1],
                    Nazwa = row_toperatpliki[2].ToString(),
                    Idcategory = (int)row_toperatpliki[3],
                    Idset = (int)row_toperatpliki[4],
                    Setnumber = row_toperatpliki[5].ToString(),
                    Timeofmodified = row_toperatpliki[6].ToString(),
                    Indexinset = (int)row_toperatpliki[7],
                   // Idjpg = (int)row_toperatpliki[8],
                    Tom = row_toperatpliki[9].ToString()
                });
            }
            con.Close();
        }


        public void dodaj_strone_do_dokumentu(List<row_toperat_str> lvXX_toperat_pliki, ImageList dodImageList, int rodzaj_dokumentu)
        {
            _loger.Info("Rozpoczęto kategoryzacji dokumentu :" + listViewFile.SelectedItems[0].Tag);
            
            using (FileStream stream = new FileStream(listViewFile.SelectedItems[0].Tag.ToString(), FileMode.Open, FileAccess.Read))
            {
                dodImageList.Images.Add(Image.FromStream(stream).GetThumbnailImage(50, 50, new Image.GetThumbnailImageAbort(() => false), IntPtr.Zero));
            }


            if (!String.IsNullOrEmpty(TB_id_set.Text))
            {
                if (!String.IsNullOrEmpty(TB_numer_set.Text))
                {
                    if (!String.IsNullOrEmpty(TB_Tom.Text))
                    {
                        lv1.Items.Add(new ListViewItem
                        {
                            ImageIndex = lv1.Items.Count,
                            Text = listViewFile.SelectedItems[0].Text,
                            Tag = listViewFile.SelectedItems[0].Tag
                        });
                        _loger.Info("Dodano plik " + listViewFile.SelectedItems[0].Text + " do listy " + lvXX_toperat_pliki.ToString());

                        zapisz_dodany_plik_do_bazy(lv1.Items.Count, listViewFile.SelectedItems[0].Tag.ToString(), lvXX_toperat_pliki,rodzaj_dokumentu);
                        
                        
                        for (int i = listViewFile.Items.Count - 1; i >= 0; i--)
                        {
                            if (listViewFile.Items[i].Selected)
                            {
                                listViewFile.Items[i].Remove();

                                if (listViewFile.Items.Count > i)
                                {
                                    listViewFile.Items[i].Selected = true;
                                }
                                else
                                {
                                    // nie nie zaznaczaj 
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Uzupełnij pole Tom !!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Uzupełnij pole Numer set !!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Uzupełnij pole ID set !!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            

        }

        public void zapisz_dodany_plik_do_bazy (int count_px, string Tag, List<row_toperat_str> lvXX_toperat_pliki,  int rodzaj_dokumentu )
        {         
            int index_in_set_to_insert = lv1.Items.Count;

            int idoperat = 0;
            int idset = 0;
            int idjpg = 0;
            var con_1 = polacz_z_baza();
            var con_2 = polacz_z_baza();
            var con_3 = polacz_z_baza();
            // id operatu 
            NpgsqlCommand cmd = new NpgsqlCommand(string.Format("select idoperat from pandora.toperat where Numer like '{0}'", lOperatNr.Text), con_1);
            NpgsqlDataReader row_toperat = cmd.ExecuteReader();
            while (row_toperat.Read())
            {
                idoperat = (int)row_toperat[0];
            }

            // id seta 
            cmd = new NpgsqlCommand(string.Format("select indexinset from pandora.toperatpliki where idoperat = {0} and idcategory = {1}; ", idoperat, rodzaj_dokumentu), con_2);
            row_toperat = cmd.ExecuteReader();
            
            while (row_toperat.Read())
            {
                idset = (int)row_toperat[0];
            }

            // id dodawanego plilu jpg 
            cmd = new NpgsqlCommand(string.Format("select max (idjpg) from pandora.toperatpliki"), con_3);           
            row_toperat = cmd.ExecuteReader();

            while (row_toperat.Read())
            {
                idjpg = (int)row_toperat[0]+1;
            }

            string data_now_str = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

            lvXX_toperat_pliki.Add(new row_toperat_str()
               {
                   Idoperat = idoperat,
                   Nazwa = Tag.ToLower().Replace("jpg", "pdf"),
                   Idcategory = rodzaj_dokumentu,
                   Idset = Int32.Parse(TB_id_set.Text),
                   Setnumber = TB_numer_set.Text,
                   Timeofmodified = data_now_str,
                   Indexinset = index_in_set_to_insert,
                   Idjpg = idjpg,
                   Tom = TB_Tom.Text
               }
               );
            
            var con = polacz_z_baza();
            //cmd = new NpgsqlCommand(string.Format("INSERT INTO pandora.toperatpliki (idoperat,nazwa, idcategory, idset, setnumber, timeofmodified, indexinset, idjpg, tom) VALUES({0},'{1}',{2},{3},{4},'{5}',{6},{7},{8});", idoperat, Tag.Replace("JPG", "pdf"), rodzaj_dokumentu, Int32.Parse(TB_id_set.Text), TB_numer_set.Text, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), index_in_set_to_insert, idjpg, TB_Tom.Text), con);
            cmd = new NpgsqlCommand(string.Format("INSERT INTO pandora.toperatpliki (idoperat,nazwa, idcategory, idset, setnumber, timeofmodified, indexinset, idjpg, tom) VALUES({0},'{1}',{2},{3},{4},'{5}',{6},{7},{8});", idoperat, Tag.ToLower().Replace("jpg", "pdf"), rodzaj_dokumentu, Int32.Parse(TB_id_set.Text), TB_numer_set.Text, data_now_str, index_in_set_to_insert, idjpg, TB_Tom.Text), con);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Nie udało się wykonać zapytania :\n" + string.Format("INSERT INTO pandora.toperatpliki (idoperat,nazwa, idcategory, idset, setnumber, timeofmodified, indexinset, idjpg, tom) VALUES({0},'{1}',{2},{3},{4},'{5}',{6},{7},{8});",
                idoperat, Tag.ToLower().Replace("jpg", "pdf"), rodzaj_dokumentu, Int32.Parse(TB_id_set.Text), TB_numer_set.Text, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), index_in_set_to_insert, idjpg, TB_Tom.Text), "Błąd bazy", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            con_3.Close();
            con_2.Close();
            con_1.Close();

        }

//----------------------------------------------------------------------------------------------------------------------------------------------------

        public int zlicz_zaindeksowane()
        {
            

            var con = polacz_z_baza();
            NpgsqlCommand cmd = new NpgsqlCommand(string.Format("select count(*) from pandora.toperatpliki where idoperat in (select idoperat from pandora.toperat where numer like '{0}')", lOperatNr.Text), con);
            try
            {
                NpgsqlDataReader rows_toperatpliki = cmd.ExecuteReader();
                int ilosc_zindeksowanych = 0;
                while (rows_toperatpliki.Read())
                {
                    ilosc_zindeksowanych = Int32.Parse( rows_toperatpliki[0].ToString());
                }
                return ilosc_zindeksowanych;

            }
            catch
            {
                MessageBox.Show(string.Format("select count(*) from pandora.toperatpliki where idoperat in (select idoperat from pandora.toperat where numer like '{0}')", lOperatNr.Text), "Błąd bazy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            con.Close();
            
        }


        private void listView_p1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv1.SelectedItems.Count > 0)
            {
                var item = lv1.SelectedItems[0];
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Width = 723;
                pictureBox1.Height = 650;
                panel1.Width = 729;
                panel1.Height = 650;
                panel1.AutoScroll = false;
                pictureBox1.Location = new Point(0, 0);
                zoom = -0.75;
                pictureBox1.ImageLocation = item.Tag.ToString().ToLower().Replace("pdf", "jpg");
                pictureBox1.Enabled = false;
                btPomniejsz.Enabled = false;
                btPowieksz.Enabled = false;
                pobierz_info_strona(item.Tag.ToString().ToLower());
            }
        }


        public void pobierz_info_strona(string path_to_pdf) 
        {
            // List<row_toperat_str> lv01_toperat_pliki = new List<row_toperat_str>();
            if (CB_rodzaj_dok.SelectedItem == "1 Akt notarialny")
            {
                foreach (row_toperat_str row_lv01 in lv01_toperat_pliki)
                {
                    if (row_lv01.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv01);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "2 Akt własności ziemi")
            {
                foreach (row_toperat_str row_lv02 in lv02_toperat_pliki)
                {
                    if (row_lv02.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv02);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "3 Analiza materiałów źródłowych")
            {
                foreach (row_toperat_str row_lv03 in lv03_toperat_pliki)
                {
                    if (row_lv03.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv03);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "4 Arkusz danych ewidencyjnych budynków")
            {
                foreach (row_toperat_str row_lv04 in lv04_toperat_pliki)
                {
                    if (row_lv04.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv04);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "5 Arkusz danych ewidencyjnych lokali")
            {
                foreach (row_toperat_str row_lv05 in lv05_toperat_pliki)
                {
                    if (row_lv05.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv05);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "6 Artykuł matrykuły lub matrykuła")
            {
                foreach (row_toperat_str row_lv06 in lv06_toperat_pliki)
                {
                    if (row_lv06.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv06);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "7 Decyzja")
            {
                foreach (row_toperat_str row_lv07 in lv07_toperat_pliki)
                {
                    if (row_lv07.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv07);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "8 Dokument inny")
            {
                foreach (row_toperat_str row_lv08 in lv08_toperat_pliki)
                {
                    if (row_lv08.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv08);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "9 Dokument wyjściowy")
            {
                foreach (row_toperat_str row_lv09 in lv09_toperat_pliki)
                {
                    if (row_lv09.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv09);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "10 Dokumentacja obliczeniowa")
            {
                foreach (row_toperat_str row_lv10 in lv10_toperat_pliki)
                {
                    if (row_lv10.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv10);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "11 Dziennik pomiarowy")
            {
                foreach (row_toperat_str row_lv11 in lv11_toperat_pliki)
                {
                    if (row_lv11.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv11);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "12 Dziennik robót, prac")
            {
                foreach (row_toperat_str row_lv12 in lv12_toperat_pliki)
                {
                    if (row_lv12.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv12);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "13 Księga budynkowa")
            {
                foreach (row_toperat_str row_lv13 in lv13_toperat_pliki)
                {
                    if (row_lv13.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv13);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "14 Księga parcel")
            {
                foreach (row_toperat_str row_lv14 in lv14_toperat_pliki)
                {
                    if (row_lv14.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv14);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "15 Mapa gleboznawczej klasyfikacji gruntów")
            {
                foreach (row_toperat_str row_lv15 in lv15_toperat_pliki)
                {
                    if (row_lv15.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv15);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "16 Mapa inna")
            {
                foreach (row_toperat_str row_lv16 in lv16_toperat_pliki)
                {
                    if (row_lv16.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv16);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "17 Mapa katastralna, stanu prawnego")
            {
                foreach (row_toperat_str row_lv17 in lv17_toperat_pliki)
                {
                    if (row_lv17.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv17);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "18 Mapa powykonawcza, wynikowa pracy")
            {
                foreach (row_toperat_str row_lv18 in lv18_toperat_pliki)
                {
                    if (row_lv18.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv18);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "19 Mapa uzupełniająca")
            {
                foreach (row_toperat_str row_lv19 in lv19_toperat_pliki)
                {
                    if (row_lv19.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv19);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "20 Mapa wywiadu")
            {
                foreach (row_toperat_str row_lv20 in lv20_toperat_pliki)
                {
                    if (row_lv20.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv20);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "21 Mapa z projektem podziału")
            {
                foreach (row_toperat_str row_lv21 in lv21_toperat_pliki)
                {
                    if (row_lv21.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv21);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "22 Mapa z wstępnym projektem podziału")
            {
                foreach (row_toperat_str row_lv22 in lv22_toperat_pliki)
                {
                    if (row_lv22.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv22);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "23 Miejscowy plan zagospodarowania przestrzennego")
            {
                foreach (row_toperat_str row_lv23 in lv23_toperat_pliki)
                {
                    if (row_lv23.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv23);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "24 Odpowiedź na zgłoszenie pracy geodezyjnej")
            {
                foreach (row_toperat_str row_lv24 in lv24_toperat_pliki)
                {
                    if (row_lv24.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv24);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "25 Opinia")
            {
                foreach (row_toperat_str row_lv25 in lv25_toperat_pliki)
                {
                    if (row_lv25.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv25);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "26 Opis i mapa, wypis i wyrys")
            {
                foreach (row_toperat_str row_lv26 in lv26_toperat_pliki)
                {
                    if (row_lv26.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv26);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "27 Opis topograficzny")
            {
                foreach (row_toperat_str row_lv27 in lv27_toperat_pliki)
                {
                    if (row_lv27.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv27);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "28 Orzeczenie, wyrok sądu")
            {
                foreach (row_toperat_str row_lv28 in lv28_toperat_pliki)
                {
                    if (row_lv28.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv28);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "29 Oświadczenie")
            {
                foreach (row_toperat_str row_lv29 in lv29_toperat_pliki)
                {
                    if (row_lv29.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv29);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "30 Postanowienie")
            {
                foreach (row_toperat_str row_lv30 in lv30_toperat_pliki)
                {
                    if (row_lv30.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv30);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "31 Protokół badania księgi wieczystej, odpis")
            {
                foreach (row_toperat_str row_lv31 in lv31_toperat_pliki)
                {
                    if (row_lv31.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv31);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "32 Protokół graniczny")
            {
                foreach (row_toperat_str row_lv32 in lv32_toperat_pliki)
                {
                    if (row_lv32.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv32);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "33 Protokół inny")
            {
                foreach (row_toperat_str row_lv33 in lv33_toperat_pliki)
                {
                    if (row_lv33.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv33);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "34 Protokół katastralny, parcelowy")
            {
                foreach (row_toperat_str row_lv34 in lv34_toperat_pliki)
                {
                    if (row_lv34.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv34);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "35 Raport inny")
            {
                foreach (row_toperat_str row_lv35 in lv35_toperat_pliki)
                {
                    if (row_lv35.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv35);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "36 Raport pomiarowy rtk/rtn")
            {
                foreach (row_toperat_str row_lv36 in lv36_toperat_pliki)
                {
                    if (row_lv36.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv36);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "37 Rejestr archiwalny")
            {
                foreach (row_toperat_str row_lv37 in lv37_toperat_pliki)
                {
                    if (row_lv37.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv37);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "38 Rejestr inny")
            {
                foreach (row_toperat_str row_lv38 in lv38_toperat_pliki)
                {
                    if (row_lv38.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv38);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "39 Rejestr przed/po scaleniowy")
            {
                foreach (row_toperat_str row_lv39 in lv39_toperat_pliki)
                {
                    if (row_lv39.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv39);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "40 Skorowidz/wykaz działek")
            {
                foreach (row_toperat_str row_lv40 in lv40_toperat_pliki)
                {
                    if (row_lv40.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv40);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "41 Skorowidz/wykaz właścicieli")
            {
                foreach (row_toperat_str row_lv41 in lv41_toperat_pliki)
                {
                    if (row_lv41.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv41);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "42 Spis treści")
            {
                foreach (row_toperat_str row_lv42 in lv42_toperat_pliki)
                {
                    if (row_lv42.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv42);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "43 Sprawozdanie techniczne")
            {
                foreach (row_toperat_str row_lv43 in lv43_toperat_pliki)
                {
                    if (row_lv43.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv43);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "44 Strona tytułowa")
            {
                foreach (row_toperat_str row_lv44 in lv44_toperat_pliki)
                {
                    if (row_lv44.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv44);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "45 Szkic inny")
            {
                foreach (row_toperat_str row_lv45 in lv45_toperat_pliki)
                {
                    if (row_lv45.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv45);
                    }
                };
            }
            if (CB_rodzaj_dok.SelectedItem == "46 Szkic katastralny, podstawowy")
            {
                foreach (row_toperat_str row_lv46 in lv46_toperat_pliki)
                {
                    if (row_lv46.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv46);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "47 Szkic osnowy")
            {
                foreach (row_toperat_str row_lv47 in lv47_toperat_pliki)
                {
                    if (row_lv47.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv47);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "48 Szkic polowy")
            {
                foreach (row_toperat_str row_lv48 in lv48_toperat_pliki)
                {
                    if (row_lv48.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv48);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "49 Szkic przeglądowy")
            {
                foreach (row_toperat_str row_lv49 in lv49_toperat_pliki)
                {
                    if (row_lv49.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv49);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "50 Transformacja punktów")
            {
                foreach (row_toperat_str row_lv50 in lv50_toperat_pliki)
                {
                    if (row_lv50.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv50);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "51 Ugoda")
            {
                foreach (row_toperat_str row_lv51 in lv51_toperat_pliki)
                {
                    if (row_lv51.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv51);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "52 Upoważnienie, pełnomocnictwo")
            {
                foreach (row_toperat_str row_lv52 in lv52_toperat_pliki)
                {
                    if (row_lv52.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv52);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "53 Wniosek inny")
            {
                foreach (row_toperat_str row_lv53 in lv53_toperat_pliki)
                {
                    if (row_lv53.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv53);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "54 Wniosek o przyjęcie dokumentacji do zasobu")
            {
                foreach (row_toperat_str row_lv54 in lv54_toperat_pliki)
                {
                    if (row_lv54.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv54);
                    }
                }
            }

            if (CB_rodzaj_dok.SelectedItem == "55 Wykaz synchronizacyjny")
            {
                foreach (row_toperat_str row_lv55 in lv55_toperat_pliki)
                {
                    if (row_lv55.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv55);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "56 Wykaz współrzędnych")
            {
                foreach (row_toperat_str row_lv56 in lv56_toperat_pliki)
                {
                    if (row_lv56.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv56);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "57 Wykaz wywłaszczeniowy")
            {
                foreach (row_toperat_str row_lv57 in lv57_toperat_pliki)
                {
                    if (row_lv57.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv57);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "58 Wykaz zmian danych ewidencyjnych")
            {
                foreach (row_toperat_str row_lv58 in lv58_toperat_pliki)
                {
                    if (row_lv58.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv58);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "59 Zarys katastralny")
            {
                foreach (row_toperat_str row_lv59 in lv59_toperat_pliki)
                {
                    if (row_lv59.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv59);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "60 Zarys pomiarowy")
            {
                foreach (row_toperat_str row_lv60 in lv60_toperat_pliki)
                {
                    if (row_lv60.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv60);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "61 Zaświadczenie")
            {
                foreach (row_toperat_str row_lv61 in lv61_toperat_pliki)
                {
                    if (row_lv61.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv61);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "62 Zawiadomienie o wykonaniu zgłoszonych prac")
            {
                foreach (row_toperat_str row_lv62 in lv62_toperat_pliki)
                {
                    if (row_lv62.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv62);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "63 Zawiadomienie z wydziału kw")
            {
                foreach (row_toperat_str row_lv63 in lv63_toperat_pliki)
                {
                    if (row_lv63.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv63);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "64 Zawiadomienie, powiadomienie")
            {
                foreach (row_toperat_str row_lv64 in lv64_toperat_pliki)
                {
                    if (row_lv64.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv64);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "65 Zgłoszenie pracy geodezyjnej")
            {
                foreach (row_toperat_str row_lv65 in lv65_toperat_pliki)
                {
                    if (row_lv65.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv65);
                    }
                }
            }
            if (CB_rodzaj_dok.SelectedItem == "66 Zwrotne potwierdzenie odbioru")
            {
                foreach (row_toperat_str row_lv66 in lv66_toperat_pliki)
                {
                    if (row_lv66.Nazwa.ToLower().Contains(path_to_pdf))
                    {
                        show_file_info(row_lv66);
                    }
                }
            }


            }



        public void czysc_lv ()
        {
            lv0.Clear();
            lv1.Clear();

        }

        public void ukryj_ListView()
        {
            lv0.Visible = false;
            lv1.Visible = false;

        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------
        private void CB_rodzaj_dok_SelectedIndexChanged(object sender, EventArgs e)
        {
            lv1.Clear();

            if (CB_rodzaj_dok.SelectedItem == "1 Akt notarialny")
            {
                Pobierz_ilosc_tomow("1");
                if (Pobierz_ilosc_setow(1) > 0)
                    wczytaj_pliki_do_lvXX(lv01_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "2 Akt własności ziemi")
            {
                Pobierz_ilosc_tomow("2");
                if (Pobierz_ilosc_setow(2) > 0)
                    wczytaj_pliki_do_lvXX(lv02_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "3 Analiza materiałów źródłowych")
            {
                Pobierz_ilosc_tomow("3");
                if (Pobierz_ilosc_setow(3) > 0)
                    wczytaj_pliki_do_lvXX(lv03_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "4 Arkusz danych ewidencyjnych budynków")
            {
                Pobierz_ilosc_tomow("4");
                if (Pobierz_ilosc_setow(4) > 0)
                    wczytaj_pliki_do_lvXX(lv04_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "5 Arkusz danych ewidencyjnych lokali")
            {
                Pobierz_ilosc_tomow("5");
                if (Pobierz_ilosc_setow(5) > 0)
                    wczytaj_pliki_do_lvXX(lv05_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "6 Artykuł matrykuły lub matrykuła")
            {
                Pobierz_ilosc_tomow("6");
                if (Pobierz_ilosc_setow(6) > 0)
                    wczytaj_pliki_do_lvXX(lv06_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "7 Decyzja")
            {
                Pobierz_ilosc_tomow("7");
                if (Pobierz_ilosc_setow(7) > 0)
                    wczytaj_pliki_do_lvXX(lv07_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "8 Dokument inny")
            {
                Pobierz_ilosc_tomow("8");
                if (Pobierz_ilosc_setow(8) > 0)
                    wczytaj_pliki_do_lvXX(lv08_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "9 Dokument wyjściowy")
            {
                Pobierz_ilosc_tomow("9");
                if (Pobierz_ilosc_setow(9) > 0)
                    wczytaj_pliki_do_lvXX(lv09_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "10 Dokumentacja obliczeniowa")
            {
                Pobierz_ilosc_tomow("10");
                if (Pobierz_ilosc_setow(10) > 0)
                    wczytaj_pliki_do_lvXX(lv10_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "11 Dziennik pomiarowy")
            {
                Pobierz_ilosc_tomow("11");
                if (Pobierz_ilosc_setow(11) > 0)
                    wczytaj_pliki_do_lvXX(lv11_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "12 Dziennik robót, prac")
            {
                Pobierz_ilosc_tomow("12");
                if (Pobierz_ilosc_setow(12) > 0)
                    wczytaj_pliki_do_lvXX(lv12_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "13 Księga budynkowa")
            {
                Pobierz_ilosc_tomow("13");
                if (Pobierz_ilosc_setow(13) > 0)
                    wczytaj_pliki_do_lvXX(lv13_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "14 Księga parcel")
            {
                Pobierz_ilosc_tomow("14");
                if (Pobierz_ilosc_setow(14) > 0)
                    wczytaj_pliki_do_lvXX(lv14_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "15 Mapa gleboznawczej klasyfikacji gruntów")
            {
                Pobierz_ilosc_tomow("15");
                if (Pobierz_ilosc_setow(15) > 0)
                    wczytaj_pliki_do_lvXX(lv15_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "16 Mapa inna")
            {
                Pobierz_ilosc_tomow("16");
                if (Pobierz_ilosc_setow(16) > 0)
                    wczytaj_pliki_do_lvXX(lv16_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "17 Mapa katastralna, stanu prawnego")
            {
                Pobierz_ilosc_tomow("17");
                if (Pobierz_ilosc_setow(17) > 0)
                    wczytaj_pliki_do_lvXX(lv17_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "18 Mapa powykonawcza, wynikowa pracy")
            {
                Pobierz_ilosc_tomow("18");
                if (Pobierz_ilosc_setow(18) > 0)
                    wczytaj_pliki_do_lvXX(lv18_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "19 Mapa uzupełniająca")
            {
                Pobierz_ilosc_tomow("19");
                if (Pobierz_ilosc_setow(19) > 0)
                    wczytaj_pliki_do_lvXX(lv19_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "20 Mapa wywiadu")
            {
                Pobierz_ilosc_tomow("20");
                if (Pobierz_ilosc_setow(20) > 0)
                    wczytaj_pliki_do_lvXX(lv20_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "21 Mapa z projektem podziału")
            {
                Pobierz_ilosc_tomow("21");
                if (Pobierz_ilosc_setow(21) > 0)
                    wczytaj_pliki_do_lvXX(lv21_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "22 Mapa z wstępnym projektem podziału")
            {
                Pobierz_ilosc_tomow("22");
                if (Pobierz_ilosc_setow(22) > 0)
                    wczytaj_pliki_do_lvXX(lv22_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "23 Miejscowy plan zagospodarowania przestrzennego")
            {
                Pobierz_ilosc_tomow("23");
                if (Pobierz_ilosc_setow(23) > 0)
                    wczytaj_pliki_do_lvXX(lv23_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "24 Odpowiedź na zgłoszenie pracy geodezyjnej")
            {
                Pobierz_ilosc_tomow("24");
                if (Pobierz_ilosc_setow(24) > 0)
                    wczytaj_pliki_do_lvXX(lv24_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "25 Opinia")
            {
                Pobierz_ilosc_tomow("25");
                if (Pobierz_ilosc_setow(25) > 0)
                    wczytaj_pliki_do_lvXX(lv25_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "26 Opis i mapa, wypis i wyrys")
            {
                Pobierz_ilosc_tomow("26");
                if (Pobierz_ilosc_setow(26) > 0)
                    wczytaj_pliki_do_lvXX(lv26_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "27 Opis topograficzny")
            {
                Pobierz_ilosc_tomow("27");
                if (Pobierz_ilosc_setow(27) > 0)
                    wczytaj_pliki_do_lvXX(lv27_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "28 Orzeczenie, wyrok sądu")
            {
                Pobierz_ilosc_tomow("28");
                if (Pobierz_ilosc_setow(28) > 0)
                    wczytaj_pliki_do_lvXX(lv28_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "29 Oświadczenie")
            {
                Pobierz_ilosc_tomow("29");
                if (Pobierz_ilosc_setow(29) > 0)
                    wczytaj_pliki_do_lvXX(lv29_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "30 Postanowienie")
            {
                Pobierz_ilosc_tomow("30");
                if (Pobierz_ilosc_setow(30) > 0)
                    wczytaj_pliki_do_lvXX(lv30_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "31 Protokół badania księgi wieczystej, odpis")
            {
                Pobierz_ilosc_tomow("31");
                if (Pobierz_ilosc_setow(31) > 0)
                    wczytaj_pliki_do_lvXX(lv31_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "32 Protokół graniczny")
            {
                Pobierz_ilosc_tomow("32");
                if (Pobierz_ilosc_setow(32) > 0)
                    wczytaj_pliki_do_lvXX(lv32_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "33 Protokół inny")
            {
                Pobierz_ilosc_tomow("33");
                if (Pobierz_ilosc_setow(33) > 0)
                    wczytaj_pliki_do_lvXX(lv33_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "34 Protokół katastralny, parcelowy")
            {
                Pobierz_ilosc_tomow("34");
                if (Pobierz_ilosc_setow(34) > 0)
                    wczytaj_pliki_do_lvXX(lv34_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "35 Raport inny")
            {
                Pobierz_ilosc_tomow("35");
                if (Pobierz_ilosc_setow(35) > 0)
                    wczytaj_pliki_do_lvXX(lv35_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "36 Raport pomiarowy rtk/rtn")
            {
                Pobierz_ilosc_tomow("36");
                if (Pobierz_ilosc_setow(36) > 0)
                    wczytaj_pliki_do_lvXX(lv36_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "37 Rejestr archiwalny")
            {
                Pobierz_ilosc_tomow("37");
                if (Pobierz_ilosc_setow(37) > 0)
                    wczytaj_pliki_do_lvXX(lv37_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "38 Rejestr inny")
            {
                Pobierz_ilosc_tomow("38");
                if (Pobierz_ilosc_setow(38) > 0)
                    wczytaj_pliki_do_lvXX(lv38_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "39 Rejestr przed/po scaleniowy")
            {
                Pobierz_ilosc_tomow("39");
                if (Pobierz_ilosc_setow(39) > 0)
                    wczytaj_pliki_do_lvXX(lv39_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "40 Skorowidz/wykaz działek")
            {
                Pobierz_ilosc_tomow("40");
                if (Pobierz_ilosc_setow(40) > 0)
                    wczytaj_pliki_do_lvXX(lv40_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "41 Skorowidz/wykaz właścicieli")
            {
                Pobierz_ilosc_tomow("41");
                if (Pobierz_ilosc_setow(41) > 0)
                    wczytaj_pliki_do_lvXX(lv41_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "42 Spis treści")
            {
                Pobierz_ilosc_tomow("42");
                if (Pobierz_ilosc_setow(42) > 0)
                    wczytaj_pliki_do_lvXX(lv42_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "43 Sprawozdanie techniczne")
            {
                Pobierz_ilosc_tomow("43");
                if (Pobierz_ilosc_setow(43) > 0)
                    wczytaj_pliki_do_lvXX(lv43_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "44 Strona tytułowa")
            {
                Pobierz_ilosc_tomow("44");
                if (Pobierz_ilosc_setow(44) > 0)
                    wczytaj_pliki_do_lvXX(lv44_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "45 Szkic inny")
            {
                Pobierz_ilosc_tomow("45");
                if (Pobierz_ilosc_setow(45) > 0)
                    wczytaj_pliki_do_lvXX(lv45_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "46 Szkic katastralny, podstawowy")
            {
                Pobierz_ilosc_tomow("46");
                if (Pobierz_ilosc_setow(46) > 0)
                    wczytaj_pliki_do_lvXX(lv46_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "47 Szkic osnowy")
            {
                Pobierz_ilosc_tomow("47");
                if (Pobierz_ilosc_setow(47) > 0)
                    wczytaj_pliki_do_lvXX(lv47_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "48 Szkic polowy")
            {
                Pobierz_ilosc_tomow("48");
                if (Pobierz_ilosc_setow(48) > 0)
                    wczytaj_pliki_do_lvXX(lv48_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "49 Szkic przeglądowy")
            {
                Pobierz_ilosc_tomow("49");
                if (Pobierz_ilosc_setow(49) > 0)
                    wczytaj_pliki_do_lvXX(lv49_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "50 Transformacja punktów")
            {
                Pobierz_ilosc_tomow("50");
                if (Pobierz_ilosc_setow(50) > 0)
                    wczytaj_pliki_do_lvXX(lv50_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "51 Ugoda")
            {
                Pobierz_ilosc_tomow("51");
                if (Pobierz_ilosc_setow(51) > 0)
                    wczytaj_pliki_do_lvXX(lv51_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "52 Upoważnienie, pełnomocnictwo")
            {
                Pobierz_ilosc_tomow("52");
                if (Pobierz_ilosc_setow(52) > 0)
                    wczytaj_pliki_do_lvXX(lv52_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "53 Wniosek inny")
            {
                Pobierz_ilosc_tomow("53");
                if (Pobierz_ilosc_setow(53) > 0)
                    wczytaj_pliki_do_lvXX(lv53_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "54 Wniosek o przyjęcie dokumentacji do zasobu")
            {
                Pobierz_ilosc_tomow("54");
                if (Pobierz_ilosc_setow(54) > 0)
                    wczytaj_pliki_do_lvXX(lv54_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "55 Wykaz synchronizacyjny")
            {
                Pobierz_ilosc_tomow("55");
                if (Pobierz_ilosc_setow(55) > 0)
                    wczytaj_pliki_do_lvXX(lv55_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "56 Wykaz współrzędnych")
            {
                Pobierz_ilosc_tomow("56");
                if (Pobierz_ilosc_setow(56) > 0)
                    wczytaj_pliki_do_lvXX(lv56_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "57 Wykaz wywłaszczeniowy")
            {
                Pobierz_ilosc_tomow("57");
                if (Pobierz_ilosc_setow(57) > 0)
                    wczytaj_pliki_do_lvXX(lv57_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "58 Wykaz zmian danych ewidencyjnych")
            {
                Pobierz_ilosc_tomow("58");
                if (Pobierz_ilosc_setow(58) > 0)
                    wczytaj_pliki_do_lvXX(lv58_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "59 Zarys katastralny")
            {
                Pobierz_ilosc_tomow("59");
                if (Pobierz_ilosc_setow(59) > 0)
                    wczytaj_pliki_do_lvXX(lv59_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "60 Zarys pomiarowy")
            {
                Pobierz_ilosc_tomow("60");
                if (Pobierz_ilosc_setow(60) > 0)
                    wczytaj_pliki_do_lvXX(lv60_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "61 Zaświadczenie")
            {
                Pobierz_ilosc_tomow("61");
                if (Pobierz_ilosc_setow(61) > 0)
                    wczytaj_pliki_do_lvXX(lv61_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "62 Zawiadomienie o wykonaniu zgłoszonych prac")
            {
                Pobierz_ilosc_tomow("62");
                if (Pobierz_ilosc_setow(62) > 0)
                    wczytaj_pliki_do_lvXX(lv62_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "63 Zawiadomienie z wydziału kw")
            {
                Pobierz_ilosc_tomow("63");
                if (Pobierz_ilosc_setow(63) > 0)
                    wczytaj_pliki_do_lvXX(lv63_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "64 Zawiadomienie, powiadomienie")
            {
                Pobierz_ilosc_tomow("64");
                if (Pobierz_ilosc_setow(64) > 0)
                    wczytaj_pliki_do_lvXX(lv64_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "65 Zgłoszenie pracy geodezyjnej")
            {
                Pobierz_ilosc_tomow("65");
                if (Pobierz_ilosc_setow(65) > 0)
                    wczytaj_pliki_do_lvXX(lv65_toperat_pliki);
            }
            if (CB_rodzaj_dok.SelectedItem == "66 Zwrotne potwierdzenie odbioru")
            {
                Pobierz_ilosc_tomow("66");
                if (Pobierz_ilosc_setow(66) > 0)
                    wczytaj_pliki_do_lvXX(lv66_toperat_pliki);
            }



        }
      
        public void wczytaj_pliki_do_lvXX(List<row_toperat_str> lvXX)
        {
            int licznik_lv_obiekt = 0;
            string tom_z_dokument = "0";
            string set_z_dokument = "0";
            lv1.Clear();
            _loger.Info("Wyczyszczenie listy");
            _loger.Info("Wczytanie do listy obiektow z " + lvXX);

            DataTable table = new DataTable("Orders");
            table.Columns.Add("ImageIndex", typeof(Int32));
            table.Columns.Add("Text", typeof(string));
            table.Columns.Add("Tag", typeof(string));


            foreach (row_toperat_str lv_obiekt in lvXX)
            {
                string path_to_jpg = lv_obiekt.Nazwa.ToLower().Replace("pdf", "jpg");
                
                fi = new FileInfo(path_to_jpg);
                FileInfo fileinfo = new FileInfo(path_to_jpg);
                
                if (tom_z_dokument == "0")
                {
                    tom_z_dokument = lv_obiekt.Tom;
                    cb_TomCombo.SelectedItem = lv_obiekt.Tom;
                }
                if (set_z_dokument == "0")
                {
                    set_z_dokument = lv_obiekt.Idset.ToString();
                    cb_SetCombo.SelectedItem = lv_obiekt.Idset;
                }


                if (File.Exists(fi.FullName))
                {
                    if (lv_obiekt.Tom == cb_TomCombo.SelectedItem.ToString()) 
                    {
                        if (lv_obiekt.Idset.ToString() == cb_SetCombo.SelectedItem.ToString())
                        {
                            using (FileStream stream = new FileStream(fi.FullName, FileMode.Open, FileAccess.Read))
                            {
                                myImageListLarge_P1.Images.Add(Image.FromStream(stream).GetThumbnailImage(50, 50, new Image.GetThumbnailImageAbort(() => false), IntPtr.Zero));
                                _loger.Info("Wczytanie pliku : " + fi.FullName);
                            }
                            lv1.LargeImageList = myImageListLarge_P1;

                            DataRow newRow = table.NewRow();
                            newRow["ImageIndex"] = lv_obiekt.Indexinset;
                            newRow["Text"] = Path.GetFileName(lv_obiekt.Nazwa).Replace("pdf", "jpg");
                            newRow["Tag"] = lv_obiekt.Nazwa;

                            // Add the row to the rows collection.
                            table.Rows.Add(newRow);
    
                        }
                    }
                }

                if (lv1.Items.Count > 0)
                {
                    lv1.Items[0].Selected = true;
                    lv1.Select();
                    if (licznik_lv_obiekt == 0) 
                    {
                        show_file_info(lv_obiekt);
                    }
                    licznik_lv_obiekt++;
                }
            }

            DataRow[] foundRows;

            // Use the Select method to find all rows matching the filter.
            foundRows = table.Select("Text is not null", "ImageIndex");

            // Print column 0 of each returned row.
            for (int i = 0; i < foundRows.Length; i++)
            {
                // Console.WriteLine(foundRows[i][2]);
                
                lv1.Items.Add(new ListViewItem
                {
                    ImageIndex = Int32.Parse(foundRows[i][0].ToString()),
                    Text = foundRows[i][1].ToString(),
                    Tag = foundRows[i][2]
                });

                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
                

        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------
        public void wczytaj_pliki_do_lvXX_po_tom(List<row_toperat_str> lvXX)
        {
            _loger.Info("Wczytanie do listy obiektow po zmianie tomu");
            lv1.Clear();

            DataTable table = new DataTable("Orders");
            table.Columns.Add("ImageIndex", typeof(Int32));
            table.Columns.Add("Text", typeof(string));
            table.Columns.Add("Tag", typeof(string));
            int licznik_lv_obiekt = 0;


            if (cb_SetCombo.Items.Count > 1)
            {
                foreach (row_toperat_str lv_obiekt in lvXX)
                {
                    string path_to_jpg = lv_obiekt.Nazwa.ToLower().Replace("pdf", "jpg");

                    fi = new FileInfo(path_to_jpg);
                    FileInfo fileinfo = new FileInfo(path_to_jpg);

                    if (File.Exists(fi.FullName))
                    {
                        if (lv_obiekt.Tom == cb_TomCombo.SelectedItem.ToString())
                        {
                            if (lv_obiekt.Idset.ToString() == cb_SetCombo.SelectedItem.ToString())
                            {
                                using (FileStream stream = new FileStream(fi.FullName, FileMode.Open, FileAccess.Read))
                                {
                                    myImageListLarge_P1.Images.Add(Image.FromStream(stream).GetThumbnailImage(50, 50, new Image.GetThumbnailImageAbort(() => false), IntPtr.Zero));
                                    _loger.Info("Wczytanie pliku : " + fi.FullName);
                                }

                                lv1.LargeImageList = myImageListLarge_P1;
                                DataRow newRow = table.NewRow();
                                newRow["ImageIndex"] = lv_obiekt.Indexinset;
                                newRow["Text"] = Path.GetFileName(lv_obiekt.Nazwa).Replace("pdf", "jpg");
                                newRow["Tag"] = lv_obiekt.Nazwa;

                                // Add the row to the rows collection.
                                table.Rows.Add(newRow);
                            }
                        }
                    }

                    if (lv1.Items.Count > 0)
                    {
                        lv1.Items[0].Selected = true;
                        lv1.Select();
                        if (licznik_lv_obiekt == 0)
                        {
                            show_file_info(lv_obiekt);
                        }
                        licznik_lv_obiekt++;
                    }
                }
                DataRow[] foundRows;

                // Use the Select method to find all rows matching the filter.
                foundRows = table.Select("Text is not null", "ImageIndex");

                // Print column 0 of each returned row.
                for (int i = 0; i < foundRows.Length; i++)
                {
                    // Console.WriteLine(foundRows[i][2]);

                    lv1.Items.Add(new ListViewItem
                    {
                        ImageIndex = Int32.Parse(foundRows[i][0].ToString()),
                        Text = foundRows[i][1].ToString(),
                        Tag = foundRows[i][2]
                    });

                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                }
            }
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------------------------------------------------
        public void wczytaj_pliki_do_lvXX_po_set(List<row_toperat_str> lvXX)
        {
            _loger.Info("Wczytanie do listy obiektow po zmianie seta");
            lv1.Clear();
            int licznik_lv_obiekt = 0;

            DataTable table = new DataTable("Orders");
            table.Columns.Add("ImageIndex", typeof(Int32));
            table.Columns.Add("Text", typeof(string));
            table.Columns.Add("Tag", typeof(string));

            if (cb_TomCombo.Items.Count > 0)
            {
                foreach (row_toperat_str lv_obiekt in lvXX)
                {
                    string path_to_jpg = lv_obiekt.Nazwa.ToLower().Replace("pdf", "jpg");

                    fi = new FileInfo(path_to_jpg);
                    FileInfo fileinfo = new FileInfo(path_to_jpg);

                    if (File.Exists(fi.FullName))
                    {
                        if (lv_obiekt.Tom == cb_TomCombo.SelectedItem.ToString())
                        {
                            if (lv_obiekt.Idset.ToString() == cb_SetCombo.SelectedItem.ToString())
                            {
                                using (FileStream stream = new FileStream(fi.FullName, FileMode.Open, FileAccess.Read))
                                {
                                    myImageListLarge_P1.Images.Add(Image.FromStream(stream).GetThumbnailImage(50, 50, new Image.GetThumbnailImageAbort(() => false), IntPtr.Zero));
                                    _loger.Info("Wczytanie pliku : " + fi.FullName);
                                }

                                lv1.LargeImageList = myImageListLarge_P1;
                                DataRow newRow = table.NewRow();
                                newRow["ImageIndex"] = lv_obiekt.Indexinset;
                                newRow["Text"] = Path.GetFileName(lv_obiekt.Nazwa).Replace("pdf", "jpg");
                                newRow["Tag"] = lv_obiekt.Nazwa;
                                // Add the row to the rows collection.
                                table.Rows.Add(newRow);
                            }
                        }
                    }

                    if (lv1.Items.Count > 0)
                    {
                        lv1.Items[0].Selected = true;
                        lv1.Select();
                        if (licznik_lv_obiekt == 0)
                        {
                            show_file_info(lv_obiekt);
                        }
                        licznik_lv_obiekt++;
                    }
                }

                DataRow[] foundRows;
                foundRows = table.Select("Text is not null", "ImageIndex");
                for (int i = 0; i < foundRows.Length; i++)
                {
                    lv1.Items.Add(new ListViewItem
                    {
                        ImageIndex = Int32.Parse(foundRows[i][0].ToString()),
                        Text = foundRows[i][1].ToString(),
                        Tag = foundRows[i][2]
                    });

                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                }
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------
        public int Pobierz_ilosc_setow(int nr_dokumentu)
        {
            _loger.Info("Pobranie ilości setów");
            var con = polacz_z_baza();

            NpgsqlCommand cmd = new NpgsqlCommand(string.Format(@"select distinct idset from pandora.toperatpliki where idoperat in (select idoperat from pandora.toperat where numer like '{0}') and idcategory = {1};", lOperatNr.Text, nr_dokumentu ), con);
            NpgsqlDataReader rows_toperatpliki = cmd.ExecuteReader();

            cb_SetCombo.Items.Clear();

            while (rows_toperatpliki.Read())
            {
                cb_SetCombo.Items.Add(rows_toperatpliki[0].ToString());
            }

            con.Close();

            if (cb_SetCombo.Items.Count > 1)
            {
                cb_SetCombo.SelectedIndex = 0;
                cb_SetCombo.Enabled = true;
            }
            else if (cb_SetCombo.Items.Count < 1)
            {
                cb_SetCombo.Enabled = false;
            }
            else
            {
                cb_SetCombo.SelectedIndex = 0;
                cb_SetCombo.Enabled = false;
            }

            return cb_SetCombo.Items.Count;
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------
        public void show_file_info(row_toperat_str lv_obiekt) 
        {
            TB_id_set.Text = lv_obiekt.Idset.ToString();
            TB_numer_set.Text = lv_obiekt.Setnumber;
            TB_index_set.Text = lv_obiekt.Indexinset.ToString();
            TB_Tom.Text = lv_obiekt.Tom;
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------
        private void button2_Click(object sender, EventArgs e)
        {
            if (lv1.SelectedItems.Count > 0 && lv1.Visible == true)
            {
                przenies_do_zrodlowych(lv1, ref count_p1);
               // usun_plik_z_bazy(lv1); 
            }

            lb_iloscs_stron.Text = listViewFile.Items.Count.ToString();
            lb_indeksacja.Text = zlicz_zaindeksowane().ToString();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------
        // Przenoszenie plik do dokumentów nie zkategoryzowanych 
        public void przenies_do_zrodlowych(ListView listV ,ref int count_px)
        {
            using (FileStream stream = new FileStream(listV.SelectedItems[0].Tag.ToString().Replace("pdf","jpg"), FileMode.Open, FileAccess.Read))
            {
                myImageListLarge.Images.Add(Image.FromStream(stream));
            }

            try 
            {
                listViewFile.Items.Add(new ListViewItem
                {
                    ImageIndex = count,
                    Text = listV.SelectedItems[0].Text,
                    Tag = listV.SelectedItems[0].Tag
                });

                usun_plik_z_bazy(listV.SelectedItems[0].Text.Replace("jpg","pdf"));
                
                count++;
                count_px--;
                for (int i = listV.Items.Count - 1; i >= 0; i--)
                {
                    if (listV.Items[i].Selected)
                    {
                        listV.Items[i].Remove();
                    }
                }
            }
            catch
            {
                MessageBox.Show(String.Format("Nie udało się przenieść plku {0} do listy źródłowej", listV.SelectedItems[0].Text.ToString()), "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------
        public void usun_plik_z_bazy(string file_to_dell)
        {
            int id_pliku = 0;
            var con_1 = polacz_z_baza();

            NpgsqlCommand cmd = new NpgsqlCommand(string.Format("select id from pandora.toperatpliki where idoperat in (select idoperat from pandora.toperat where numer like '{0}') and LOWER (nazwa) like '%{1}%';", lOperatNr.Text,  file_to_dell.ToLower()), con_1);
            NpgsqlDataReader row_toperat = cmd.ExecuteReader();
            while (row_toperat.Read())
            {
                id_pliku =Int32.Parse( row_toperat[0].ToString());
            }
            con_1.Close();

            var con_2 = polacz_z_baza();
            //cmd = new NpgsqlCommand(string.Format("INSERT INTO pandora.toperatpliki (idoperat,nazwa, idcategory, idset, setnumber, timeofmodified, indexinset, idjpg, tom) VALUES({0},'{1}',{2},{3},{4},'{5}',{6},{7},{8});", idoperat, Tag.Replace("JPG", "pdf"), rodzaj_dokumentu, Int32.Parse(TB_id_set.Text), TB_numer_set.Text, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), index_in_set_to_insert, idjpg, TB_Tom.Text), con);
            cmd = new NpgsqlCommand(string.Format("delete from pandora.toperatpliki where id = {0}", id_pliku), con_2);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show(string.Format("delete from pandora.toperatpliki where id = {0}", id_pliku.ToString()), "Błąd kasowania dannych bazy.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con_2.Close();
        }
//------------------------------------------------------------------------------------------------------
        // Przycisk ossługujący gebterowanie dokumentu XML 
        private void BT_Crt_PDF_Click(object sender, EventArgs e)
        {
            _loger.Info("Zaczynam generowanie PDF");
            if (rb_DokKat.Checked)
            {
                if (Int32.TryParse(tb_rok.Text, out int numValue) || tb_rok.Text == "bez_rocznika")
                {
                    int rok_aktu = Int32.Parse(DateTime.Now.Date.ToString("yyyy"));
                    if ((numValue > 1800 && rok_aktu >= numValue) || tb_rok.Text == "bez_rocznika")
                    {
                        if ( Int32.TryParse(tb_nr_w_roku.Text, out int tb_nr_w_r))
                        {
                            if (tb_nr_w_r > 0)
                            {
                                Regex rgx = new Regex(@"^[0-9]{6}_[0-9]{1}\.[0-9]{4}");
                                if (rgx.IsMatch(tb_teryt.Text))
                                {
                                    po_but_gemetuj();
                                }
                                else
                                {
                                    MessageBox.Show("Podaj prawidłowy nr TERYT !!!", "ERR");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Podaj prawidłową wartość /n w polu Nr w roku !!!", "ERR");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Podaj prawidłową wartość /n w polu Nr w roku !!!", "ERR");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wpisz poprawny rok lub bez_rocznika !!!", "ERR");
                    }
                }
            }
            else
            {
                po_but_gemetuj();
            }
        }
//------------------------------------------------------------------------------------------------------
        public void po_but_gemetuj()
        {
            if (Directory.Exists(tb_path_pdf_out.Text))
            {

                CreatePDF_4(lOperatNr.Text);

                polacz_pliki_wileostr();
                pb_gen_PDF.PerformStep();

                przenumeruj_PG();
                MessageBox.Show("Ekspoert PDF zakonczony.", "Info");

              
            }
            else
            {
                MessageBox.Show("Wskazany katalog nie istnieje !!!\nProszę wskazać istniejący katalog.", "Info");
            }
        }

//----------------------------------------------------------------------------------------------------------------------------------
        
        public void CreatePDF_4(string numer_operatu)
        {
            int id_operat = 0;
            // Odczytnie numeru operatu 
            var con = polacz_z_baza();
            NpgsqlCommand cmd = new NpgsqlCommand(string.Format(@"select idoperat from pandora.toperat where numer  like '{0}'", lOperatNr.Text), con);
            NpgsqlDataReader operat_sql = cmd.ExecuteReader();

            while (operat_sql.Read())
            {
                id_operat = Int32.Parse(operat_sql[0].ToString());
            }
            con.Close();
            // Display the ProgressBar control.
            pb_gen_PDF.Visible = true;
            // Set Minimum to 1 to represent the first file being copied.
            pb_gen_PDF.Minimum = 1;
            // Set Maximum to the total number of files to copy.
            
            con = polacz_z_baza();
            cmd = new NpgsqlCommand(string.Format(@"select count (*) from pandora.toperatpliki t2  where idoperat = {0}", id_operat), con);
            NpgsqlDataReader sql_ilosc_plikow = cmd.ExecuteReader();

            int ilosc_plikow =0;

            while (sql_ilosc_plikow.Read())
            {
                ilosc_plikow = Int32.Parse( sql_ilosc_plikow[0].ToString())+1;
            }
            con.Close();

            pb_gen_PDF.Maximum = ilosc_plikow;
            // Set the initial value of the ProgressBar.
            pb_gen_PDF.Value = 1;
            // Set the Step property to a value of 1 to represent each file being copied.
            pb_gen_PDF.Step = 1;
            
            // Odczytanie tomów 
            if (id_operat != 0)
            {
                List<int> tomy = new List<int>();
                con = polacz_z_baza();
                cmd = new NpgsqlCommand(string.Format(@"select distinct tom from pandora.toperatpliki where idoperat ={0}", id_operat), con);
                NpgsqlDataReader sql_tomy = cmd.ExecuteReader();

                while (sql_tomy.Read())
                {
                    tomy.Add(Int32.Parse(sql_tomy[0].ToString()));
                }
                con.Close();
                // Odczytanie setów   
                foreach (int tom in tomy)
                {
                    List<int> sety = new List<int>();
                    con = polacz_z_baza();
                    cmd = new NpgsqlCommand(string.Format(@"select distinct idset from pandora.toperatpliki where idoperat ={0} and tom like '{1}';", id_operat, tom), con);
                    NpgsqlDataReader sql_sety = cmd.ExecuteReader();

                    while (sql_sety.Read())
                    {
                        sety.Add(Int32.Parse(sql_sety[0].ToString()));
                    }
                    con.Close();

                    // Odczytanie typów stron dokumentu 
                    foreach (int set in sety)
                    {
                        List<int> kategorie = new List<int>();
                        con = polacz_z_baza();
                        //cmd = new NpgsqlCommand(string.Format(@"select distinct idcategory from pandora.toperatpliki where idoperat = {0} and tom like '{1}' and idset = {2}; ", id_operat, tom, set), con);
                        cmd = new NpgsqlCommand(string.Format(@"SELECT c.idcategory	FROM ( select distinct idcategory from pandora.toperatpliki where idoperat = {0} and tom like '{1}' and idset = {2}) c JOIN   unnest('{{44,42,43,65,24,54,12,32,66,31,34,33,10,36,50,11,49,48,47,45,46,60,59,20,21,22,19,18,15,26,17,16,56,58,55,57,53,7,28,51,1,2,37,39,38,40,41,4,5,52,29,25,30,61,62,63,64,3,6,27,23,13,14,35,8,9}}'::int[]) WITH ORDINALITY t(idcategory, ord) USING (idcategory)	ORDER  BY t.ord; ", id_operat, tom, set), con);
                        NpgsqlDataReader sql_kategorie = cmd.ExecuteReader();

                        while (sql_kategorie.Read())
                        {
                            kategorie.Add(Int32.Parse(sql_kategorie[0].ToString()));
                        }
                        con.Close();
                        richTextBox1.Text = "";
                        foreach (int kategoria in kategorie)
                        {
                            List<string> lista_stron = new List<string>();
                            con = polacz_z_baza();
                            cmd = new NpgsqlCommand(string.Format(@"select nazwa from pandora.toperatpliki where idoperat ={0} and tom like '{1}' and idset = {2} and idcategory = {3}; ", id_operat, tom, set, kategoria), con);
                            NpgsqlDataReader strony_dla_kategorii = cmd.ExecuteReader();

                            while (strony_dla_kategorii.Read())
                            {
                                lista_stron.Add(strony_dla_kategorii[0].ToString().Replace("pdf","JPG"));
                                richTextBox1.Text += strony_dla_kategorii[0].ToString();
                                pb_gen_PDF.Value++;
                            }
                            con.Close();
                            pdf_do_4_str(lista_stron, kategoria);
                        }
                    }
                }
                pb_gen_PDF.Value = 1;
            }
        }
        //----------------------------------------------------------------------------------------------------------------------
        public void pdf_do_4_str(List<string> lista_stron, int kategoria)
         {
             if (lista_stron.Count > 0)
             {
                 _loger.Info("Pdf do 4 stron");
                 if (lista_stron.Count < 5)
                 {
                     // dokumnety jednostronicowe

                     if (kategoria == 45 || kategoria == 46 || kategoria == 47 || kategoria == 48 || kategoria == 49 || kategoria == 15 || kategoria == 16 || kategoria == 17 || kategoria == 18 || kategoria == 19 || kategoria == 20 || kategoria == 21 || kategoria == 22 || kategoria == 59 || kategoria == 60)
                     {
                         _loger.Info("Pdf jednostronicowy");
                         do_pdf_jednostr(1, lista_stron.Count, 1, kategoria, lista_stron);
                     }
                     // dokumenty wielostronicowe 
                     else
                     {
                         licz_dokument++;
                         _loger.Info("Pdf wielostronicowy");
                         do_pdf(1, lista_stron.Count, 1, kategoria, lista_stron);
                     }
                 }

                 else
                 {
                     _loger.Info("Pdf ponad  4 strony");
                     float dziel = lista_stron.Count / 4;
                     float dziel_mod = lista_stron.Count % 4;

                     if (dziel_mod == 0)
                     {
                         int aaa = 0;
                         for (int i = 0; i < dziel - 1; i++)
                         {
                            if (kategoria == 45 || kategoria == 46 || kategoria == 47 || kategoria == 48 || kategoria == 49 || kategoria == 15 || kategoria == 16 || kategoria == 17 || kategoria == 18 || kategoria == 19 || kategoria == 20 || kategoria == 21 || kategoria == 22 || kategoria == 59 || kategoria == 60)
                            {
                                 _loger.Info("Pdf jednostronicowy");
                                 do_pdf_jednostr(1 + (4 * i), (4 * i) + 4, i + 1, kategoria, lista_stron);
                             }
                             // dokumenty wielostronicowe 
                             else
                             {
                                 if (i ==0)
                                     licz_dokument++;
                                 _loger.Info("Pdf wielostronicowy");
                                 do_pdf(1 + (4 * i), (4 * i) + 4, i + 1, kategoria, lista_stron);
                             }
                             aaa = i;
                         }
                         aaa++;
                         if (kategoria == 45 || kategoria == 46 || kategoria == 47 || kategoria == 48 || kategoria == 49 || kategoria == 15 || kategoria == 16 || kategoria == 17 || kategoria == 18 || kategoria == 19 || kategoria == 20 || kategoria == 21 || kategoria == 22 || kategoria == 59 || kategoria == 60)
                         { 
                             do_pdf_jednostr(1 + (4 * aaa), lista_stron.Count, aaa + 1, kategoria, lista_stron);
                         }
                         // dokumenty wielostronicowe 
                         else
                         {
                             do_pdf(1 + (4 * aaa), lista_stron.Count, aaa + 1, kategoria, lista_stron);
                         }
                     }
                     else
                     {
                         int aaa = 0;
                         for (int i = 0; i < dziel; i++)
                         {
                            if (kategoria == 45 || kategoria == 46 || kategoria == 47 || kategoria == 48 || kategoria == 49 || kategoria == 15 || kategoria == 16 || kategoria == 17 || kategoria == 18 || kategoria == 19 || kategoria == 20 || kategoria == 21 || kategoria == 22 || kategoria == 59 || kategoria == 60)
                            {
                                 _loger.Info("Pdf jednostronicowy");
                                 do_pdf_jednostr(1 + (4 * i), (4 * i) + 4, i + 1, kategoria, lista_stron);
                             }
                             // dokumenty wielostronicowe 
                             else
                             {
                                 if (i==0)
                                     licz_dokument++;
                                 _loger.Info("Pdf wielostronicowy");
                                 do_pdf(1 + (4 * i), (4 * i) + 4, i + 1, kategoria, lista_stron);
                             }

                             aaa = i;
                         }
                         aaa++;

                        if (kategoria == 45 || kategoria == 46 || kategoria == 47 || kategoria == 48 || kategoria == 49 || kategoria == 15 || kategoria == 16 || kategoria == 17 || kategoria == 18 || kategoria == 19 || kategoria == 20 || kategoria == 21 || kategoria == 22 || kategoria == 59 || kategoria == 60)
                        {
                             _loger.Info("Pdf jednostronicowy");
                             do_pdf_jednostr(1 + (4 * aaa), lista_stron.Count, aaa + 1, kategoria, lista_stron);
                         }
                         // dokumenty wielostronicowe 
                         else
                         {
                             _loger.Info("Pdf wielostronicowy");
                             do_pdf(1 + (4 * aaa), lista_stron.Count, aaa + 1, kategoria, lista_stron);
                         }
                     }
                 }
             }
         }
        

        //------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public void polacz_pliki_wileostr()
        {

            if (rb_DokKat.Checked)
            {
                if (tb_rok.Text == "bez_rocznika")
                    laczenie_plikow(tb_path_pdf_out.Text + @"\" + tb_rok.Text + @"\" + cb_typ_dok_kat.SelectedItem);
                else
                    laczenie_plikow(tb_path_pdf_out.Text + @"\R" + tb_rok.Text + @"\" + cb_typ_dok_kat.SelectedItem);
            }
            else
            {
                laczenie_plikow(tb_path_pdf_out.Text + @"\" + dir_name);
            }
        }
//----------------------------------------------------------------------------------------------------------------------------------------------------------
        public void laczenie_plikow ( string path)
        {
             string[] lista_plikow = Directory.GetFiles(path);
             List<string> lista_plik_do_lacz = new List<string>();

            // wyszuaj pliki do łaczenia 
            foreach (string plik in lista_plikow)
            {
                if (plik.Contains("#"))
                {
                    if (rb_DokKat.Checked)
                    {
                        lista_plik_do_lacz.Add(plik.Split('#')[0]);
                    }
                    else
                    {
                        lista_plik_do_lacz.Add(plik.Split('#')[0]);
                    }
                    
                }
            }

            var lista_plik_do_lacz_dist = lista_plik_do_lacz.GroupBy(x => x).Select(y => y.First());

            foreach (string plik_czesc_naz in lista_plik_do_lacz_dist)
            {
                bool merged = true;
                string plik_czesc_naz_01;
                if (rb_DokKat.Checked)
                {
                    plik_czesc_naz_01 = plik_czesc_naz+"_1.pdf";
                }
                else
                {
                    plik_czesc_naz_01 = plik_czesc_naz + "001.pdf";
                }

                using (FileStream stream = new FileStream(plik_czesc_naz_01, FileMode.Create))
                {
                    iTextSharp.text.Document document = new iTextSharp.text.Document();
                    PdfCopy pdf = new PdfCopy(document, stream);
                    PdfReader reader = null;
                    try
                    {
                        document.Open();
                        foreach (string plik in lista_plikow)
                        {
                            if (plik.Contains(plik_czesc_naz))
                            {
                                //richTextBox1.Text += plik + "\n";
                                reader = new PdfReader(plik);
                                pdf.AddDocument(reader);
                                reader.Close();
                            }
                        }
                    }
                    catch (Exception)
                    {
                        merged = false;
                        if (reader != null)
                        {
                            reader.Close();
                        }
                    }
                    finally
                    {
                        if (document != null)
                        {
                            document.Close();
                        }
                    }
                }
                foreach (string plik in lista_plikow)
                {
                    if (plik.Contains(plik_czesc_naz))
                    {
                        File.Delete(plik);
                    }
                }
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------
        public void do_pdf_jednostr(int start, int stop, int part, int kategoria, List<string> lista_stron)
        {
            int intIndex = start - 1;
            while (intIndex < stop)
            {
                _loger.Info("Pdf jednostronicowe dla " + kategoria.ToString());
                Aspose.Pdf.Document doc = new Aspose.Pdf.Document();
                licz_dokument++;
                string rodz_dok;
                rodz_dok = pobierz_rodzaj_dokumentu(kategoria);

                if (intIndex < stop)
                {
                    System.Drawing.Image srcImage = System.Drawing.Image.FromFile(lista_stron[intIndex].ToString());
                    // Read Height of input image
                    int h = srcImage.Height;

                    // Read Height of input image
                    int w = srcImage.Width;

                    // Add an empty page
                    Aspose.Pdf.Page page = doc.Pages.Add();
                    Aspose.Pdf.Image image = new Aspose.Pdf.Image();
                    image.File = (lista_stron[intIndex].ToString());
                    // Set page dimensions and margins
                    page.PageInfo.Height = (h);
                    page.PageInfo.Width = (w);
                    page.PageInfo.Margin.Bottom = (0);
                    page.PageInfo.Margin.Top = (0);
                    page.PageInfo.Margin.Right = (0);
                    page.PageInfo.Margin.Left = (0);
                    page.Paragraphs.Add(image);
                }
                intIndex++;

                if (rb_DokKat.Checked)
                {
                    _loger.Info("Pdf dla kataster");
                    // Dokumenty katastralne 
                    if (tb_rok.Text == "bez_rocznika")
                    {
                        if (!Directory.Exists(tb_path_pdf_out.Text + @"\" + tb_rok.Text + @"\" + cb_typ_dok_kat.SelectedItem))
                        {
                            // Try to create the directory.
                            DirectoryInfo di = Directory.CreateDirectory(tb_path_pdf_out.Text + @"\" + tb_rok.Text + @"\" + cb_typ_dok_kat.SelectedItem);
                        }

                        doc.Save(tb_path_pdf_out.Text + @"\" + tb_rok.Text + @"\" + cb_typ_dok_kat.SelectedItem + @"\" + rodz_dok + tb_teryt.Text + "-N" + tb_nr_w_roku.Text + "_" + intIndex + ".pdf");

                        VerySimpleReplaceText(tb_path_pdf_out.Text + @"\" + tb_rok.Text + @"\" + cb_typ_dok_kat.SelectedItem + @"\" + rodz_dok + tb_teryt.Text + "-N" + tb_nr_w_roku.Text + "_" + intIndex + ".pdf",
                                              tb_path_pdf_out.Text + @"\" + tb_rok.Text + @"\" + cb_typ_dok_kat.SelectedItem + @"\" + rodz_dok + tb_teryt.Text + "-N" + tb_nr_w_roku.Text + "_" + intIndex + "_clr.pdf");
                        File.Delete(tb_path_pdf_out.Text + @"\" + tb_rok.Text + @"\" + cb_typ_dok_kat.SelectedItem + @"\" + rodz_dok + tb_teryt.Text + "-N" + tb_nr_w_roku.Text + "_" + intIndex + ".pdf");
                        System.IO.File.Move(tb_path_pdf_out.Text + @"\" + tb_rok.Text + @"\" + cb_typ_dok_kat.SelectedItem + @"\" + rodz_dok + tb_teryt.Text + "-N" + tb_nr_w_roku.Text + "_" + intIndex + "_clr.pdf",
                                            tb_path_pdf_out.Text + @"\" + tb_rok.Text + @"\" + cb_typ_dok_kat.SelectedItem + @"\" + rodz_dok + tb_teryt.Text + "-N" + tb_nr_w_roku.Text + "_" + intIndex + ".pdf");
                        GC.Collect();
                        GC.WaitForPendingFinalizers();

                    }

                    else
                    {
                        if (!Directory.Exists(tb_path_pdf_out.Text + @"\R" + tb_rok + @"\" + cb_typ_dok_kat.SelectedItem))
                        {
                            // Try to create the directory.
                            DirectoryInfo di = Directory.CreateDirectory(tb_path_pdf_out.Text + @"\R" + tb_rok.Text + @"\" + cb_typ_dok_kat.SelectedItem);
                        }

                        // Save output PDF file
                        if (!Directory.Exists(tb_path_pdf_out.Text + dir_name))
                        {
                            // Try to create the directory.
                            DirectoryInfo di = Directory.CreateDirectory(tb_path_pdf_out.Text + @"\" + dir_name);
                        }
                        doc.Save(tb_path_pdf_out.Text + @"\R" + tb_rok.Text + @"\"
                                                     + cb_typ_dok_kat.SelectedItem + @"\" + rodz_dok + tb_teryt.Text + "-R" + tb_rok.Text + "-N" + tb_nr_w_roku.Text + "_" + intIndex + ".pdf");

                        VerySimpleReplaceText(tb_path_pdf_out.Text + @"\R" + tb_rok.Text + @"\" + cb_typ_dok_kat.SelectedItem + @"\" + rodz_dok + tb_teryt.Text + "-R" + tb_rok.Text + "-N" + tb_nr_w_roku.Text + "_" + intIndex + ".pdf",
                                              tb_path_pdf_out.Text + @"\R" + tb_rok.Text + @"\" + cb_typ_dok_kat.SelectedItem + @"\" + rodz_dok + tb_teryt.Text + "-R" + tb_rok.Text + "-N" + tb_nr_w_roku.Text + "_" + intIndex + "_clr.pdf");
                        File.Delete(tb_path_pdf_out.Text + @"\R" + tb_rok.Text + @"\" + cb_typ_dok_kat.SelectedItem + @"\" + rodz_dok + tb_teryt.Text + "-R" + tb_rok.Text + "-N" + tb_nr_w_roku.Text + "_" + intIndex + ".pdf");
                        System.IO.File.Move(tb_path_pdf_out.Text + @"\R" + tb_rok.Text + @"\" + cb_typ_dok_kat.SelectedItem + @"\" + rodz_dok + tb_teryt.Text + "-R" + tb_rok.Text + "-N" + tb_nr_w_roku.Text + "_" + intIndex + "_clr.pdf",
                                            tb_path_pdf_out.Text + @"\R" + tb_rok.Text + @"\" + cb_typ_dok_kat.SelectedItem + @"\" + rodz_dok + tb_teryt.Text + "-R" + tb_rok.Text + "-N" + tb_nr_w_roku.Text + "_" + intIndex + ".pdf");
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                    }
                }
                else
                {
                    _loger.Info("Pdf  dla operat");
                    // Nie  kataster 
                    // Save output PDF file
                    if (!Directory.Exists(tb_path_pdf_out.Text + dir_name))
                    {
                        // Try to create the directory.
                        DirectoryInfo di = Directory.CreateDirectory(tb_path_pdf_out.Text + @"\" + dir_name);
                    }

                    doc.Save(tb_path_pdf_out.Text + @"\" + dir_name + @"\" + dir_name + "_" + licz_dokument + rodz_dok + intIndex + ".pdf");
                    VerySimpleReplaceText(tb_path_pdf_out.Text + @"\" + dir_name + @"\" + dir_name + "_" + licz_dokument + rodz_dok + intIndex + ".pdf", tb_path_pdf_out.Text + @"\" + dir_name + @"\" + dir_name + "_" + licz_dokument + rodz_dok + intIndex + "_clr.pdf");
                    File.Delete(tb_path_pdf_out.Text + @"\" + dir_name + @"\" + dir_name + "_" + licz_dokument + rodz_dok + intIndex + ".pdf");

                    if (intIndex < 10)
                    {
                        System.IO.File.Move(tb_path_pdf_out.Text + @"\" + dir_name + @"\" + dir_name + "_" + licz_dokument + rodz_dok + intIndex + "_clr.pdf", tb_path_pdf_out.Text + @"\" + dir_name + @"\" + dir_name + "_" + licz_dokument + rodz_dok + "00" + intIndex + ".pdf");
                    }
                    else if (intIndex > 9 && intIndex < 100)
                    {
                        System.IO.File.Move(tb_path_pdf_out.Text + @"\" + dir_name + @"\" + dir_name + "_" + licz_dokument + rodz_dok + intIndex + "_clr.pdf", tb_path_pdf_out.Text + @"\" + dir_name + @"\" + dir_name + "_" + licz_dokument + rodz_dok + "0" + intIndex + ".pdf");
                    }
                    else if (intIndex > 99 && intIndex < 1000)
                    {
                        System.IO.File.Move(tb_path_pdf_out.Text + @"\" + dir_name + @"\" + dir_name + "_" + licz_dokument + rodz_dok + intIndex + "_clr.pdf", tb_path_pdf_out.Text + @"\" + dir_name + @"\" + dir_name + "_" + licz_dokument + rodz_dok + intIndex + ".pdf");
                    }
                }
            }
        }


        //--------------------------------------------------------------------------------------------------------------------------------------------------
        public void do_pdf(int start, int stop, int part, int kategoria , List<string> lista_stron)
        {
            _loger.Info("Pdf wielostronicowe dla " + kategoria);
            Aspose.Pdf.Document doc = new Aspose.Pdf.Document();
            int intIndex = start -1;
            string rodz_dok;
            rodz_dok = pobierz_rodzaj_dokumentu(kategoria);

            while (intIndex < stop)
            {
                if (intIndex < stop)
                {
                    System.Drawing.Image srcImage = System.Drawing.Image.FromFile(lista_stron[intIndex].ToString());
                    // Read Height of input image
                    int h = srcImage.Height;

                    // Read Height of input image
                    int w = srcImage.Width;

                    // Add an empty page
                    Aspose.Pdf.Page page = doc.Pages.Add();
                    Aspose.Pdf.Image image = new Aspose.Pdf.Image();
                    image.File = (lista_stron[intIndex].ToString());
                    // Set page dimensions and margins
                    page.PageInfo.Height = (h);
                    page.PageInfo.Width = (w);
                    page.PageInfo.Margin.Bottom = (0);
                    page.PageInfo.Margin.Top = (0);
                    page.PageInfo.Margin.Right = (0);
                    page.PageInfo.Margin.Left = (0);
                    page.Paragraphs.Add(image);
                }
                intIndex++;
            }

            if (rb_DokKat.Checked)
            {
               if (tb_rok.Text == "bez_rocznika")
                {
                    if (!Directory.Exists(tb_path_pdf_out.Text + @"\" + tb_rok.Text + @"\" + cb_typ_dok_kat.SelectedItem))
                    {
                        // Try to create the directory.
                        DirectoryInfo di = Directory.CreateDirectory(tb_path_pdf_out.Text + @"\" + tb_rok.Text + @"\" + cb_typ_dok_kat.SelectedItem);
                    }
                }
               else
                {
                    if (!Directory.Exists(tb_path_pdf_out.Text + @"\R" + tb_rok + @"\" + cb_typ_dok_kat.SelectedItem))
                    {
                        // Try to create the directory.
                        DirectoryInfo di = Directory.CreateDirectory(tb_path_pdf_out.Text + @"\R" + tb_rok.Text + @"\" + cb_typ_dok_kat.SelectedItem);
                    }
                }
                

                if (tb_rok.Text.Equals("bez_rocznika"))
                {

                    doc.Save(tb_path_pdf_out.Text + @"\" + tb_rok.Text + @"\" + cb_typ_dok_kat.SelectedItem + @"\" + rodz_dok + tb_teryt.Text + "-N" + tb_nr_w_roku.Text + "_" + intIndex + ".pdf");

                    VerySimpleReplaceText(tb_path_pdf_out.Text + @"\" + tb_rok.Text + @"\" + cb_typ_dok_kat.SelectedItem + @"\" + rodz_dok + tb_teryt.Text + "-N" + tb_nr_w_roku.Text + "_" + intIndex + ".pdf",
                                          tb_path_pdf_out.Text + @"\" + tb_rok.Text + @"\" + cb_typ_dok_kat.SelectedItem + @"\" + rodz_dok + tb_teryt.Text + "-N" + tb_nr_w_roku.Text + "_" + intIndex + "_clr.pdf");
                    File.Delete(tb_path_pdf_out.Text + @"\" + tb_rok.Text + @"\" + cb_typ_dok_kat.SelectedItem + @"\" + rodz_dok + tb_teryt.Text + "-N" + tb_nr_w_roku.Text + "_" + intIndex + ".pdf");
                    System.IO.File.Move(tb_path_pdf_out.Text + @"\" + tb_rok.Text + @"\" + cb_typ_dok_kat.SelectedItem + @"\" + rodz_dok + tb_teryt.Text + "-N" + tb_nr_w_roku.Text + "_" + intIndex + "_clr.pdf",
                                        tb_path_pdf_out.Text + @"\" + tb_rok.Text + @"\" + cb_typ_dok_kat.SelectedItem + @"\" + rodz_dok + tb_teryt.Text + "-N" + tb_nr_w_roku.Text + "_" + intIndex + ".pdf");



                    doc.Save(tb_path_pdf_out.Text + @"\" + tb_rok.Text + @"\" + cb_typ_dok_kat.SelectedItem + @"\" + rodz_dok + tb_teryt.Text + "-N" + tb_nr_w_roku.Text + "#" + part + "#" + ".pdf");
                    VerySimpleReplaceText(tb_path_pdf_out.Text + @"\" + tb_rok.Text + @"\" + cb_typ_dok_kat.SelectedItem + @"\" + rodz_dok + tb_teryt.Text + "-N" + tb_nr_w_roku.Text + "#" + part + "#" + ".pdf", 
                                          tb_path_pdf_out.Text + @"\" + tb_rok.Text + @"\" + cb_typ_dok_kat.SelectedItem + @"\" + rodz_dok + tb_teryt.Text + "-N" + tb_nr_w_roku.Text + "#" + part + "#" + "_clr.pdf");
                    File.Delete(tb_path_pdf_out.Text + @"\" + tb_rok.Text + @"\" + cb_typ_dok_kat.SelectedItem + @"\" + rodz_dok + tb_teryt.Text + "-N" + tb_nr_w_roku.Text + "#" + part + "#" + ".pdf");
                    System.IO.File.Move(tb_path_pdf_out.Text + @"\" + tb_rok.Text + @"\" + cb_typ_dok_kat.SelectedItem + @"\" + rodz_dok + tb_teryt.Text + "-N" + tb_nr_w_roku.Text + "#" + part + "#" + "_clr.pdf", 
                                        tb_path_pdf_out.Text + @"\" + tb_rok.Text + @"\" + cb_typ_dok_kat.SelectedItem + @"\" + rodz_dok + tb_teryt.Text + "-N" + tb_nr_w_roku.Text + "#" + part + ".pdf");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                }
                else
                {
                    doc.Save(tb_path_pdf_out.Text + @"\R" + tb_rok.Text + @"\" + cb_typ_dok_kat.SelectedItem + @"\" + rodz_dok + tb_teryt.Text + "-R" + tb_rok.Text + "-N" + tb_nr_w_roku.Text + "#" + part + "#" + ".pdf");
                    VerySimpleReplaceText(tb_path_pdf_out.Text + @"\R" + tb_rok.Text + @"\" + cb_typ_dok_kat.SelectedItem + @"\" + rodz_dok + tb_teryt.Text + "-R" + tb_rok.Text + "-N" + tb_nr_w_roku.Text + "#" + part + "#" + ".pdf", 
                                          tb_path_pdf_out.Text + @"\R" + tb_rok.Text + @"\" + cb_typ_dok_kat.SelectedItem + @"\" + rodz_dok + tb_teryt.Text + "-R" + tb_rok.Text + "-N" + tb_nr_w_roku.Text + "#" + part + "#" + "_clr.pdf");
                    File.Delete(tb_path_pdf_out.Text + @"\R" + tb_rok.Text + @"\" + cb_typ_dok_kat.SelectedItem + @"\" + rodz_dok + tb_teryt.Text + "-R" + tb_rok.Text + "-N" + tb_nr_w_roku.Text + "#" + part + "#" + ".pdf");
                    System.IO.File.Move(tb_path_pdf_out.Text + @"\R" + tb_rok.Text + @"\" + cb_typ_dok_kat.SelectedItem + @"\" + rodz_dok + tb_teryt.Text + "-R" + tb_rok.Text + "-N" + tb_nr_w_roku.Text + "#" + part + "#" + "_clr.pdf", 
                                        tb_path_pdf_out.Text + @"\R" + tb_rok.Text + @"\" + cb_typ_dok_kat.SelectedItem + @"\" + rodz_dok + tb_teryt.Text + "-R" + tb_rok.Text + "-N" + tb_nr_w_roku.Text + "#" + part + ".pdf");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                }
            }
            else
            {
                // Save output PDF file
                if (!Directory.Exists(tb_path_pdf_out.Text + @"\" + dir_name))
                {
                    // Try to create the directory.
                    DirectoryInfo di = Directory.CreateDirectory(tb_path_pdf_out.Text + @"\" + dir_name);
                }

                doc.Save(tb_path_pdf_out.Text + @"\" + dir_name + @"\" + dir_name + "_" + licz_dokument + rodz_dok + "#" + part + "#" + ".pdf");
                VerySimpleReplaceText(tb_path_pdf_out.Text + @"\" + dir_name + @"\" + dir_name + "_" + licz_dokument + rodz_dok + "#" + part + "#" + ".pdf", tb_path_pdf_out.Text + @"\" + dir_name + @"\" + dir_name + "_" + licz_dokument + rodz_dok + "#" + part + "#" + "_clr.pdf");
                File.Delete(tb_path_pdf_out.Text + @"\" + dir_name + @"\" + dir_name + "_" + licz_dokument + rodz_dok + "#" + part + "#" + ".pdf");
                System.IO.File.Move(tb_path_pdf_out.Text + @"\" + dir_name + @"\" + dir_name + "_" + licz_dokument + rodz_dok + "#" + part + "#" + "_clr.pdf", tb_path_pdf_out.Text + @"\" + dir_name + @"\" + dir_name + "_" + licz_dokument + rodz_dok + "#" + part + "#" + ".pdf");
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------
        public string pobierz_rodzaj_dokumentu(int kategoria)
        {
            string rodzaj_dokumentu;

            switch (kategoria)
            {
                case 44:
                    rodzaj_dokumentu = "-STR-TYT-";
                    break;
                case 42:
                    rodzaj_dokumentu = "-SPIS-";
                    break;
                case 43:
                    rodzaj_dokumentu = "S-TECH-";
                    break;
                case 65:
                    rodzaj_dokumentu = "-ZGL-PRAC-";
                    break;
                case 24:
                    rodzaj_dokumentu = "-ZGL-ODP-";
                    break;
                case 54:
                    rodzaj_dokumentu = "-WNI-PRZ-";
                    break;
                case 12:
                    rodzaj_dokumentu = "-DZ-R-";
                    break;
                case 32:
                    rodzaj_dokumentu = "-P-G-";
                    break;
                case 66:
                    rodzaj_dokumentu = "-ZW-";
                    break;
                case 31:
                    rodzaj_dokumentu = "-P-KW-";
                    break;
                case 34:
                    rodzaj_dokumentu = "-P-KAT-";
                    break;
                case 33:
                    rodzaj_dokumentu = "-P-IN-";
                    break;
                case 10:
                    rodzaj_dokumentu = "-DOK-OBL-";
                    break;
                case 36:
                    rodzaj_dokumentu = "-R-GPS-";
                    break;
                case 50:
                    rodzaj_dokumentu = "-TR-PKT-";
                    break;
                case 11:
                    rodzaj_dokumentu = "-DZ-P-";
                    break;
                case 49:
                    rodzaj_dokumentu = "-SZK-PRZ-";
                    break;
                case 48:
                    rodzaj_dokumentu = "-SZK-POL-";
                    break;
                case 47:
                    rodzaj_dokumentu = "-SZK-OSN-";
                    break;
                case 45:
                    rodzaj_dokumentu = "-SZK-INN-";
                    break;
                case 46:
                    rodzaj_dokumentu = "-SZK-KAT-";
                    break;
                case 60:
                    rodzaj_dokumentu = "-Z-POM-";
                    break;
                case 59:
                    rodzaj_dokumentu = "-Z-KAT-";
                    break;
                case 20:
                    rodzaj_dokumentu = "-M-WYW-";
                    break;
                case 21:
                    rodzaj_dokumentu = "-M-PROJ-";
                    break;
                case 22:
                    rodzaj_dokumentu = "-M-WPROJ-";
                    break;
                case 19:
                    rodzaj_dokumentu = "-M-UZ-";
                    break;
                case 18:
                    rodzaj_dokumentu = "-M-WYN-";
                    break;
                case 15:
                    rodzaj_dokumentu = "-M-KL-";
                    break;
                case 26:
                    rodzaj_dokumentu = "-OIM-";
                    break;
                case 17:
                    rodzaj_dokumentu = "-M-KAT-";
                    break;
                case 16:
                    rodzaj_dokumentu = "-M-IN-";
                    break;
                case 56:
                    rodzaj_dokumentu = "-W-WSP-";
                    break;
                case 58:
                    rodzaj_dokumentu = "-W-ZDE-";
                    break;
                case 55:
                    rodzaj_dokumentu = "-W-S-";
                    break;
                case 57:
                    rodzaj_dokumentu = "-W-WYW-";
                    break;
                case 53:
                    rodzaj_dokumentu = "-WNI-IN-";
                    break;
                case 7:
                    rodzaj_dokumentu = "-DEC-";
                    break;
                case 28:
                    rodzaj_dokumentu = "-ORZ-";
                    break;
                case 51:
                    rodzaj_dokumentu = "-UGO-";
                    break;
                case 1:
                    rodzaj_dokumentu = "-AKN-";
                    break;
                case 2:
                    rodzaj_dokumentu = "-AWZ-";
                    break;
                case 37:
                    rodzaj_dokumentu = "-REJ-ARCH-";
                    break;
                case 39:
                    rodzaj_dokumentu = "-REJ-SCAL-";
                    break;
                case 38:
                    rodzaj_dokumentu = "-REJ-IN-";
                    break;
                case 40:
                    rodzaj_dokumentu = "-SK-D-";
                    break;
                case 41:
                    rodzaj_dokumentu = "-SK-W-";
                    break;
                case 4:
                    rodzaj_dokumentu = "-ADEB-";
                    break;
                case 5:
                    rodzaj_dokumentu = "-ADEL-";
                    break;
                case 52:
                    rodzaj_dokumentu = "-UPOW-";
                    break;
                case 29:
                    rodzaj_dokumentu = "-OSW-";
                    break;
                case 25:
                    rodzaj_dokumentu = "-OPIN-";
                    break;
                case 30:
                    rodzaj_dokumentu = "-POST-";
                    break;
                case 61:
                    rodzaj_dokumentu = "-ZASW-";
                    break;
                case 62:
                    rodzaj_dokumentu = "-ZAW-ZGL-";
                    break;
                case 63:
                    rodzaj_dokumentu = "-ZAW-IN-";
                    break;
                case 64:
                    rodzaj_dokumentu = "-ZAW-KW-";
                    break;
                case 3:
                    rodzaj_dokumentu = "-AMZ-";
                    break;
                case 6:
                    rodzaj_dokumentu = "-MATR-";
                    break;
                case 27:
                    rodzaj_dokumentu = "-OTOP-";
                    break;
                case 23:
                    rodzaj_dokumentu = "-MPZP-";
                    break;
                case 13:
                    rodzaj_dokumentu = "-K-BUD-";
                    break;
                case 14:
                    rodzaj_dokumentu = "-K-PAR-";
                    break;
                case 35:
                    rodzaj_dokumentu = "-R-IN-";
                    break;
                case 8:
                    rodzaj_dokumentu = "-DOK-IN-";
                    break;
                case 9:
                    rodzaj_dokumentu = "-DOK-WYJ-";
                    break;
                default:
                    rodzaj_dokumentu = " ERR ";
                    break;
            }

                return rodzaj_dokumentu;
        }

//--------------------------------------------------------------------------------------------------------------------------------------------------

        public void przenumeruj_PG()
        {
            if (!rb_DokKat.Checked) 
            {
                _loger.Info("Poprawa numercji pdf-ów dla protokołów");
                string[] lista_plikow = Directory.GetFiles(tb_path_pdf_out.Text + @"\" + dir_name);
                List<string> lista_plik_do_lacz = new List<string>();

                // wyszuaj pliki do łaczenia 
                foreach (string plik_sciazka in lista_plikow)
                {
                    if (plik_sciazka.Contains("-P-G-") || plik_sciazka.Contains("-P-IN-"))
                    {
                        string nowa_nazwa_PG = "";
                        string plik = Path.GetFileName(plik_sciazka);
                        string sciezka = Path.GetDirectoryName(plik_sciazka);
                        string[] plik_spit1 = plik.Split('-');
                        string[] plik_spit1_1 = plik_spit1[0].Split('_');
                        nowa_nazwa_PG = plik_spit1[0] + "-" + plik_spit1[1] + "-" + plik_spit1[2] + "-001.pdf";

                        System.IO.File.Move(plik_sciazka, sciezka + @"\" + nowa_nazwa_PG);
                    }
                }
            }
        }
//--------------------------------------------------------------------------------------------------------------------------------------------------
        public static void VerySimpleReplaceText(string OrigFile, string ResultFile)
        {
            _loger.Info("Usunięcie napisu kontrolnego z "+ OrigFile);
            using (PdfReader reader = new PdfReader(OrigFile))
            {
                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    byte[] contentBytes = reader.GetPageContent(i);
                    string contentString = PdfEncodings.ConvertToString(contentBytes, PdfObject.TEXT_PDFDOCENCODING);
                    contentString = contentString.Replace("002800590044004F005800440057004C00520051000300320051004F005C0011000300260055004800440057004800470003005A004C0057004B0003002400560053005200560048001100330027002900110003002600520053005C0055004C004A004B005700030015001300130015001000150013001500140003002400560053005200560048000300330057005C0003002F005700470011", "");
                    reader.SetPageContent(i, PdfEncodings.ConvertToBytes(contentString, PdfObject.TEXT_PDFDOCENCODING));
                }
                new PdfStamper(reader, new FileStream(ResultFile, FileMode.Create, FileAccess.Write)).Close();
            }
        }

//--------------------------------------------------------------------------------------------------------------------------------------------------
        public void przesuwanie_listy(ListView ListV, DragEventArgs e, int Idcategory) 
        {
            
            if (ListV.SelectedItems.Count == 0)
            {
                return;
            }
            Point Pt = ListV.PointToClient(new Point(e.X, e.Y)); // 651 649 523 451
            ListViewItem ItemDrag = ListV.GetItemAt(Pt.X, Pt.Y); //286 284 158 86

            if (ItemDrag == null)
            {
                return;
            }
            
            int ItemDragIndex = ItemDrag.Index; // Na jaki indeks przeniesione 
            ListViewItem[] Sel = new ListViewItem[ListV.SelectedItems.Count];

            for (int i = 0; i < ListV.SelectedItems.Count; i++)
            {
                Sel[i] = ListV.SelectedItems[i];
            }

            for (int i = 0; i < Sel.GetLength(0); i++)
            {
                ListViewItem Item = Sel[i];
                int ItemIndex = ItemDragIndex;

                if (ItemIndex == Item.Index)
                {
                    return;
                }
                if (Item.Index < ItemIndex)
                {
                    ItemIndex++;
                }
                else
                {
                    ItemIndex = ItemDragIndex + 1;
                }

                ListViewItem InsertItem = (ListViewItem)Item.Clone();

                ListV.Items.Insert(ItemIndex, InsertItem);
                ListV.Items.Remove(Item);
                
                
                    _loger.Info("Wybór rodzju dokumnetu przy przesuwaniu listy");
                    switch (CB_rodzaj_dok.SelectedItem)
                    {
                    case "1 Akt notarialny":
                        _loger.Info("Wybrano 1 Akt notarialny ");
                        przesun_element_listy(lv01_toperat_pliki, ListV);
                        break;
                    case "2 Akt własności ziemi":
                        _loger.Info("2 Akt własności ziemi");
                        przesun_element_listy(lv02_toperat_pliki, ListV);
                        break;
                    case "3 Analiza materiałów źródłowych":
                        _loger.Info("3 Analiza materiałów źródłowych");
                        przesun_element_listy(lv03_toperat_pliki, ListV);
                        break;
                    case "4 Arkusz danych ewidencyjnych budynków":
                        _loger.Info("4 Arkusz danych ewidencyjnych budynków");
                        przesun_element_listy(lv04_toperat_pliki, ListV);
                        break;
                    case "5 Arkusz danych ewidencyjnych lokali":
                        _loger.Info("5 Arkusz danych ewidencyjnych lokali");
                        przesun_element_listy(lv05_toperat_pliki, ListV);
                        break;
                    case "6 Artykuł matrykuły lub matrykuła":
                        _loger.Info("6 Artykuł matrykuły lub matrykuła");
                        przesun_element_listy(lv06_toperat_pliki, ListV);
                        break;
                    case "7 Decyzja":
                        _loger.Info("7 Decyzja");
                        przesun_element_listy(lv07_toperat_pliki, ListV);
                        break;
                    case "8 Dokument inny":
                        _loger.Info("8 Dokument inny");
                        przesun_element_listy(lv08_toperat_pliki, ListV);
                        break;
                    case "9 Dokument wyjściowy":
                        _loger.Info("9 Dokument wyjściowy");
                        przesun_element_listy(lv09_toperat_pliki, ListV);
                        break;
                    case "10 Dokumentacja obliczeniowa":
                        _loger.Info("10 Dokumentacja obliczeniowa");
                        przesun_element_listy(lv10_toperat_pliki, ListV);
                        break;
                    case "11 Dziennik pomiarowy":
                        _loger.Info("11 Dziennik pomiarowy");
                        przesun_element_listy(lv11_toperat_pliki, ListV);
                        break;
                    case "12 Dziennik robót, prac":
                        _loger.Info("12 Dziennik robót, prac");
                        przesun_element_listy(lv12_toperat_pliki, ListV);
                        break;
                    case "13 Księga budynkowa":
                        _loger.Info("13 Księga budynkowa");
                        przesun_element_listy(lv13_toperat_pliki, ListV);
                        break;
                    case "14 Księga parcel":
                        _loger.Info("14 Księga parcel");
                        przesun_element_listy(lv14_toperat_pliki, ListV);
                        break;
                    case "15 Mapa gleboznawczej klasyfikacji gruntów":
                        _loger.Info("15 Mapa gleboznawczej klasyfikacji gruntów");
                        przesun_element_listy(lv15_toperat_pliki, ListV);
                        break;
                    case "16 Mapa inna":
                        _loger.Info("16 Mapa inna");
                        przesun_element_listy(lv16_toperat_pliki, ListV);
                        break;
                    case "17 Mapa katastralna, stanu prawnego":
                        _loger.Info("17 Mapa katastralna, stanu prawnego");
                        przesun_element_listy(lv17_toperat_pliki, ListV);
                        break;
                    case "18 Mapa powykonawcza, wynikowa pracy":
                        _loger.Info("18 Mapa powykonawcza, wynikowa pracy");
                        przesun_element_listy(lv18_toperat_pliki, ListV);
                        break;
                    case "19 Mapa uzupełniająca":
                        _loger.Info("19 Mapa uzupełniająca");
                        przesun_element_listy(lv19_toperat_pliki, ListV);
                        break;
                    case "20 Mapa wywiadu":
                        _loger.Info("20 Mapa wywiadu");
                        przesun_element_listy(lv20_toperat_pliki, ListV);
                        break;
                    case "21 Mapa z projektem podziału":
                        _loger.Info("21 Mapa z projektem podziału");
                        przesun_element_listy(lv21_toperat_pliki, ListV);
                        break;
                    case "22 Mapa z wstępnym projektem podziału":
                        _loger.Info("22 Mapa z wstępnym projektem podziału");
                        przesun_element_listy(lv22_toperat_pliki, ListV);
                        break;
                    case "23 Miejscowy plan zagospodarowania przestrzennego":
                        _loger.Info("23 Miejscowy plan zagospodarowania przestrzennego");
                        przesun_element_listy(lv23_toperat_pliki, ListV);
                        break;
                    case "24 Odpowiedź na zgłoszenie pracy geodezyjnej":
                        _loger.Info("24 Odpowiedź na zgłoszenie pracy geodezyjnej");
                        przesun_element_listy(lv24_toperat_pliki, ListV);
                        break;
                    case "25 Opinia":
                        _loger.Info("25 Opinia");
                        przesun_element_listy(lv25_toperat_pliki, ListV);
                        break;
                    case "26 Opis i mapa, wypis i wyrys":
                        _loger.Info("26 Opis i mapa, wypis i wyrys");
                        przesun_element_listy(lv26_toperat_pliki, ListV);
                        break;
                    case "27 Opis topograficzny":
                        _loger.Info("27 Opis topograficzny");
                        przesun_element_listy(lv27_toperat_pliki, ListV);
                        break;
                    case "28 Orzeczenie, wyrok sądu":
                        _loger.Info("28 Orzeczenie, wyrok sądu");
                        przesun_element_listy(lv28_toperat_pliki, ListV);
                        break;
                    case "29 Oświadczenie":
                        _loger.Info("29 Oświadczenie");
                        przesun_element_listy(lv29_toperat_pliki, ListV);
                        break;
                    case "30 Postanowienie":
                        _loger.Info("30 Postanowienie");
                        przesun_element_listy(lv30_toperat_pliki, ListV);
                        break;
                    case "31 Protokół badania księgi wieczystej, odpis":
                        _loger.Info("31 Protokół badania księgi wieczystej, odpis");
                        przesun_element_listy(lv31_toperat_pliki, ListV);
                        break;
                    case "32 Protokół graniczny":
                        _loger.Info("32 Protokół graniczny");
                        przesun_element_listy(lv32_toperat_pliki, ListV);
                        break;
                    case "33 Protokół inny":
                        _loger.Info("33 Protokół inny");
                        przesun_element_listy(lv33_toperat_pliki, ListV);
                        break;
                    case "34 Protokół katastralny, parcelowy":
                        _loger.Info("34 Protokół katastralny, parcelowy");
                        przesun_element_listy(lv34_toperat_pliki, ListV);
                        break;
                    case "35 Raport inny":
                        _loger.Info("35 Raport inny");
                        przesun_element_listy(lv35_toperat_pliki, ListV);
                        break;
                    case "36 Raport pomiarowy rtk/rtn":
                        _loger.Info("36 Raport pomiarowy rtk/rtn");
                        przesun_element_listy(lv36_toperat_pliki, ListV);
                        break;
                    case "37 Rejestr archiwalny":
                        _loger.Info("37 Rejestr archiwalny");
                        przesun_element_listy(lv37_toperat_pliki, ListV);
                        break;
                    case "38 Rejestr inny":
                        _loger.Info("38 Rejestr inny");
                        przesun_element_listy(lv38_toperat_pliki, ListV);
                        break;
                    case "39 Rejestr przed/po scaleniowy":
                        _loger.Info("39 Rejestr przed/po scaleniowy");
                        przesun_element_listy(lv39_toperat_pliki, ListV);
                        break;
                    case "40 Skorowidz/wykaz działek":
                        _loger.Info("40 Skorowidz/wykaz działek");
                        przesun_element_listy(lv40_toperat_pliki, ListV);
                        break;
                    case "41 Skorowidz/wykaz właścicieli":
                        _loger.Info("41 Skorowidz/wykaz właścicieli");
                        przesun_element_listy(lv41_toperat_pliki, ListV);
                        break;
                    case "42 Spis treści":
                        _loger.Info("42 Spis treści");
                        przesun_element_listy(lv42_toperat_pliki, ListV);
                        break;
                    case "43 Sprawozdanie techniczne":
                        _loger.Info("43 Sprawozdanie techniczne");
                        przesun_element_listy(lv43_toperat_pliki, ListV);
                        break;
                    case "44 Strona tytułowa":
                        _loger.Info("44 Strona tytułowa");
                        przesun_element_listy(lv44_toperat_pliki, ListV);
                        break;
                    case "45 Szkic inny":
                        _loger.Info("45 Szkic inny");
                        przesun_element_listy(lv45_toperat_pliki, ListV);
                        break;
                    case "46 Szkic katastralny, podstawowy":
                        _loger.Info("46 Szkic katastralny, podstawowy");
                        przesun_element_listy(lv46_toperat_pliki, ListV);
                        break;
                    case "47 Szkic osnowy":
                        _loger.Info("47 Szkic osnowy");
                        przesun_element_listy(lv47_toperat_pliki, ListV);
                        break;
                    case "48 Szkic polowy":
                        _loger.Info("48 Szkic polowy");
                        przesun_element_listy(lv48_toperat_pliki, ListV);
                        break;
                    case "49 Szkic przeglądowy":
                        _loger.Info("49 Szkic przeglądowy");
                        przesun_element_listy(lv49_toperat_pliki, ListV);
                        break;
                    case "50 Transformacja punktów":
                        _loger.Info("50 Transformacja punktów");
                        przesun_element_listy(lv50_toperat_pliki, ListV);
                        break;
                    case "51 Ugoda":
                        _loger.Info("51 Ugoda");
                        przesun_element_listy(lv51_toperat_pliki, ListV);
                        break;
                    case "52 Upoważnienie, pełnomocnictwo":
                        _loger.Info("52 Upoważnienie, pełnomocnictwo");
                        przesun_element_listy(lv52_toperat_pliki, ListV);
                        break;
                    case "53 Wniosek inny":
                        _loger.Info("53 Wniosek inny");
                        przesun_element_listy(lv53_toperat_pliki, ListV);
                        break;
                    case "54 Wniosek o przyjęcie dokumentacji do zasobu":
                        _loger.Info("54 Wniosek o przyjęcie dokumentacji do zasobu");
                        przesun_element_listy(lv54_toperat_pliki, ListV);
                        break;
                    case "55 Wykaz synchronizacyjny":
                        _loger.Info("55 Wykaz synchronizacyjny");
                        przesun_element_listy(lv55_toperat_pliki, ListV);
                        break;
                    case "56 Wykaz współrzędnych":
                        _loger.Info("56 Wykaz współrzędnych");
                        przesun_element_listy(lv56_toperat_pliki, ListV);
                        break;
                    case "57 Wykaz wywłaszczeniowy":
                        _loger.Info("57 Wykaz wywłaszczeniowy");
                        przesun_element_listy(lv57_toperat_pliki, ListV);
                        break;
                    case "58 Wykaz zmian danych ewidencyjnych":
                        _loger.Info("58 Wykaz zmian danych ewidencyjnych");
                        przesun_element_listy(lv58_toperat_pliki, ListV);
                        break;
                    case "59 Zarys katastralny":
                        _loger.Info("59 Zarys katastralny");
                        przesun_element_listy(lv59_toperat_pliki, ListV);
                        break;
                    case "60 Zarys pomiarowy":
                        _loger.Info("60 Zarys pomiarowy");
                        przesun_element_listy(lv60_toperat_pliki, ListV);
                        break;
                    case "61 Zaświadczenie":
                        _loger.Info("61 Zaświadczenie");
                        przesun_element_listy(lv61_toperat_pliki, ListV);
                        break;
                    case "62 Zawiadomienie o wykonaniu zgłoszonych prac":
                        _loger.Info("62 Zawiadomienie o wykonaniu zgłoszonych prac");
                        przesun_element_listy(lv62_toperat_pliki, ListV);
                        break;
                    case "63 Zawiadomienie z wydziału kw":
                        _loger.Info("63 Zawiadomienie z wydziału kw");
                        przesun_element_listy(lv63_toperat_pliki, ListV);
                        break;
                    case "64 Zawiadomienie, powiadomienie":
                        _loger.Info("64 Zawiadomienie, powiadomienie");
                        przesun_element_listy(lv64_toperat_pliki, ListV);
                        break;
                    case "65 Zgłoszenie pracy geodezyjnej":
                        _loger.Info("65 Zgłoszenie pracy geodezyjnej");
                        przesun_element_listy(lv65_toperat_pliki, ListV);
                        break;
                    case "66 Zwrotne potwierdzenie odbioru":
                        _loger.Info("66 Zwrotne potwierdzenie odbioru");
                        przesun_element_listy(lv66_toperat_pliki, ListV);
                        break;
                }
                
            }
        }

    public void przesun_element_listy(List<row_toperat_str> lvXX_toperat_pliki, ListView ListV)
    {
        var con = polacz_z_baza();
        
        for (int licz = 0; licz < ListV.Items.Count; licz++)
        {
            int licz_toperatpliki_Indexinset = 0;
            foreach (var row_toperatpliki in lvXX_toperat_pliki)
            {
                string aaa = row_toperatpliki.Nazwa.ToLower();
                string bbb = ListV.Items[licz].Tag.ToString().ToLower();
                string cos = aaa + bbb;
                if (row_toperatpliki.Nazwa.ToLower().Contains(ListV.Items[licz].Tag.ToString().ToLower()))
                {
                    row_toperatpliki.Indexinset = licz;
                    lvXX_toperat_pliki[licz_toperatpliki_Indexinset].Indexinset = licz;
                    //     var table_toperat_str_as_list = new table_toperat_str();
                    NpgsqlCommand cmd = new NpgsqlCommand(string.Format(@"update pandora.toperatpliki set indexinset = {0} where id = '{1}';", licz, row_toperatpliki.Id), con);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        _loger.Info("Wykonanie zapytania " + string.Format(@"update pandora.toperatpliki set indexinset = {0} where id = '{1}';", licz, row_toperatpliki.Id));
                    }
                    catch
                    {
                        MessageBox.Show("Nie udało się wykonać zapytania :\n" + string.Format(@"update pandora.toperatpliki set indexinset = {0} where nazwa like '{1}';", licz, row_toperatpliki.Nazwa), "Błąd bazy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _loger.Error("Nie udało się wykonać zapytania: " + string.Format(@"update pandora.toperatpliki set indexinset = {0} where id = '{1}';", licz, row_toperatpliki.Id));
                    }
                }
                licz_toperatpliki_Indexinset++;
            }
        }
            wczytaj_pliki_do_lvXX(lvXX_toperat_pliki);
    }

        //-- lv1
        private void lv1_DragDrop(object sender, DragEventArgs e)
        {
            przesuwanie_listy(lv1,e,1);
        }

        private void lv1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void lv1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            lv1.DoDragDrop(lv1.SelectedItems, DragDropEffects.Move);
        }

        private void bt_czyt_katalog_Click(object sender, EventArgs e)
        {
            wczytaj_z_katalogu();
            _loger.Info("Wczytanie danych przez wybór plików");
        }

        public void wczytaj_z_katalogu()
        {
            ofd_dir.SelectedPath = @"f:\";
            if (ofd_dir.ShowDialog() == DialogResult.OK)
            {
                tb_Path_dir.Text = ofd_dir.SelectedPath;
                lOperatNr.Text = Path.GetFileName(tb_Path_dir.Text);
                dir_name = Path.GetFileName(tb_Path_dir.Text)+lOperatNr.Text;

                string[] lista_plikow = Directory.GetFiles(tb_Path_dir.Text);

                // wyszuaj pliki do łaczenia 
                listViewFile.Items.Clear();
                Cursor = Cursors.WaitCursor;
                foreach (string plik in lista_plikow)
                {
                    czysc_lv();
                    //dir_name = Path.GetDirectoryName(ofd.FileName).Split('\\').Last();
                    //lOperatNr.Text = dir_name;
                    fi = new FileInfo(plik);
                    _loger.Info("Wczytanie pliku : " + fi.FullName);//ofd_dir.SelectedPath = Directory.GetCurrentDirectory(); 
                    FileInfo fileinfo = new FileInfo(plik);
                    _loger.Info("Wczytanie pliku : " + fi.FullName);

                    using (FileStream stream = new FileStream(fi.FullName, FileMode.Open, FileAccess.Read))
                    {
                        myImageListLarge.Images.Add(Image.FromStream(stream).GetThumbnailImage(50, 50, new Image.GetThumbnailImageAbort(() => false), IntPtr.Zero));
                    }

                    listViewFile.LargeImageList = myImageListLarge;
                    listViewFile.Items.Add(new ListViewItem
                    {
                        ImageIndex = count,
                        Text = fi.Name,
                        Tag = fi.FullName
                    });
                    count++;

                    if (listViewFile.Items.Count > 0)
                    {
                        listViewFile.Items[0].Selected = true;
                    }
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                }
                Cursor = Cursors.Default;
            }
            lb_iloscs_stron.Text = listViewFile.Items.Count.ToString();
            sprawdz_save(lOperatNr.Text);
            
            _loger.Info("Wczytano do listy plików :" + lb_iloscs_stron.Text);
            lb_indeksacja.Text = zlicz_zaindeksowane().ToString();
        //    utworz_plik(lOperatNr.Text);
        }


        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void bt_path_pdf_out_Click(object sender, EventArgs e)
        {
            ofd_path_pdf_out.SelectedPath = Directory.GetCurrentDirectory() + @"\pdf_out";
            if (ofd_path_pdf_out.ShowDialog() == DialogResult.OK)
            {
                tb_path_pdf_out.Text = ofd_path_pdf_out.SelectedPath;
            }
        }


        private void listViewFile_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            load_from_file = false;
            kategoryzuj_dane();
        }
  //----------------------------------------------------------------------------------------------------------------------------------------      
        public void kategoryzuj_dane() 
        {
            
            if (listViewFile.SelectedItems.Count > 0)
            {
                //int dec_kol = 0;
                _loger.Info("Wybrano plik " + lb_iloscs_stron.Text);
                switch (CB_rodzaj_dok.SelectedItem)
                {

                    case "1 Akt notarialny":
                        dodaj_strone_do_dokumentu(lv01_toperat_pliki, myImageListLarge_P1, 1);
                        _loger.Info("1 Akt notarialny");
                        break;
                    case "2 Akt własności ziemi":
                        dodaj_strone_do_dokumentu(lv02_toperat_pliki, myImageListLarge_P1, 2);
                        _loger.Info("2 Akt własności ziemi");
                        break;
                    case "3 Analiza materiałów źródłowych":
                        dodaj_strone_do_dokumentu(lv03_toperat_pliki, myImageListLarge_P1, 3);
                        _loger.Info("3 Analiza materiałów źródłowych");
                        break;
                    case "4 Arkusz danych ewidencyjnych budynków":
                        dodaj_strone_do_dokumentu(lv04_toperat_pliki, myImageListLarge_P1, 4);
                        _loger.Info("4 Arkusz danych ewidencyjnych budynków");
                        break;
                    case "5 Arkusz danych ewidencyjnych lokali":
                        dodaj_strone_do_dokumentu(lv05_toperat_pliki, myImageListLarge_P1, 5);
                        _loger.Info("5 Arkusz danych ewidencyjnych lokali");
                        break;
                    case "6 Artykuł matrykuły lub matrykuła":
                        dodaj_strone_do_dokumentu(lv06_toperat_pliki, myImageListLarge_P1, 6);
                        _loger.Info("6 Artykuł matrykuły lub matrykuła");
                        break;
                    case "7 Decyzja":
                        dodaj_strone_do_dokumentu(lv07_toperat_pliki, myImageListLarge_P1, 7);
                        _loger.Info("7 Decyzja");
                        break;
                    case "8 Dokument inny":
                        dodaj_strone_do_dokumentu(lv08_toperat_pliki, myImageListLarge_P1, 8);
                        _loger.Info("8 Dokument inny");
                        break;
                    case "9 Dokument wyjściowy":
                        dodaj_strone_do_dokumentu(lv09_toperat_pliki, myImageListLarge_P1, 9);
                        _loger.Info("9 Dokument wyjściowy");
                        break;
                    case "10 Dokumentacja obliczeniowa":
                        dodaj_strone_do_dokumentu(lv10_toperat_pliki, myImageListLarge_P1, 10);
                        _loger.Info("10 Dokumentacja obliczeniowa");
                        break;
                    case "11 Dziennik pomiarowy":
                        dodaj_strone_do_dokumentu(lv11_toperat_pliki, myImageListLarge_P1, 11);
                        _loger.Info("11 Dziennik pomiarowy");
                        break;
                    case "12 Dziennik robót, prac":
                        dodaj_strone_do_dokumentu(lv12_toperat_pliki, myImageListLarge_P1, 12);
                        _loger.Info("12 Dziennik robót, prac");
                        break;
                    case "13 Księga budynkowa":
                        dodaj_strone_do_dokumentu(lv13_toperat_pliki, myImageListLarge_P1, 13);
                        _loger.Info("13 Księga budynkowa");
                        break;
                    case "14 Księga parcel":
                        dodaj_strone_do_dokumentu(lv14_toperat_pliki, myImageListLarge_P1, 14);
                        _loger.Info("14 Księga parcel");
                        break;
                    case "15 Mapa gleboznawczej klasyfikacji gruntów":
                        dodaj_strone_do_dokumentu(lv15_toperat_pliki, myImageListLarge_P1, 15);
                        _loger.Info("15 Mapa gleboznawczej klasyfikacji gruntów");
                        break;
                    case "16 Mapa inna":
                        dodaj_strone_do_dokumentu(lv16_toperat_pliki, myImageListLarge_P1, 16);
                        _loger.Info("16 Mapa inna");
                        break;
                    case "17 Mapa katastralna, stanu prawnego":
                        dodaj_strone_do_dokumentu(lv17_toperat_pliki, myImageListLarge_P1, 17);
                        _loger.Info("17 Mapa katastralna, stanu prawnego");
                        break;
                    case "18 Mapa powykonawcza, wynikowa pracy":
                        dodaj_strone_do_dokumentu(lv18_toperat_pliki, myImageListLarge_P1, 18);
                        _loger.Info("18 Mapa powykonawcza, wynikowa pracy");
                        break;
                    case "19 Mapa uzupełniająca":
                        dodaj_strone_do_dokumentu(lv19_toperat_pliki, myImageListLarge_P1, 19);
                        _loger.Info("19 Mapa uzupełniająca");
                        break;
                    case "20 Mapa wywiadu":
                        dodaj_strone_do_dokumentu(lv20_toperat_pliki, myImageListLarge_P1, 20);
                        _loger.Info("20 Mapa wywiadu");
                        break;
                    case "21 Mapa z projektem podziału":
                        dodaj_strone_do_dokumentu(lv21_toperat_pliki, myImageListLarge_P1, 21);
                        _loger.Info("21 Mapa z projektem podziału");
                        break;
                    case "22 Mapa z wstępnym projektem podziału":
                        dodaj_strone_do_dokumentu(lv22_toperat_pliki, myImageListLarge_P1, 22);
                        _loger.Info("22 Mapa z wstępnym projektem podziału");
                        break;
                    case "23 Miejscowy plan zagospodarowania przestrzennego":
                        dodaj_strone_do_dokumentu(lv23_toperat_pliki, myImageListLarge_P1, 23);
                        _loger.Info("23 Miejscowy plan zagospodarowania przestrzennego");
                        break;
                    case "24 Odpowiedź na zgłoszenie pracy geodezyjnej":
                        dodaj_strone_do_dokumentu(lv24_toperat_pliki, myImageListLarge_P1, 24);
                        _loger.Info("24 Odpowiedź na zgłoszenie pracy geodezyjnej");
                        break;
                    case "25 Opinia":
                        dodaj_strone_do_dokumentu(lv25_toperat_pliki, myImageListLarge_P1, 25);
                        _loger.Info("25 Opinia");
                        break;
                    case "26 Opis i mapa, wypis i wyrys":
                        dodaj_strone_do_dokumentu(lv26_toperat_pliki, myImageListLarge_P1, 26);
                        _loger.Info("26 Opis i mapa, wypis i wyrys");
                        break;
                    case "27 Opis topograficzny":
                        dodaj_strone_do_dokumentu(lv27_toperat_pliki, myImageListLarge_P1, 27);
                        _loger.Info("27 Opis topograficzny");
                        break;
                    case "28 Orzeczenie, wyrok sądu":
                        dodaj_strone_do_dokumentu(lv28_toperat_pliki, myImageListLarge_P1, 28);
                        _loger.Info("28 Orzeczenie, wyrok sądu");
                        break;
                    case "29 Oświadczenie":
                        dodaj_strone_do_dokumentu(lv29_toperat_pliki, myImageListLarge_P1, 29);
                        _loger.Info("29 Oświadczenie");
                        break;
                    case "30 Postanowienie":
                        dodaj_strone_do_dokumentu(lv30_toperat_pliki, myImageListLarge_P1, 30);
                        _loger.Info("30 Postanowienie");
                        break;
                    case "31 Protokół badania księgi wieczystej, odpis":
                        dodaj_strone_do_dokumentu(lv31_toperat_pliki, myImageListLarge_P1, 31);
                        _loger.Info("31 Protokół badania księgi wieczystej, odpis");
                        break;
                    case "32 Protokół graniczny":
                        dodaj_strone_do_dokumentu(lv32_toperat_pliki, myImageListLarge_P1, 32);
                        _loger.Info("32 Protokół graniczny");
                        break;
                    case "33 Protokół inny":
                        dodaj_strone_do_dokumentu(lv33_toperat_pliki, myImageListLarge_P1, 33);
                        _loger.Info("33 Protokół inny");
                        break;
                    case "34 Protokół katastralny, parcelowy":
                        dodaj_strone_do_dokumentu(lv34_toperat_pliki, myImageListLarge_P1, 34);
                        _loger.Info("34 Protokół katastralny, parcelowy");
                        break;
                    case "35 Raport inny":
                        dodaj_strone_do_dokumentu(lv35_toperat_pliki, myImageListLarge_P1, 35);
                        _loger.Info("35 Raport inny");
                        break;
                    case "36 Raport pomiarowy rtk/rtn":
                        dodaj_strone_do_dokumentu(lv36_toperat_pliki, myImageListLarge_P1, 36);
                        _loger.Info("36 Raport pomiarowy rtk/rtn");
                        break;
                    case "37 Rejestr archiwalny":
                        dodaj_strone_do_dokumentu(lv37_toperat_pliki, myImageListLarge_P1, 37);
                        _loger.Info("37 Rejestr archiwalny");
                        break;
                    case "38 Rejestr inny":
                        dodaj_strone_do_dokumentu(lv38_toperat_pliki, myImageListLarge_P1, 38);
                        _loger.Info("38 Rejestr inny");
                        break;
                    case "39 Rejestr przed/po scaleniowy":
                        dodaj_strone_do_dokumentu(lv39_toperat_pliki, myImageListLarge_P1, 39);
                        _loger.Info("39 Rejestr przed/po scaleniowy");
                        break;
                    case "40 Skorowidz/wykaz działek":
                        dodaj_strone_do_dokumentu(lv40_toperat_pliki, myImageListLarge_P1, 40);
                        _loger.Info("40 Skorowidz/wykaz działek");
                        break;
                    case "41 Skorowidz/wykaz właścicieli":
                        dodaj_strone_do_dokumentu(lv41_toperat_pliki, myImageListLarge_P1, 41);
                        _loger.Info("41 Skorowidz/wykaz właścicieli");
                        break;
                    case "42 Spis treści":
                        dodaj_strone_do_dokumentu(lv42_toperat_pliki, myImageListLarge_P1, 42);
                        _loger.Info("42 Spis treści");
                        break;
                    case "43 Sprawozdanie techniczne":
                        dodaj_strone_do_dokumentu(lv43_toperat_pliki, myImageListLarge_P1, 43);
                        _loger.Info("43 Sprawozdanie techniczne");
                        break;
                    case "44 Strona tytułowa":
                        dodaj_strone_do_dokumentu(lv44_toperat_pliki, myImageListLarge_P1, 44);
                        _loger.Info("44 Strona tytułowa");
                        break;
                    case "45 Szkic inny":
                        dodaj_strone_do_dokumentu(lv45_toperat_pliki, myImageListLarge_P1, 45);
                        _loger.Info("45 Szkic inny");
                        break;
                    case "46 Szkic katastralny, podstawowy":
                        dodaj_strone_do_dokumentu(lv46_toperat_pliki, myImageListLarge_P1, 46);
                        _loger.Info("46 Szkic katastralny, podstawowy");
                        break;
                    case "47 Szkic osnowy":
                        dodaj_strone_do_dokumentu(lv47_toperat_pliki, myImageListLarge_P1, 47);
                        _loger.Info("47 Szkic osnowy");
                        break;
                    case "48 Szkic polowy":
                        dodaj_strone_do_dokumentu(lv48_toperat_pliki, myImageListLarge_P1, 48);
                        _loger.Info("48 Szkic polowy");
                        break;
                    case "49 Szkic przeglądowy":
                        dodaj_strone_do_dokumentu(lv49_toperat_pliki, myImageListLarge_P1, 49);
                        _loger.Info("49 Szkic przeglądowy");
                        break;
                    case "50 Transformacja punktów":
                        dodaj_strone_do_dokumentu(lv50_toperat_pliki, myImageListLarge_P1, 50);
                        _loger.Info("50 Transformacja punktów");
                        break;
                    case "51 Ugoda":
                        dodaj_strone_do_dokumentu(lv51_toperat_pliki, myImageListLarge_P1, 51);
                        _loger.Info("51 Ugoda");
                        break;
                    case "52 Upoważnienie, pełnomocnictwo":
                        dodaj_strone_do_dokumentu(lv52_toperat_pliki, myImageListLarge_P1, 52);
                        _loger.Info("52 Upoważnienie, pełnomocnictwo");
                        break;
                    case "53 Wniosek inny":
                        dodaj_strone_do_dokumentu(lv53_toperat_pliki, myImageListLarge_P1, 53);
                        _loger.Info("53 Wniosek inny");
                        break;
                    case "54 Wniosek o przyjęcie dokumentacji do zasobu":
                        dodaj_strone_do_dokumentu(lv54_toperat_pliki, myImageListLarge_P1, 54);
                        _loger.Info("54 Wniosek o przyjęcie dokumentacji do zasobu");
                        break;
                    case "55 Wykaz synchronizacyjny":
                        dodaj_strone_do_dokumentu(lv55_toperat_pliki, myImageListLarge_P1, 55);
                        _loger.Info("55 Wykaz synchronizacyjny");
                        break;
                    case "56 Wykaz współrzędnych":
                        dodaj_strone_do_dokumentu(lv56_toperat_pliki, myImageListLarge_P1, 56);
                        _loger.Info("56 Wykaz współrzędnych");
                        break;
                    case "57 Wykaz wywłaszczeniowy":
                        dodaj_strone_do_dokumentu(lv57_toperat_pliki, myImageListLarge_P1, 57);
                        _loger.Info("57 Wykaz wywłaszczeniowy");
                        break;
                    case "58 Wykaz zmian danych ewidencyjnych":
                        dodaj_strone_do_dokumentu(lv58_toperat_pliki, myImageListLarge_P1, 58);
                        _loger.Info("58 Wykaz zmian danych ewidencyjnych");
                        break;
                    case "59 Zarys katastralny":
                        dodaj_strone_do_dokumentu(lv59_toperat_pliki, myImageListLarge_P1, 59);
                        _loger.Info("59 Zarys katastralny");
                        break;
                    case "60 Zarys pomiarowy":
                        dodaj_strone_do_dokumentu(lv60_toperat_pliki, myImageListLarge_P1, 60);
                        _loger.Info("60 Zarys pomiarowy");
                        break;
                    case "61 Zaświadczenie":
                        dodaj_strone_do_dokumentu(lv61_toperat_pliki, myImageListLarge_P1, 61);
                        _loger.Info("61 Zaświadczenie");
                        break;
                    case "62 Zawiadomienie o wykonaniu zgłoszonych prac":
                        dodaj_strone_do_dokumentu(lv62_toperat_pliki, myImageListLarge_P1, 62);
                        _loger.Info("62 Zawiadomienie o wykonaniu zgłoszonych prac");
                        break;
                    case "63 Zawiadomienie z wydziału kw":
                        dodaj_strone_do_dokumentu(lv63_toperat_pliki, myImageListLarge_P1, 63);
                        _loger.Info("63 Zawiadomienie z wydziału kw");
                        break;
                    case "64 Zawiadomienie, powiadomienie":
                        dodaj_strone_do_dokumentu(lv64_toperat_pliki, myImageListLarge_P1, 64);
                        _loger.Info("64 Zawiadomienie, powiadomienie");
                        break;
                    case "65 Zgłoszenie pracy geodezyjnej":
                        dodaj_strone_do_dokumentu(lv65_toperat_pliki, myImageListLarge_P1, 65);
                        _loger.Info("65 Zgłoszenie pracy geodezyjnej");
                        break;
                    case "66 Zwrotne potwierdzenie odbioru":
                        dodaj_strone_do_dokumentu(lv66_toperat_pliki, myImageListLarge_P1, 66);
                        _loger.Info("66 Zwrotne potwierdzenie odbioru");
                        break;

                    default:
                        MessageBox.Show("Wybierz rodzaj dokumentu !!!", "Info");
                        break;
                }

                lb_iloscs_stron.Text = listViewFile.Items.Count.ToString();
                lb_indeksacja.Text = zlicz_zaindeksowane().ToString();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
      
        private void btPowieksz_Click(object sender, EventArgs e)
        {
            if (zoom < 0.15)
                zoom += 0.05;
            _loger.Info("Poziekrznie zoom "+zoom );
            panel1.AutoScroll = true;
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            Bitmap bm = new Bitmap(pictureBox2.Image, Convert.ToInt32(pictureBox2.Image.Size.Width * (1 + 1 * zoom)), Convert.ToInt32(pictureBox2.Image.Size.Height * (1 + 1 * zoom)));
            Graphics gpu = Graphics.FromImage(bm);
            gpu.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            pictureBox1.Image = bm;
        }

        private void btPomniejsz_Click(object sender, EventArgs e)
        {
            if (zoom > -0.90)
                zoom -= 0.05;
            _loger.Info("Pomniejszenie zoom " + zoom);
            panel1.AutoScroll = true;
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;

            Bitmap bm = new Bitmap(pictureBox2.Image, Convert.ToInt32(pictureBox2.Image.Size.Width * (1 + 1 * zoom)), Convert.ToInt32(pictureBox2.Image.Size.Height * (1 + 1 * zoom)));
            Graphics gpu = Graphics.FromImage(bm);
            gpu.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            pictureBox1.Image = bm;
        }

        private void chBKataster_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_DokKat.Checked)
            {
                _loger.Info("Zaznaczono dokument katastralny ");
                gbKataster.Enabled = true;
            }
                
            else
            {
                _loger.Info("Zaznaczono zwykły operat");
                gbKataster.Enabled = false;
            }
                
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        
        public void sprawdz_save(string operat)
        {
            var con = polacz_z_baza();
       //     var table_toperat_str_as_list = new table_toperat_str();
            bool czy_jest_w_bezie = false;

            //NpgsqlCommand cmd = new NpgsqlCommand(string.Format(@"select *from pandora.toperatpliki where idoperat  in (select idoperat from pandora.toperat where numer like '{0}') order by idcategory,indexinset;", operat), con);
            NpgsqlCommand cmd = new NpgsqlCommand(string.Format(@"select* from pandora.toperatpliki where idoperat  in (select idoperat from pandora.toperat where numer like '{0}') order by idcategory, tom,idset ,indexinset", operat), con); 
            NpgsqlDataReader rows_toperatpliki = cmd.ExecuteReader();
           
            richTextBox1.Text = "";
            
            while (rows_toperatpliki.Read())
            {
                czy_jest_w_bezie = true;
          //      table_toperat_str_as_list.AddRowTo_table_toperat_str(Int32.Parse(rows_toperatpliki[0].ToString()), Int32.Parse(rows_toperatpliki[1].ToString()), rows_toperatpliki[2].ToString(), Int32.Parse(rows_toperatpliki[3].ToString()), Int32.Parse(rows_toperatpliki[4].ToString()), Int32.Parse(rows_toperatpliki[5].ToString()), rows_toperatpliki[6].ToString(), Int32.Parse(rows_toperatpliki[7].ToString()), Int32.Parse(rows_toperatpliki[8].ToString()), Int32.Parse(rows_toperatpliki[9].ToString()));
                
                string text_to_find = Path.GetFileName(rows_toperatpliki[2].ToString());
                text_to_find = text_to_find.Replace(".pdf",".jpg");
                ListViewItem item1 = listViewFile.FindItemWithText(text_to_find);

                if (item1 == null)
                {
                    _loger.Info("Brakujacy plik:" + rows_toperatpliki[2].ToString());
                }
                else
                {
                    listViewFile.Items[0].Selected = false;
                    listViewFile.Items[item1.Index].Selected = true;
                    //na_typy_z_bazy(rows_toperatpliki[3].ToString());
                    na_typy_z_bazy(Int32.Parse(rows_toperatpliki[0].ToString()), rows_toperatpliki[3].ToString());
                    listViewFile.Items[item1.Index].Selected = false;
                    listViewFile.Items[item1.Index].Remove();
                }
            }

            con.Close();
            CB_rodzaj_dok.SelectedIndex = 0;
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------
        public void Pobierz_ilosc_tomow(string rodzaj_dokumentu) 
        {
            _loger.Info("Pobranie ilości tomów");
            var con = polacz_z_baza();
            string select_query = string.Format(@"select distinct tom from pandora.toperatpliki where idoperat in (select idoperat from pandora.toperat where numer like '{0}') and idcategory = {1};", lOperatNr.Text, rodzaj_dokumentu);
            NpgsqlCommand cmd = new NpgsqlCommand(select_query, con);
            NpgsqlDataReader rows_toperatpliki = cmd.ExecuteReader();

            cb_TomCombo.Items.Clear();

            while (rows_toperatpliki.Read())
            {
                cb_TomCombo.Items.Add(rows_toperatpliki[0].ToString());
            }
            
            if (cb_TomCombo.Items.Count >1)
            {
                cb_TomCombo.SelectedIndex = 0; 
                cb_TomCombo.Enabled = true;
            }
            else if (cb_TomCombo.Items.Count > 0)
            {
                cb_TomCombo.SelectedIndex = 0;
                cb_TomCombo.Enabled = false;
            }
            else
            {

            }
            con.Close();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------

        private void na_typy_z_bazy (int id, string warstwa)
        {

            richTextBox1.Text += warstwa+"\n";
            
            switch (warstwa)
            {
                case "1":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv01_toperat_pliki, id);
                    break;
                case "2":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv02_toperat_pliki, id);
                    break;
                case "3":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv03_toperat_pliki, id);
                    break;
                case "4":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv04_toperat_pliki, id);
                    break;
                case "5":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv05_toperat_pliki, id);
                    break;
                case "6":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv06_toperat_pliki, id);
                    break;
                case "7":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv07_toperat_pliki, id);
                    break;
                case "8":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv08_toperat_pliki, id);
                    break;
                case "9":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv09_toperat_pliki, id);
                    break;
                case "10":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv10_toperat_pliki, id);
                    break;
                case "11":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv11_toperat_pliki, id);
                    break;
                case "12":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv12_toperat_pliki, id);
                    break;
                case "13":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv13_toperat_pliki, id);
                    break;
                case "14":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv14_toperat_pliki, id);
                    break;
                case "15":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv15_toperat_pliki, id);
                    break;
                case "16":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv16_toperat_pliki, id);
                    break;
                case "17":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv17_toperat_pliki, id);
                    break;
                case "18":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv18_toperat_pliki, id);
                    break;
                case "19":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv19_toperat_pliki, id);
                    break;
                case "20":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv20_toperat_pliki, id);
                    break;
                case "21":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv21_toperat_pliki, id);
                    break;
                case "22":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv22_toperat_pliki, id);
                    break;
                case "23":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv23_toperat_pliki, id);
                    break;
                case "24":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv24_toperat_pliki, id);
                    break;
                case "25":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv25_toperat_pliki, id);
                    break;
                case "26":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv26_toperat_pliki, id);
                    break;
                case "27":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv27_toperat_pliki, id);
                    break;
                case "28":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv28_toperat_pliki, id);
                    break;
                case "29":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv29_toperat_pliki, id);
                    break;
                case "30":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv30_toperat_pliki, id);
                    break;
                case "31":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv31_toperat_pliki, id);
                    break;
                case "32":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv32_toperat_pliki, id);
                    break;
                case "33":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv33_toperat_pliki, id);
                    break;
                case "34":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv34_toperat_pliki, id);
                    break;
                case "35":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv35_toperat_pliki, id);
                    break;
                case "36":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv36_toperat_pliki, id);
                    break;
                case "37":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv37_toperat_pliki, id);
                    break;
                case "38":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv38_toperat_pliki, id);
                    break;
                case "39":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv39_toperat_pliki, id);
                    break;
                case "40":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv40_toperat_pliki, id);
                    break;
                case "41":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv41_toperat_pliki, id);
                    break;
                case "42":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv42_toperat_pliki, id);
                    break;
                case "43":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv43_toperat_pliki, id);
                    break;
                case "44":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv44_toperat_pliki, id);
                    break;
                case "45":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv45_toperat_pliki, id);
                    break;
                case "46":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv46_toperat_pliki, id);
                    break;
                case "47":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv47_toperat_pliki, id);
                    break;
                case "48":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv48_toperat_pliki, id);
                    break;
                case "49":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv49_toperat_pliki, id);
                    break;
                case "50":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv50_toperat_pliki, id);
                    break;
                case "51":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv51_toperat_pliki, id);
                    break;
                case "52":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv52_toperat_pliki, id);
                    break;
                case "53":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv53_toperat_pliki, id);
                    break;
                case "54":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv54_toperat_pliki, id);
                    break;
                case "55":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv55_toperat_pliki, id);
                    break;
                case "56":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv56_toperat_pliki, id);
                    break;
                case "57":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv57_toperat_pliki, id);
                    break;
                case "58":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv58_toperat_pliki, id);
                    break;
                case "59":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv59_toperat_pliki, id);
                    break;
                case "60":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv60_toperat_pliki, id);
                    break;
                case "61":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv61_toperat_pliki, id);
                    break;
                case "62":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv62_toperat_pliki, id);
                    break;
                case "63":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv63_toperat_pliki, id);
                    break;
                case "64":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv64_toperat_pliki, id);
                    break;
                case "65":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv65_toperat_pliki, id);
                    break;
                case "66":
                    Dodaj_zkategoryzowana_strone_do_dokumentu(lv66_toperat_pliki, id);
                    break;

                default:
                    break;
            
            }
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------
        private void Pobierz_Click(object sender, EventArgs e)
        {
            kategoryzuj_dane();
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------
        private void bt_DodajOperat_Click(object sender, EventArgs e)
        {
            dodaj_operat();
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------
        public bool dodaj_operat()
        {
            form_DodajOperat DFO = new form_DodajOperat();
            DFO.Show();
            return true;
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------
        private void bt_EdytujOperat_Click(object sender, EventArgs e)
        {

        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------
        private void cb_TomCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_TomCombo.Items.Count > 1)
            {
                lv1.Clear();
                if (CB_rodzaj_dok.SelectedItem == "1 Akt notarialny")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv01_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "2 Akt własności ziemi")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv02_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "3 Analiza materiałów źródłowych")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv03_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "4 Arkusz danych ewidencyjnych budynków")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv04_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "5 Arkusz danych ewidencyjnych lokali")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv05_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "6 Artykuł matrykuły lub matrykuła")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv06_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "7 Decyzja")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv07_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "8 Dokument inny")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv08_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "9 Dokument wyjściowy")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv09_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "10 Dokumentacja obliczeniowa")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv10_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "11 Dziennik pomiarowy")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv11_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "12 Dziennik robót, prac")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv12_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "13 Księga budynkowa")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv13_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "14 Księga parcel")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv14_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "15 Mapa gleboznawczej klasyfikacji gruntów")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv15_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "16 Mapa inna")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv16_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "17 Mapa katastralna, stanu prawnego")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv17_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "18 Mapa powykonawcza, wynikowa pracy")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv18_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "19 Mapa uzupełniająca")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv19_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "20 Mapa wywiadu")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv20_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "21 Mapa z projektem podziału")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv21_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "22 Mapa z wstępnym projektem podziału")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv22_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "23 Miejscowy plan zagospodarowania przestrzennego")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv23_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "24 Odpowiedź na zgłoszenie pracy geodezyjnej")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv24_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "25 Opinia")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv25_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "26 Opis i mapa, wypis i wyrys")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv26_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "27 Opis topograficzny")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv27_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "28 Orzeczenie, wyrok sądu")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv28_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "29 Oświadczenie")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv29_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "30 Postanowienie")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv30_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "31 Protokół badania księgi wieczystej, odpis")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv31_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "32 Protokół graniczny")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv32_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "33 Protokół inny")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv33_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "34 Protokół katastralny, parcelowy")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv34_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "35 Raport inny")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv35_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "36 Raport pomiarowy rtk/rtn")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv36_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "37 Rejestr archiwalny")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv37_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "38 Rejestr inny")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv38_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "39 Rejestr przed/po scaleniowy")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv39_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "40 Skorowidz/wykaz działek")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv40_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "41 Skorowidz/wykaz właścicieli")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv41_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "42 Spis treści")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv42_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "43 Sprawozdanie techniczne")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv43_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "44 Strona tytułowa")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv44_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "45 Szkic inny")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv45_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "46 Szkic katastralny, podstawowy")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv46_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "47 Szkic osnowy")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv47_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "48 Szkic polowy")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv48_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "49 Szkic przeglądowy")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv49_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "50 Transformacja punktów")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv50_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "51 Ugoda")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv51_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "52 Upoważnienie, pełnomocnictwo")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv52_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "53 Wniosek inny")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv53_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "54 Wniosek o przyjęcie dokumentacji do zasobu")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv54_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "55 Wykaz synchronizacyjny")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv55_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "56 Wykaz współrzędnych")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv56_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "57 Wykaz wywłaszczeniowy")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv57_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "58 Wykaz zmian danych ewidencyjnych")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv58_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "59 Zarys katastralny")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv59_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "60 Zarys pomiarowy")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv60_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "61 Zaświadczenie")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv61_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "62 Zawiadomienie o wykonaniu zgłoszonych prac")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv62_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "63 Zawiadomienie z wydziału kw")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv63_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "64 Zawiadomienie, powiadomienie")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv64_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "65 Zgłoszenie pracy geodezyjnej")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv65_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "66 Zwrotne potwierdzenie odbioru")
                {
                    wczytaj_pliki_do_lvXX_po_tom(lv66_toperat_pliki);
                }
            }
        }

        private void cb_SetCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_SetCombo.Items.Count > 1)
            {
                lv1.Clear();
                if (CB_rodzaj_dok.SelectedItem == "1 Akt notarialny")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv01_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "2 Akt własności ziemi")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv02_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "3 Analiza materiałów źródłowych")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv03_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "4 Arkusz danych ewidencyjnych budynków")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv04_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "5 Arkusz danych ewidencyjnych lokali")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv05_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "6 Artykuł matrykuły lub matrykuła")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv06_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "7 Decyzja")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv07_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "8 Dokument inny")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv08_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "9 Dokument wyjściowy")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv09_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "10 Dokumentacja obliczeniowa")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv10_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "11 Dziennik pomiarowy")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv11_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "12 Dziennik robót, prac")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv12_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "13 Księga budynkowa")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv13_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "14 Księga parcel")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv14_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "15 Mapa gleboznawczej klasyfikacji gruntów")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv15_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "16 Mapa inna")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv16_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "17 Mapa katastralna, stanu prawnego")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv17_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "18 Mapa powykonawcza, wynikowa pracy")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv18_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "19 Mapa uzupełniająca")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv19_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "20 Mapa wywiadu")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv20_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "21 Mapa z projektem podziału")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv21_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "22 Mapa z wstępnym projektem podziału")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv22_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "23 Miejscowy plan zagospodarowania przestrzennego")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv23_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "24 Odpowiedź na zgłoszenie pracy geodezyjnej")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv24_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "25 Opinia")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv25_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "26 Opis i mapa, wypis i wyrys")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv26_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "27 Opis topograficzny")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv27_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "28 Orzeczenie, wyrok sądu")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv28_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "29 Oświadczenie")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv29_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "30 Postanowienie")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv30_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "31 Protokół badania księgi wieczystej, odpis")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv31_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "32 Protokół graniczny")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv32_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "33 Protokół inny")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv33_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "34 Protokół katastralny, parcelowy")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv34_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "35 Raport inny")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv35_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "36 Raport pomiarowy rtk/rtn")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv36_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "37 Rejestr archiwalny")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv37_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "38 Rejestr inny")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv38_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "39 Rejestr przed/po scaleniowy")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv39_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "40 Skorowidz/wykaz działek")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv40_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "41 Skorowidz/wykaz właścicieli")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv41_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "42 Spis treści")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv42_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "43 Sprawozdanie techniczne")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv43_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "44 Strona tytułowa")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv44_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "45 Szkic inny")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv45_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "46 Szkic katastralny, podstawowy")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv46_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "47 Szkic osnowy")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv47_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "48 Szkic polowy")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv48_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "49 Szkic przeglądowy")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv49_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "50 Transformacja punktów")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv50_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "51 Ugoda")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv51_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "52 Upoważnienie, pełnomocnictwo")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv52_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "53 Wniosek inny")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv53_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "54 Wniosek o przyjęcie dokumentacji do zasobu")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv54_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "55 Wykaz synchronizacyjny")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv55_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "56 Wykaz współrzędnych")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv56_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "57 Wykaz wywłaszczeniowy")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv57_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "58 Wykaz zmian danych ewidencyjnych")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv58_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "59 Zarys katastralny")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv59_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "60 Zarys pomiarowy")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv60_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "61 Zaświadczenie")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv61_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "62 Zawiadomienie o wykonaniu zgłoszonych prac")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv62_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "63 Zawiadomienie z wydziału kw")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv63_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "64 Zawiadomienie, powiadomienie")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv64_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "65 Zgłoszenie pracy geodezyjnej")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv65_toperat_pliki);
                }
                if (CB_rodzaj_dok.SelectedItem == "66 Zwrotne potwierdzenie odbioru")
                {
                    wczytaj_pliki_do_lvXX_po_set(lv66_toperat_pliki);
                }
            }
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------
    }
}