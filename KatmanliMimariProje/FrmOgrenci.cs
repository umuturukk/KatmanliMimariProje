using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccesLayer;
using BusinessLayer;

namespace KatmanliMimariProje
{ 
  
    public partial class FrmOgrenci : Form
    {
        public void MesajVer()
        {
            MessageBox.Show("İşlem başarıyla gerçekleşti.", "Başarılı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public FrmOgrenci()
        {
            InitializeComponent();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            EntityOgrenci ent = new EntityOgrenci();
            ent.Ad = TxtOgrenciAd.Text;
            ent.Soyad = TxtOgrenciSoyad.Text;
            ent.Numara = MskNumara.Text;
            ent.Bolum = TxtBolum.Text;
            BLOgrenci.OgrenciEkleBL(ent);
            MesajVer();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            List<EntityOgrenci> ogrenciler = BLOgrenci.OgrenciListesiBL();
            dataGridView1.DataSource = ogrenciler;
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int deger = int.Parse(TxtOgrenciID.Text);
            EntityOgrenci en = new EntityOgrenci();
            en.OgrID = deger;
            BLOgrenci.OgrenciSilBL(en.OgrID);
            MesajVer();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            EntityOgrenci ent = new EntityOgrenci();
            ent.Ad = TxtOgrenciAd.Text;
            ent.Soyad = TxtOgrenciSoyad.Text;
            ent.Bolum = TxtBolum.Text;
            ent.Numara = MskNumara.Text;
            ent.OgrID = int.Parse(TxtOgrenciID.Text);
            BLOgrenci.OgrenciGuncelleBL(ent);
            MesajVer();
        }
    }
}
