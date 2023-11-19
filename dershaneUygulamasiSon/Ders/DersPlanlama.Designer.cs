
namespace dershaneUygulamasiSon
{
    partial class DersPlanlama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DersPlanlama));
            this.btnDersPlanlamaDersIslemleri = new System.Windows.Forms.Button();
            this.btnDersPlanlamaDersProgrami = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDersPlanlamaAnasayfa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDersPlanlamaDersIslemleri
            // 
            this.btnDersPlanlamaDersIslemleri.BackColor = System.Drawing.Color.SpringGreen;
            this.btnDersPlanlamaDersIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDersPlanlamaDersIslemleri.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDersPlanlamaDersIslemleri.Location = new System.Drawing.Point(26, 131);
            this.btnDersPlanlamaDersIslemleri.Name = "btnDersPlanlamaDersIslemleri";
            this.btnDersPlanlamaDersIslemleri.Size = new System.Drawing.Size(89, 41);
            this.btnDersPlanlamaDersIslemleri.TabIndex = 0;
            this.btnDersPlanlamaDersIslemleri.Text = "DERS ve SINIF İŞLEMLERİ";
            this.btnDersPlanlamaDersIslemleri.UseVisualStyleBackColor = false;
            this.btnDersPlanlamaDersIslemleri.Click += new System.EventHandler(this.btnDersPlanlamaDersIslemleri_Click);
            // 
            // btnDersPlanlamaDersProgrami
            // 
            this.btnDersPlanlamaDersProgrami.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDersPlanlamaDersProgrami.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDersPlanlamaDersProgrami.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDersPlanlamaDersProgrami.Location = new System.Drawing.Point(145, 131);
            this.btnDersPlanlamaDersProgrami.Name = "btnDersPlanlamaDersProgrami";
            this.btnDersPlanlamaDersProgrami.Size = new System.Drawing.Size(89, 41);
            this.btnDersPlanlamaDersProgrami.TabIndex = 0;
            this.btnDersPlanlamaDersProgrami.Text = "ÇİZELGE";
            this.btnDersPlanlamaDersProgrami.UseVisualStyleBackColor = false;
            this.btnDersPlanlamaDersProgrami.Click += new System.EventHandler(this.btnDersPlanlamaDersProgrami_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(145, 22);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(89, 87);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnDersPlanlamaAnasayfa
            // 
            this.btnDersPlanlamaAnasayfa.BackColor = System.Drawing.Color.Yellow;
            this.btnDersPlanlamaAnasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDersPlanlamaAnasayfa.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDersPlanlamaAnasayfa.Location = new System.Drawing.Point(87, 178);
            this.btnDersPlanlamaAnasayfa.Name = "btnDersPlanlamaAnasayfa";
            this.btnDersPlanlamaAnasayfa.Size = new System.Drawing.Size(89, 41);
            this.btnDersPlanlamaAnasayfa.TabIndex = 5;
            this.btnDersPlanlamaAnasayfa.Text = "ANASAYFA";
            this.btnDersPlanlamaAnasayfa.UseVisualStyleBackColor = false;
            this.btnDersPlanlamaAnasayfa.Click += new System.EventHandler(this.btnDersPlanlamaAnasayfa_Click);
            // 
            // DersPlanlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(263, 240);
            this.Controls.Add(this.btnDersPlanlamaAnasayfa);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDersPlanlamaDersIslemleri);
            this.Controls.Add(this.btnDersPlanlamaDersProgrami);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DersPlanlama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BİREYSEL AKADEMİ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDersPlanlamaDersIslemleri;
        private System.Windows.Forms.Button btnDersPlanlamaDersProgrami;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnDersPlanlamaAnasayfa;
    }
}