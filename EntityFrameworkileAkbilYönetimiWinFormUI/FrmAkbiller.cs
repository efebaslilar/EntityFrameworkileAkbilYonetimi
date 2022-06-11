using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityFrameworkileAkbilYönetimiDAL;

namespace EntityFrameworkileAkbilYönetimiWinFormUI
{
    public partial class FrmAkbiller : Form
    {
        AkbilYonetimDBEntities akbilContext = new AkbilYonetimDBEntities();


        public FrmAkbiller()
        {
            InitializeComponent();
        }

        private void FrmAkbiller_Load(object sender, EventArgs e)
        {
            SistemdekiAktifAkbilleriGetir();
        }

        private void SistemdekiAktifAkbilleriGetir()
        {
            try
            {
                dataGridViewAkbilList.DataSource = akbilContext.Akbiller.Where(x=>x.AktifMi).ToList();
            }
            catch (Exception hata)
            {

                MessageBox.Show("Beklenmeyen bir hata oluştu!"+hata.Message);
            }
        }

        private void btnAkbilEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtAdSoyad.Text))
                {
                    throw new Exception("Abil Sahibi alanı boş geçilmez!");
                }
                Akbiller yeniAkbil = new Akbiller();
                yeniAkbil.AkbilSahibi = txtAdSoyad.Text;
                yeniAkbil.AktifMi = true;
                yeniAkbil.KayitTarihi = DateTime.Now;
                yeniAkbil.SeriNumarasi = txtSeriNumarasi.Text;
                if (string.IsNullOrEmpty(txtSeriNumarasi.Text))
                {
                    //eğer içi boş ise yani kullanıcı seri numarası yazmadıysa biz rastgele seri numarası üreteceğiz
                    yeniAkbil.SeriNumarasi = RastgeleSeriNumarasiOlustur();
                }
                else if (!Akbiller.TumKarakterlerRakamMi(yeniAkbil.SeriNumarasi))
                {
                    throw new Exception("Seri numarasın sadece rakamlardan oluşmalıdır!");
                }
                else if (AyniSeriNumarasindanVarMi(yeniAkbil.SeriNumarasi))
                {
                    throw new Exception("Bu seri numarası sistemde zaten kayıtlıdır!");
                }

                //akbil dbye ekle
                //teşbih yaptık:D
                akbilContext.Akbiller.Add(yeniAkbil);//insert into cümlesi gibi
                akbilContext.SaveChanges();//executenonquery gibi düşünebilirsiniz.
                MessageBox.Show("Yeni akbil eklendi.");
                txtAdSoyad.Clear();
                txtSeriNumarasi.Clear();
                SistemdekiAktifAkbilleriGetir();
                tabControlAkbiller.SelectedTab = tabControlAkbiller.TabPages["tabPageAkbilList"];


            }
            catch (Exception hata)
            {

                MessageBox.Show("Beklenmeyen Bir hata oluştu!"+hata.Message);
            }
        }
        string RastgeleSeriNumarasiOlustur()
        {
            try
            {
                string serialNo = string.Empty;
                Random rnd = new Random();
                do
                {
                    serialNo = string.Empty;
                    for (int i = 0; i <= 15; i++)
                    {
                        serialNo += rnd.Next(0, 9).ToString();
                    }
                } while (AyniSeriNumarasindanVarMi(serialNo));
                return serialNo;
            }
            catch (Exception)
            {
                throw;
            }
        }

        bool AyniSeriNumarasindanVarMi(string seriNumarasi)
        {
            try
            {
                if (seriNumarasi.Length != 16)
                {
                    throw new Exception("Hata! Seri Numarası 16 hane olmalıdır.");
                }
                if (akbilContext.Akbiller.Count(x=>x.SeriNumarasi==seriNumarasi)>0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }

}
