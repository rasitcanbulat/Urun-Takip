using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_Proje_Uygulama
{
    public partial class Frmİstatistik : Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void Frmİstatistik_Load(object sender, EventArgs e)
        {
            label2.Text = db.TBLKATEGORI.Count().ToString();
            label3.Text = db.TBLURUN.Count().ToString();
            label5.Text = db.TBLMUSTERI.Count(x=> x.DURUM == true).ToString();
            label7.Text = db.TBLMUSTERI.Count(x => x.DURUM == false).ToString();
            label13.Text = db.TBLURUN.Sum(y=> y.STOK).ToString();
            label21.Text = db.TBLSATIS.Sum(z => z.FIYAT).ToString()+ " TL";
            label11.Text = (from x in db.TBLURUN orderby x.FIYAT descending select x.URUNAD).FirstOrDefault();
            label9.Text = (from x in db.TBLURUN orderby x.FIYAT ascending select x.URUNAD).FirstOrDefault();
            label15.Text = db.TBLURUN.Count(x => x.KATEGORI == 1).ToString();
            label17.Text = db.TBLURUN.Count(x => x.URUNAD == "BUZDOLABI").ToString();
            label23.Text = (from x in db.TBLMUSTERI select x.SEHİR).Distinct().Count().ToString();


        }
    }
}
