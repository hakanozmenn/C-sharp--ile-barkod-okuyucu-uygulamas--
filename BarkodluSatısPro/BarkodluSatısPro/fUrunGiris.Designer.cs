﻿namespace BarkodluSatısPro
{
    partial class fUrunGiris
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tAlisFiyati = new System.Windows.Forms.TextBox();
            this.tSatisFiyati = new System.Windows.Forms.TextBox();
            this.cmbUrunGrubu = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lSandart11 = new BarkodluSatısPro.lSandart();
            this.lKullanici = new BarkodluSatısPro.lSandart();
            this.tUrunSayisi = new BarkodluSatısPro.tNumeric();
            this.lSandart10 = new BarkodluSatısPro.lSandart();
            this.tUrunAra = new BarkodluSatısPro.tStandart();
            this.lSandart9 = new BarkodluSatısPro.lSandart();
            this.bRaporAl = new BarkodluSatısPro.bStandar();
            this.bKaydet = new BarkodluSatısPro.bStandar();
            this.bIptal = new BarkodluSatısPro.bStandar();
            this.bBarkodOlustur = new BarkodluSatısPro.bStandar();
            this.bUrunGrubuEkle = new BarkodluSatısPro.bStandar();
            this.tKdvOrani = new BarkodluSatısPro.tNumeric();
            this.tMiktar = new BarkodluSatısPro.tNumeric();
            this.lSandart8 = new BarkodluSatısPro.lSandart();
            this.lSandart7 = new BarkodluSatısPro.lSandart();
            this.lSandart6 = new BarkodluSatısPro.lSandart();
            this.lSandart5 = new BarkodluSatısPro.lSandart();
            this.tAciklama = new BarkodluSatısPro.tStandart();
            this.tUrunAdi = new BarkodluSatısPro.tStandart();
            this.tBarkod = new BarkodluSatısPro.tStandart();
            this.lSandart4 = new BarkodluSatısPro.lSandart();
            this.lSandart3 = new BarkodluSatısPro.lSandart();
            this.lSandart2 = new BarkodluSatısPro.lSandart();
            this.lSandart1 = new BarkodluSatısPro.lSandart();
            this.gridUrunler = new BarkodluSatısPro.gridOzel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tAlisFiyati);
            this.splitContainer1.Panel1.Controls.Add(this.tSatisFiyati);
            this.splitContainer1.Panel1.Controls.Add(this.lSandart11);
            this.splitContainer1.Panel1.Controls.Add(this.lKullanici);
            this.splitContainer1.Panel1.Controls.Add(this.tUrunSayisi);
            this.splitContainer1.Panel1.Controls.Add(this.lSandart10);
            this.splitContainer1.Panel1.Controls.Add(this.tUrunAra);
            this.splitContainer1.Panel1.Controls.Add(this.lSandart9);
            this.splitContainer1.Panel1.Controls.Add(this.bRaporAl);
            this.splitContainer1.Panel1.Controls.Add(this.bKaydet);
            this.splitContainer1.Panel1.Controls.Add(this.bIptal);
            this.splitContainer1.Panel1.Controls.Add(this.bBarkodOlustur);
            this.splitContainer1.Panel1.Controls.Add(this.bUrunGrubuEkle);
            this.splitContainer1.Panel1.Controls.Add(this.tKdvOrani);
            this.splitContainer1.Panel1.Controls.Add(this.tMiktar);
            this.splitContainer1.Panel1.Controls.Add(this.lSandart8);
            this.splitContainer1.Panel1.Controls.Add(this.lSandart7);
            this.splitContainer1.Panel1.Controls.Add(this.lSandart6);
            this.splitContainer1.Panel1.Controls.Add(this.lSandart5);
            this.splitContainer1.Panel1.Controls.Add(this.tAciklama);
            this.splitContainer1.Panel1.Controls.Add(this.tUrunAdi);
            this.splitContainer1.Panel1.Controls.Add(this.tBarkod);
            this.splitContainer1.Panel1.Controls.Add(this.cmbUrunGrubu);
            this.splitContainer1.Panel1.Controls.Add(this.lSandart4);
            this.splitContainer1.Panel1.Controls.Add(this.lSandart3);
            this.splitContainer1.Panel1.Controls.Add(this.lSandart2);
            this.splitContainer1.Panel1.Controls.Add(this.lSandart1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridUrunler);
            this.splitContainer1.Size = new System.Drawing.Size(954, 625);
            this.splitContainer1.SplitterDistance = 379;
            this.splitContainer1.TabIndex = 0;
            // 
            // tAlisFiyati
            // 
            this.tAlisFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tAlisFiyati.Location = new System.Drawing.Point(580, 57);
            this.tAlisFiyati.Name = "tAlisFiyati";
            this.tAlisFiyati.Size = new System.Drawing.Size(114, 30);
            this.tAlisFiyati.TabIndex = 4;
            this.tAlisFiyati.Text = "0";
            this.tAlisFiyati.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tAlisFiyati.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tSatisFiyati_KeyPress);
            // 
            // tSatisFiyati
            // 
            this.tSatisFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tSatisFiyati.Location = new System.Drawing.Point(580, 103);
            this.tSatisFiyati.Name = "tSatisFiyati";
            this.tSatisFiyati.Size = new System.Drawing.Size(114, 30);
            this.tSatisFiyati.TabIndex = 5;
            this.tSatisFiyati.Text = "0";
            this.tSatisFiyati.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tSatisFiyati.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tSatisFiyati_KeyPress);
            // 
            // cmbUrunGrubu
            // 
            this.cmbUrunGrubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbUrunGrubu.FormattingEnabled = true;
            this.cmbUrunGrubu.Location = new System.Drawing.Point(142, 196);
            this.cmbUrunGrubu.Name = "cmbUrunGrubu";
            this.cmbUrunGrubu.Size = new System.Drawing.Size(250, 33);
            this.cmbUrunGrubu.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 56);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // lSandart11
            // 
            this.lSandart11.AutoSize = true;
            this.lSandart11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lSandart11.ForeColor = System.Drawing.Color.DarkCyan;
            this.lSandart11.Location = new System.Drawing.Point(44, 18);
            this.lSandart11.Name = "lSandart11";
            this.lSandart11.Size = new System.Drawing.Size(91, 25);
            this.lSandart11.TabIndex = 21;
            this.lSandart11.Text = "Kullanıcı:";
            // 
            // lKullanici
            // 
            this.lKullanici.AutoSize = true;
            this.lKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lKullanici.ForeColor = System.Drawing.Color.DarkCyan;
            this.lKullanici.Location = new System.Drawing.Point(141, 18);
            this.lKullanici.Name = "lKullanici";
            this.lKullanici.Size = new System.Drawing.Size(107, 25);
            this.lKullanici.TabIndex = 20;
            this.lKullanici.Text = "lSandart11";
            // 
            // tUrunSayisi
            // 
            this.tUrunSayisi.BackColor = System.Drawing.Color.White;
            this.tUrunSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tUrunSayisi.Location = new System.Drawing.Point(598, 340);
            this.tUrunSayisi.Name = "tUrunSayisi";
            this.tUrunSayisi.ReadOnly = true;
            this.tUrunSayisi.Size = new System.Drawing.Size(115, 30);
            this.tUrunSayisi.TabIndex = 19;
            this.tUrunSayisi.TabStop = false;
            this.tUrunSayisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lSandart10
            // 
            this.lSandart10.AutoSize = true;
            this.lSandart10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lSandart10.ForeColor = System.Drawing.Color.DarkCyan;
            this.lSandart10.Location = new System.Drawing.Point(474, 343);
            this.lSandart10.Name = "lSandart10";
            this.lSandart10.Size = new System.Drawing.Size(112, 25);
            this.lSandart10.TabIndex = 18;
            this.lSandart10.Text = "Ürün Sayısı";
            // 
            // tUrunAra
            // 
            this.tUrunAra.BackColor = System.Drawing.Color.White;
            this.tUrunAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tUrunAra.Location = new System.Drawing.Point(142, 337);
            this.tUrunAra.Name = "tUrunAra";
            this.tUrunAra.Size = new System.Drawing.Size(250, 30);
            this.tUrunAra.TabIndex = 12;
            this.tUrunAra.TextChanged += new System.EventHandler(this.tUrunAra_TextChanged);
            // 
            // lSandart9
            // 
            this.lSandart9.AutoSize = true;
            this.lSandart9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lSandart9.ForeColor = System.Drawing.Color.DarkCyan;
            this.lSandart9.Location = new System.Drawing.Point(28, 343);
            this.lSandart9.Name = "lSandart9";
            this.lSandart9.Size = new System.Drawing.Size(90, 25);
            this.lSandart9.TabIndex = 16;
            this.lSandart9.Text = "Ürün Ara";
            // 
            // bRaporAl
            // 
            this.bRaporAl.BackColor = System.Drawing.Color.Firebrick;
            this.bRaporAl.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.bRaporAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRaporAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bRaporAl.ForeColor = System.Drawing.Color.White;
            this.bRaporAl.Image = global::BarkodluSatısPro.Properties.Resources.rapor4854;
            this.bRaporAl.Location = new System.Drawing.Point(767, 235);
            this.bRaporAl.Margin = new System.Windows.Forms.Padding(1);
            this.bRaporAl.Name = "bRaporAl";
            this.bRaporAl.Size = new System.Drawing.Size(129, 127);
            this.bRaporAl.TabIndex = 0;
            this.bRaporAl.Text = "Rapor Al";
            this.bRaporAl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bRaporAl.UseVisualStyleBackColor = false;
            // 
            // bKaydet
            // 
            this.bKaydet.BackColor = System.Drawing.Color.LightCoral;
            this.bKaydet.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.bKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bKaydet.ForeColor = System.Drawing.Color.White;
            this.bKaydet.Image = global::BarkodluSatısPro.Properties.Resources.save24;
            this.bKaydet.Location = new System.Drawing.Point(741, 143);
            this.bKaydet.Margin = new System.Windows.Forms.Padding(1);
            this.bKaydet.Name = "bKaydet";
            this.bKaydet.Size = new System.Drawing.Size(172, 71);
            this.bKaydet.TabIndex = 8;
            this.bKaydet.Text = "Kaydet";
            this.bKaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bKaydet.UseVisualStyleBackColor = false;
            this.bKaydet.Click += new System.EventHandler(this.bKaydet_Click);
            // 
            // bIptal
            // 
            this.bIptal.BackColor = System.Drawing.Color.Goldenrod;
            this.bIptal.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.bIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bIptal.ForeColor = System.Drawing.Color.White;
            this.bIptal.Image = global::BarkodluSatısPro.Properties.Resources.cancel24;
            this.bIptal.Location = new System.Drawing.Point(741, 37);
            this.bIptal.Margin = new System.Windows.Forms.Padding(1);
            this.bIptal.Name = "bIptal";
            this.bIptal.Size = new System.Drawing.Size(172, 74);
            this.bIptal.TabIndex = 9;
            this.bIptal.Text = "İptal";
            this.bIptal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bIptal.UseVisualStyleBackColor = false;
            this.bIptal.Click += new System.EventHandler(this.bIptal_Click);
            // 
            // bBarkodOlustur
            // 
            this.bBarkodOlustur.BackColor = System.Drawing.Color.SaddleBrown;
            this.bBarkodOlustur.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.bBarkodOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBarkodOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bBarkodOlustur.ForeColor = System.Drawing.Color.White;
            this.bBarkodOlustur.Image = global::BarkodluSatısPro.Properties.Resources.barcode4832;
            this.bBarkodOlustur.Location = new System.Drawing.Point(264, 235);
            this.bBarkodOlustur.Margin = new System.Windows.Forms.Padding(1);
            this.bBarkodOlustur.Name = "bBarkodOlustur";
            this.bBarkodOlustur.Size = new System.Drawing.Size(107, 88);
            this.bBarkodOlustur.TabIndex = 11;
            this.bBarkodOlustur.Text = "Barkod Oluştur";
            this.bBarkodOlustur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bBarkodOlustur.UseVisualStyleBackColor = false;
            this.bBarkodOlustur.Click += new System.EventHandler(this.bBarkodOlustur_Click);
            // 
            // bUrunGrubuEkle
            // 
            this.bUrunGrubuEkle.BackColor = System.Drawing.Color.SandyBrown;
            this.bUrunGrubuEkle.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown;
            this.bUrunGrubuEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bUrunGrubuEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bUrunGrubuEkle.ForeColor = System.Drawing.Color.White;
            this.bUrunGrubuEkle.Image = global::BarkodluSatısPro.Properties.Resources.Ekle20;
            this.bUrunGrubuEkle.Location = new System.Drawing.Point(142, 235);
            this.bUrunGrubuEkle.Margin = new System.Windows.Forms.Padding(1);
            this.bUrunGrubuEkle.Name = "bUrunGrubuEkle";
            this.bUrunGrubuEkle.Size = new System.Drawing.Size(109, 88);
            this.bUrunGrubuEkle.TabIndex = 10;
            this.bUrunGrubuEkle.Text = "Ürün Grubu Ekle";
            this.bUrunGrubuEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bUrunGrubuEkle.UseVisualStyleBackColor = false;
            this.bUrunGrubuEkle.Click += new System.EventHandler(this.bUrunGrubuEkle_Click);
            // 
            // tKdvOrani
            // 
            this.tKdvOrani.BackColor = System.Drawing.Color.White;
            this.tKdvOrani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tKdvOrani.Location = new System.Drawing.Point(580, 186);
            this.tKdvOrani.Name = "tKdvOrani";
            this.tKdvOrani.Size = new System.Drawing.Size(115, 30);
            this.tKdvOrani.TabIndex = 7;
            this.tKdvOrani.Text = "0";
            this.tKdvOrani.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tMiktar
            // 
            this.tMiktar.BackColor = System.Drawing.Color.White;
            this.tMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tMiktar.Location = new System.Drawing.Point(580, 144);
            this.tMiktar.Name = "tMiktar";
            this.tMiktar.Size = new System.Drawing.Size(115, 30);
            this.tMiktar.TabIndex = 6;
            this.tMiktar.Text = "0";
            this.tMiktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lSandart8
            // 
            this.lSandart8.AutoSize = true;
            this.lSandart8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lSandart8.ForeColor = System.Drawing.Color.DarkCyan;
            this.lSandart8.Location = new System.Drawing.Point(474, 189);
            this.lSandart8.Name = "lSandart8";
            this.lSandart8.Size = new System.Drawing.Size(100, 25);
            this.lSandart8.TabIndex = 11;
            this.lSandart8.Text = "Kdv Oranı";
            // 
            // lSandart7
            // 
            this.lSandart7.AutoSize = true;
            this.lSandart7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lSandart7.ForeColor = System.Drawing.Color.DarkCyan;
            this.lSandart7.Location = new System.Drawing.Point(509, 150);
            this.lSandart7.Name = "lSandart7";
            this.lSandart7.Size = new System.Drawing.Size(65, 25);
            this.lSandart7.TabIndex = 10;
            this.lSandart7.Text = "Miktar";
            // 
            // lSandart6
            // 
            this.lSandart6.AutoSize = true;
            this.lSandart6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lSandart6.ForeColor = System.Drawing.Color.DarkCyan;
            this.lSandart6.Location = new System.Drawing.Point(467, 106);
            this.lSandart6.Name = "lSandart6";
            this.lSandart6.Size = new System.Drawing.Size(107, 25);
            this.lSandart6.TabIndex = 9;
            this.lSandart6.Text = "Satış Fiyatı";
            // 
            // lSandart5
            // 
            this.lSandart5.AutoSize = true;
            this.lSandart5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lSandart5.ForeColor = System.Drawing.Color.DarkCyan;
            this.lSandart5.Location = new System.Drawing.Point(479, 57);
            this.lSandart5.Name = "lSandart5";
            this.lSandart5.Size = new System.Drawing.Size(95, 25);
            this.lSandart5.TabIndex = 8;
            this.lSandart5.Text = "Alış Fiyatı";
            // 
            // tAciklama
            // 
            this.tAciklama.BackColor = System.Drawing.Color.White;
            this.tAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tAciklama.Location = new System.Drawing.Point(142, 145);
            this.tAciklama.Name = "tAciklama";
            this.tAciklama.Size = new System.Drawing.Size(250, 30);
            this.tAciklama.TabIndex = 2;
            // 
            // tUrunAdi
            // 
            this.tUrunAdi.BackColor = System.Drawing.Color.White;
            this.tUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tUrunAdi.Location = new System.Drawing.Point(142, 103);
            this.tUrunAdi.Name = "tUrunAdi";
            this.tUrunAdi.Size = new System.Drawing.Size(250, 30);
            this.tUrunAdi.TabIndex = 1;
            // 
            // tBarkod
            // 
            this.tBarkod.BackColor = System.Drawing.Color.White;
            this.tBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tBarkod.Location = new System.Drawing.Point(142, 54);
            this.tBarkod.Name = "tBarkod";
            this.tBarkod.Size = new System.Drawing.Size(250, 30);
            this.tBarkod.TabIndex = 0;
            this.tBarkod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBarkod_KeyDown);
            // 
            // lSandart4
            // 
            this.lSandart4.AutoSize = true;
            this.lSandart4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lSandart4.ForeColor = System.Drawing.Color.DarkCyan;
            this.lSandart4.Location = new System.Drawing.Point(23, 192);
            this.lSandart4.Name = "lSandart4";
            this.lSandart4.Size = new System.Drawing.Size(113, 25);
            this.lSandart4.TabIndex = 3;
            this.lSandart4.Text = "Ürün Grubu";
            // 
            // lSandart3
            // 
            this.lSandart3.AutoSize = true;
            this.lSandart3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lSandart3.ForeColor = System.Drawing.Color.DarkCyan;
            this.lSandart3.Location = new System.Drawing.Point(44, 145);
            this.lSandart3.Name = "lSandart3";
            this.lSandart3.Size = new System.Drawing.Size(92, 25);
            this.lSandart3.TabIndex = 2;
            this.lSandart3.Text = "Açıklama";
            // 
            // lSandart2
            // 
            this.lSandart2.AutoSize = true;
            this.lSandart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lSandart2.ForeColor = System.Drawing.Color.DarkCyan;
            this.lSandart2.Location = new System.Drawing.Point(51, 103);
            this.lSandart2.Name = "lSandart2";
            this.lSandart2.Size = new System.Drawing.Size(88, 25);
            this.lSandart2.TabIndex = 1;
            this.lSandart2.Text = "Ürün Adı";
            // 
            // lSandart1
            // 
            this.lSandart1.AutoSize = true;
            this.lSandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lSandart1.ForeColor = System.Drawing.Color.DarkCyan;
            this.lSandart1.Location = new System.Drawing.Point(62, 57);
            this.lSandart1.Name = "lSandart1";
            this.lSandart1.Size = new System.Drawing.Size(74, 25);
            this.lSandart1.TabIndex = 0;
            this.lSandart1.Text = "Barkod";
            // 
            // gridUrunler
            // 
            this.gridUrunler.AllowUserToAddRows = false;
            this.gridUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridUrunler.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gridUrunler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridUrunler.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUrunler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUrunler.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridUrunler.EnableHeadersVisualStyles = false;
            this.gridUrunler.Location = new System.Drawing.Point(0, 0);
            this.gridUrunler.Name = "gridUrunler";
            this.gridUrunler.RowHeadersVisible = false;
            this.gridUrunler.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUrunler.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridUrunler.RowTemplate.ContextMenuStrip = this.contextMenuStrip1;
            this.gridUrunler.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.gridUrunler.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.gridUrunler.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gridUrunler.RowTemplate.Height = 32;
            this.gridUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUrunler.Size = new System.Drawing.Size(954, 242);
            this.gridUrunler.TabIndex = 0;
            // 
            // fUrunGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(954, 625);
            this.Controls.Add(this.splitContainer1);
            this.Name = "fUrunGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Giriş Formu";
            this.Load += new System.EventHandler(this.fUrunGiris_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private tNumeric tUrunSayisi;
        private lSandart lSandart10;
        private tStandart tUrunAra;
        private lSandart lSandart9;
        private bStandar bRaporAl;
        private bStandar bKaydet;
        private bStandar bIptal;
        private bStandar bBarkodOlustur;
        private bStandar bUrunGrubuEkle;
        private tNumeric tKdvOrani;
        private tNumeric tMiktar;
        private lSandart lSandart8;
        private lSandart lSandart7;
        private lSandart lSandart6;
        private lSandart lSandart5;
        private tStandart tAciklama;
        private tStandart tUrunAdi;
        private lSandart lSandart4;
        private lSandart lSandart3;
        private lSandart lSandart2;
        private lSandart lSandart1;
        private gridOzel gridUrunler;
        internal tStandart tBarkod;
        private lSandart lSandart11;
        internal lSandart lKullanici;
        public System.Windows.Forms.ComboBox cmbUrunGrubu;
        private System.Windows.Forms.TextBox tSatisFiyati;
        private System.Windows.Forms.TextBox tAlisFiyati;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    }
}