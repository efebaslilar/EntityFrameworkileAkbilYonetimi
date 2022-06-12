
namespace EntityFrameworkileAkbilYönetimiWinFormUI
{
    partial class FrmAkbiller
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
            this.components = new System.ComponentModel.Container();
            this.comboBoxAkbilGuncelle = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAkbikGuncelle = new System.Windows.Forms.Button();
            this.txtGuncelleSeriNo = new System.Windows.Forms.TextBox();
            this.txtGuncelleAkbilSahibi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxAkbilBilgileri = new System.Windows.Forms.GroupBox();
            this.tabPageAkbilGuncelle = new System.Windows.Forms.TabPage();
            this.btnAkbilEkle = new System.Windows.Forms.Button();
            this.txtSeriNumarasi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageAkbilEkle = new System.Windows.Forms.TabPage();
            this.contextMenuStripAkbilSil = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridViewAkbilList = new System.Windows.Forms.DataGridView();
            this.tabControlAkbiller = new System.Windows.Forms.TabControl();
            this.tabPageAkbilList = new System.Windows.Forms.TabPage();
            this.talimatlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anaSayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripAkbiller = new System.Windows.Forms.MenuStrip();
            this.hardDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.softDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBoxAkbilBilgileri.SuspendLayout();
            this.tabPageAkbilGuncelle.SuspendLayout();
            this.tabPageAkbilEkle.SuspendLayout();
            this.contextMenuStripAkbilSil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAkbilList)).BeginInit();
            this.tabControlAkbiller.SuspendLayout();
            this.tabPageAkbilList.SuspendLayout();
            this.menuStripAkbiller.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxAkbilGuncelle
            // 
            this.comboBoxAkbilGuncelle.FormattingEnabled = true;
            this.comboBoxAkbilGuncelle.Location = new System.Drawing.Point(151, 49);
            this.comboBoxAkbilGuncelle.Name = "comboBoxAkbilGuncelle";
            this.comboBoxAkbilGuncelle.Size = new System.Drawing.Size(672, 21);
            this.comboBoxAkbilGuncelle.TabIndex = 0;
            this.comboBoxAkbilGuncelle.SelectedIndexChanged += new System.EventHandler(this.comboBoxAkbilGuncelle_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxAkbilGuncelle);
            this.groupBox1.Location = new System.Drawing.Point(42, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(840, 117);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Akbil Seç:";
            // 
            // btnAkbikGuncelle
            // 
            this.btnAkbikGuncelle.Location = new System.Drawing.Point(662, 46);
            this.btnAkbikGuncelle.Name = "btnAkbikGuncelle";
            this.btnAkbikGuncelle.Size = new System.Drawing.Size(161, 84);
            this.btnAkbikGuncelle.TabIndex = 4;
            this.btnAkbikGuncelle.Text = "GÜNCELLE";
            this.btnAkbikGuncelle.UseVisualStyleBackColor = true;
            this.btnAkbikGuncelle.Click += new System.EventHandler(this.btnAkbikGuncelle_Click);
            // 
            // txtGuncelleSeriNo
            // 
            this.txtGuncelleSeriNo.Location = new System.Drawing.Point(223, 96);
            this.txtGuncelleSeriNo.Name = "txtGuncelleSeriNo";
            this.txtGuncelleSeriNo.Size = new System.Drawing.Size(417, 20);
            this.txtGuncelleSeriNo.TabIndex = 3;
            // 
            // txtGuncelleAkbilSahibi
            // 
            this.txtGuncelleAkbilSahibi.Location = new System.Drawing.Point(223, 46);
            this.txtGuncelleAkbilSahibi.Name = "txtGuncelleAkbilSahibi";
            this.txtGuncelleAkbilSahibi.Size = new System.Drawing.Size(417, 20);
            this.txtGuncelleAkbilSahibi.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Seri Numarası:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Akbil Sahibi:";
            // 
            // groupBoxAkbilBilgileri
            // 
            this.groupBoxAkbilBilgileri.Controls.Add(this.btnAkbikGuncelle);
            this.groupBoxAkbilBilgileri.Controls.Add(this.txtGuncelleSeriNo);
            this.groupBoxAkbilBilgileri.Controls.Add(this.txtGuncelleAkbilSahibi);
            this.groupBoxAkbilBilgileri.Controls.Add(this.label5);
            this.groupBoxAkbilBilgileri.Controls.Add(this.label4);
            this.groupBoxAkbilBilgileri.Location = new System.Drawing.Point(42, 181);
            this.groupBoxAkbilBilgileri.Name = "groupBoxAkbilBilgileri";
            this.groupBoxAkbilBilgileri.Size = new System.Drawing.Size(840, 146);
            this.groupBoxAkbilBilgileri.TabIndex = 3;
            this.groupBoxAkbilBilgileri.TabStop = false;
            // 
            // tabPageAkbilGuncelle
            // 
            this.tabPageAkbilGuncelle.Controls.Add(this.groupBoxAkbilBilgileri);
            this.tabPageAkbilGuncelle.Controls.Add(this.groupBox1);
            this.tabPageAkbilGuncelle.Location = new System.Drawing.Point(4, 22);
            this.tabPageAkbilGuncelle.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPageAkbilGuncelle.Name = "tabPageAkbilGuncelle";
            this.tabPageAkbilGuncelle.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPageAkbilGuncelle.Size = new System.Drawing.Size(1004, 429);
            this.tabPageAkbilGuncelle.TabIndex = 3;
            this.tabPageAkbilGuncelle.Text = "Akbil Bilgileri Güncelle";
            this.tabPageAkbilGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnAkbilEkle
            // 
            this.btnAkbilEkle.Location = new System.Drawing.Point(223, 211);
            this.btnAkbilEkle.Name = "btnAkbilEkle";
            this.btnAkbilEkle.Size = new System.Drawing.Size(404, 36);
            this.btnAkbilEkle.TabIndex = 5;
            this.btnAkbilEkle.Text = "KAYDET";
            this.btnAkbilEkle.UseVisualStyleBackColor = true;
            this.btnAkbilEkle.Click += new System.EventHandler(this.btnAkbilEkle_Click);
            // 
            // txtSeriNumarasi
            // 
            this.txtSeriNumarasi.Location = new System.Drawing.Point(338, 138);
            this.txtSeriNumarasi.Name = "txtSeriNumarasi";
            this.txtSeriNumarasi.Size = new System.Drawing.Size(289, 20);
            this.txtSeriNumarasi.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seri Numarası:";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(338, 76);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(289, 20);
            this.txtAdSoyad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad:";
            // 
            // tabPageAkbilEkle
            // 
            this.tabPageAkbilEkle.Controls.Add(this.btnAkbilEkle);
            this.tabPageAkbilEkle.Controls.Add(this.txtSeriNumarasi);
            this.tabPageAkbilEkle.Controls.Add(this.label2);
            this.tabPageAkbilEkle.Controls.Add(this.txtAdSoyad);
            this.tabPageAkbilEkle.Controls.Add(this.label1);
            this.tabPageAkbilEkle.Location = new System.Drawing.Point(4, 22);
            this.tabPageAkbilEkle.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPageAkbilEkle.Name = "tabPageAkbilEkle";
            this.tabPageAkbilEkle.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPageAkbilEkle.Size = new System.Drawing.Size(1004, 429);
            this.tabPageAkbilEkle.TabIndex = 2;
            this.tabPageAkbilEkle.Text = "Yeni Akbil Ekle";
            this.tabPageAkbilEkle.UseVisualStyleBackColor = true;
            // 
            // contextMenuStripAkbilSil
            // 
            this.contextMenuStripAkbilSil.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripAkbilSil.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hardDeleteToolStripMenuItem,
            this.softDeleteToolStripMenuItem});
            this.contextMenuStripAkbilSil.Name = "contextMenuStripAkbilSil";
            this.contextMenuStripAkbilSil.Size = new System.Drawing.Size(181, 70);
            // 
            // dataGridViewAkbilList
            // 
            this.dataGridViewAkbilList.AllowUserToAddRows = false;
            this.dataGridViewAkbilList.AllowUserToDeleteRows = false;
            this.dataGridViewAkbilList.AllowUserToOrderColumns = true;
            this.dataGridViewAkbilList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAkbilList.ContextMenuStrip = this.contextMenuStripAkbilSil;
            this.dataGridViewAkbilList.Location = new System.Drawing.Point(23, 24);
            this.dataGridViewAkbilList.MultiSelect = false;
            this.dataGridViewAkbilList.Name = "dataGridViewAkbilList";
            this.dataGridViewAkbilList.ReadOnly = true;
            this.dataGridViewAkbilList.RowHeadersWidth = 51;
            this.dataGridViewAkbilList.Size = new System.Drawing.Size(869, 296);
            this.dataGridViewAkbilList.TabIndex = 0;
            // 
            // tabControlAkbiller
            // 
            this.tabControlAkbiller.Controls.Add(this.tabPageAkbilList);
            this.tabControlAkbiller.Controls.Add(this.tabPageAkbilEkle);
            this.tabControlAkbiller.Controls.Add(this.tabPageAkbilGuncelle);
            this.tabControlAkbiller.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAkbiller.Location = new System.Drawing.Point(0, 27);
            this.tabControlAkbiller.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabControlAkbiller.Name = "tabControlAkbiller";
            this.tabControlAkbiller.SelectedIndex = 0;
            this.tabControlAkbiller.Size = new System.Drawing.Size(1012, 455);
            this.tabControlAkbiller.TabIndex = 3;
            // 
            // tabPageAkbilList
            // 
            this.tabPageAkbilList.Controls.Add(this.dataGridViewAkbilList);
            this.tabPageAkbilList.Location = new System.Drawing.Point(4, 22);
            this.tabPageAkbilList.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPageAkbilList.Name = "tabPageAkbilList";
            this.tabPageAkbilList.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPageAkbilList.Size = new System.Drawing.Size(1004, 429);
            this.tabPageAkbilList.TabIndex = 1;
            this.tabPageAkbilList.Text = "Sistemdeki Akbiller";
            this.tabPageAkbilList.UseVisualStyleBackColor = true;
            // 
            // talimatlarToolStripMenuItem
            // 
            this.talimatlarToolStripMenuItem.Name = "talimatlarToolStripMenuItem";
            this.talimatlarToolStripMenuItem.Size = new System.Drawing.Size(70, 19);
            this.talimatlarToolStripMenuItem.Text = "Talimatlar";
            // 
            // anaSayfaToolStripMenuItem
            // 
            this.anaSayfaToolStripMenuItem.Name = "anaSayfaToolStripMenuItem";
            this.anaSayfaToolStripMenuItem.Size = new System.Drawing.Size(71, 19);
            this.anaSayfaToolStripMenuItem.Text = "Ana Sayfa";
            // 
            // menuStripAkbiller
            // 
            this.menuStripAkbiller.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripAkbiller.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anaSayfaToolStripMenuItem,
            this.talimatlarToolStripMenuItem});
            this.menuStripAkbiller.Location = new System.Drawing.Point(0, 0);
            this.menuStripAkbiller.Name = "menuStripAkbiller";
            this.menuStripAkbiller.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStripAkbiller.Size = new System.Drawing.Size(1012, 27);
            this.menuStripAkbiller.TabIndex = 2;
            this.menuStripAkbiller.Text = "menuStrip1";
            // 
            // hardDeleteToolStripMenuItem
            // 
            this.hardDeleteToolStripMenuItem.Name = "hardDeleteToolStripMenuItem";
            this.hardDeleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hardDeleteToolStripMenuItem.Text = "Hard Delete";
            this.hardDeleteToolStripMenuItem.Click += new System.EventHandler(this.hardDeleteToolStripMenuItem_Click);
            // 
            // softDeleteToolStripMenuItem
            // 
            this.softDeleteToolStripMenuItem.Name = "softDeleteToolStripMenuItem";
            this.softDeleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.softDeleteToolStripMenuItem.Text = "Soft Delete";
            this.softDeleteToolStripMenuItem.Click += new System.EventHandler(this.softDeleteToolStripMenuItem_Click);
            // 
            // FrmAkbiller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 482);
            this.Controls.Add(this.tabControlAkbiller);
            this.Controls.Add(this.menuStripAkbiller);
            this.Name = "FrmAkbiller";
            this.Text = "FrmAkbiller";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAkbiller_FormClosed);
            this.Load += new System.EventHandler(this.FrmAkbiller_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxAkbilBilgileri.ResumeLayout(false);
            this.groupBoxAkbilBilgileri.PerformLayout();
            this.tabPageAkbilGuncelle.ResumeLayout(false);
            this.tabPageAkbilEkle.ResumeLayout(false);
            this.tabPageAkbilEkle.PerformLayout();
            this.contextMenuStripAkbilSil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAkbilList)).EndInit();
            this.tabControlAkbiller.ResumeLayout(false);
            this.tabPageAkbilList.ResumeLayout(false);
            this.menuStripAkbiller.ResumeLayout(false);
            this.menuStripAkbiller.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAkbilGuncelle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAkbikGuncelle;
        private System.Windows.Forms.TextBox txtGuncelleSeriNo;
        private System.Windows.Forms.TextBox txtGuncelleAkbilSahibi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxAkbilBilgileri;
        private System.Windows.Forms.TabPage tabPageAkbilGuncelle;
        private System.Windows.Forms.Button btnAkbilEkle;
        private System.Windows.Forms.TextBox txtSeriNumarasi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageAkbilEkle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripAkbilSil;
        private System.Windows.Forms.DataGridView dataGridViewAkbilList;
        private System.Windows.Forms.TabControl tabControlAkbiller;
        private System.Windows.Forms.TabPage tabPageAkbilList;
        private System.Windows.Forms.ToolStripMenuItem talimatlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anaSayfaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStripAkbiller;
        private System.Windows.Forms.ToolStripMenuItem hardDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem softDeleteToolStripMenuItem;
    }
}