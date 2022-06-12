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
            AkbilGuncelleTabPageTemizlik();
            dataGridViewAkbilList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAkbilList.ContextMenuStrip = contextMenuStripAkbilSil;
            dataGridViewAkbilList.MultiSelect = false;
            
        }

        private void AkbilGuncelleTabPageTemizlik()
        {
            txtGuncelleAkbilSahibi.Clear();
            txtGuncelleSeriNo.Clear();
            comboBoxAkbilGuncelle.SelectedIndex = -1;
            comboBoxAkbilGuncelle.Text = "Akbil Seçiniz";
            groupBoxAkbilBilgileri.Enabled = false;
        }

        private void SistemdekiAktifAkbilleriGetir()
        {
            try
            {
                dataGridViewAkbilList.DataSource = akbilContext.Akbiller.Where(x=>x.AktifMi).ToList();
                comboBoxAkbilGuncelle.DataSource = akbilContext.Akbiller.Where(x => x.AktifMi).ToList();
                comboBoxAkbilGuncelle.DisplayMember = "AkbilSahibi";
                comboBoxAkbilGuncelle.ValueMember = "Id";
                AkbilGuncelleTabPageTemizlik();
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

        private void comboBoxAkbilGuncelle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAkbilGuncelle.SelectedIndex>-1)
            {
                int akbilId;
                if (!int.TryParse(comboBoxAkbilGuncelle.SelectedValue.ToString(),out akbilId))
                {
                    return;
                }
                //bulmak
                // var akbil = akbilContext.Akbiller.Find(akbilId);
                var akbil = akbilContext.Akbiller.FirstOrDefault(x=> x.Id==akbilId);
                txtGuncelleAkbilSahibi.Text = akbil.AkbilSahibi;
                txtGuncelleSeriNo.Text = akbil.SeriNumarasi;
                groupBoxAkbilBilgileri.Enabled = true;
            }
        }

        private void FrmAkbiller_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAkbikGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int akbilId = Convert.ToInt32(comboBoxAkbilGuncelle.SelectedValue.ToString());
                var akbil = akbilContext.Akbiller.FirstOrDefault(x=> x.Id==akbilId);
                if (akbil.AkbilSahibi==txtGuncelleAkbilSahibi.Text && akbil.SeriNumarasi==txtGuncelleSeriNo.Text)
                {
                    MessageBox.Show("Herhangi Bir değişiklik yapılmadı. Lütfen Değişiklik Yapınız..");
                }

                //önce şuna bakalım seri numarası tamamen rakam mı?
                if (!Akbiller.TumKarakterlerRakamMi(txtGuncelleSeriNo.Text))
                {
                    throw new Exception("Seri numarası Yalnızca Rakamlardan oluşmalıdır.");
                }

                //eğer girdiği seri no, mevcuttakinden farklıysa aynı seri numaradan var mı diye kontrol edilsin.
                if (akbil.SeriNumarasi != txtGuncelleSeriNo.Text)
                {
                    if (AyniSeriNumarasindanVarMi(txtGuncelleSeriNo.Text))
                    {
                        throw new Exception("Bu seri numarası kullanılmatadır.");
                    }
                }

                akbil.AkbilSahibi = txtGuncelleAkbilSahibi.Text;
                akbil.SeriNumarasi = txtGuncelleSeriNo.Text;
                //entity framework .nette update metodu yok.
                //Referans tip olduğu için porplarda yapılan değişikliklerler nesneye yansıyor.
                //Convtexti save changes yapmak yeterli oluyor.
                akbilContext.SaveChanges();
                //akbilcontex.akbiller.update(akbil) diye bir şey yok. - (entity framework Core ya geçene kadar yok..)
                MessageBox.Show("Akbil Bilgileri Güncellendi.");
                SistemdekiAktifAkbilleriGetir();
                AkbilGuncelleTabPageTemizlik();
                
            }
            catch (Exception hata)
            {
                MessageBox.Show("Beklenmedik Bir Hata Oluştu! \n"+hata.Message);
            }
        }

        private void softDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
               int akbilId= Convert.ToInt32(dataGridViewAkbilList.SelectedRows[0].Cells["Id"].Value);
                var akbil = akbilContext.Akbiller.FirstOrDefault(x => x.Id == akbilId);
                akbil.AktifMi = false;
                akbilContext.SaveChanges();
                MessageBox.Show("Akbil deaktif edildi.");
                SistemdekiAktifAkbilleriGetir();

            }
            catch (Exception hata)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu! "+hata.Message);
            }
        }

        private void hardDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
              int akbilId = Convert.ToInt32(dataGridViewAkbilList.SelectedRows[0].Cells["Id"].Value);
                var akbil = akbilContext.Akbiller.FirstOrDefault(x=>x.Id == akbilId);
                if (akbilContext.Talimatlar.Count(x=> x.AkbilId==akbilId)>0)
                {
                    //silinsin.
                    foreach (var item in akbilContext.Talimatlar.Where(x=>x.AkbilId==akbilId))//kaç talimat olduğunu bilmediğimiz için foreach
                    {
                        akbilContext.Talimatlar.Remove(item);
                    }
                    
                }
                //akbili siliyoruz.
                akbilContext.Akbiller.Remove(akbil);
                akbilContext.SaveChanges();
                MessageBox.Show("Akbil Sistemden Başarıyla silnmiştir.");
                SistemdekiAktifAkbilleriGetir();
            }
            catch (Exception hata)
            {

                MessageBox.Show("Beklenmedik bir hata oluştu! " + hata.Message);
            }
        }
    }

}
