namespace PersonelKayıtSistemi
{
    partial class frmPersonelKayit
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
            gbxPersonelKayit = new GroupBox();
            cmbBolum = new ComboBox();
            dtmDogumTarihi = new DateTimePicker();
            rbnErkek = new RadioButton();
            rbnKadin = new RadioButton();
            txtTc = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnEkle = new Button();
            btnSil = new Button();
            btnTemizle = new Button();
            gbxPersonelKayit.SuspendLayout();
            SuspendLayout();
            // 
            // gbxPersonelKayit
            // 
            gbxPersonelKayit.Controls.Add(cmbBolum);
            gbxPersonelKayit.Controls.Add(dtmDogumTarihi);
            gbxPersonelKayit.Controls.Add(rbnErkek);
            gbxPersonelKayit.Controls.Add(rbnKadin);
            gbxPersonelKayit.Controls.Add(txtTc);
            gbxPersonelKayit.Controls.Add(txtSoyad);
            gbxPersonelKayit.Controls.Add(txtAd);
            gbxPersonelKayit.Controls.Add(label6);
            gbxPersonelKayit.Controls.Add(label4);
            gbxPersonelKayit.Controls.Add(label5);
            gbxPersonelKayit.Controls.Add(label3);
            gbxPersonelKayit.Controls.Add(label2);
            gbxPersonelKayit.Controls.Add(label1);
            gbxPersonelKayit.Location = new Point(44, 46);
            gbxPersonelKayit.Name = "gbxPersonelKayit";
            gbxPersonelKayit.Size = new Size(371, 229);
            gbxPersonelKayit.TabIndex = 0;
            gbxPersonelKayit.TabStop = false;
            gbxPersonelKayit.Text = "Personel Kayıt Bilgileri";
            // 
            // cmbBolum
            // 
            cmbBolum.FormattingEnabled = true;
            cmbBolum.Location = new Point(143, 178);
            cmbBolum.Name = "cmbBolum";
            cmbBolum.Size = new Size(200, 23);
            cmbBolum.TabIndex = 4;
            // 
            // dtmDogumTarihi
            // 
            dtmDogumTarihi.Location = new Point(143, 151);
            dtmDogumTarihi.Name = "dtmDogumTarihi";
            dtmDogumTarihi.Size = new Size(200, 22);
            dtmDogumTarihi.TabIndex = 3;
            // 
            // rbnErkek
            // 
            rbnErkek.AutoSize = true;
            rbnErkek.Location = new Point(244, 120);
            rbnErkek.Name = "rbnErkek";
            rbnErkek.Size = new Size(54, 19);
            rbnErkek.TabIndex = 2;
            rbnErkek.TabStop = true;
            rbnErkek.Text = "Erkek";
            rbnErkek.UseVisualStyleBackColor = true;
            // 
            // rbnKadin
            // 
            rbnKadin.AutoSize = true;
            rbnKadin.Location = new Point(143, 122);
            rbnKadin.Name = "rbnKadin";
            rbnKadin.Size = new Size(57, 19);
            rbnKadin.TabIndex = 2;
            rbnKadin.TabStop = true;
            rbnKadin.Text = "Kadın";
            rbnKadin.UseVisualStyleBackColor = true;
            // 
            // txtTc
            // 
            txtTc.BorderStyle = BorderStyle.FixedSingle;
            txtTc.Location = new Point(143, 90);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(200, 22);
            txtTc.TabIndex = 1;
            // 
            // txtSoyad
            // 
            txtSoyad.BorderStyle = BorderStyle.FixedSingle;
            txtSoyad.Location = new Point(143, 61);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(200, 22);
            txtSoyad.TabIndex = 1;
            // 
            // txtAd
            // 
            txtAd.BorderStyle = BorderStyle.FixedSingle;
            txtAd.Location = new Point(143, 30);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(200, 22);
            txtAd.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 186);
            label6.Name = "label6";
            label6.Size = new Size(96, 15);
            label6.TabIndex = 0;
            label6.Text = "Çalıştığı Bölüm : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 157);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 0;
            label4.Text = "Doğum Tarihi : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 126);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 0;
            label5.Text = "Cinsiyet : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 97);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 0;
            label3.Text = "TC No : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 68);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 0;
            label2.Text = "Personel Soyad : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 37);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "Personel Ad : ";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(178, 281);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 23);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(259, 281);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 23);
            btnSil.TabIndex = 2;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(340, 281);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(75, 23);
            btnTemizle.TabIndex = 2;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            // 
            // frmPersonelKayit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(455, 361);
            Controls.Add(btnTemizle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(gbxPersonelKayit);
            Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "frmPersonelKayit";
            Text = "Personel Kayıt";
            Load += frmPersonelKayit_Load;
            gbxPersonelKayit.ResumeLayout(false);
            gbxPersonelKayit.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxPersonelKayit;
        private ComboBox cmbBolum;
        private DateTimePicker dtmDogumTarihi;
        private RadioButton rbnErkek;
        private RadioButton rbnKadin;
        private TextBox txtTc;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Label label6;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnEkle;
        private Button btnSil;
        private Button btnTemizle;
    }
}