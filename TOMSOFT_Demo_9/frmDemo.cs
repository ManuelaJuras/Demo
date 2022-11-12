using restClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace TOMSOFT_Demo_9
{
    public partial class frmDemo : Form
    {
        public int x { get; set; }

        public static string input = "";
        public static string input2 = "";

        public static string[] jdata = new string[0];

        public frmDemo()
        {
            InitializeComponent();

            txtDatumOdP.Mask = "00/00/0000";
            txtDatumOdP.ValidatingType = typeof(DateTime);
            txtDatumDoP.Mask = "00/00/0000";
            txtDatumDoP.ValidatingType = typeof(DateTime);
            txtDatumOdA.Mask = "00/00/0000";
            txtDatumOdA.ValidatingType = typeof(DateTime);
            txtDatumDoA.Mask = "00/00/0000";
            txtDatumDoA.ValidatingType = typeof(DateTime);

            txtNazivArtila.Text = "";
            txtNazivArtila.Select();
            txtNazivArtila.Focus();

            tabSvastaNesto.SelectedIndexChanged += new EventHandler(tabSvastaNesto_SelectedIndexChanged);
            this.KeyDown += frmDemo_KeyDown;
            this.KeyPreview = true;
        }
        private void frmDemo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == System.Windows.Forms.Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
        private void tabSvastaNesto_SelectedIndexChanged(Object sender, EventArgs e)
        {
            if (tabSvastaNesto.SelectedTab.Name == "tabObracunArtikli")
            {
                txtPoslovnaJedinicaP .Select();
                txtPoslovnaJedinicaP.Focus();
                x = 2;
            }
            else if (tabSvastaNesto.SelectedTab.Name == "tabArtikli")
            {
                txtNazivArtila.Select();
                txtNazivArtila.Focus();
                x = 0;
            }
            else if (tabSvastaNesto.SelectedTab.Name == "tabObracunPlacanje")
            {
                txtNazivArtila.Select();
                txtNazivArtila.Focus();
                x = 1;
            }  
        }

        private void btnTrazi_Click(object sender, EventArgs e)
        {
            RESTClient rClient = new RESTClient();
                rClient.endpointURLnumber = x;
                rClient.paramNaziv = txtNazivArtila.Text;
                string strJSON = string.Empty;
                strJSON = rClient.makeRequest();
                try
                {
                    Data.ArtikliRoot artikliRoot = JsonConvert.DeserializeObject<Data.ArtikliRoot>(strJSON);

                    // inicijalizacija grida
                    grdArtikli.Rows.Clear();
                    grdArtikli.Columns.Clear();
                    grdArtikli.Refresh();
                    grdArtikli.Columns.Add("id", "ID");
                    grdArtikli.Columns.Add("naziv", "Naziv");
                    grdArtikli.Columns["id"].Width = 80;
                    grdArtikli.Columns["naziv"].Width = 320;

                    foreach (var Artikl in artikliRoot.result[0].artikli)
                    {
                        var index = grdArtikli.Rows.Add();
                        grdArtikli.Rows[index].Cells["id"].Value = Artikl.id.ToString();
                        grdArtikli.Rows[index].Cells["naziv"].Value = Artikl.naziv.ToString();
                }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
                }
        }

        private void btnTrazi2_Click(object sender, EventArgs e)
        {
            RESTClient rClient = new RESTClient();
                rClient.endpointURLnumber = x;
                rClient.paramPJID  = txtPoslovnaJedinicaP.Text;

            if (txtPoslovnaJedinicaP.Text == "")
            {
                MessageBox.Show("Poslovna jedinica mora biti upisana!");
                txtPoslovnaJedinicaP.Focus();
                return;
            }
            if (txtDatumOdP.Text== "  .  ." || txtDatumDoP.Text == "  .  .")
              {
                MessageBox.Show("Upišite datum!");
                return;
            }
                else
              {
                DateTime bla = Convert.ToDateTime(txtDatumOdP.Text);
                rClient.paramDatumOd = (bla.Day + "." + bla.Month + "." + bla.Year);  
                bla = Convert.ToDateTime(txtDatumDoP.Text);
                rClient.paramDatumDo = (bla.Day + "." + bla.Month + "." + bla.Year);
            }
           
            string strJSON = string.Empty;
            strJSON = rClient.makeRequest();
                try
                {
                    Data.ObracunPlacanjaRoot obracunPlacanjaRoot = JsonConvert.DeserializeObject<Data.ObracunPlacanjaRoot>(strJSON);
                // inicijalizacija grida
                grdObracunPlacanje.Rows.Clear();
                grdObracunPlacanje.Columns.Clear();
                grdObracunPlacanje.Refresh();
                grdObracunPlacanje.Columns.Add("id", "ID");
                grdObracunPlacanje.Columns.Add("naziv", "Naziv");
                grdObracunPlacanje.Columns.Add("iznos", "Iznos");
               

                grdObracunPlacanje.Columns["id"].Width = 80;
                grdObracunPlacanje.Columns["naziv"].Width = 200;

                    foreach (var obracunP in obracunPlacanjaRoot.result[0].obracun_placanja)
                    {
                        var index = grdObracunPlacanje.Rows.Add();
                        grdObracunPlacanje.Rows[index].Cells["id"].Value = obracunP.vrste_placanja_uid.ToString();
                        grdObracunPlacanje.Rows[index].Cells["naziv"].Value = obracunP.naziv.ToString();
                        grdObracunPlacanje.Rows[index].Cells["iznos"].Value = obracunP.iznos.ToString();
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
                }
            
        }

        private void btnTrazi3_Click(object sender, EventArgs e)
        {
            RESTClient rClient = new RESTClient();
                rClient.endpointURLnumber = x;
                rClient.paramPJID = txtPoslovnaJedinicaA.Text;
                if (txtPoslovnaJedinicaA.Text == "")
                {
                    MessageBox.Show("Poslovna jedinica mora biti upisana!");
                    txtPoslovnaJedinicaA.Focus();
                    return;
                }
                if (txtDatumOdA.Text == "  .  ." || txtDatumDoA.Text == "  .  .")
                {
                    MessageBox.Show("Upišite datum!");
                    return;
                }
                else
                {
                    DateTime bla = Convert.ToDateTime(txtDatumOdA.Text);
                    rClient.paramDatumOd = (bla.Day + "." + bla.Month + "." + bla.Year);
                    bla = Convert.ToDateTime(txtDatumDoA.Text);
                    rClient.paramDatumDo = (bla.Day + "." + bla.Month + "." + bla.Year);
                }

                string strJSON = string.Empty;
                strJSON = rClient.makeRequest();
                try
                {
                    Data.ObracunArtikliRoot obracunArtikliRoot = JsonConvert.DeserializeObject<Data.ObracunArtikliRoot>(strJSON);

                    // inicijalizacija grida

                    grdObracunArtikli.Rows.Clear();
                    grdObracunArtikli.Columns.Clear();
                    grdObracunArtikli.Refresh();

                    grdObracunArtikli.Columns.Add("id", "ID");
                    grdObracunArtikli.Columns.Add("naziv", "Naziv");
                    grdObracunArtikli.Columns.Add("iznos", "Iznos");
                   
                    grdObracunArtikli.Columns["id"].Width = 80;
                    grdObracunArtikli.Columns["naziv"].Width = 200;

                    foreach (var obracunA in obracunArtikliRoot.result[0].obracun_artikli)
                    {
                        string artiklID = "";
                        string artiklNaziv = "";

                        if (obracunA.artikl_uid != null) { artiklID = obracunA.artikl_uid.ToString(); }
                        if (obracunA.naziv_artikla != null) { artiklNaziv = obracunA.naziv_artikla.ToString(); }
   
                        var index = grdObracunArtikli.Rows.Add();

                        grdObracunArtikli.Rows[index].Cells["id"].Value = artiklID;
                        grdObracunArtikli.Rows[index].Cells["naziv"].Value = artiklNaziv;
                        grdObracunArtikli.Rows[index].Cells["iznos"].Value = obracunA.iznos.ToString();
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
                } 
        }
    }

}