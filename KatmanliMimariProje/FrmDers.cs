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
using System.Diagnostics;

namespace KatmanliMimariProje
{
    public partial class FrmDers : Form
    {
        public void MesajVer()
        {
            MessageBox.Show("İşlem başarıyla gerçekleşti.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public FrmDers()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            EntityDers ent = new EntityDers();
            ent.DersAd = TxtDersAd.Text;
            BLDers.DersEkleBL(ent);
            MesajVer();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            List<EntityDers> ders = BLDers.DersListesiBL();
            dataGridView1.DataSource = ders;
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            byte deger = byte.Parse(TxtDersID.Text);
            EntityDers d = new EntityDers();
            d.DersID = byte.Parse(deger.ToString());
            BLDers.DersSilBL(d.DersID);
            MesajVer();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            EntityDers ent = new EntityDers();
            ent.DersAd = TxtDersAd.Text;
            ent.DersID = byte.Parse(TxtDersID.Text);
            BLDers.DersGuncelleBL(ent);
            MesajVer();
        }

        private void FrmDers_Load(object sender, EventArgs e)
        {

        }
    }
}
