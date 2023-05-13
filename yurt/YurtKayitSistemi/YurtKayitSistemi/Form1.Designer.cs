namespace YurtKayitSistemi
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
            this.Ogr = new System.Windows.Forms.Label();
            this.TxtOgrAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtOgrSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MskOgrTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MskDogum = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbBolum = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CmbOdaNo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtVeliAdSoyad = new System.Windows.Forms.TextBox();
            this.MskVeliTelefon = new System.Windows.Forms.MaskedTextBox();
            this.RchAdres = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Ogr
            // 
            this.Ogr.AutoSize = true;
            this.Ogr.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Ogr.Location = new System.Drawing.Point(32, 59);
            this.Ogr.Name = "Ogr";
            this.Ogr.Size = new System.Drawing.Size(135, 24);
            this.Ogr.TabIndex = 0;
            this.Ogr.Text = "Öğrenci Adı : ";
            // 
            // TxtOgrAd
            // 
            this.TxtOgrAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtOgrAd.Location = new System.Drawing.Point(173, 56);
            this.TxtOgrAd.Name = "TxtOgrAd";
            this.TxtOgrAd.Size = new System.Drawing.Size(171, 27);
            this.TxtOgrAd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Soyadı : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtOgrSoyad
            // 
            this.TxtOgrSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtOgrSoyad.Location = new System.Drawing.Point(173, 117);
            this.TxtOgrSoyad.Name = "TxtOgrSoyad";
            this.TxtOgrSoyad.Size = new System.Drawing.Size(171, 27);
            this.TxtOgrSoyad.TabIndex = 1;
            this.TxtOgrSoyad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(114, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "TC : ";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // MskTC
            // 
            this.MskTC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.MskTC.Location = new System.Drawing.Point(173, 165);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(171, 27);
            this.MskTC.TabIndex = 2;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(42, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Telefon No : ";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // MskOgrTelefon
            // 
            this.MskOgrTelefon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.MskOgrTelefon.Location = new System.Drawing.Point(173, 216);
            this.MskOgrTelefon.Mask = "(999) 000-0000";
            this.MskOgrTelefon.Name = "MskOgrTelefon";
            this.MskOgrTelefon.Size = new System.Drawing.Size(171, 27);
            this.MskOgrTelefon.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(11, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Doğum Tarihi : ";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // MskDogum
            // 
            this.MskDogum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.MskDogum.Location = new System.Drawing.Point(173, 256);
            this.MskDogum.Mask = "00/00/0000";
            this.MskDogum.Name = "MskDogum";
            this.MskDogum.Size = new System.Drawing.Size(171, 27);
            this.MskDogum.TabIndex = 2;
            this.MskDogum.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(1, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Öğrenci Bölüm :";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // CmbBolum
            // 
            this.CmbBolum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CmbBolum.FormattingEnabled = true;
            this.CmbBolum.Location = new System.Drawing.Point(173, 307);
            this.CmbBolum.Name = "CmbBolum";
            this.CmbBolum.Size = new System.Drawing.Size(171, 28);
            this.CmbBolum.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(32, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mail Adresi :";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtMail
            // 
            this.TxtMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtMail.Location = new System.Drawing.Point(173, 351);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(171, 27);
            this.TxtMail.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(68, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Oda No :";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // CmbOdaNo
            // 
            this.CmbOdaNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CmbOdaNo.FormattingEnabled = true;
            this.CmbOdaNo.Location = new System.Drawing.Point(173, 398);
            this.CmbOdaNo.Name = "CmbOdaNo";
            this.CmbOdaNo.Size = new System.Drawing.Size(171, 28);
            this.CmbOdaNo.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(12, 449);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Veli Ad Soyad :";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(384, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Veli Telefon :";
            this.label9.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtVeliAdSoyad
            // 
            this.TxtVeliAdSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtVeliAdSoyad.Location = new System.Drawing.Point(173, 449);
            this.TxtVeliAdSoyad.Name = "TxtVeliAdSoyad";
            this.TxtVeliAdSoyad.Size = new System.Drawing.Size(171, 27);
            this.TxtVeliAdSoyad.TabIndex = 1;
            // 
            // MskVeliTelefon
            // 
            this.MskVeliTelefon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.MskVeliTelefon.Location = new System.Drawing.Point(518, 59);
            this.MskVeliTelefon.Mask = "(999) 000-0000";
            this.MskVeliTelefon.Name = "MskVeliTelefon";
            this.MskVeliTelefon.Size = new System.Drawing.Size(171, 27);
            this.MskVeliTelefon.TabIndex = 2;
            this.MskVeliTelefon.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MskVeliTelefon_MaskInputRejected);
            // 
            // RchAdres
            // 
            this.RchAdres.BackColor = System.Drawing.SystemColors.Info;
            this.RchAdres.Location = new System.Drawing.Point(475, 139);
            this.RchAdres.Name = "RchAdres";
            this.RchAdres.Size = new System.Drawing.Size(263, 192);
            this.RchAdres.TabIndex = 4;
            this.RchAdres.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(350, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 24);
            this.label10.TabIndex = 0;
            this.label10.Text = "Veli Adres : ";
            this.label10.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnKaydet.ForeColor = System.Drawing.Color.Crimson;
            this.BtnKaydet.Location = new System.Drawing.Point(475, 398);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(263, 118);
            this.BtnKaydet.TabIndex = 5;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(14, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(330, 27);
            this.label12.TabIndex = 6;
            this.label12.Text = "Kadir Metehan AKDEMİR ";
            this.label12.Click += new System.EventHandler(this.label11_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(750, 545);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.RchAdres);
            this.Controls.Add(this.CmbOdaNo);
            this.Controls.Add(this.CmbBolum);
            this.Controls.Add(this.MskDogum);
            this.Controls.Add(this.MskVeliTelefon);
            this.Controls.Add(this.MskOgrTelefon);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.TxtOgrSoyad);
            this.Controls.Add(this.TxtMail);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtVeliAdSoyad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtOgrAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ogr);
            this.Name = "Form1";
            this.Text = "Öğrenci Kayit Bölümü";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Ogr;
        private TextBox TxtOgrAd;
        private Label label1;
        private TextBox TxtOgrSoyad;
        private Label label2;
        private MaskedTextBox MskTC;
        private Label label3;
        private MaskedTextBox MskOgrTelefon;
        private Label label4;
        private MaskedTextBox MskDogum;
        private Label label5;
        private ComboBox CmbBolum;
        private Label label6;
        private TextBox TxtMail;
        private Label label7;
        private ComboBox CmbOdaNo;
        private Label label8;
        private Label label9;
        private TextBox TxtVeliAdSoyad;
        private MaskedTextBox MskVeliTelefon;
        private RichTextBox RchAdres;
        private Label label10;
        private Button BtnKaydet;
        private Label label12;
    }
}