using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelKayıtSistemi
{
    public partial class frmPersonelKayit : Form
    {
        private static int id = 1;
        List<string> list = new List<string>();
        string ad = string.Empty;
        string soyad = string.Empty;
        string tc = string.Empty;
        string cinsiyet = string.Empty;
        string dogumTarihi = string.Empty;
        string calistigiBolum = string.Empty;






        //SortedList<int, string[]> personelBilgileri = new SortedList<int, string[]>();

        public frmPersonelKayit()
        {
            InitializeComponent();
        }
        static public string personel;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            PersonelBilgileriAl();
            id = list.Count();
            //personelBilgileri.Add(id, new string[] { ad, soyad, tc, dogumTarihi, calistigiBolum });
            string personel = $"{id},{ad},{soyad},{tc},{dogumTarihi},{calistigiBolum}";
            
            list.Add(personel);
            VeriyiKaydet(personel);
            id++;

        }


        /// <summary>
        /// Personel bilgilerini girdiren metottur.
        /// </summary>
        private void PersonelBilgileriAl()
        {
            ad = txtAd.Text;
            soyad = txtSoyad.Text;
            tc = txtTc.Text;
            dogumTarihi = dtmDogumTarihi.Text;
            cinsiyet = rbnKadin.Checked ? "Bayan" : "Erkek";//ternary if
            calistigiBolum = cmbBolum.Text;
            TCNoKontrolEt(tc);
        }

        private void VeriyiKaydet(string personel)
        {
            using FileStream fs = new FileStream("Personel_Bilgileri.txt", FileMode.Append, FileAccess.Write);//burası formu oluşturur. txt
            //FileMode.OpenOrCreate komutu "Personel_Bilgileri.txt" dosyası var mı var sa içine yaz yoksa oluşturup içine bilgileri yazdırma işlemi yap diyor aşağıdaki bilgilere göre...

            using (StreamWriter writer = new StreamWriter(fs))//burada forma yazdırır.
            {
                writer.WriteLine(personel); //"\t" bir tab boşluk bırakır.
                MessageBox.Show("Kayıt Başarılı");
            }
        }

        private void frmPersonelKayit_Load(object sender, EventArgs e)// burasıda kayıtları listeye okuyup geri getiriyor.
        {

            using FileStream fs = new FileStream("Personel_Bilgileri.txt", FileMode.Open, FileAccess.Read);
            using StreamReader sr = new StreamReader(fs);
            string line;
            do
            {
                line = sr.ReadLine();
                list.Add(line);
            } while (line != null);
        }

        private void TCNoKontrolEt(string sayı)
        {
            long longTcNo;
            bool geçersizDeğer = !long.TryParse(sayı, out longTcNo);
            if (geçersizDeğer)
            {
                MessageBox.Show("Hatalı giriş yaptınız. Lütfen TC Numaranızı girerken sayısal bir değer giriniz.");
            }



            int size = sayı.Length;
            if (size != 11)
            {
                MessageBox.Show("Hatalı giriş yaptınız. TC Kimlik Numarası 11 haneli olmalıdır.");
            }



            char karakter = Convert.ToChar(sayı.Substring(0, 1));
            if (karakter == '0')
            {
                MessageBox.Show("Hatalı giriş yaptınız. TC Kimlik Numarasının ilk hanesi 0(sıfır) olamaz.");
            }



            int tekToplam = 0;
            int çiftToplam = 0;
            for (int i = 0; i < 9; i++)
            {
                int intKarakter = Convert.ToInt32(sayı.Substring(i, 1));
                if (i % 2 == 0)
                {
                    tekToplam = tekToplam + intKarakter;
                }
                else
                {
                    çiftToplam = çiftToplam + intKarakter;
                }
            }
            int karakter10 = Convert.ToInt32(sayı.Substring(9, 1));
            int mod10 = (tekToplam * 7) - çiftToplam;
            if (mod10 % 10 != karakter10)
            {
                MessageBox.Show("Hatalı giriş yaptınız. " + (mod10 % 10) + " != " + karakter10 + " 1, 3, 5, 7 ve 9. hanelerin toplamının 7 katından; 2, 4, 6 ve 8. hanelerin toplamı çıkartıldığında, elde edilen sonucun 10’a bölümünden kalan bize 10. haneyi vermelidir.");
            }



            int karakter11 = Convert.ToInt32(sayı.Substring(10, 1));
            int mod11 = tekToplam + çiftToplam + karakter10;
            if (mod11 % 10 != karakter11)
            {
                MessageBox.Show("Hatalı giriş yaptınız. " + (mod11 % 10) + " != " + karakter11 + " 1, 2, 3, 4, 5, 6, 7, 8, 9 ve 10. hanelerin toplamından elde edilen sonucun 10’a bölümünden kalan bize 11. haneyi vermelidir.");
            }
        }
    }
}



