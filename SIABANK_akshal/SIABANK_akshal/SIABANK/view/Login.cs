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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin akan keluar aplikasi ?",
               "KONFIRMASI",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "admin" && txt_pw.Text == "akshal")
            {
                RegNab regnab = new RegNab();
                regnab.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Maaf, Userid/Password anda salah.", "Notifikasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txt_id.SelectAll();
            txt_id.Focus();
        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_pw.Focus();
            }
        }

        private void txt_pw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btn_login.PerformClick();
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            txt_id.Focus();
        }


    }
}
