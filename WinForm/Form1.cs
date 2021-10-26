using TidsIntervaller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPrenumerera_Click(object sender, EventArgs e)
        {            
            test.FileStreamer(textBoxURL.Text);
        }
       
    }
}
