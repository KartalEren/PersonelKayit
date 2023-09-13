namespace PersonelKayıtSistemi
{
    partial class frmPersonelListesi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnListele = new Button();
            listView1 = new ListView();
            ChID = new ColumnHeader();
            chIsim = new ColumnHeader();
            chSoyad = new ColumnHeader();
            chTC = new ColumnHeader();
            chCinsiyet = new ColumnHeader();
            chDogumTarihi = new ColumnHeader();
            chCalistigiBolum = new ColumnHeader();
            SuspendLayout();
            // 
            // btnListele
            // 
            btnListele.Location = new Point(333, 267);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(75, 23);
            btnListele.TabIndex = 1;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = true;
            btnListele.Click += btnListele_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { ChID, chIsim, chSoyad, chTC, chCinsiyet, chDogumTarihi, chCalistigiBolum });
            listView1.Dock = DockStyle.Top;
            listView1.GridLines = true;
            listView1.Location = new Point(0, 0);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(754, 261);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // ChID
            // 
            ChID.Text = "ID";
            ChID.Width = 100;
            // 
            // chIsim
            // 
            chIsim.Text = "İsim";
            chIsim.Width = 100;
            // 
            // chSoyad
            // 
            chSoyad.Text = "Soyad";
            chSoyad.Width = 100;
            // 
            // chTC
            // 
            chTC.Text = "TC";
            chTC.Width = 150;
            // 
            // chCinsiyet
            // 
            chCinsiyet.Text = "Cinsiyet";
            chCinsiyet.Width = 100;
            // 
            // chDogumTarihi
            // 
            chDogumTarihi.Text = "Doğum Tarihi";
            chDogumTarihi.Width = 100;
            // 
            // chCalistigiBolum
            // 
            chCalistigiBolum.Text = "Çalıştığı Bölüm";
            chCalistigiBolum.Width = 100;
            // 
            // frmPersonelListesi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.NavajoWhite;
            ClientSize = new Size(754, 306);
            Controls.Add(listView1);
            Controls.Add(btnListele);
            Name = "frmPersonelListesi";
            Text = "frmPersonelListesi";
            ResumeLayout(false);
        }

        #endregion

        private Button btnListele;
        private ListView listView1;
        private ColumnHeader ChID;
        private ColumnHeader chIsim;
        private ColumnHeader chSoyad;
        private ColumnHeader chTC;
        private ColumnHeader chCinsiyet;
        private ColumnHeader chDogumTarihi;
        private ColumnHeader chCalistigiBolum;
    }
}