
namespace dershaneUygulamasiSon
{
    partial class DersPlanlamaDersIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DersPlanlamaDersIslemleri));
            this.txtDersPlanlamaDersArama = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDersPlanlamaDersArama = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDersPlanlamaDersKodu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDersPlanlamaDersListele = new System.Windows.Forms.Button();
            this.txtDersPlanlamaSaat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDersPlanlamaGun = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDersPlanlamaSinifSeviyesi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDersPlanlamaDersEkle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDersPlanlamaDersAnasayfa = new System.Windows.Forms.Button();
            this.btnDersPlanlamaSinifIslemleriGuncelle = new System.Windows.Forms.Button();
            this.btnDersPlanlamaDersSil = new System.Windows.Forms.Button();
            this.btnDersPlanlamaDersEkle = new System.Windows.Forms.Button();
            this.DGVDersPlanlamaDersIslemleri = new System.Windows.Forms.DataGridView();
            this.btnDersPlanlamaGeri = new System.Windows.Forms.Button();
            this.cmbOgretmen = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDersPlanlamaDersIslemleri)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDersPlanlamaDersArama
            // 
            this.txtDersPlanlamaDersArama.Location = new System.Drawing.Point(111, 49);
            this.txtDersPlanlamaDersArama.Name = "txtDersPlanlamaDersArama";
            this.txtDersPlanlamaDersArama.Size = new System.Drawing.Size(115, 23);
            this.txtDersPlanlamaDersArama.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDersPlanlamaDersArama);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtDersPlanlamaDersArama);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(484, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 185);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Arama";
            // 
            // btnDersPlanlamaDersArama
            // 
            this.btnDersPlanlamaDersArama.BackColor = System.Drawing.Color.Red;
            this.btnDersPlanlamaDersArama.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDersPlanlamaDersArama.Location = new System.Drawing.Point(143, 78);
            this.btnDersPlanlamaDersArama.Name = "btnDersPlanlamaDersArama";
            this.btnDersPlanlamaDersArama.Size = new System.Drawing.Size(83, 23);
            this.btnDersPlanlamaDersArama.TabIndex = 10;
            this.btnDersPlanlamaDersArama.Text = "Arama";
            this.btnDersPlanlamaDersArama.UseVisualStyleBackColor = false;
            this.btnDersPlanlamaDersArama.Click += new System.EventHandler(this.btnDersPlanlamaDersArama_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ders Kodu:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbOgretmen);
            this.groupBox1.Controls.Add(this.txtDersPlanlamaDersKodu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnDersPlanlamaDersListele);
            this.groupBox1.Controls.Add(this.txtDersPlanlamaSaat);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDersPlanlamaGun);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDersPlanlamaSinifSeviyesi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDersPlanlamaDersEkle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 186);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgiler";
            // 
            // txtDersPlanlamaDersKodu
            // 
            this.txtDersPlanlamaDersKodu.Location = new System.Drawing.Point(88, 41);
            this.txtDersPlanlamaDersKodu.Name = "txtDersPlanlamaDersKodu";
            this.txtDersPlanlamaDersKodu.ReadOnly = true;
            this.txtDersPlanlamaDersKodu.Size = new System.Drawing.Size(138, 23);
            this.txtDersPlanlamaDersKodu.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ders Kodu:";
            // 
            // btnDersPlanlamaDersListele
            // 
            this.btnDersPlanlamaDersListele.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnDersPlanlamaDersListele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDersPlanlamaDersListele.ForeColor = System.Drawing.Color.Black;
            this.btnDersPlanlamaDersListele.Location = new System.Drawing.Point(338, 102);
            this.btnDersPlanlamaDersListele.Name = "btnDersPlanlamaDersListele";
            this.btnDersPlanlamaDersListele.Size = new System.Drawing.Size(83, 23);
            this.btnDersPlanlamaDersListele.TabIndex = 4;
            this.btnDersPlanlamaDersListele.Text = "Tüm Dersler";
            this.btnDersPlanlamaDersListele.UseVisualStyleBackColor = false;
            this.btnDersPlanlamaDersListele.Click += new System.EventHandler(this.btnDersPlanlamaDersListele_Click);
            // 
            // txtDersPlanlamaSaat
            // 
            this.txtDersPlanlamaSaat.Location = new System.Drawing.Point(283, 70);
            this.txtDersPlanlamaSaat.Name = "txtDersPlanlamaSaat";
            this.txtDersPlanlamaSaat.Size = new System.Drawing.Size(138, 23);
            this.txtDersPlanlamaSaat.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(241, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Saat:";
            // 
            // txtDersPlanlamaGun
            // 
            this.txtDersPlanlamaGun.Location = new System.Drawing.Point(283, 41);
            this.txtDersPlanlamaGun.Name = "txtDersPlanlamaGun";
            this.txtDersPlanlamaGun.Size = new System.Drawing.Size(138, 23);
            this.txtDersPlanlamaGun.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Gün:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Öğretmen:";
            // 
            // txtDersPlanlamaSinifSeviyesi
            // 
            this.txtDersPlanlamaSinifSeviyesi.Location = new System.Drawing.Point(88, 99);
            this.txtDersPlanlamaSinifSeviyesi.Name = "txtDersPlanlamaSinifSeviyesi";
            this.txtDersPlanlamaSinifSeviyesi.Size = new System.Drawing.Size(138, 23);
            this.txtDersPlanlamaSinifSeviyesi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sınıf:";
            // 
            // txtDersPlanlamaDersEkle
            // 
            this.txtDersPlanlamaDersEkle.Location = new System.Drawing.Point(88, 70);
            this.txtDersPlanlamaDersEkle.Name = "txtDersPlanlamaDersEkle";
            this.txtDersPlanlamaDersEkle.Size = new System.Drawing.Size(138, 23);
            this.txtDersPlanlamaDersEkle.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ders:";
            // 
            // btnDersPlanlamaDersAnasayfa
            // 
            this.btnDersPlanlamaDersAnasayfa.BackColor = System.Drawing.Color.ForestGreen;
            this.btnDersPlanlamaDersAnasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDersPlanlamaDersAnasayfa.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.btnDersPlanlamaDersAnasayfa.Image = ((System.Drawing.Image)(resources.GetObject("btnDersPlanlamaDersAnasayfa.Image")));
            this.btnDersPlanlamaDersAnasayfa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDersPlanlamaDersAnasayfa.Location = new System.Drawing.Point(575, 437);
            this.btnDersPlanlamaDersAnasayfa.Name = "btnDersPlanlamaDersAnasayfa";
            this.btnDersPlanlamaDersAnasayfa.Size = new System.Drawing.Size(123, 57);
            this.btnDersPlanlamaDersAnasayfa.TabIndex = 38;
            this.btnDersPlanlamaDersAnasayfa.Text = "ANASAYFA";
            this.btnDersPlanlamaDersAnasayfa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDersPlanlamaDersAnasayfa.UseVisualStyleBackColor = false;
            this.btnDersPlanlamaDersAnasayfa.Click += new System.EventHandler(this.btnDersPlanlamaDersAnasayfa_Click_1);
            // 
            // btnDersPlanlamaSinifIslemleriGuncelle
            // 
            this.btnDersPlanlamaSinifIslemleriGuncelle.BackColor = System.Drawing.Color.Coral;
            this.btnDersPlanlamaSinifIslemleriGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDersPlanlamaSinifIslemleriGuncelle.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.btnDersPlanlamaSinifIslemleriGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("btnDersPlanlamaSinifIslemleriGuncelle.Image")));
            this.btnDersPlanlamaSinifIslemleriGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDersPlanlamaSinifIslemleriGuncelle.Location = new System.Drawing.Point(188, 437);
            this.btnDersPlanlamaSinifIslemleriGuncelle.Name = "btnDersPlanlamaSinifIslemleriGuncelle";
            this.btnDersPlanlamaSinifIslemleriGuncelle.Size = new System.Drawing.Size(123, 57);
            this.btnDersPlanlamaSinifIslemleriGuncelle.TabIndex = 35;
            this.btnDersPlanlamaSinifIslemleriGuncelle.Text = "     GÜNCELLE";
            this.btnDersPlanlamaSinifIslemleriGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDersPlanlamaSinifIslemleriGuncelle.UseVisualStyleBackColor = false;
            this.btnDersPlanlamaSinifIslemleriGuncelle.Click += new System.EventHandler(this.btnDersPlanlamaSinifIslemleriGuncelle_Click);
            // 
            // btnDersPlanlamaDersSil
            // 
            this.btnDersPlanlamaDersSil.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDersPlanlamaDersSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDersPlanlamaDersSil.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.btnDersPlanlamaDersSil.Image = ((System.Drawing.Image)(resources.GetObject("btnDersPlanlamaDersSil.Image")));
            this.btnDersPlanlamaDersSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDersPlanlamaDersSil.Location = new System.Drawing.Point(317, 437);
            this.btnDersPlanlamaDersSil.Name = "btnDersPlanlamaDersSil";
            this.btnDersPlanlamaDersSil.Size = new System.Drawing.Size(123, 57);
            this.btnDersPlanlamaDersSil.TabIndex = 34;
            this.btnDersPlanlamaDersSil.Text = "SİL";
            this.btnDersPlanlamaDersSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDersPlanlamaDersSil.UseVisualStyleBackColor = false;
            this.btnDersPlanlamaDersSil.Click += new System.EventHandler(this.btnDersPlanlamaDersSil_Click);
            // 
            // btnDersPlanlamaDersEkle
            // 
            this.btnDersPlanlamaDersEkle.BackColor = System.Drawing.Color.Gold;
            this.btnDersPlanlamaDersEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDersPlanlamaDersEkle.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.btnDersPlanlamaDersEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnDersPlanlamaDersEkle.Image")));
            this.btnDersPlanlamaDersEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDersPlanlamaDersEkle.Location = new System.Drawing.Point(59, 437);
            this.btnDersPlanlamaDersEkle.Name = "btnDersPlanlamaDersEkle";
            this.btnDersPlanlamaDersEkle.Size = new System.Drawing.Size(123, 57);
            this.btnDersPlanlamaDersEkle.TabIndex = 33;
            this.btnDersPlanlamaDersEkle.Text = "EKLE";
            this.btnDersPlanlamaDersEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDersPlanlamaDersEkle.UseVisualStyleBackColor = false;
            this.btnDersPlanlamaDersEkle.Click += new System.EventHandler(this.btnDersPlanlamaDersEkle_Click);
            // 
            // DGVDersPlanlamaDersIslemleri
            // 
            this.DGVDersPlanlamaDersIslemleri.BackgroundColor = System.Drawing.Color.Azure;
            this.DGVDersPlanlamaDersIslemleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDersPlanlamaDersIslemleri.Location = new System.Drawing.Point(27, 204);
            this.DGVDersPlanlamaDersIslemleri.Name = "DGVDersPlanlamaDersIslemleri";
            this.DGVDersPlanlamaDersIslemleri.Size = new System.Drawing.Size(709, 222);
            this.DGVDersPlanlamaDersIslemleri.TabIndex = 32;
            this.DGVDersPlanlamaDersIslemleri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDersPlanlamaDersIslemleri_CellClick);
            // 
            // btnDersPlanlamaGeri
            // 
            this.btnDersPlanlamaGeri.BackColor = System.Drawing.Color.Violet;
            this.btnDersPlanlamaGeri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDersPlanlamaGeri.Image = ((System.Drawing.Image)(resources.GetObject("btnDersPlanlamaGeri.Image")));
            this.btnDersPlanlamaGeri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDersPlanlamaGeri.Location = new System.Drawing.Point(446, 437);
            this.btnDersPlanlamaGeri.Name = "btnDersPlanlamaGeri";
            this.btnDersPlanlamaGeri.Size = new System.Drawing.Size(123, 57);
            this.btnDersPlanlamaGeri.TabIndex = 39;
            this.btnDersPlanlamaGeri.Text = "GERİ";
            this.btnDersPlanlamaGeri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDersPlanlamaGeri.UseVisualStyleBackColor = false;
            this.btnDersPlanlamaGeri.Click += new System.EventHandler(this.btnDersPlanlamaGeri_Click);
            // 
            // cmbOgretmen
            // 
            this.cmbOgretmen.FormattingEnabled = true;
            this.cmbOgretmen.Location = new System.Drawing.Point(89, 131);
            this.cmbOgretmen.Name = "cmbOgretmen";
            this.cmbOgretmen.Size = new System.Drawing.Size(137, 23);
            this.cmbOgretmen.TabIndex = 7;
            // 
            // DersPlanlamaDersIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(768, 515);
            this.Controls.Add(this.btnDersPlanlamaGeri);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDersPlanlamaDersAnasayfa);
            this.Controls.Add(this.btnDersPlanlamaSinifIslemleriGuncelle);
            this.Controls.Add(this.btnDersPlanlamaDersSil);
            this.Controls.Add(this.btnDersPlanlamaDersEkle);
            this.Controls.Add(this.DGVDersPlanlamaDersIslemleri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DersPlanlamaDersIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DersPlanlamaDersIslemleri";
            this.Load += new System.EventHandler(this.DersPlanlamaDersIslemleri_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDersPlanlamaDersIslemleri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtDersPlanlamaDersArama;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDersPlanlamaDersArama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDersPlanlamaDersEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDersPlanlamaDersAnasayfa;
        private System.Windows.Forms.Button btnDersPlanlamaSinifIslemleriGuncelle;
        private System.Windows.Forms.Button btnDersPlanlamaDersSil;
        private System.Windows.Forms.Button btnDersPlanlamaDersEkle;
        private System.Windows.Forms.DataGridView DGVDersPlanlamaDersIslemleri;
        private System.Windows.Forms.Button btnDersPlanlamaDersListele;
        private System.Windows.Forms.TextBox txtDersPlanlamaDersKodu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDersPlanlamaSinifSeviyesi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDersPlanlamaSaat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDersPlanlamaGun;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDersPlanlamaGeri;
        private System.Windows.Forms.ComboBox cmbOgretmen;
    }
}