namespace aracKiralama
{
    partial class frmAracListele
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.cbxAraclar = new System.Windows.Forms.ComboBox();
			this.btnResimDegistir = new System.Windows.Forms.Button();
			this.btnIptal = new System.Windows.Forms.Button();
			this.btnGuncelle = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cbxYakitTipi = new System.Windows.Forms.ComboBox();
			this.cbxModel = new System.Windows.Forms.ComboBox();
			this.cbxMarka = new System.Windows.Forms.ComboBox();
			this.txtMotorGucu = new System.Windows.Forms.TextBox();
			this.txtUcret = new System.Windows.Forms.TextBox();
			this.txtKm = new System.Windows.Forms.TextBox();
			this.txtRenk = new System.Windows.Forms.TextBox();
			this.txtYil = new System.Windows.Forms.TextBox();
			this.txtPlaka = new System.Windows.Forms.TextBox();
			this.btnSil = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(451, 90);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(1057, 517);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
			// 
			// cbxAraclar
			// 
			this.cbxAraclar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cbxAraclar.FormattingEnabled = true;
			this.cbxAraclar.Items.AddRange(new object[] {
            "Tüm Araçlar",
            "Boş Araçlar",
            "Kiradaki Araçlar"});
			this.cbxAraclar.Location = new System.Drawing.Point(1237, 43);
			this.cbxAraclar.Name = "cbxAraclar";
			this.cbxAraclar.Size = new System.Drawing.Size(234, 32);
			this.cbxAraclar.TabIndex = 1;
			this.cbxAraclar.SelectedIndexChanged += new System.EventHandler(this.cbxAraclar_SelectedIndexChanged);
			// 
			// btnResimDegistir
			// 
			this.btnResimDegistir.BackColor = System.Drawing.Color.Black;
			this.btnResimDegistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnResimDegistir.ForeColor = System.Drawing.Color.White;
			this.btnResimDegistir.Location = new System.Drawing.Point(182, 740);
			this.btnResimDegistir.Name = "btnResimDegistir";
			this.btnResimDegistir.Size = new System.Drawing.Size(168, 51);
			this.btnResimDegistir.TabIndex = 26;
			this.btnResimDegistir.Text = "Resim Değiştir";
			this.btnResimDegistir.UseVisualStyleBackColor = false;
			this.btnResimDegistir.Click += new System.EventHandler(this.btnResimDegistir_Click);
			// 
			// btnIptal
			// 
			this.btnIptal.BackColor = System.Drawing.Color.Black;
			this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnIptal.ForeColor = System.Drawing.Color.White;
			this.btnIptal.Location = new System.Drawing.Point(676, 640);
			this.btnIptal.Name = "btnIptal";
			this.btnIptal.Size = new System.Drawing.Size(101, 51);
			this.btnIptal.TabIndex = 25;
			this.btnIptal.Text = "İptal";
			this.btnIptal.UseVisualStyleBackColor = false;
			this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.BackColor = System.Drawing.Color.Black;
			this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnGuncelle.ForeColor = System.Drawing.Color.White;
			this.btnGuncelle.Location = new System.Drawing.Point(451, 640);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(112, 51);
			this.btnGuncelle.TabIndex = 24;
			this.btnGuncelle.Text = "Güncelle";
			this.btnGuncelle.UseVisualStyleBackColor = false;
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label9.ForeColor = System.Drawing.Color.White;
			this.label9.Location = new System.Drawing.Point(76, 390);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(76, 16);
			this.label9.TabIndex = 21;
			this.label9.Text = "Motor Gücü";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(83, 486);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(69, 16);
			this.label8.TabIndex = 20;
			this.label8.Text = "Kira Ücreti";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(85, 443);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(64, 16);
			this.label7.TabIndex = 19;
			this.label7.Text = "Yakıt Tipi";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(88, 339);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 16);
			this.label6.TabIndex = 18;
			this.label6.Text = "Kilometre";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(112, 285);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 16);
			this.label5.TabIndex = 17;
			this.label5.Text = "Renk";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(126, 232);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(23, 16);
			this.label4.TabIndex = 22;
			this.label4.Text = "Yıl";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(103, 188);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 16);
			this.label3.TabIndex = 16;
			this.label3.Text = "Model";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(106, 143);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 16);
			this.label2.TabIndex = 15;
			this.label2.Text = "Marka";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(106, 91);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 16);
			this.label1.TabIndex = 14;
			this.label1.Text = "Plaka";
			// 
			// cbxYakitTipi
			// 
			this.cbxYakitTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cbxYakitTipi.FormattingEnabled = true;
			this.cbxYakitTipi.Items.AddRange(new object[] {
            "Dizel ",
            "Benzin",
            "Benzin + LPG",
            "Hibrit",
            "E-Tech"});
			this.cbxYakitTipi.Location = new System.Drawing.Point(168, 437);
			this.cbxYakitTipi.Name = "cbxYakitTipi";
			this.cbxYakitTipi.Size = new System.Drawing.Size(216, 28);
			this.cbxYakitTipi.TabIndex = 13;
			// 
			// cbxModel
			// 
			this.cbxModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cbxModel.FormattingEnabled = true;
			this.cbxModel.Location = new System.Drawing.Point(168, 182);
			this.cbxModel.Name = "cbxModel";
			this.cbxModel.Size = new System.Drawing.Size(216, 28);
			this.cbxModel.TabIndex = 12;
			// 
			// cbxMarka
			// 
			this.cbxMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
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
			this.cbxMarka.Location = new System.Drawing.Point(168, 137);
			this.cbxMarka.Name = "cbxMarka";
			this.cbxMarka.Size = new System.Drawing.Size(216, 28);
			this.cbxMarka.TabIndex = 11;
			this.cbxMarka.SelectedIndexChanged += new System.EventHandler(this.cbxMarka_SelectedIndexChanged);
			// 
			// txtMotorGucu
			// 
			this.txtMotorGucu.Location = new System.Drawing.Point(168, 389);
			this.txtMotorGucu.Multiline = true;
			this.txtMotorGucu.Name = "txtMotorGucu";
			this.txtMotorGucu.Size = new System.Drawing.Size(216, 29);
			this.txtMotorGucu.TabIndex = 9;
			// 
			// txtUcret
			// 
			this.txtUcret.Location = new System.Drawing.Point(168, 485);
			this.txtUcret.Multiline = true;
			this.txtUcret.Name = "txtUcret";
			this.txtUcret.Size = new System.Drawing.Size(216, 30);
			this.txtUcret.TabIndex = 8;
			// 
			// txtKm
			// 
			this.txtKm.Location = new System.Drawing.Point(168, 338);
			this.txtKm.Multiline = true;
			this.txtKm.Name = "txtKm";
			this.txtKm.Size = new System.Drawing.Size(216, 29);
			this.txtKm.TabIndex = 7;
			// 
			// txtRenk
			// 
			this.txtRenk.Location = new System.Drawing.Point(168, 284);
			this.txtRenk.Multiline = true;
			this.txtRenk.Name = "txtRenk";
			this.txtRenk.Size = new System.Drawing.Size(216, 29);
			this.txtRenk.TabIndex = 6;
			// 
			// txtYil
			// 
			this.txtYil.Location = new System.Drawing.Point(168, 231);
			this.txtYil.Multiline = true;
			this.txtYil.Name = "txtYil";
			this.txtYil.Size = new System.Drawing.Size(216, 29);
			this.txtYil.TabIndex = 10;
			// 
			// txtPlaka
			// 
			this.txtPlaka.Location = new System.Drawing.Point(168, 90);
			this.txtPlaka.Multiline = true;
			this.txtPlaka.Name = "txtPlaka";
			this.txtPlaka.Size = new System.Drawing.Size(216, 29);
			this.txtPlaka.TabIndex = 5;
			// 
			// btnSil
			// 
			this.btnSil.BackColor = System.Drawing.Color.Black;
			this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnSil.ForeColor = System.Drawing.Color.White;
			this.btnSil.Location = new System.Drawing.Point(569, 640);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(101, 51);
			this.btnSil.TabIndex = 25;
			this.btnSil.Text = "Sil";
			this.btnSil.UseVisualStyleBackColor = false;
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox2.Location = new System.Drawing.Point(115, 532);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(303, 202);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 27;
			this.pictureBox2.TabStop = false;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// frmAracListele
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1556, 813);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.btnResimDegistir);
			this.Controls.Add(this.btnSil);
			this.Controls.Add(this.btnIptal);
			this.Controls.Add(this.btnGuncelle);
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
			this.Controls.Add(this.cbxAraclar);
			this.Controls.Add(this.dataGridView1);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmAracListele";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Araç Listeleme Sayfası";
			this.Load += new System.EventHandler(this.frmAracListele_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbxAraclar;
        private System.Windows.Forms.Button btnResimDegistir;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxYakitTipi;
        private System.Windows.Forms.ComboBox cbxModel;
        private System.Windows.Forms.ComboBox cbxMarka;
        private System.Windows.Forms.TextBox txtMotorGucu;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.TextBox txtRenk;
        private System.Windows.Forms.TextBox txtYil;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}