using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SIABANK.model
{
    using konfig;
    class Nasabah
    {
        private string _no_rek;
        private string _nama_sabah;
        private string _jenis_kelamin;
        private string _alamat;
        private string _storan_awal;
        private string _password;

        private KonekDB server;
        private DataTable data;
        private string Query = "";

        public Nasabah()
        {
            _no_rek = "";
            _nama_sabah = "";
            _jenis_kelamin = "";
            _alamat = "";
            _storan_awal = "";
            _password = "";

            server = new KonekDB();
            data = new DataTable();
        }

        public string no_rek
        {                                                                                                                                       
            set { _no_rek = value; }
        }

        public string nama_sabah
        {
            set { _nama_sabah = value; }
        }

        public string jenis_kelamin
        {
            set { _jenis_kelamin = value; }
        }

        public string alamat
        {
            set { _alamat = value; }
        }

        public string storan_awal
        {
            set { _storan_awal = value; }
        }

        public string password
        {
            set { _password = value; }
        }

        public bool adaTidak(string norek)
        {
            bool cek = false;
            Query = "Select * from nasabah where no_rek='" + norek + "'";
            data = server.eksekusiQuery(Query);

            if (data.Rows.Count > 0)
            {
                cek = true;
            }
            return cek;
        }


        public DataTable tunjukan(string uid,string pin) 
        {
            Query = "Select nama_sabah,no_rek,password,jenis_kelamin from nasabah where no_rek ='" + uid + "' and password ='" + pin + "'";
            return server.eksekusiQuery(Query);
        }

        public void simpan()
        {
            Query = "insert into nasabah values ('" + _no_rek + "','" + _nama_sabah + "','" + _jenis_kelamin + "','" + _alamat + "','" + _storan_awal + "','" + _password + "')";
            if (!(server.eksekusiNonQuery(Query) > 0))
            {
                throw new Exception("Data gagal disimpan");
            }
        }

        public void ubah(string norek)
        {
            Query = "update nasabah set nama_sabah='" + _nama_sabah + "',jenis_kelamin='" + _jenis_kelamin + "',alamat='" + _alamat + "',password='" + _password + "',storan_awal='" + _storan_awal + "'  where " + " no_rek='" + norek + "'";
            if (!(server.eksekusiNonQuery(Query) > 0))
            {
                throw new Exception("Data gagal diubah");
            }
        }

        public void hapus(string norek)
        {
            Query = "Delete from nasabah where no_rek='" + norek + "'";
            if (!(server.eksekusiNonQuery(Query) > 0))
            {
                throw new Exception("Data gagal dihapus");
            }
        }

        public DataTable tampilsemua()
        {
            Query = "select * from nasabah";

            return server.eksekusiQuery(Query);
        }

        public DataTable tampilbynama(string nama)
        {
            Query = "select * from nasabah where nama_sabah like'%" + nama + "%'";

            return server.eksekusiQuery(Query);
        }

        public string ambilnamabykode(string norek)
        {
            string kd = "";
            Query = "select nama_sabah,jenis_kelamin,alamat,storan_awal,password from nasabah where no_rek='" + norek + "'";
            data = server.eksekusiQuery(Query);

            if (data.Rows.Count > 0)
            {
                foreach (DataRow dt in data.Rows)
                {
                    kd = dt[0].ToString();
                }

            }
            return kd;
        }
    }
}
