using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbKategori_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLaggTill_Click(object sender, EventArgs e)
        {
            
            string KategoriNamn = tbKategori.Text;
          
            try
            {
                new KategoriValidering(KategoriNamn);

                //Spara kategori namn om validering gick bra 
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnPrenumerera_Click(object sender, EventArgs e)
        {
            
            string urlPodcast = tbUrl.Text;

            try
            {
                new UrlValidering(urlPodcast);

                //Validera uppdateringsfekvens o kategori
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

                var uppdateringsFrekvens = comboBox1.SelectedItem.ToString();

            try
            {
                new UrlValidering(uppdateringsFrekvens);

                
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }


    }
}
