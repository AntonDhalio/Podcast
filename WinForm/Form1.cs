using TidsIntervaller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WinForm
{
    public partial class Form1 : Form
    {
        static Inervall skapaIntervaller = new Inervall();
  
        RSS test = new RSS();       
       
        public Form1()
        {
            InitializeComponent();
            skapaIntervaller.CreateTimers();
            skapaIntervaller.activateTimer();
            LaddaLista();
        }

        List<Kategori> kategorier = new List<Kategori>();

        public void LaddaLista()
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPrenumerera_Click(object sender, EventArgs e)
        {            
            test.FileStreamer(textBoxURL.Text);
        }

        private void btnLaggTill_Click_1(object sender, EventArgs e)
        {
            Kategori kategori = new Kategori();
            kategori.namn = tbKategori.Text;
            kategorier.Add(kategori);
            SerializeraKategori serializering = new SerializeraKategori();
            serializering.Serializera(kategorier);
            LaddaLista();
            tbKategori.Clear();
        }

        private void btnAndra2_Click_1(object sender, EventArgs e)
        {
            if (lbKategorier.SelectedItem != null && tbKategori.Text != null)
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
                LaddaLista();
                tbKategori.Clear();
            }
            else
            {
                MessageBox.Show("Välj en kategori ut listan och skriv det nya namnet innan du trycker på ändra.");
            }
        }

        private void btnDelete2_Click_1(object sender, EventArgs e)
        {
            if (lbKategorier.SelectedItem != null)
            {
                //String namn = lbKategorier.SelectedItem.ToString();
                //var fraga = from Kategori enKat in kategorier
                //            where enKat.namn == namn
                //            select enKat;
                SerializeraKategori serializering = new SerializeraKategori();
                serializering.Serializera(kategorier);
                LaddaLista();
            }
        }
    }
}
