using KoctasWM_Project;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Koctas_VM_Desktop
{
    public partial class Kerem : Form
    {
        public Kerem()
        {
            InitializeComponent();
        }

        DataTable dt_mal = null;

        private void Kerem_Load(object sender, EventArgs e)
        {
            this.TopMost = false;
            Utility.loginInfo(lbl_LoginInfo);

            dt_mal = new DataTable();
            dt_mal.Columns.Add("matnr");
            dt_mal.Columns.Add("maktx");
            dt_mal.Columns.Add("S");
            dt_mal.Columns.Add("menge");
            dt_mal.Columns.Add("meins");
            dt_mal.Columns.Add("ebeln");
            dt_mal.Columns.Add("werks");
            dt_mal.Columns.Add("ebelp");
            dt_mal.Columns.Add("lgort");
            dt_mal.Columns.Add("Amenge");

        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            Koctas_VM_Desktop.WS_Palet_Oku.Z_EWM_PALETLI_MAL_KABUL_OKU serv = new WS_Palet_Oku.Z_EWM_PALETLI_MAL_KABUL_OKU();
            Koctas_VM_Desktop.WS_Palet_Oku.Z_EWM_PALETLI_MAL_KABUL_OKUResponse resp = new WS_Palet_Oku.Z_EWM_PALETLI_MAL_KABUL_OKUResponse();
            Koctas_VM_Desktop.WS_Palet_Oku.Z_EWM_PALETLI_MAL_KABUL_OKU1 req = new WS_Palet_Oku.Z_EWM_PALETLI_MAL_KABUL_OKU1();
            req.I_SEVKNO = txtSevkNo.Text.Trim();
            resp = serv.CallZ_EWM_PALETLI_MAL_KABUL_OKU(req);


        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {

        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {

        }
    }
}
