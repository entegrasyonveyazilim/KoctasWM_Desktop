﻿using KoctasWM_Project;
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
            dt_mal.Columns.Add("SA_Belge_No");
            dt_mal.Columns.Add("Klm");
            dt_mal.Columns.Add("Malzeme");
            dt_mal.Columns.Add("Malzeme_Tanimi");
            dt_mal.Columns.Add("Teslimat_Miktari");
            dt_mal.Columns.Add("Birim");
            dt_mal.Columns.Add("Giris_Miktari");

            txtSevkNo.Focus();
        }

        private void EditdwColumn(DataGrid dw)
        {
            //dw
            ////dw.Columns["Giris_Miktari"].ReadOnly = true;
            //foreach (DataGridColumn dc in dw.colu)
            //{
            //    if (dc.Name == "Giris_Miktari")
            //    {
            //        dc.ReadOnly = false;
            //    }
            //    else
            //    {
            //        dc.ReadOnly = true;
            //    }
            //}
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Koctas_VM_Desktop.WS_Palet_Oku.Z_EWM_PALETLI_MAL_KABUL_OKU serv = new WS_Palet_Oku.Z_EWM_PALETLI_MAL_KABUL_OKU();
                Koctas_VM_Desktop.WS_Palet_Oku.Z_EWM_PALETLI_MAL_KABUL_OKUResponse resp = new WS_Palet_Oku.Z_EWM_PALETLI_MAL_KABUL_OKUResponse();
                Koctas_VM_Desktop.WS_Palet_Oku.Z_EWM_PALETLI_MAL_KABUL_OKU1 req = new WS_Palet_Oku.Z_EWM_PALETLI_MAL_KABUL_OKU1();
                serv.Credentials = GlobalData.globalCr;
                req.I_SEVKNO = "1003900092";//txtSevkNo.Text.Trim();
                req.ET_LIST = new WS_Palet_Oku.ZEWM_ST_PALET_MAL_KABUL[0];
                resp = serv.CallZ_EWM_PALETLI_MAL_KABUL_OKU(req);

                int count = resp.ET_LIST.Length;
                Koctas_VM_Desktop.WS_Palet_Oku.ZEWM_ST_PALET_MAL_KABUL[] etlist = new WS_Palet_Oku.ZEWM_ST_PALET_MAL_KABUL[count];
                etlist = resp.ET_LIST;

                for (int i = 0; i < count; i++)
                {
                    DataRow row = dt_mal.NewRow();
                    row["SA_Belge_No"] = etlist[i].EBELN.ToString();
                    row["Klm"] = etlist[i].EBELP.ToString();
                    row["Malzeme"] = etlist[i].MATNR.ToString();
                    row["Malzeme_Tanimi"] = etlist[i].MAKTX.ToString();
                    row["Teslimat_Miktari"] = etlist[i].SMENGE.ToString();
                    row["Birim"] = etlist[i].MEINS.ToString();
                    row["Giris_Miktari"] = etlist[i].AMENGE.ToString();

                    dt_mal.Rows.Add(row);
                }

                grd_mal.DataSource = null;
                grd_mal.DataSource = dt_mal;
             
             
               // grd_mal.Row
                //EditdwColumn(grd_mal);
                Utility.selectText(txtSevkNo);
            }
            catch(Exception ex)
            {
                string mesaj = ex.Message;
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }

        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Koctas_VM_Desktop.WS_Palet_Kaydet.Z_EWM_PALETLI_MAL_KABUL_KAYDET serv = new WS_Palet_Kaydet.Z_EWM_PALETLI_MAL_KABUL_KAYDET();
                Koctas_VM_Desktop.WS_Palet_Kaydet.Z_EWM_PALETLI_MAL_KABUL_KAYDETResponse resp = new WS_Palet_Kaydet.Z_EWM_PALETLI_MAL_KABUL_KAYDETResponse();
                Koctas_VM_Desktop.WS_Palet_Kaydet.Z_EWM_PALETLI_MAL_KABUL_KAYDET1 req = new WS_Palet_Kaydet.Z_EWM_PALETLI_MAL_KABUL_KAYDET1();
                serv.Credentials = GlobalData.globalCr;

                Koctas_VM_Desktop.WS_Palet_Kaydet.ZEWM_ST_PALET_MAL_KABUL[] paletlist = new WS_Palet_Kaydet.ZEWM_ST_PALET_MAL_KABUL[dt_mal.Rows.Count];

                
                req.I_BUDAT = dtp_kayit.ToString();

               for (int i = 0; i < dt_mal.Rows.Count; i++)
                {
                    paletlist[i] = new WS_Palet_Kaydet.ZEWM_ST_PALET_MAL_KABUL();
                    paletlist[i].EBELP = dt_mal.Rows[i]["Klm"].ToString();
                    paletlist[i].EBELN = dt_mal.Rows[i]["SA_Belge_No"].ToString();
                    paletlist[i].MATNR = dt_mal.Rows[i]["Malzeme"].ToString();
                    paletlist[i].MAKTX = dt_mal.Rows[i]["Malzeme_Tanimi"].ToString();
                    paletlist[i].SMENGE = decimal.Parse(dt_mal.Rows[i]["Teslimat_Miktari"].ToString());
                    paletlist[i].AMENGE = dt_mal.Rows[i]["Giris_Miktari"].ToString();
                    paletlist[i].MEINS = dt_mal.Rows[i]["Birim"].ToString();
                }

                req.IT_LIST = paletlist;

                resp = serv.CallZ_EWM_PALETLI_MAL_KABUL_KAYDET(req);

                Cursor.Current = Cursors.Default;

                MessageBox.Show(resp.ET_RETURN[0].TYPE, "SONUÇ");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA");
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string degisken = "ali";
        private void pictureButton1_Click(object sender, EventArgs e)
        {
            //Popupform popup = new Popupform();
            //if (popup.ShowDialog(this) == DialogResult.OK)
            //{
            //    // Read the contents of testDialog's TextBox.
            //    this.degisken = popup.ReturnValue1;
            //}
            //else
            //{
            //    this.degisken = "Cancelled";
            //}

            ////if (popup.ShowDialog(this) == DialogResult.OK)
            ////{
            ////    // Read the contents of testDialog's TextBox.
            ////    degisken = popup.ReturnValue1;
            ////}
            ////degisken = degisken;
            ////popup.Dispose();
            ////else
            ////{
            ////    this.txtResult.Text = "Cancelled";
            ////}


        }
    }
}