using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PersonelKayıtSistemi
{
    public partial class frmPersonelListesi : Form
    {
        public frmPersonelListesi()
        {
            InitializeComponent();
        }
        List<string> lists = new List<string>(); 
        private async void btnListele_Click(object sender, EventArgs e)
        {
        

            frmPersonelKayit frmPersonelKayit = new frmPersonelKayit();
            using FileStream fs = new FileStream("Personel_Bilgileri.txt", FileMode.Open, FileAccess.Read);
            using StreamReader sr = new StreamReader(fs);
            string line;
            do
            {
                line = sr.ReadLine();
                lists.Add(line);
            } while (line != null);
            Listed();


        }

        private void Listed()
        {
            for (int i = 0; i < lists.Count - 1; i++)
            {
                string b = lists[i];

                char[] ayraclar = { ',' }; //ayraçlar
                var kelimeler = b.Split(ayraclar, 7);
                var satir = new ListViewItem(kelimeler);
                listView1.Items.Add(satir);
            }


        }

    }

}


