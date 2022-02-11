
namespace Ders21_Form_AdoNet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabEkle = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.txt_tc = new System.Windows.Forms.TextBox();
            this.txt_telefon = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabSil = new System.Windows.Forms.TabPage();
            this.btn_sil = new System.Windows.Forms.Button();
            this.cmb_sil_liste = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabGuncelle = new System.Windows.Forms.TabPage();
            this.cmb_guncelle = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.txt_tc_guncelle = new System.Windows.Forms.TextBox();
            this.txt_telefon_guncelle = new System.Windows.Forms.TextBox();
            this.txt_soyad_guncelle = new System.Windows.Forms.TextBox();
            this.txt_ad_guncelle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabListele = new System.Windows.Forms.TabPage();
            this.data_ogrenciler = new System.Windows.Forms.DataGridView();
            this.btn_ogretmen = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabEkle.SuspendLayout();
            this.tabSil.SuspendLayout();
            this.tabGuncelle.SuspendLayout();
            this.tabListele.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_ogrenciler)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabEkle);
            this.tabControl1.Controls.Add(this.tabSil);
            this.tabControl1.Controls.Add(this.tabGuncelle);
            this.tabControl1.Controls.Add(this.tabListele);
            this.tabControl1.Location = new System.Drawing.Point(15, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(757, 467);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.Form1_Load);
            // 
            // tabEkle
            // 
            this.tabEkle.BackColor = System.Drawing.Color.MediumTurquoise;
            this.tabEkle.Controls.Add(this.label5);
            this.tabEkle.Controls.Add(this.btn_ekle);
            this.tabEkle.Controls.Add(this.txt_tc);
            this.tabEkle.Controls.Add(this.txt_telefon);
            this.tabEkle.Controls.Add(this.txt_soyad);
            this.tabEkle.Controls.Add(this.txt_ad);
            this.tabEkle.Controls.Add(this.label4);
            this.tabEkle.Controls.Add(this.label3);
            this.tabEkle.Controls.Add(this.label2);
            this.tabEkle.Controls.Add(this.label1);
            this.tabEkle.Location = new System.Drawing.Point(4, 46);
            this.tabEkle.Margin = new System.Windows.Forms.Padding(6);
            this.tabEkle.Name = "tabEkle";
            this.tabEkle.Padding = new System.Windows.Forms.Padding(6);
            this.tabEkle.Size = new System.Drawing.Size(749, 417);
            this.tabEkle.TabIndex = 0;
            this.tabEkle.Text = "Ekle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Lavender;
            this.label5.Location = new System.Drawing.Point(37, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(614, 38);
            this.label5.TabIndex = 9;
            this.label5.Text = "                          ÖĞRENCİ EKLE                          ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(250, 318);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(256, 67);
            this.btn_ekle.TabIndex = 8;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_SP);
            // 
            // txt_tc
            // 
            this.txt_tc.Location = new System.Drawing.Point(248, 252);
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(256, 43);
            this.txt_tc.TabIndex = 7;
            // 
            // txt_telefon
            // 
            this.txt_telefon.Location = new System.Drawing.Point(248, 196);
            this.txt_telefon.Name = "txt_telefon";
            this.txt_telefon.Size = new System.Drawing.Size(256, 43);
            this.txt_telefon.TabIndex = 6;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(248, 140);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(256, 43);
            this.txt_soyad.TabIndex = 5;
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(250, 85);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(256, 43);
            this.txt_ad.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 38);
            this.label4.TabIndex = 3;
            this.label4.Text = "TC Kim. N. :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad :";
            // 
            // tabSil
            // 
            this.tabSil.BackColor = System.Drawing.Color.Salmon;
            this.tabSil.Controls.Add(this.btn_sil);
            this.tabSil.Controls.Add(this.cmb_sil_liste);
            this.tabSil.Controls.Add(this.label6);
            this.tabSil.Location = new System.Drawing.Point(4, 46);
            this.tabSil.Margin = new System.Windows.Forms.Padding(6);
            this.tabSil.Name = "tabSil";
            this.tabSil.Padding = new System.Windows.Forms.Padding(6);
            this.tabSil.Size = new System.Drawing.Size(749, 417);
            this.tabSil.TabIndex = 1;
            this.tabSil.Text = "Sil";
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(159, 208);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(450, 60);
            this.btn_sil.TabIndex = 2;
            this.btn_sil.Text = "ÖĞRENCİ SİL";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // cmb_sil_liste
            // 
            this.cmb_sil_liste.FormattingEnabled = true;
            this.cmb_sil_liste.Location = new System.Drawing.Point(159, 134);
            this.cmb_sil_liste.Name = "cmb_sil_liste";
            this.cmb_sil_liste.Size = new System.Drawing.Size(450, 45);
            this.cmb_sil_liste.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(159, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(450, 38);
            this.label6.TabIndex = 0;
            this.label6.Text = "Silinecek öğrenciyi listeden seçiniz.";
            // 
            // tabGuncelle
            // 
            this.tabGuncelle.BackColor = System.Drawing.Color.Thistle;
            this.tabGuncelle.Controls.Add(this.cmb_guncelle);
            this.tabGuncelle.Controls.Add(this.label12);
            this.tabGuncelle.Controls.Add(this.label7);
            this.tabGuncelle.Controls.Add(this.btn_guncelle);
            this.tabGuncelle.Controls.Add(this.txt_tc_guncelle);
            this.tabGuncelle.Controls.Add(this.txt_telefon_guncelle);
            this.tabGuncelle.Controls.Add(this.txt_soyad_guncelle);
            this.tabGuncelle.Controls.Add(this.txt_ad_guncelle);
            this.tabGuncelle.Controls.Add(this.label8);
            this.tabGuncelle.Controls.Add(this.label9);
            this.tabGuncelle.Controls.Add(this.label10);
            this.tabGuncelle.Controls.Add(this.label11);
            this.tabGuncelle.Location = new System.Drawing.Point(4, 46);
            this.tabGuncelle.Name = "tabGuncelle";
            this.tabGuncelle.Size = new System.Drawing.Size(749, 417);
            this.tabGuncelle.TabIndex = 2;
            this.tabGuncelle.Text = "Düzenle";
            // 
            // cmb_guncelle
            // 
            this.cmb_guncelle.FormattingEnabled = true;
            this.cmb_guncelle.Location = new System.Drawing.Point(278, 92);
            this.cmb_guncelle.Name = "cmb_guncelle";
            this.cmb_guncelle.Size = new System.Drawing.Size(258, 45);
            this.cmb_guncelle.TabIndex = 21;
            this.cmb_guncelle.TextChanged += new System.EventHandler(this.cmb_guncelle_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Snow;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(219, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(356, 28);
            this.label12.TabIndex = 20;
            this.label12.Text = "Düzenlenecek öğrenciyi listeden seçiniz.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Lavender;
            this.label7.Location = new System.Drawing.Point(45, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(674, 38);
            this.label7.TabIndex = 19;
            this.label7.Text = "                          ÖĞRENCİ DÜZENLE                          ";
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(278, 348);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(256, 57);
            this.btn_guncelle.TabIndex = 18;
            this.btn_guncelle.Text = "GÜNCELLE";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // txt_tc_guncelle
            // 
            this.txt_tc_guncelle.Location = new System.Drawing.Point(278, 297);
            this.txt_tc_guncelle.Name = "txt_tc_guncelle";
            this.txt_tc_guncelle.Size = new System.Drawing.Size(256, 43);
            this.txt_tc_guncelle.TabIndex = 17;
            // 
            // txt_telefon_guncelle
            // 
            this.txt_telefon_guncelle.Location = new System.Drawing.Point(278, 246);
            this.txt_telefon_guncelle.Name = "txt_telefon_guncelle";
            this.txt_telefon_guncelle.Size = new System.Drawing.Size(256, 43);
            this.txt_telefon_guncelle.TabIndex = 16;
            // 
            // txt_soyad_guncelle
            // 
            this.txt_soyad_guncelle.Location = new System.Drawing.Point(278, 195);
            this.txt_soyad_guncelle.Name = "txt_soyad_guncelle";
            this.txt_soyad_guncelle.Size = new System.Drawing.Size(256, 43);
            this.txt_soyad_guncelle.TabIndex = 15;
            // 
            // txt_ad_guncelle
            // 
            this.txt_ad_guncelle.Location = new System.Drawing.Point(280, 142);
            this.txt_ad_guncelle.Name = "txt_ad_guncelle";
            this.txt_ad_guncelle.Size = new System.Drawing.Size(256, 43);
            this.txt_ad_guncelle.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(114, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 38);
            this.label8.TabIndex = 13;
            this.label8.Text = "TC Kim. N. :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(151, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 38);
            this.label9.TabIndex = 12;
            this.label9.Text = "Telefon :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(166, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 38);
            this.label10.TabIndex = 11;
            this.label10.Text = "Soyad :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(207, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 38);
            this.label11.TabIndex = 10;
            this.label11.Text = "Ad :";
            // 
            // tabListele
            // 
            this.tabListele.BackColor = System.Drawing.Color.NavajoWhite;
            this.tabListele.Controls.Add(this.data_ogrenciler);
            this.tabListele.Location = new System.Drawing.Point(4, 46);
            this.tabListele.Name = "tabListele";
            this.tabListele.Size = new System.Drawing.Size(749, 417);
            this.tabListele.TabIndex = 3;
            this.tabListele.Text = "Listele";
            // 
            // data_ogrenciler
            // 
            this.data_ogrenciler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_ogrenciler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_ogrenciler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_ogrenciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_ogrenciler.Location = new System.Drawing.Point(27, 21);
            this.data_ogrenciler.Name = "data_ogrenciler";
            this.data_ogrenciler.ReadOnly = true;
            this.data_ogrenciler.RowHeadersWidth = 51;
            this.data_ogrenciler.RowTemplate.Height = 29;
            this.data_ogrenciler.Size = new System.Drawing.Size(700, 378);
            this.data_ogrenciler.TabIndex = 0;
            // 
            // btn_ogretmen
            // 
            this.btn_ogretmen.Location = new System.Drawing.Point(19, 491);
            this.btn_ogretmen.Name = "btn_ogretmen";
            this.btn_ogretmen.Size = new System.Drawing.Size(749, 49);
            this.btn_ogretmen.TabIndex = 1;
            this.btn_ogretmen.Text = "Öğretmen Sayfası";
            this.btn_ogretmen.UseVisualStyleBackColor = true;
            this.btn_ogretmen.Click += new System.EventHandler(this.btn_ogretmen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 570);
            this.Controls.Add(this.btn_ogretmen);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Öğrenci Bilgi Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabEkle.ResumeLayout(false);
            this.tabEkle.PerformLayout();
            this.tabSil.ResumeLayout(false);
            this.tabSil.PerformLayout();
            this.tabGuncelle.ResumeLayout(false);
            this.tabGuncelle.PerformLayout();
            this.tabListele.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_ogrenciler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabEkle;
        private System.Windows.Forms.TabPage tabSil;
        private System.Windows.Forms.TabPage tabGuncelle;
        private System.Windows.Forms.TabPage tabListele;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.TextBox txt_tc;
        private System.Windows.Forms.TextBox txt_telefon;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.DataGridView data_ogrenciler;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.ComboBox cmb_sil_liste;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_guncelle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.TextBox txt_tc_guncelle;
        private System.Windows.Forms.TextBox txt_telefon_guncelle;
        private System.Windows.Forms.TextBox txt_soyad_guncelle;
        private System.Windows.Forms.TextBox txt_ad_guncelle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_ogretmen;
    }
}

