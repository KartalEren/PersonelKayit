namespace PersonelKayıtSistemi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            personelKayıtToolStripMenuItem = new ToolStripMenuItem();
            yeniKayıtToolStripMenuItem = new ToolStripMenuItem();
            personelleriListeleToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { personelKayıtToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(654, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // personelKayıtToolStripMenuItem
            // 
            personelKayıtToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { yeniKayıtToolStripMenuItem, personelleriListeleToolStripMenuItem });
            personelKayıtToolStripMenuItem.Name = "personelKayıtToolStripMenuItem";
            personelKayıtToolStripMenuItem.Size = new Size(64, 20);
            personelKayıtToolStripMenuItem.Text = "Personel";
            // 
            // yeniKayıtToolStripMenuItem
            // 
            yeniKayıtToolStripMenuItem.Name = "yeniKayıtToolStripMenuItem";
            yeniKayıtToolStripMenuItem.Size = new Size(180, 22);
            yeniKayıtToolStripMenuItem.Text = "Yeni Kayıt";
            yeniKayıtToolStripMenuItem.Click += yeniKayıtToolStripMenuItem_Click;
            // 
            // personelleriListeleToolStripMenuItem
            // 
            personelleriListeleToolStripMenuItem.Name = "personelleriListeleToolStripMenuItem";
            personelleriListeleToolStripMenuItem.Size = new Size(180, 22);
            personelleriListeleToolStripMenuItem.Text = "Personelleri Listele";
            personelleriListeleToolStripMenuItem.Click += personelleriListeleToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 479);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "frmMdi";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem personelKayıtToolStripMenuItem;
        private ToolStripMenuItem yeniKayıtToolStripMenuItem;
        private ToolStripMenuItem personelleriListeleToolStripMenuItem;
    }
}