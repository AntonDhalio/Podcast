using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WinForm
{
    class KategoriLista: IListor
    {
        public List<Kategori> lista { get; set; } 
        

        
        public void LaddaLista(Form1 form1)
        {
            lista = new List<Kategori>();
            if (File.Exists("Kategorier.xml"))
            {
                lista.Clear();
                SerializeraKategori serializeraKategori = new SerializeraKategori();
                lista = serializeraKategori.DeserializeraLista();
                form1.UppdateralbKategorier();
                form1.UppdateraCbKategorier();

            }
        }
    }
}
