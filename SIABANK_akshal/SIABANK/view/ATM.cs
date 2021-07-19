using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SIABANK
{
    using model;
    public partial class ATM : Form
    {
        Nasabah nasabah = new Nasabah();
        public ATM()
        {
           
            InitializeComponent();
        }

        private void ATM_Activated(object sender, EventArgs e)
        {
            txt_id.Focus();
        }
        
        private void ATM_Load(object sender, EventArgs e)
        {
            txt_id.Focus();
        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                txt_pin.Focus();
            }
        }

        private void txt_pin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                btn_login.PerformClick();
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (nasabah.adaTidak(txt_id.Text.Trim()))
            {
                DataTable dat = new DataTable();
                dat=nasabah.tunjukan(txt_id.Text, txt_pin.Text);
                if (dat.Rows.Count > 0) ;
                {
                    if (dat.Rows[0][3].ToString() == "L")
                    {
                        MessageBox.Show("Selamat Datang Tuan " + dat.Rows[0][0].ToString() + " Anda berhasil melakukan Login.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (dat.Rows[0][3].ToString() == "P")
                    {
                        MessageBox.Show("Selamat Datang Nyonya " + dat.Rows[0][0].ToString() + " Anda berhasil melakukan Login.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin akan keluar aplikasi ?",
               "KONFIRMASI",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        
    }
}
