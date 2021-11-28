using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Data_Layer;

namespace Business_Layer
{
    public class KategoriLista: IListor
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
        public async Task LaddaListaAsync(Form1 form1)
        {
                await Task.Run(() =>
                {
                lista = new List<Kategori>();
                    if (File.Exists("Kategorier.xml"))
                    {
                        lista.Clear();
                        SerializeraKategori serializeraKategori = new SerializeraKategori();
                        lista = serializeraKategori.DeserializeraLista();
                    }
                });
        }
    }
}
