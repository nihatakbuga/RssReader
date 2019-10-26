using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RSS_Okuma_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox SecilenDeger = (ListBox)sender;
            Haber SecilenHaber = (Haber)SecilenDeger.SelectedItem;
            web_haberdetay.DocumentText = SecilenHaber.Aciklama;
        }

        private void btn_goster_Click(object sender, EventArgs e)
        {
            List<Haber> Kayitlar = XMLCevir();
            list_haberler.DataSource = Kayitlar;


        }
        private List<Haber>XMLCevir()
        {
            List<Haber> HaberKayitlari = new List<Haber>();
            XDocument XMLKaynak = XDocument.Load(txt_rssurl.Text);
            List<XElement> Rows = XMLKaynak.Descendants("item").ToList();
            foreach (XElement item in Rows)
            {
                Haber Temp = new Haber();
                Temp.Baslik = item.Element("title").Value;
                Temp.Link = item.Element("link").Value;
                Temp.Aciklama = item.Element("description").Value;
                HaberKayitlari.Add(Temp);
                
            }
            return HaberKayitlari;
        }
    }
}
