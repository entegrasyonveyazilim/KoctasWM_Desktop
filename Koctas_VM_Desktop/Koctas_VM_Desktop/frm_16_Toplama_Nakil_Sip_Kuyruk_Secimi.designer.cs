namespace KoctasWM_Project
{
    partial class frm_16_Toplama_Nakil_Sip_Kuyruk_Secimi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_16_Toplama_Nakil_Sip_Kuyruk_Secimi));
            this.p4 = new System.Windows.Forms.Panel();
            this.btn_KuyrukDegistir = new KoctasWM_Project.PictureButton();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.lbl_KullaniciAdi = new System.Windows.Forms.Label();
            this.txtDepoNo = new System.Windows.Forms.TextBox();
            this.lbl_DepoNo = new System.Windows.Forms.Label();
            this.txtMevcutKuyruk = new System.Windows.Forms.TextBox();
            this.lbl_MevcutKuyruk = new System.Windows.Forms.Label();
            this.grd_List = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.btn_Geri = new KoctasWM_Project.PictureButton();
            this.btn_Kaydet = new KoctasWM_Project.PictureButton();
            this.lbl_LoginInfo = new System.Windows.Forms.Label();
            this.p4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_List)).BeginInit();
            this.SuspendLayout();
            // 
            // p4
            // 
            this.p4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(228)))));
            this.p4.Controls.Add(this.btn_KuyrukDegistir);
            this.p4.Controls.Add(this.txtKullaniciAdi);
            this.p4.Controls.Add(this.lbl_KullaniciAdi);
            this.p4.Controls.Add(this.txtDepoNo);
            this.p4.Controls.Add(this.lbl_DepoNo);
            this.p4.Controls.Add(this.txtMevcutKuyruk);
            this.p4.Controls.Add(this.lbl_MevcutKuyruk);
            this.p4.Location = new System.Drawing.Point(3, 3);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(312, 84);
            this.p4.TabIndex = 65;
            // 
            // btn_KuyrukDegistir
            // 
            this.btn_KuyrukDegistir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(117)))), ((int)(((byte)(30)))));
            this.btn_KuyrukDegistir.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_KuyrukDegistir.ForeColor = System.Drawing.Color.White;
            this.btn_KuyrukDegistir.Location = new System.Drawing.Point(230, 55);
            this.btn_KuyrukDegistir.Name = "btn_KuyrukDegistir";
            this.btn_KuyrukDegistir.PressedImage = null;
            this.btn_KuyrukDegistir.Size = new System.Drawing.Size(79, 23);
            this.btn_KuyrukDegistir.TabIndex = 76;
            this.btn_KuyrukDegistir.Text = "Değiştir";
            this.btn_KuyrukDegistir.Click += new System.EventHandler(this.btn_KuyrukDegistir_Click);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(188)))), ((int)(((byte)(138)))));
            this.txtKullaniciAdi.Enabled = false;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(131, 30);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(178, 20);
            this.txtKullaniciAdi.TabIndex = 61;
            // 
            // lbl_KullaniciAdi
            // 
            this.lbl_KullaniciAdi.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_KullaniciAdi.Location = new System.Drawing.Point(3, 33);
            this.lbl_KullaniciAdi.Name = "lbl_KullaniciAdi";
            this.lbl_KullaniciAdi.Size = new System.Drawing.Size(109, 20);
            this.lbl_KullaniciAdi.TabIndex = 77;
            this.lbl_KullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // txtDepoNo
            // 
            this.txtDepoNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(188)))), ((int)(((byte)(138)))));
            this.txtDepoNo.Enabled = false;
            this.txtDepoNo.Location = new System.Drawing.Point(131, 5);
            this.txtDepoNo.Name = "txtDepoNo";
            this.txtDepoNo.Size = new System.Drawing.Size(178, 20);
            this.txtDepoNo.TabIndex = 59;
            // 
            // lbl_DepoNo
            // 
            this.lbl_DepoNo.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_DepoNo.Location = new System.Drawing.Point(3, 8);
            this.lbl_DepoNo.Name = "lbl_DepoNo";
            this.lbl_DepoNo.Size = new System.Drawing.Size(122, 20);
            this.lbl_DepoNo.TabIndex = 78;
            this.lbl_DepoNo.Text = "Depo No:";
            // 
            // txtMevcutKuyruk
            // 
            this.txtMevcutKuyruk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(188)))), ((int)(((byte)(138)))));
            this.txtMevcutKuyruk.Enabled = false;
            this.txtMevcutKuyruk.Location = new System.Drawing.Point(131, 55);
            this.txtMevcutKuyruk.Name = "txtMevcutKuyruk";
            this.txtMevcutKuyruk.Size = new System.Drawing.Size(93, 20);
            this.txtMevcutKuyruk.TabIndex = 56;
            // 
            // lbl_MevcutKuyruk
            // 
            this.lbl_MevcutKuyruk.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_MevcutKuyruk.Location = new System.Drawing.Point(3, 58);
            this.lbl_MevcutKuyruk.Name = "lbl_MevcutKuyruk";
            this.lbl_MevcutKuyruk.Size = new System.Drawing.Size(122, 20);
            this.lbl_MevcutKuyruk.TabIndex = 79;
            this.lbl_MevcutKuyruk.Text = "Mevcut Kuyruk:";
            // 
            // grd_List
            // 
            this.grd_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grd_List.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(228)))));
            this.grd_List.DataMember = "";
            this.grd_List.Enabled = false;
            this.grd_List.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(188)))), ((int)(((byte)(138)))));
            this.grd_List.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.grd_List.Location = new System.Drawing.Point(6, 90);
            this.grd_List.Name = "grd_List";
            this.grd_List.Size = new System.Drawing.Size(306, 113);
            this.grd_List.TabIndex = 3;
            this.grd_List.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
            this.dataGridTableStyle1});
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.DataGrid = this.grd_List;
            this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
            this.dataGridTextBoxColumn1,
            this.dataGridTextBoxColumn2,
            this.dataGridTextBoxColumn3});
            this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.HeaderText = "Kuyruk No";
            this.dataGridTextBoxColumn1.MappingName = "kuyrukNo";
            this.dataGridTextBoxColumn1.Width = 75;
            // 
            // dataGridTextBoxColumn2
            // 
            this.dataGridTextBoxColumn2.Format = "";
            this.dataGridTextBoxColumn2.FormatInfo = null;
            this.dataGridTextBoxColumn2.HeaderText = "Kuyruk Açıklaması";
            this.dataGridTextBoxColumn2.MappingName = "kuyrukAciklamasi";
            // 
            // dataGridTextBoxColumn3
            // 
            this.dataGridTextBoxColumn3.Format = "";
            this.dataGridTextBoxColumn3.FormatInfo = null;
            this.dataGridTextBoxColumn3.HeaderText = "Açık Sip. Sayısı";
            this.dataGridTextBoxColumn3.MappingName = "acikSiparisSayisi";
            this.dataGridTextBoxColumn3.Width = 75;
            // 
            // btn_Geri
            // 
            this.btn_Geri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(117)))), ((int)(((byte)(30)))));
            this.btn_Geri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Geri.BackgroundImage")));
            this.btn_Geri.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Geri.ForeColor = System.Drawing.Color.White;
            this.btn_Geri.Location = new System.Drawing.Point(6, 209);
            this.btn_Geri.Name = "btn_Geri";
            this.btn_Geri.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Geri.PressedImage")));
            this.btn_Geri.Size = new System.Drawing.Size(150, 47);
            this.btn_Geri.TabIndex = 64;
            this.btn_Geri.Text = "GERİ";
            this.btn_Geri.Click += new System.EventHandler(this.btn_Geri_Click);
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(117)))), ((int)(((byte)(30)))));
            this.btn_Kaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Kaydet.BackgroundImage")));
            this.btn_Kaydet.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Kaydet.ForeColor = System.Drawing.Color.White;
            this.btn_Kaydet.Location = new System.Drawing.Point(162, 209);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Kaydet.PressedImage")));
            this.btn_Kaydet.Size = new System.Drawing.Size(150, 47);
            this.btn_Kaydet.TabIndex = 63;
            this.btn_Kaydet.Text = "DEVAM ET";
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // lbl_LoginInfo
            // 
            this.lbl_LoginInfo.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbl_LoginInfo.ForeColor = System.Drawing.Color.Black;
            this.lbl_LoginInfo.Location = new System.Drawing.Point(98, 257);
            this.lbl_LoginInfo.Name = "lbl_LoginInfo";
            this.lbl_LoginInfo.Size = new System.Drawing.Size(217, 16);
            this.lbl_LoginInfo.TabIndex = 0;
            this.lbl_LoginInfo.Text = "Bağlı Kullanıcı: ";
            this.lbl_LoginInfo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frm_16_Toplama_Nakil_Sip_Kuyruk_Secimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(318, 295);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_LoginInfo);
            this.Controls.Add(this.btn_Geri);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.grd_List);
            this.Controls.Add(this.p4);
            this.Name = "frm_16_Toplama_Nakil_Sip_Kuyruk_Secimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toplama Kuyruk Seçimi";
            this.Load += new System.EventHandler(this.frm_16_Toplama_Nakil_Sip_Kuyruk_Secimi_Load);
            this.p4.ResumeLayout(false);
            this.p4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_List)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p4;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label lbl_KullaniciAdi;
        private System.Windows.Forms.TextBox txtDepoNo;
        private System.Windows.Forms.Label lbl_DepoNo;
        private System.Windows.Forms.TextBox txtMevcutKuyruk;
        private System.Windows.Forms.Label lbl_MevcutKuyruk;
        private System.Windows.Forms.DataGrid grd_List;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private PictureButton btn_Geri;
        private PictureButton btn_Kaydet;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
        private PictureButton btn_KuyrukDegistir;
        private System.Windows.Forms.Label lbl_LoginInfo;
    }
}