namespace Koctas_VM_Desktop
{
    partial class Kerem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kerem));
            this.p1 = new System.Windows.Forms.Panel();
            this.lbl_MalzemeNo = new System.Windows.Forms.Label();
            this.txtSevkNo = new System.Windows.Forms.TextBox();
            this.p2 = new System.Windows.Forms.Panel();
            this.dtp_kayit = new System.Windows.Forms.DateTimePicker();
            this.lbl_KayitTarihi = new System.Windows.Forms.Label();
            this.grd_mal = new System.Windows.Forms.DataGrid();
            this.lbl_LoginInfo = new System.Windows.Forms.Label();
            this.pictureButton1 = new KoctasWM_Project.PictureButton();
            this.btn_Geri = new KoctasWM_Project.PictureButton();
            this.btn_Kaydet = new KoctasWM_Project.PictureButton();
            this.btn_Ekle = new KoctasWM_Project.PictureButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.p1.SuspendLayout();
            this.p2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_mal)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.White;
            this.p1.Controls.Add(this.lbl_MalzemeNo);
            this.p1.Controls.Add(this.txtSevkNo);
            this.p1.Location = new System.Drawing.Point(3, 3);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(312, 27);
            this.p1.TabIndex = 87;
            // 
            // lbl_MalzemeNo
            // 
            this.lbl_MalzemeNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_MalzemeNo.Location = new System.Drawing.Point(3, 6);
            this.lbl_MalzemeNo.Name = "lbl_MalzemeNo";
            this.lbl_MalzemeNo.Size = new System.Drawing.Size(122, 18);
            this.lbl_MalzemeNo.TabIndex = 0;
            this.lbl_MalzemeNo.Text = "Taşıma Birimi";
            // 
            // txtSevkNo
            // 
            this.txtSevkNo.BackColor = System.Drawing.Color.White;
            this.txtSevkNo.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtSevkNo.Location = new System.Drawing.Point(131, 3);
            this.txtSevkNo.Name = "txtSevkNo";
            this.txtSevkNo.Size = new System.Drawing.Size(178, 22);
            this.txtSevkNo.TabIndex = 3;
            // 
            // p2
            // 
            this.p2.BackColor = System.Drawing.Color.White;
            this.p2.Controls.Add(this.dtp_kayit);
            this.p2.Controls.Add(this.lbl_KayitTarihi);
            this.p2.Location = new System.Drawing.Point(3, 30);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(312, 29);
            this.p2.TabIndex = 95;
            // 
            // dtp_kayit
            // 
            this.dtp_kayit.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dtp_kayit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_kayit.Location = new System.Drawing.Point(131, 4);
            this.dtp_kayit.Name = "dtp_kayit";
            this.dtp_kayit.Size = new System.Drawing.Size(178, 22);
            this.dtp_kayit.TabIndex = 64;
            // 
            // lbl_KayitTarihi
            // 
            this.lbl_KayitTarihi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_KayitTarihi.Location = new System.Drawing.Point(3, 6);
            this.lbl_KayitTarihi.Name = "lbl_KayitTarihi";
            this.lbl_KayitTarihi.Size = new System.Drawing.Size(122, 20);
            this.lbl_KayitTarihi.TabIndex = 65;
            this.lbl_KayitTarihi.Text = "Kayıt Tarihi:";
            // 
            // grd_mal
            // 
            this.grd_mal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grd_mal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(228)))));
            this.grd_mal.DataMember = "";
            this.grd_mal.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(188)))), ((int)(((byte)(138)))));
            this.grd_mal.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.grd_mal.Location = new System.Drawing.Point(3, 98);
            this.grd_mal.Name = "grd_mal";
            this.grd_mal.Size = new System.Drawing.Size(312, 112);
            this.grd_mal.TabIndex = 97;
            this.grd_mal.Click += new System.EventHandler(this.grd_mal_Click);
            this.grd_mal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.grd_mal_MouseClick);
            // 
            // lbl_LoginInfo
            // 
            this.lbl_LoginInfo.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbl_LoginInfo.ForeColor = System.Drawing.Color.Black;
            this.lbl_LoginInfo.Location = new System.Drawing.Point(95, 272);
            this.lbl_LoginInfo.Name = "lbl_LoginInfo";
            this.lbl_LoginInfo.Size = new System.Drawing.Size(217, 16);
            this.lbl_LoginInfo.TabIndex = 98;
            this.lbl_LoginInfo.Text = "Bağlı Kullanıcı: ";
            this.lbl_LoginInfo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureButton1
            // 
            this.pictureButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(117)))), ((int)(((byte)(30)))));
            this.pictureButton1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.pictureButton1.ForeColor = System.Drawing.Color.White;
            this.pictureButton1.Location = new System.Drawing.Point(128, 0);
            this.pictureButton1.Name = "pictureButton1";
            this.pictureButton1.PressedImage = null;
            this.pictureButton1.Size = new System.Drawing.Size(60, 27);
            this.pictureButton1.TabIndex = 101;
            this.pictureButton1.Text = "Güncelle";
            this.pictureButton1.Click += new System.EventHandler(this.pictureButton1_Click);
            // 
            // btn_Geri
            // 
            this.btn_Geri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(117)))), ((int)(((byte)(30)))));
            this.btn_Geri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Geri.BackgroundImage")));
            this.btn_Geri.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Geri.ForeColor = System.Drawing.Color.White;
            this.btn_Geri.Location = new System.Drawing.Point(3, 216);
            this.btn_Geri.Name = "btn_Geri";
            this.btn_Geri.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Geri.PressedImage")));
            this.btn_Geri.Size = new System.Drawing.Size(150, 47);
            this.btn_Geri.TabIndex = 100;
            this.btn_Geri.Text = "GERİ";
            this.btn_Geri.Click += new System.EventHandler(this.btn_Geri_Click);
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(117)))), ((int)(((byte)(30)))));
            this.btn_Kaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Kaydet.BackgroundImage")));
            this.btn_Kaydet.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Kaydet.ForeColor = System.Drawing.Color.White;
            this.btn_Kaydet.Location = new System.Drawing.Point(165, 216);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Kaydet.PressedImage")));
            this.btn_Kaydet.Size = new System.Drawing.Size(150, 47);
            this.btn_Kaydet.TabIndex = 99;
            this.btn_Kaydet.Text = "    KAYDET";
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(117)))), ((int)(((byte)(30)))));
            this.btn_Ekle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Ekle.ForeColor = System.Drawing.Color.White;
            this.btn_Ekle.Location = new System.Drawing.Point(3, 65);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.PressedImage = null;
            this.btn_Ekle.Size = new System.Drawing.Size(92, 27);
            this.btn_Ekle.TabIndex = 96;
            this.btn_Ekle.Text = "Listele";
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.pictureButton1);
            this.panel1.Location = new System.Drawing.Point(120, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 27);
            this.panel1.TabIndex = 88;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Miktar:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.textBox2.Location = new System.Drawing.Point(63, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(56, 22);
            this.textBox2.TabIndex = 3;
            // 
            // Kerem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 295);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Geri);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.lbl_LoginInfo);
            this.Controls.Add(this.grd_mal);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Name = "Kerem";
            this.Text = "Kerem";
            this.Load += new System.EventHandler(this.Kerem_Load);
            this.p1.ResumeLayout(false);
            this.p1.PerformLayout();
            this.p2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_mal)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p1;
        private System.Windows.Forms.Label lbl_MalzemeNo;
        private System.Windows.Forms.TextBox txtSevkNo;
        private System.Windows.Forms.Panel p2;
        private System.Windows.Forms.DateTimePicker dtp_kayit;
        private System.Windows.Forms.Label lbl_KayitTarihi;
        private KoctasWM_Project.PictureButton btn_Ekle;
        private System.Windows.Forms.DataGrid grd_mal;
        private System.Windows.Forms.Label lbl_LoginInfo;
        private KoctasWM_Project.PictureButton btn_Geri;
        private KoctasWM_Project.PictureButton btn_Kaydet;
        private KoctasWM_Project.PictureButton pictureButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
    }
}