namespace PersonelKayıtSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void yeniKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonelKayit kayit = new frmPersonelKayit();
            kayit.MdiParent = this;
            kayit.Dock = DockStyle.Fill;
            kayit.FormBorderStyle = FormBorderStyle.None;
            kayit.Show();
        }

        private void personelleriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonelListesi frmPersonelListesi = new frmPersonelListesi();
            frmPersonelListesi.Show();
        }
    }
}