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
        KategoriLista kategoriLista1 = new KategoriLista();
        RssLista rssLista1 = new RssLista();
        Intervall intervaller = new Intervall();
        List<Avsnitt> avsnitt = new List<Avsnitt>();
        SerializeraKategori serializeraKategori = new SerializeraKategori();
        SerializeraPodcast serializeraPodcast = new SerializeraPodcast();

        public Form1()
        {
            InitializeComponent();
            intervaller.CreateTimers();
            intervaller.activateTimer();
            kategoriLista1.LaddaLista(this);
            rssLista1.LaddaLista(this);
            listViewPodd.Sorting = SortOrder.Ascending;
            intervaller.TimerAvklaradShort += UppdateraPodcastXml;
            intervaller.TimerAvklaradMedium += UppdateraPodcastXml;
            intervaller.TimerAvklaradLong += UppdateraPodcastXml;
        }

        public void UppdateralbKategorier()
        {
            lbKategorier.Items.Clear();
            if (kategoriLista1.lista != null)
            {
                lbKategorier.Items.Insert(0, "Visa alla");
                foreach (Kategori enKategori in kategoriLista1.lista)
                {
                    lbKategorier.Items.Add(enKategori.namn);
                }
            } else
            {
                lbKategorier.Items.Add("Kategorilistan är tom");
            }
        }

        public void UppdateraCbKategorier()
        {
            cbKategorier.Items.Clear();
            List<Kategori> enLista = kategoriLista1.lista;
            if (enLista != null)
            {
                foreach (Kategori enKategori in enLista)
                {
                    cbKategorier.Items.Add(enKategori.namn);
                }
            }
        }
        public void UppdateraListViewContent()
        {
            rssLista1.lista = serializeraPodcast.DeserializeraLista();
            foreach (RSS podd in rssLista1.lista)
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
            if (rssLista1.lista != null)
            {
                foreach (RSS podd in rssLista1.lista)
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

            string urlPodcast = textBoxURL.Text;

            try
            {
                new UrlValidering(urlPodcast);

                //Validera uppdateringsfekvens o kategori
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }

            int indexFrekvens = comboBoxFrekvens.SelectedIndex;           
            try
            {
                new UppdateraComboBox(indexFrekvens);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }
            
            int indexKategori = cbKategorier.SelectedIndex;
            try
            {
                new UppdateraComboBox(indexKategori);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }
            bool namnLedigt = true;
            foreach(RSS podd in rssLista1.lista)
            {
                if(podd.namn.Equals(textBoxNamn.Text))
                {
                    namnLedigt = false;
                }
            }
            if (namnLedigt) {
                RSS podcast = new RSS
                {
                    url = textBoxURL.Text,
                    tidsIntervall = comboBoxFrekvens.Text,
                    kategori = cbKategorier.Text
                };
                podcast.namn = textBoxNamn.Text;
                podcast.antalAvsnitt = podcast.AntalAvsnitt(textBoxURL.Text);
                rssLista1.lista.Add(podcast);
                serializeraPodcast.Serializera(rssLista1.lista);
                rssLista1.LaddaLista(this);
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
                    RSS valdPodd = (from RSS podd in rssLista1.lista
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
                    serializeraPodcast.Serializera(rssLista1.lista);
                    rssLista1.LaddaLista(this);
                    textBoxNamn.Clear();
                    comboBoxFrekvens.SelectedIndex = -1;
                    cbKategorier.SelectedIndex = -1;
                }
            } else
            {
                MessageBox.Show("Välj en podcast i listan att ändra.");
            }
        }
        public void Radera(ListView listView, List<RSS> rssLista)
        {
            if (listView.SelectedItems.Count > 0)
            {
                String poddNamn = listView.SelectedItems[0].SubItems[0].Text;
                DialogResult resultat;
                resultat = MessageBox.Show("Är du säker på att du vill radera podcasten " + poddNamn
                + "?", "Är du säker?", MessageBoxButtons.YesNo);
                if (resultat == DialogResult.Yes)
                {
                    RSS valdPodd = (from RSS podd in rssLista
                                    where podd.namn == poddNamn
                                    select podd).Single();
                    rssLista.Remove(valdPodd);
                    serializeraPodcast.Serializera(rssLista);
                    rssLista1.LaddaLista(this);
                }
            }
            else
            {
                MessageBox.Show("Välj en podcast i listan att ta bort.");
            }
        }
        public void Radera(ListBox listBox, List<Kategori> kategoriLista, List<RSS> rssLista)
        {
            if (listBox.SelectedItem != null && listBox.SelectedIndex != 0)
            {
                DialogResult resultat;
                resultat = MessageBox.Show("Är du säker på att du vill radera kategorin " + listBox.SelectedItem.ToString()
                    + "? Alla sparade poddar med kategorin kommer också att raderas.", "Är du säker?", MessageBoxButtons.YesNo);
                if (resultat == DialogResult.Yes)
                {
                    List<RSS> allaPoddar = serializeraPodcast.DeserializeraLista();
                    String namn = listBox.SelectedItem.ToString();
                    Kategori attTabort = (from Kategori enKat in kategoriLista
                                          where enKat.namn == namn
                                          select enKat).Single();
                    var poddarAttBehalla = (from RSS podd in allaPoddar
                                            where podd.kategori != namn
                                            select podd).ToList();
                    rssLista = poddarAttBehalla;
                    kategoriLista.Remove(attTabort);
                    serializeraKategori.Serializera(kategoriLista);
                    serializeraPodcast.Serializera(rssLista);
                    kategoriLista1.LaddaLista(this);
                    rssLista1.LaddaLista(this);
                }
            }
            else
            {
                MessageBox.Show("Välj en kategori i listan att ta bort");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Radera(listViewPodd, rssLista1.lista);
        }

        private void btnLaggTill_Click_1(object sender, EventArgs e)
        {
            string KategoriNamn = tbKategori.Text;

            try
            {
                new KategoriValidering(KategoriNamn);


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }

            bool namnLedigt = true;
            foreach (Kategori enKat in kategoriLista1.lista)
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
                kategoriLista1.lista.Add(kategori);
                serializeraKategori.Serializera(kategoriLista1.lista);
                kategoriLista1.LaddaLista(this);
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
                rssLista1.LaddaLista(this);
                var poddar = from RSS podd in rssLista1.lista
                             where podd.kategori == namn
                             select podd;
                foreach (RSS enPodd in poddar)
                {
                    enPodd.kategori = tbKategori.Text;
                }
                Kategori attAndra = (from Kategori enKat in kategoriLista1.lista
                                     where enKat.namn == namn
                                     select enKat).Single();
                attAndra.namn = tbKategori.Text;
                serializeraKategori.Serializera(kategoriLista1.lista);
                serializeraPodcast.Serializera(rssLista1.lista);
                kategoriLista1.LaddaLista(this);
                rssLista1.LaddaLista(this);
                tbKategori.Clear();
            }
            else
            {
                MessageBox.Show("Välj en kategori ur listan och skriv det nya namnet innan du trycker på ändra.");
            }
        }

        private void btnDelete2_Click_1(object sender, EventArgs e)
        {
            Radera(lbKategorier, kategoriLista1.lista, rssLista1.lista);
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
                rssLista1.lista = tillfallig;
                serializeraPodcast.Serializera(rssLista1.lista);
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

        public void SortertaKategori()
        {
            rssLista1.LaddaLista(this);
            if (lbKategorier.SelectedIndex == 0)
            {
                UppdateraListView();
            }
            else if (lbKategorier.SelectedItem == null)
            {
                Debug.WriteLine("Denna ruta är tom");
            }
            else
            {
                var attVisa = (from RSS podd in rssLista1.lista
                            where podd.kategori.ToLower() == lbKategorier.SelectedItem.ToString().ToLower()
                            select podd).ToList();
                rssLista1.lista = attVisa;
                UppdateraListView();
            }
        }

        private void listViewPodd_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = 0;
            if (listViewPodd.SelectedItems.Count > 0)
            {
                lbAvsnitt.Items.Clear();
                avsnitt.Clear();
                ListViewItem item = listViewPodd.SelectedItems[0];
                RSS valdPodd = (from RSS podd in rssLista1.lista
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
            rssLista1.LaddaLista(this);
            if (lbKategorier.SelectedIndex == 0)
            {
                UppdateraListView();
            }
            else
            {
                var poddarAttVisa = (from RSS podd in rssLista1.lista
                                     where podd.kategori.ToLower() == lbKategorier.SelectedItem.ToString().ToLower()
                                     select podd).ToList();
                rssLista1.lista = poddarAttVisa;
                UppdateraListView();
            }
        }

        private void textBoxURL_TextChanged(object sender, EventArgs e)
        {
            if(textBoxURL.TextLength > 0)
            {
                try
                {
                    XmlReader xmlReader = XmlReader.Create(textBoxURL.Text);
                    SyndicationFeed syndication = SyndicationFeed.Load(xmlReader);
                    textBoxNamn.Text = syndication.Title.Text;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }
        }
    }
}
