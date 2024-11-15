namespace aracKiralama
{
    partial class frmAracKayit
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
			this.txtPlaka = new System.Windows.Forms.TextBox();
			this.cbxMarka = new System.Windows.Forms.ComboBox();
			this.cbxModel = new System.Windows.Forms.ComboBox();
			this.txtYil = new System.Windows.Forms.TextBox();
			this.txtRenk = new System.Windows.Forms.TextBox();
			this.txtKm = new System.Windows.Forms.TextBox();
			this.cbxYakitTipi = new System.Windows.Forms.ComboBox();
			this.txtUcret = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnKayit = new System.Windows.Forms.Button();
			this.btnIptal = new System.Windows.Forms.Button();
			this.btnResimEkle = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.txtMotorGucu = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtPlaka
			// 
			this.txtPlaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtPlaka.Location = new System.Drawing.Point(308, 120);
			this.txtPlaka.Multiline = true;
			this.txtPlaka.Name = "txtPlaka";
			this.txtPlaka.Size = new System.Drawing.Size(216, 29);
			this.txtPlaka.TabIndex = 0;
			// 
			// cbxMarka
			// 
			this.cbxMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cbxMarka.FormattingEnabled = true;
			this.cbxMarka.Items.AddRange(new object[] {
            "Fiat",
            "Toyota",
            "Renault",
            "Opel",
            "Ford",
            "Volkswagen",
            "Peugeot",
            "Hyundai"});
			this.cbxMarka.Location = new System.Drawing.Point(308, 172);
			this.cbxMarka.Name = "cbxMarka";
			this.cbxMarka.Size = new System.Drawing.Size(216, 28);
			this.cbxMarka.TabIndex = 1;
			this.cbxMarka.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// cbxModel
			// 
			this.cbxModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cbxModel.FormattingEnabled = true;
			this.cbxModel.Location = new System.Drawing.Point(308, 224);
			this.cbxModel.Name = "cbxModel";
			this.cbxModel.Size = new System.Drawing.Size(216, 28);
			this.cbxModel.TabIndex = 1;
			// 
			// txtYil
			// 
			this.txtYil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtYil.Location = new System.Drawing.Point(308, 273);
			this.txtYil.Multiline = true;
			this.txtYil.Name = "txtYil";
			this.txtYil.Size = new System.Drawing.Size(216, 29);
			this.txtYil.TabIndex = 0;
			// 
			// txtRenk
			// 
			this.txtRenk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtRenk.Location = new System.Drawing.Point(308, 322);
			this.txtRenk.Multiline = true;
			this.txtRenk.Name = "txtRenk";
			this.txtRenk.Size = new System.Drawing.Size(216, 29);
			this.txtRenk.TabIndex = 0;
			// 
			// txtKm
			// 
			this.txtKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtKm.Location = new System.Drawing.Point(308, 375);
			this.txtKm.Multiline = true;
			this.txtKm.Name = "txtKm";
			this.txtKm.Size = new System.Drawing.Size(216, 29);
			this.txtKm.TabIndex = 0;
			// 
			// cbxYakitTipi
			// 
			this.cbxYakitTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cbxYakitTipi.FormattingEnabled = true;
			this.cbxYakitTipi.Items.AddRange(new object[] {
            "Dizel ",
            "Benzin",
            "Benzin + LPG",
            "Hibrit",
            "E-Tech"});
			this.cbxYakitTipi.Location = new System.Drawing.Point(308, 477);
			this.cbxYakitTipi.Name = "cbxYakitTipi";
			this.cbxYakitTipi.Size = new System.Drawing.Size(216, 28);
			this.cbxYakitTipi.TabIndex = 1;
			// 
			// txtUcret
			// 
			this.txtUcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtUcret.Location = new System.Drawing.Point(308, 529);
			this.txtUcret.Multiline = true;
			this.txtUcret.Name = "txtUcret";
			this.txtUcret.Size = new System.Drawing.Size(216, 30);
			this.txtUcret.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(254, 123);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Plaka";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(249, 175);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Marka";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(250, 227);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Model";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(276, 276);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(26, 20);
			this.label4.TabIndex = 2;
			this.label4.Text = "Yıl";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(255, 325);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(47, 20);
			this.label5.TabIndex = 2;
			this.label5.Text = "Renk";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(227, 378);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(75, 20);
			this.label6.TabIndex = 2;
			this.label6.Text = "Kilometre";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(229, 480);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(73, 20);
			this.label7.TabIndex = 2;
			this.label7.Text = "Yakıt Tipi";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(220, 532);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(82, 20);
			this.label8.TabIndex = 2;
			this.label8.Text = "Kira Ücreti";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Location = new System.Drawing.Point(601, 165);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(544, 325);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// btnKayit
			// 
			this.btnKayit.BackColor = System.Drawing.Color.Black;
			this.btnKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnKayit.ForeColor = System.Drawing.Color.White;
			this.btnKayit.Location = new System.Drawing.Point(308, 584);
			this.btnKayit.Name = "btnKayit";
			this.btnKayit.Size = new System.Drawing.Size(105, 56);
			this.btnKayit.TabIndex = 4;
			this.btnKayit.Text = "Kayıt";
			this.btnKayit.UseVisualStyleBackColor = false;
			this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
			// 
			// btnIptal
			// 
			this.btnIptal.BackColor = System.Drawing.Color.Black;
			this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnIptal.ForeColor = System.Drawing.Color.White;
			this.btnIptal.Location = new System.Drawing.Point(419, 584);
			this.btnIptal.Name = "btnIptal";
			this.btnIptal.Size = new System.Drawing.Size(105, 56);
			this.btnIptal.TabIndex = 4;
			this.btnIptal.Text = "İptal";
			this.btnIptal.UseVisualStyleBackColor = false;
			this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
			// 
			// btnResimEkle
			// 
			this.btnResimEkle.BackColor = System.Drawing.Color.Black;
			this.btnResimEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnResimEkle.ForeColor = System.Drawing.Color.White;
			this.btnResimEkle.Location = new System.Drawing.Point(789, 522);
			this.btnResimEkle.Name = "btnResimEkle";
			this.btnResimEkle.Size = new System.Drawing.Size(194, 56);
			this.btnResimEkle.TabIndex = 4;
			this.btnResimEkle.Text = "Resim Ekle";
			this.btnResimEkle.UseVisualStyleBackColor = false;
			this.btnResimEkle.Click += new System.EventHandler(this.btnResimEkle_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// txtMotorGucu
			// 
			this.txtMotorGucu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtMotorGucu.Location = new System.Drawing.Point(308, 424);
			this.txtMotorGucu.Multiline = true;
			this.txtMotorGucu.Name = "txtMotorGucu";
			this.txtMotorGucu.Size = new System.Drawing.Size(216, 29);
			this.txtMotorGucu.TabIndex = 0;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label9.ForeColor = System.Drawing.Color.White;
			this.label9.Location = new System.Drawing.Point(209, 427);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(93, 20);
			this.label9.TabIndex = 2;
			this.label9.Text = "Motor Gücü";
			// 
			// frmAracKayit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1368, 752);
			this.Controls.Add(this.btnResimEkle);
			this.Controls.Add(this.btnIptal);
			this.Controls.Add(this.btnKayit);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cbxYakitTipi);
			this.Controls.Add(this.cbxModel);
			this.Controls.Add(this.cbxMarka);
			this.Controls.Add(this.txtMotorGucu);
			this.Controls.Add(this.txtUcret);
			this.Controls.Add(this.txtKm);
			this.Controls.Add(this.txtRenk);
			this.Controls.Add(this.txtYil);
			this.Controls.Add(this.txtPlaka);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmAracKayit";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmAracKayit";
			this.Load += new System.EventHandler(this.frmAracKayit_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.ComboBox cbxMarka;
        private System.Windows.Forms.ComboBox cbxModel;
        private System.Windows.Forms.TextBox txtYil;
        private System.Windows.Forms.TextBox txtRenk;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.ComboBox cbxYakitTipi;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnResimEkle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtMotorGucu;
        private System.Windows.Forms.Label label9;
    }
}