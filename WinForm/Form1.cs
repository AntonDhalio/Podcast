using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Xml;
using System.Xml.Linq;
using System.ServiceModel.Syndication;
using System.Xml.Serialization;
using System.Threading;

namespace WinForm
{
    public partial class Form1 : Form
    {
        Intervall intervaller = new Intervall();
        List<Kategori> kategorier = new List<Kategori>();
        List<RSS> podcasts = new List<RSS>();

        public Form1()
        {
            InitializeComponent();
            intervaller.CreateTimers();
            intervaller.activateTimer();
            LaddaListaKategori();
            LaddaListaPodcast();
            listViewPodd.Sorting = SortOrder.Ascending;
            intervaller.TimerAvklaradShort += UppdateraPodcastXml;
            intervaller.TimerAvklaradMedium += UppdateraPodcastXml;
            intervaller.TimerAvklaradLong += UppdateraPodcastXml;
        }     

        public void LaddaListaKategori()
        {
            if (File.Exists("Kategorier.xml"))
            {
                kategorier.Clear();
                SerializeraKategori xmlSerializering = new SerializeraKategori();
                kategorier = xmlSerializering.DeserializeraLista();
                UppdateralbKategorier();
                UppdateraCbKategorier();
                
            }
            else
            {
                lbKategorier.Items.Add("Kategorilistan är tom");
            }
        }

        public void UppdateralbKategorier()
        {
            lbKategorier.Items.Clear();
            if (kategorier != null)
            {
                foreach (Kategori enKategori in kategorier)
                {
                    lbKategorier.Items.Add(enKategori.namn);
                }
            }
        }

        public void UppdateraCbKategorier()
        {
            cbKategorier.Items.Clear();
            if (kategorier != null)
            {
                foreach (Kategori enKategori in kategorier)
                {
                    cbKategorier.Items.Add(enKategori.namn);
                }
            }
        }
        public void LaddaListaPodcast()
        {
            if (File.Exists("PodcastLista.xml"))
            {
                podcasts.Clear();
                SerializeraPodcast xmlSerializering = new SerializeraPodcast();
                podcasts = xmlSerializering.DeserializeraLista();
                UppdateraListView();
            }
            else
            {
                
            }
        }
        public void UppdateraListViewContent()
        {
            SerializeraPodcast serializering = new SerializeraPodcast();
            podcasts = serializering.DeserializeraLista();
            foreach (RSS podd in podcasts)
            {
                string namn = podd.namn;
                var item = this.listViewPodd.FindItemWithText(namn);
                item.SubItems[1].Text = podd.antalAvsnitt;
            }
            Debug.WriteLine("Uppdaterad");
        }
        public void UppdateraListView()
        {
            listViewPodd.Items.Clear();
            if(podcasts != null)
            {
                foreach (RSS podd in podcasts)
                {
                    ListViewItem newItem = new ListViewItem(podd.namn);
                    newItem.SubItems.Add(podd.antalAvsnitt);
                    newItem.SubItems.Add(podd.tidsIntervall);
                    newItem.SubItems.Add(podd.kategori);
                    listViewPodd.Items.Add(newItem);
                }
            }
        }

        private void btnPrenumerera_Click(object sender, EventArgs e)
        {
            RSS podcast = new RSS();
            podcast.url = textBoxURL.Text;
            podcast.tidsIntervall = comboBoxFrekvens.Text;
            podcast.kategori = cbKategorier.Text;
            podcast.namn = podcast.PodcastNamn(textBoxURL.Text);
            podcast.antalAvsnitt = podcast.AntalAvsnitt(textBoxURL.Text);
            podcasts.Add(podcast);
            SerializeraPodcast serializering = new SerializeraPodcast();
            serializering.Serializera(podcasts);
            LaddaListaPodcast();
            textBoxURL.Clear();
            
        }
        private void btnAndra_Click(object sender, EventArgs e)
        {
           
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //SerializeraPodcast serializering = new SerializeraPodcast();
            //List<RSS> allaPoddar = serializering.DeserializeraLista();
            //var skaSparas = from RSS podd in allaPoddar
            //                      where podd.namn != namn
            //                      select podd;
            //List<RSS> tillfallig = new List<RSS>();
            //foreach (RSS enPodd in skaSparas)
            //{
            //    tillfallig.Add(enPodd);
            //}
        }

        private void btnLaggTill_Click_1(object sender, EventArgs e)
        {
            bool namnLedigt = true;
            foreach (Kategori enKat in kategorier)
            {
                if (tbKategori.Text.ToLower().Equals(enKat.namn.ToLower()))
                {
                    namnLedigt = false;
                }
            }
            if (namnLedigt)
            {
                Kategori kategori = new Kategori();
                kategori.namn = tbKategori.Text;
                kategorier.Add(kategori);
                SerializeraKategori serializering = new SerializeraKategori();
                serializering.Serializera(kategorier);
                LaddaListaKategori();
                tbKategori.Clear();
            }
            else
            {
                MessageBox.Show("Kategorinamnet finns redan, vänlig välj ett annat");
            }
        }

        private void btnAndra2_Click_1(object sender, EventArgs e)
        {
            if (lbKategorier.SelectedItem != null && tbKategori.Text.Length != 0)
            {
                String namn = lbKategorier.SelectedItem.ToString();
                var fraga = from Kategori enKat in kategorier
                            where enKat.namn == namn
                            select enKat;
                foreach (Kategori kat in fraga)
                {
                    kat.namn = tbKategori.Text;
                }
                SerializeraKategori serializering = new SerializeraKategori();
                serializering.Serializera(kategorier);
                LaddaListaKategori();
                tbKategori.Clear();
            }
            else
            {
                MessageBox.Show("Välj en kategori ut listan och skriv det nya namnet innan du trycker på ändra.");
            }
        }

        private void btnDelete2_Click_1(object sender, EventArgs e)
        {
            if (lbKategorier.SelectedItem != null && lbKategorier.SelectedIndex != 0)
            {
                DialogResult resultat;
                resultat = MessageBox.Show("Är du säker på att du vill radera kategorin " + lbKategorier.SelectedItem.ToString()
                    + "? Alla sparade poddar med kategorin kommer också att raderas.", "Är du säker?", MessageBoxButtons.YesNo);
                if (resultat == DialogResult.Yes)
                {
                    SerializeraPodcast serializering1 = new SerializeraPodcast();
                    List<RSS> allaPoddar = serializering1.DeserializeraLista();
                    String namn = lbKategorier.SelectedItem.ToString();
                    Kategori attTabort = (from Kategori enKat in kategorier
                                          where enKat.namn == namn
                                          select enKat).Single();
                    var poddarAttBehalla = from RSS podd in allaPoddar
                                           where podd.kategori != namn
                                           select podd;
                    List<RSS> tillfallig = new List<RSS>();
                    foreach (RSS enPodd in poddarAttBehalla)
                    {
                        tillfallig.Add(enPodd);
                    }
                    podcasts = tillfallig;
                    kategorier.Remove(attTabort);
                    SerializeraKategori serializering = new SerializeraKategori();
                    serializering.Serializera(kategorier);
                    serializering1.Serializera(podcasts);
                    LaddaListaKategori();
                    LaddaListaPodcast();
                }
            }
            else
            {
                MessageBox.Show("Välj en kategori i listan att ta bort");
            }
        }

        private void listViewPodd_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem item = listViewPodd.SelectedItems[0];
            RSS valdPodd = (from RSS podd in podcasts
                            where podd.namn == item.Text
                            select podd).Single();
            //XmlReader xmlReader = XmlReader.Create(valdPodd.url);
            textBoxURL.Text = valdPodd.namn;
            comboBoxFrekvens.Text = valdPodd.tidsIntervall;
            cbKategorier.Text = valdPodd.kategori;
        }
        public void UppdateraPodcastXml(string intervall)
        {
            try {
                SerializeraPodcast serializering = new SerializeraPodcast();
                List<RSS> allaPoddar = serializering.DeserializeraLista();
                var skaEjUppdateras = from RSS podd in allaPoddar
                                      where podd.tidsIntervall != intervall
                                      select podd;
                var skaUppdateras = from RSS podd in allaPoddar
                                    where podd.tidsIntervall == intervall
                                    select podd;
                List<RSS> tillfallig = new List<RSS>();
                foreach (RSS enPodd in skaEjUppdateras)
                {
                    tillfallig.Add(enPodd);
                }
                foreach (RSS podd in skaUppdateras)
                {
                    RSS podcast = new RSS();
                    podcast.url = podd.url;
                    podcast.tidsIntervall = podd.tidsIntervall;
                    podcast.kategori = podd.kategori;
                    podcast.namn = podd.namn;
                    podcast.antalAvsnitt = podcast.AntalAvsnitt(podd.url);
                    tillfallig.Add(podcast);

                }
                podcasts = tillfallig;
                serializering.Serializera(podcasts);
                if (listViewPodd.InvokeRequired)
                {
                    listViewPodd.Invoke(new Action(UppdateraListViewContent));
                    return;
                }
                else
                {
                    UppdateraListViewContent();
                }
            }
            catch { }
        }
    }
}
