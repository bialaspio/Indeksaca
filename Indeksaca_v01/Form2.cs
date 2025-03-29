using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Indeksaca_v01.Form1;

namespace Indeksaca_v01
{
    public partial class form_DodajOperat : Form
    {
        FolderBrowserDialog ofd_dir = new FolderBrowserDialog();

        public form_DodajOperat()
        {
            InitializeComponent();
        }

        private void bt_DodOperDodajOperat_Click(object sender, EventArgs e)
        {
            // Numer operatu 
            if (!String.IsNullOrEmpty(tb_DodOperNumerOperatu.Text))
            {
                // Sciezka do operatu 
                if (!String.IsNullOrEmpty(tb_DodOperPath.Text))
                {
                   // Rodzaj operatu 
                   switch (cd_DodOperRodzajDokumentu.SelectedItem)
                   {
                        case "Operat":
                            sp_przed_dod_operat();
                            break;
                        
                        case "Dokument katastralny":
                            sp_przed_dod_mapa_kok_kat();
                            break;
                        
                        case "Mapa":
                            sp_przed_dod_operat();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Wskarz ścieżkę do katalogu z operatem.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Dodaj numer operatu.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void wypelnij_cbObreby(string jednostka)
        {
            cbObreb.Items.Clear();
            var con = polacz_z_baza();
            NpgsqlCommand cmd = new NpgsqlCommand(string.Format(@"select distinct obreb from pandora.tjednostki where jednostka_ewidencyjna like '{0}'; ",jednostka), con);
            NpgsqlDataReader obreby = cmd.ExecuteReader();

            while (obreby.Read())
            {
                cbObreb.Items.Add(obreby[0]);
            }
            con.Close();
        }

        public NpgsqlConnection polacz_z_baza()
        {
            var cs = "Host=localhost;Username=postgres;Password=aaaaaa;Database=Pandora_test";
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

        private void cbJednostka_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbObreb.Items.Clear();
            switch (cbJednostka.SelectedItem)
            {
                case "JEŻEWO":
                    wypelnij_cbObreby("JEŻEWO");
                    break;

                case "MIASTO ŚWIECIE":
                    wypelnij_cbObreby("MIASTO ŚWIECIE");
                    break;
                
                case "WARLUBIE":
                    wypelnij_cbObreby("WARLUBIE");
                    break;
                
                case "MAPY / DOKUMENTY KATASTRALNE":
                    wypelnij_cbObreby("MAPY / DOKUMENTY KATASTRALNE");
                    break;
                
                case "BUKOWIEC":
                    wypelnij_cbObreby("BUKOWIEC");
                    break;

                case "MIASTO NOWE":
                    wypelnij_cbObreby("MIASTO NOWE");
                    break;
                
                case "ŚWIECIE":
                    wypelnij_cbObreby("ŚWIECIE");
                    break;
                
                case "DRAGACZ":
                    wypelnij_cbObreby("DRAGACZ");
                    break;
                
                case "NOWE":
                    wypelnij_cbObreby("BUKOWIEC");
                    break;

                case "LNIANO":
                    wypelnij_cbObreby("LNIANO");
                    break;
                
                case "ŚWIEKATOWO":
                    wypelnij_cbObreby("ŚWIEKATOWO");
                    break;
                
                case "OSIE":
                    wypelnij_cbObreby("OSIE");
                    break;

                case "DRZYCIM":
                    wypelnij_cbObreby("DRZYCIM");
                    break;
                
                case "PRUSZCZ":
                    wypelnij_cbObreby("PRUSZCZ");
                    break;

                default:
                    MessageBox.Show("Wybierz jednostkę", "Info");
                    break;
            }
            cbObreb.ResetText();
        }

        private void bt_DodOperOtworzSciezke_Click(object sender, EventArgs e)
        {
            ofd_dir.SelectedPath = @"E:\OPERATY_SWC\";
            if (ofd_dir.ShowDialog() == DialogResult.OK)
            {
                tb_DodOperPath.Text = ofd_dir.SelectedPath;
            }
        }

        private void cd_DodOperRodzajDokumentu_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cd_DodOperRodzajDokumentu.Text)
            {
                case "Operat":
                    czysc_formularz_dodaj_operat();

                    cbJednostka.Items.Add("JEŻEWO");
                    cbJednostka.Items.Add("MIASTO ŚWIECIE");
                    cbJednostka.Items.Add("WARLUBIE");
                    cbJednostka.Items.Add("BUKOWIEC");
                    cbJednostka.Items.Add("MIASTO NOWE");
                    cbJednostka.Items.Add("ŚWIECIE");
                    cbJednostka.Items.Add("DRAGACZ");
                    cbJednostka.Items.Add("NOWE");
                    cbJednostka.Items.Add("LNIANO");
                    cbJednostka.Items.Add("ŚWIEKATOWO");
                    cbJednostka.Items.Add("OSIE");
                    cbJednostka.Items.Add("DRZYCIM");
                    cbJednostka.Items.Add("PRUSZCZ");

                    gbKataster.Enabled = false;
                    break;
                
                case "Dokument katastralny":
                    czysc_formularz_dodaj_operat();

                    cbJednostka.Items.Add("JEŻEWO");
                    cbJednostka.Items.Add("MIASTO ŚWIECIE");
                    cbJednostka.Items.Add("WARLUBIE");
                    cbJednostka.Items.Add("BUKOWIEC");
                    cbJednostka.Items.Add("MIASTO NOWE");
                    cbJednostka.Items.Add("ŚWIECIE");
                    cbJednostka.Items.Add("DRAGACZ");
                    cbJednostka.Items.Add("NOWE");
                    cbJednostka.Items.Add("LNIANO");
                    cbJednostka.Items.Add("ŚWIEKATOWO");
                    cbJednostka.Items.Add("OSIE");
                    cbJednostka.Items.Add("DRZYCIM");
                    cbJednostka.Items.Add("PRUSZCZ");

                    gbKataster.Enabled = true;
                    break;
                
                case "Mapa":
                    czysc_formularz_dodaj_operat();

                    cbJednostka.Items.Add("JEŻEWO");
                    cbJednostka.Items.Add("MIASTO ŚWIECIE");
                    cbJednostka.Items.Add("WARLUBIE");
                    cbJednostka.Items.Add("BUKOWIEC");
                    cbJednostka.Items.Add("MIASTO NOWE");
                    cbJednostka.Items.Add("ŚWIECIE");
                    cbJednostka.Items.Add("DRAGACZ");
                    cbJednostka.Items.Add("NOWE");
                    cbJednostka.Items.Add("LNIANO");
                    cbJednostka.Items.Add("ŚWIEKATOWO");
                    cbJednostka.Items.Add("OSIE");
                    cbJednostka.Items.Add("DRZYCIM");
                    cbJednostka.Items.Add("PRUSZCZ");
                    gbKataster.Enabled = false;

                    break;
            }
        }
            

        public void czysc_formularz_dodaj_operat()
        {
            cbJednostka.Items.Clear();
            cbJednostka.ResetText();
            cbObreb.Items.Clear();
            cbObreb.ResetText();
            cb_DodOperTypDokKat.ResetText();

            tb_DodOperNumerOperatu.Text = "";
            tb_DodOperOMZ.Text = "";
            tb_DodOperPath.Text = "";
            tb_DodOperRok.Text = "";
            tb_DodOperNrWRoku.Text = "";
        }


        public void dodaj_operat_do_bazy()
        {
            string dir1 = "";
            string dir2 = "";
            string dir3 = "";
            string dir4 = "";
            string sub_dir_path;

            sub_dir_path = tb_DodOperPath.Text.ToUpper().Replace(@"E:\OPERATY_SWC\", "");
            string path_operat = tb_DodOperPath.Text + @"\" + tb_DodOperNumerOperatu.Text;
            string[] dirs = sub_dir_path.Split('\\');
            int licznik = 1;

            foreach (string dir in dirs)
            {
                switch (licznik.ToString())
                {
                    case "1":
                        dir1 = dir;
                        break;

                    case "2":
                        dir2 = dir;
                        break;

                    case "3":
                        dir3 = dir;
                        break;

                    case "4":
                        dir4 = dir;
                        break;
                };

                licznik++;
            }

            string insert_query = "";


            switch (cd_DodOperRodzajDokumentu.Text)
            {
                case "Operat":
                    insert_query = string.Format("INSERT INTO pandora.toperat(numer, \"oznMaterialuZasobu\", \"path\", jednostka, obreb, status, datastatus, dir1, dir2, dir3, dir4, typdokumentu) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}','60 - Wygenerowane pliki','{5}','{6}','{7}','{8}','{9}','operat');", tb_DodOperNumerOperatu.Text, tb_DodOperOMZ.Text, tb_DodOperPath.Text.ToLower().Replace("e:\\operaty_swc\\", ""), cbJednostka.SelectedItem.ToString(), cbObreb.SelectedItem.ToString(), DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"), dir1, dir2, dir3, dir4, cd_DodOperRodzajDokumentu.SelectedItem.ToString());
                    break;

                case "Dokument katastralny":
                    insert_query = string.Format("INSERT INTO pandora.toperat(numer, \"oznMaterialuZasobu\", \"path\", jednostka, status, datastatus, dir1, dir2, dir3, dir4, typdokumentu,rodzajdokkat, rok,numwramachrocznika) VALUES ('{0}', '{1}', '{2}', '{3}','60 - Wygenerowane pliki', '{4}', '{5}','{6}','{7}','{8}',{9},{10},{11},{12});", tb_DodOperNumerOperatu.Text, tb_DodOperOMZ.Text, tb_DodOperPath.Text.ToLower().Replace("e:\\operaty_swc\\", ""), cbJednostka.SelectedItem.ToString(), DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"), dir1, dir2, dir3, dir4,cd_DodOperRodzajDokumentu.SelectedItem.ToString(), cb_DodOperTypDokKat.SelectedItem.ToString(), tb_DodOperRok.Text, tb_DodOperNrWRoku.Text);
                    break;

                case "Mapa":
                    insert_query = string.Format("INSERT INTO pandora.toperat(numer, \"oznMaterialuZasobu\", \"path\", jednostka, obreb, status, datastatus, dir1, dir2, dir3, dir4, typdokumentu) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}','60 - Wygenerowane pliki','{5}','{6}','{7}','{8}','{9}','operat');", tb_DodOperNumerOperatu.Text, tb_DodOperOMZ.Text, tb_DodOperPath.Text.ToLower().Replace("e:\\operaty_swc\\",""), cbJednostka.SelectedItem.ToString(), cbObreb.SelectedItem.ToString(), DateTime.Now.ToString("yyyy -MM-dd hh:mm:ss"), dir1, dir2, dir3, dir4, cd_DodOperRodzajDokumentu.SelectedItem.ToString()); ;
                    break;
            }

            if (!String.IsNullOrEmpty(insert_query))
            {
                var con = polacz_z_baza();
                NpgsqlCommand cmd = new NpgsqlCommand(insert_query, con);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Operat dodany do bazy", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Nie udało się wykonać zapytania :\n" + insert_query);
                }
            }
        }

        public void sp_przed_dod_operat()
        {
            // Jednostka
            if (this.cbJednostka.SelectedItem == null || this.cbJednostka.SelectedIndex == -1)
            {
                MessageBox.Show("Wybierz jednostkę !", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Obręb 
                if (this.cbObreb.SelectedItem == null || this.cbObreb.SelectedIndex == -1)
                {
                    MessageBox.Show("Wybierz obreb !", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Numer OMZ 
                    if (!String.IsNullOrEmpty(tb_DodOperOMZ.Text))
                    {
                        dodaj_operat_do_bazy();
                    }
                    else
                    {
                        DialogResult m_result = MessageBox.Show("Brak numeru OMZ. Czy dodać wpis bez OMZ.\n Wybierz Tak aby dodać wpis bez OMZ \n Nie aby powócić formularza", "Info", MessageBoxButtons.YesNo);
                        if (m_result == DialogResult.Yes)
                        {
                            dodaj_operat_do_bazy();
                        }
                        else if (m_result == DialogResult.No)
                        {
                            MessageBox.Show("Uzupełnij numer OMZ.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }

        public void sp_przed_dod_mapa_kok_kat()
        {
             if (this.cb_DodOperTypDokKat.SelectedItem == null || this.cb_DodOperTypDokKat.SelectedIndex == -1)
            {
                MessageBox.Show("Wybierz typ dokumentu katastralnego !", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
             else
            {
                if (!String.IsNullOrEmpty(tb_DodOperRok.Text))
                {
                    if (!String.IsNullOrEmpty(tb_DodOperNrWRoku.Text))
                    {
                        dodaj_operat_do_bazy();
                    }
                    else
                    {
                        MessageBox.Show("Uzupełnij numer w roku .", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Uzupełnij rok.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
