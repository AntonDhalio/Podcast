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
        List<Avsnitt> avsnitt = new List<Avsnitt>();
        SerializeraKategori serializeraKategori = new SerializeraKategori();
        SerializeraPodcast serializeraPodcast = new SerializeraPodcast();

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
                kategorier = serializeraKategori.DeserializeraLista();
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
                lbKategorier.Items.Insert(0, "Visa alla");
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
                podcasts = serializeraPodcast.DeserializeraLista();
                UppdateraListView();
            }
        }
        public void UppdateraListViewContent()
        {
            podcasts = serializeraPodcast.DeserializeraLista();
            foreach (RSS podd in podcasts)
            {
                string namn = podd.namn;
                var item = this.listViewPodd.FindItemWithText(namn);
                if (this.listViewPodd.FindItemWithText(namn) != null)
                {
                    item.SubItems[1].Text = podd.antalAvsnitt;
                }

            }
            Debug.WriteLine("Uppdaterad");
        }
        public void UppdateraListView()
        {
            listViewPodd.Items.Clear();
            if (podcasts != null)
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
            bool namnLedigt = true;
            foreach(RSS podd in podcasts)
            {
                if(podd.namn.Equals(textBoxNamn.Text))
                {
                    namnLedigt = false;
                }
            }
            if (namnLedigt)
            {
                RSS podcast = new RSS
                {
                    url = textBoxURL.Text,
                    tidsIntervall = comboBoxFrekvens.Text,
                    kategori = cbKategorier.Text
                };
                podcast.namn = textBoxNamn.Text;
                podcast.antalAvsnitt = podcast.AntalAvsnitt(textBoxURL.Text);
                podcasts.Add(podcast);
                serializeraPodcast.Serializera(podcasts);
                LaddaListaPodcast();
                textBoxURL.Clear();
                textBoxNamn.Clear();
            } else
            {
                MessageBox.Show("Det finns redan en podcast med namnet " + textBoxNamn.Text + ", vänligen välj ett annat.");
            }
            

        }
        private void btnAndra_Click(object sender, EventArgs e)
        {
            if(listViewPodd.SelectedItems.Count > 0)
            {
                DialogResult resultat;
                resultat = MessageBox.Show("Är du säker på att du vill ändra informationen?", "Är du säker?", MessageBoxButtons.YesNo);
                if (resultat == DialogResult.Yes)
                {
                    String poddNamn = listViewPodd.SelectedItems[0].SubItems[0].Text;
                    RSS valdPodd = (from RSS podd in podcasts
                                    where podd.namn == poddNamn
                                    select podd).Single();
                    if (comboBoxFrekvens.SelectedIndex != -1)
                    {
                        valdPodd.tidsIntervall = comboBoxFrekvens.Text;
                    }
                    if (cbKategorier.SelectedIndex != -1)
                    {
                        valdPodd.kategori = cbKategorier.Text;
                    }
                    if (textBoxNamn.TextLength > 0)
                    {
                        valdPodd.namn = textBoxNamn.Text;
                    }
                    serializeraPodcast.Serializera(podcasts);
                    LaddaListaPodcast();
                    textBoxNamn.Clear();
                    comboBoxFrekvens.SelectedIndex = -1;
                    cbKategorier.SelectedIndex = -1;
                }
            } else
            {
                MessageBox.Show("Välj en podcast i listan att ändra.");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(listViewPodd.SelectedItems.Count > 0)
            {
                String poddNamn = listViewPodd.SelectedItems[0].SubItems[0].Text;
                DialogResult resultat;
                resultat = MessageBox.Show("Är du säker på att du vill radera podcasten " + poddNamn
                + "?" , "Är du säker?", MessageBoxButtons.YesNo);
                if (resultat == DialogResult.Yes)
                {
                    RSS valdPodd = (from RSS podd in podcasts
                                    where podd.namn == poddNamn
                                    select podd).Single();
                    podcasts.Remove(valdPodd);
                    serializeraPodcast.Serializera(podcasts);
                    LaddaListaPodcast();
                }
            } else
            {
                MessageBox.Show("Välj en podcast i listan att ta bort.");
            }
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
                Kategori kategori = new Kategori
                {
                    namn = tbKategori.Text
                };
                kategorier.Add(kategori);
                serializeraKategori.Serializera(kategorier);
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
            if (lbKategorier.SelectedItem != null && tbKategori.Text.Length != 0 && lbKategorier.SelectedIndex != 0)
            {
                String namn = lbKategorier.SelectedItem.ToString();
                LaddaListaPodcast();
                var poddar = from RSS podd in podcasts
                             where podd.kategori == namn
                             select podd;
                foreach (RSS enPodd in poddar)
                {
                    enPodd.kategori = tbKategori.Text;
                }
                Kategori attAndra = (from Kategori enKat in kategorier
                                     where enKat.namn == namn
                                     select enKat).Single();
                attAndra.namn = tbKategori.Text;
                serializeraKategori.Serializera(kategorier);
                serializeraPodcast.Serializera(podcasts);
                LaddaListaKategori();
                LaddaListaPodcast();
                tbKategori.Clear();
            }
            else
            {
                MessageBox.Show("Välj en kategori ur listan och skriv det nya namnet innan du trycker på ändra.");
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
                    List<RSS> allaPoddar = serializeraPodcast.DeserializeraLista();
                    String namn = lbKategorier.SelectedItem.ToString();
                    Kategori attTabort = (from Kategori enKat in kategorier
                                          where enKat.namn == namn
                                          select enKat).Single();
                    var poddarAttBehalla = (from RSS podd in allaPoddar
                                           where podd.kategori != namn
                                           select podd).ToList();
                    podcasts = poddarAttBehalla;
                    kategorier.Remove(attTabort);
                    serializeraKategori.Serializera(kategorier);
                    serializeraPodcast.Serializera(podcasts);
                    LaddaListaKategori();
                    LaddaListaPodcast();
                }
            }
            else
            {
                MessageBox.Show("Välj en kategori i listan att ta bort");
            }
        }

        public void UppdateraPodcastXml(string intervall)
        {
            try
            {
                List<RSS> allaPoddar = serializeraPodcast.DeserializeraLista();
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
                serializeraPodcast.Serializera(podcasts);
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

        private void listViewPodd_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = 0;
            if (listViewPodd.SelectedItems.Count > 0)
            {
                lbAvsnitt.Items.Clear();
                avsnitt.Clear();
                ListViewItem item = listViewPodd.SelectedItems[0];
                RSS valdPodd = (from RSS podd in podcasts
                                where podd.namn == item.SubItems[0].Text
                                select podd).Single();
                XmlReader xmlReader = XmlReader.Create(valdPodd.url);
                SyndicationFeed syndication = SyndicationFeed.Load(xmlReader);
                foreach (SyndicationItem ettitem in syndication.Items)
                {
                    Avsnitt ettAvsnitt = new Avsnitt
                    {
                        namn = ettitem.Title.Text,
                        Beskrivning = ettitem.Summary.Text,
                        Index = index++
                    };
                    avsnitt.Add(ettAvsnitt);
                    lbAvsnitt.Items.Add(ettAvsnitt.namn);

                }
            }
        }

        private void lbAvsnitt_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var avs = from Avsnitt ettAvs in avsnitt
                      where ettAvs.namn == lbAvsnitt.SelectedItem.ToString()
                      select ettAvs;
            int index = lbAvsnitt.SelectedIndex;
            if (avs.Count() > 1) 
            {
                foreach (Avsnitt ettAvsnitt in avs)
                {
                    if (ettAvsnitt.Index == index)
                    {
                        lblAvsnitt.Text = ettAvsnitt.namn;
                        textBox2.Text = ettAvsnitt.Beskrivning;
                    }
                }
            }
            else
            {
                foreach( Avsnitt ettAvsnitt in avs)
                {
                    lblAvsnitt.Text = ettAvsnitt.namn;
                    textBox2.Text = ettAvsnitt.Beskrivning;
                }
            }
        }

        private void lbKategorier_SelectedIndexChanged(object sender, EventArgs e)
        {
            LaddaListaPodcast();
            if (lbKategorier.SelectedIndex == 0)
            {
                UppdateraListView();
            }
            else
            {
                var poddarAttVisa = (from RSS podd in podcasts
                                     where podd.kategori.ToLower() == lbKategorier.SelectedItem.ToString().ToLower()
                                     select podd).ToList();
                podcasts = poddarAttVisa;
                UppdateraListView();
            }
        }

        private void textBoxURL_TextChanged(object sender, EventArgs e)
        {
            if(textBoxURL.TextLength > 0)
            {
                XmlReader xmlReader = XmlReader.Create(textBoxURL.Text);
                SyndicationFeed syndication = SyndicationFeed.Load(xmlReader);
                textBoxNamn.Text = syndication.Title.Text;
            }
        }
    }
}
