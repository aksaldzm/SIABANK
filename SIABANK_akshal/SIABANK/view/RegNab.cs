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
    public partial class RegNab : Form
    {
        Nasabah nasabah = new Nasabah();
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_norek;
        private TextBox txt_nama;
        private TextBox txt_alamat;
        private TextBox txt_setorawal;
        private TextBox txt_pin;
        private ComboBox cmb_jenkel;
        private Button btn_simpan;
        private Button btn_ubah;
        private Button btn_hapus;
        private Button btn_batal;
        private Button btn_keluar;
        private DataGridView dgv_nasabah;
        private TextBox txt_cari;
        private Label label8;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private DataGridViewTextBoxColumn no_rek;
        private DataGridViewTextBoxColumn nama_sabah;
        private DataGridViewTextBoxColumn jenis_kel;
        private DataGridViewTextBoxColumn alamat;
        private DataGridViewTextBoxColumn storan_awal;
        private DataGridViewTextBoxColumn keluar;
        private Panel panel2;
        private Label label7;
    
        public RegNab()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_norek = new System.Windows.Forms.TextBox();
            this.txt_nama = new System.Windows.Forms.TextBox();
            this.txt_alamat = new System.Windows.Forms.TextBox();
            this.txt_setorawal = new System.Windows.Forms.TextBox();
            this.txt_pin = new System.Windows.Forms.TextBox();
            this.cmb_jenkel = new System.Windows.Forms.ComboBox();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.btn_ubah = new System.Windows.Forms.Button();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.btn_batal = new System.Windows.Forms.Button();
            this.btn_keluar = new System.Windows.Forms.Button();
            this.dgv_nasabah = new System.Windows.Forms.DataGridView();
            this.no_rek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_sabah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenis_kel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storan_awal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keluar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_cari = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nasabah)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.shapeContainer1);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 57);
            this.panel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(259, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(306, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = "Form Registrasi Nasabah Baru";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(568, 57);
            this.shapeContainer1.TabIndex = 24;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.lineShape1.BorderWidth = 4;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 110;
            this.lineShape1.X2 = 563;
            this.lineShape1.Y1 = 38;
            this.lineShape1.Y2 = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nomor Rekening";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nama Nasabah";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Jenis Kelamin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Alamat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Setoran Awal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "PIN";
            // 
            // txt_norek
            // 
            this.txt_norek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_norek.Location = new System.Drawing.Point(173, 62);
            this.txt_norek.MaxLength = 7;
            this.txt_norek.Name = "txt_norek";
            this.txt_norek.Size = new System.Drawing.Size(107, 22);
            this.txt_norek.TabIndex = 8;
            this.txt_norek.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_norek_KeyPress);
            // 
            // txt_nama
            // 
            this.txt_nama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nama.Location = new System.Drawing.Point(173, 90);
            this.txt_nama.MaxLength = 35;
            this.txt_nama.Name = "txt_nama";
            this.txt_nama.Size = new System.Drawing.Size(211, 22);
            this.txt_nama.TabIndex = 9;
            this.txt_nama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nama_KeyPress_1);
            // 
            // txt_alamat
            // 
            this.txt_alamat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_alamat.Location = new System.Drawing.Point(173, 148);
            this.txt_alamat.MaxLength = 150;
            this.txt_alamat.Name = "txt_alamat";
            this.txt_alamat.Size = new System.Drawing.Size(211, 22);
            this.txt_alamat.TabIndex = 11;
            this.txt_alamat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_alamat_KeyPress_1);
            // 
            // txt_setorawal
            // 
            this.txt_setorawal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_setorawal.Location = new System.Drawing.Point(173, 205);
            this.txt_setorawal.MaxLength = 20;
            this.txt_setorawal.Name = "txt_setorawal";
            this.txt_setorawal.Size = new System.Drawing.Size(211, 22);
            this.txt_setorawal.TabIndex = 13;
            this.txt_setorawal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_setorawal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_setorawal_KeyPress);
            // 
            // txt_pin
            // 
            this.txt_pin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pin.Location = new System.Drawing.Point(173, 177);
            this.txt_pin.MaxLength = 8;
            this.txt_pin.Name = "txt_pin";
            this.txt_pin.PasswordChar = '*';
            this.txt_pin.Size = new System.Drawing.Size(211, 22);
            this.txt_pin.TabIndex = 12;
            this.txt_pin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pin_KeyPress_1);
            // 
            // cmb_jenkel
            // 
            this.cmb_jenkel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_jenkel.FormattingEnabled = true;
            this.cmb_jenkel.Location = new System.Drawing.Point(173, 121);
            this.cmb_jenkel.Name = "cmb_jenkel";
            this.cmb_jenkel.Size = new System.Drawing.Size(211, 21);
            this.cmb_jenkel.TabIndex = 14;
            this.cmb_jenkel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_jenkel_KeyPress_1);
            // 
            // btn_simpan
            // 
            this.btn_simpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simpan.Location = new System.Drawing.Point(173, 240);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(64, 25);
            this.btn_simpan.TabIndex = 15;
            this.btn_simpan.Text = "Simpan";
            this.btn_simpan.UseVisualStyleBackColor = true;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // btn_ubah
            // 
            this.btn_ubah.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ubah.Location = new System.Drawing.Point(243, 240);
            this.btn_ubah.Name = "btn_ubah";
            this.btn_ubah.Size = new System.Drawing.Size(64, 25);
            this.btn_ubah.TabIndex = 16;
            this.btn_ubah.Text = "Ubah";
            this.btn_ubah.UseVisualStyleBackColor = true;
            this.btn_ubah.Click += new System.EventHandler(this.btn_ubah_Click);
            // 
            // btn_hapus
            // 
            this.btn_hapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hapus.Location = new System.Drawing.Point(313, 240);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(64, 25);
            this.btn_hapus.TabIndex = 17;
            this.btn_hapus.Text = "Hapus";
            this.btn_hapus.UseVisualStyleBackColor = true;
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click);
            // 
            // btn_batal
            // 
            this.btn_batal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_batal.Location = new System.Drawing.Point(383, 240);
            this.btn_batal.Name = "btn_batal";
            this.btn_batal.Size = new System.Drawing.Size(64, 25);
            this.btn_batal.TabIndex = 18;
            this.btn_batal.Text = "Batal";
            this.btn_batal.UseVisualStyleBackColor = true;
            this.btn_batal.Click += new System.EventHandler(this.btn_batal_Click);
            // 
            // btn_keluar
            // 
            this.btn_keluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_keluar.Location = new System.Drawing.Point(453, 240);
            this.btn_keluar.Name = "btn_keluar";
            this.btn_keluar.Size = new System.Drawing.Size(64, 25);
            this.btn_keluar.TabIndex = 19;
            this.btn_keluar.Text = "Keluar";
            this.btn_keluar.UseVisualStyleBackColor = true;
            this.btn_keluar.Click += new System.EventHandler(this.btn_keluar_Click_1);
            // 
            // dgv_nasabah
            // 
            this.dgv_nasabah.AllowUserToAddRows = false;
            this.dgv_nasabah.AllowUserToDeleteRows = false;
            this.dgv_nasabah.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nasabah.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no_rek,
            this.nama_sabah,
            this.jenis_kel,
            this.alamat,
            this.storan_awal,
            this.keluar});
            this.dgv_nasabah.Location = new System.Drawing.Point(8, 271);
            this.dgv_nasabah.Name = "dgv_nasabah";
            this.dgv_nasabah.ReadOnly = true;
            this.dgv_nasabah.Size = new System.Drawing.Size(558, 135);
            this.dgv_nasabah.TabIndex = 20;
            this.dgv_nasabah.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_nasabah_CellClick);
            // 
            // no_rek
            // 
            this.no_rek.DataPropertyName = "no_rek";
            this.no_rek.HeaderText = "NO.REK";
            this.no_rek.Name = "no_rek";
            this.no_rek.ReadOnly = true;
            // 
            // nama_sabah
            // 
            this.nama_sabah.DataPropertyName = "nama_sabah";
            this.nama_sabah.HeaderText = "NAMA NASABAH";
            this.nama_sabah.Name = "nama_sabah";
            this.nama_sabah.ReadOnly = true;
            // 
            // jenis_kel
            // 
            this.jenis_kel.DataPropertyName = "jenis_kelamin";
            this.jenis_kel.HeaderText = "JENIS KELAMIN";
            this.jenis_kel.Name = "jenis_kel";
            this.jenis_kel.ReadOnly = true;
            // 
            // alamat
            // 
            this.alamat.DataPropertyName = "alamat";
            this.alamat.HeaderText = "ALAMAT";
            this.alamat.Name = "alamat";
            this.alamat.ReadOnly = true;
            // 
            // storan_awal
            // 
            this.storan_awal.DataPropertyName = "storan_awal";
            this.storan_awal.HeaderText = "SETORAN AWAL";
            this.storan_awal.Name = "storan_awal";
            this.storan_awal.ReadOnly = true;
            // 
            // keluar
            // 
            this.keluar.DataPropertyName = "password";
            this.keluar.HeaderText = "PASSWORD";
            this.keluar.Name = "keluar";
            this.keluar.ReadOnly = true;
            // 
            // txt_cari
            // 
            this.txt_cari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cari.Location = new System.Drawing.Point(349, 18);
            this.txt_cari.Name = "txt_cari";
            this.txt_cari.Size = new System.Drawing.Size(211, 22);
            this.txt_cari.TabIndex = 22;
            this.txt_cari.TextChanged += new System.EventHandler(this.txt_cari_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(346, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Cari Nama Nasabah";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleVioletRed;
            this.panel2.Controls.Add(this.txt_cari);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 409);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(572, 42);
            this.panel2.TabIndex = 23;
            // 
            // RegNab
            // 
            this.ClientSize = new System.Drawing.Size(572, 451);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgv_nasabah);
            this.Controls.Add(this.btn_keluar);
            this.Controls.Add(this.btn_batal);
            this.Controls.Add(this.btn_hapus);
            this.Controls.Add(this.btn_ubah);
            this.Controls.Add(this.btn_simpan);
            this.Controls.Add(this.cmb_jenkel);
            this.Controls.Add(this.txt_setorawal);
            this.Controls.Add(this.txt_pin);
            this.Controls.Add(this.txt_alamat);
            this.Controls.Add(this.txt_nama);
            this.Controls.Add(this.txt_norek);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegNab";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.RegNab_Activated_1);
            this.Load += new System.EventHandler(this.RegNab_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nasabah)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        void tampilGrid()
        {
            dgv_nasabah.DataSource = nasabah.tampilsemua();
        }

        private void RegNab_Activated_1(object sender, EventArgs e)
        {
            txt_norek.Focus();
        }


        private void btn_keluar_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Close();
        }


        private void btn_simpan_Click(object sender, EventArgs e)
        {
            if (!nasabah.adaTidak(txt_norek.Text.Trim()))
            {
                nasabah.no_rek = txt_norek.Text.Trim();
                nasabah.nama_sabah = txt_nama.Text.Trim();
                nasabah.jenis_kelamin = cmb_jenkel.Text.Trim();
                nasabah.alamat = txt_alamat.Text.Trim();
                nasabah.password = txt_pin.Text.Trim();
                nasabah.storan_awal = txt_setorawal.Text.Trim();
                nasabah.simpan();

                MessageBox.Show("Data berhasil disimpan");
                tampilGrid();
            }
        }


        private void txt_nama_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cmb_jenkel.Focus();
            }
        }

        private void cmb_jenkel_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_alamat.Focus();
            }
        }

        private void txt_alamat_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_pin.Focus();
            }
        }

        private void txt_pin_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                txt_setorawal.Focus();
            }
        }

        private void RegNab_Load(object sender, EventArgs e)
        {
            cmb_jenkel.Items.Clear();
            cmb_jenkel.Items.Add("Laki-laki");
            cmb_jenkel.Items.Add("Perempuan");
            tampilGrid();
        }

        private void dgv_nasabah_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow baris = this.dgv_nasabah.Rows[e.RowIndex];

            txt_norek.Text = baris.Cells[0].Value.ToString();
            txt_nama.Text = baris.Cells[1].Value.ToString();
            if (baris.Cells[2].Value.ToString() == "L")
            {
                cmb_jenkel.Text = "Laki-laki";
            }
            else if (baris.Cells[2].Value.ToString() == "P")
            {
                cmb_jenkel.Text = "Perempuan";
            }

            txt_alamat.Text = baris.Cells[3].Value.ToString();
            txt_setorawal.Text = baris.Cells[4].Value.ToString();
            txt_pin.Text = baris.Cells[5].Value.ToString();
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin mau ngeclear data yang barusan diketik ?",
               "KONFIRMASI",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                txt_norek.Clear();
                txt_nama.Clear();
                cmb_jenkel.SelectedIndex = -1;
                txt_alamat.Clear();
                txt_setorawal.Clear();
                txt_pin.Clear();
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            if (nasabah.adaTidak(txt_norek.Text.Trim()))
            {
                if (MessageBox.Show("Yakin Data Nasabah akan dihapus?", "HAPUS DATA",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    nasabah.hapus(txt_norek.Text.Trim());

                    MessageBox.Show("Data berhasil dihapus");
                    tampilGrid();
                }
            }
        }

        private void btn_ubah_Click(object sender, EventArgs e)
        {
            if (nasabah.adaTidak(txt_norek.Text.Trim()))
            {
                if (MessageBox.Show("Yakin data nasabah akan diubah?", "UBAH DATA",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    nasabah.nama_sabah = txt_nama.Text.Trim();
                    nasabah.jenis_kelamin = cmb_jenkel.Text.Trim();
                    nasabah.alamat = txt_alamat.Text.Trim();
                    nasabah.password = txt_pin.Text.Trim();
                    nasabah.storan_awal = txt_setorawal.Text.Trim();
                    nasabah.ubah(txt_norek.Text.Trim());
                    

                    MessageBox.Show("Data berhasil diubah");
                    tampilGrid();
                }
            }
        }

        private void txt_cari_TextChanged(object sender, EventArgs e)
        {
            dgv_nasabah.DataSource = nasabah.tampilbynama(txt_cari.Text);
        }

        private void txt_norek_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (!char.IsNumber(e.KeyChar) && e.KeyChar!=8)
            {
                e.Handled = true;
            }
             if (e.KeyChar == 13)
             {
                 txt_nama.Focus();
             }

        }

        private void txt_setorawal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        











    }
}
