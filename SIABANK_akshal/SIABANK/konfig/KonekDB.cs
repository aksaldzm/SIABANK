using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace SIABANK.konfig
{
    class KonekDB : KonfigServ
    {
        private MySqlConnection mCon;
        private MySqlCommand mCom;
        private MySqlDataAdapter mDap;

        private string serv = "server=localhost;port=3306;" +
            "database=siabank;uid=root;password=";

        public KonekDB()
        {
            mCon = new MySqlConnection(serv);
            mCom = new MySqlCommand();
            mDap = new MySqlDataAdapter();
        }

        private void bukakoneksi()
        {
            if (mCon.State == ConnectionState.Closed)
            {
                try
                {
                    mCon.Open();
                }
                catch (Exception e) { }
            }
        }

        private void tutupkoneksi()
        {
            mCon.Close();
        }

        public override int eksekusiNonQuery(string query)
        {
            int kembalian = -1;

            try
            {
                bukakoneksi();
                mCom.Connection = mCon;
                mCom.CommandText = query;
                kembalian = mCom.ExecuteNonQuery();
            }
            catch (Exception e1) { }
            finally
            {
                tutupkoneksi();
            }

            return kembalian;
        }

        public override DataTable eksekusiQuery(string query)
        {
            DataTable kembalian = new DataTable();

            try
            {
                bukakoneksi();
                mCom.Connection = mCon;
                mCom.CommandText = query;
                mDap.SelectCommand = mCom;
                mDap.Fill(kembalian);
            }
            catch (Exception e1) { }
            finally
            {
                tutupkoneksi();
            }

            return kembalian;
        }


    }
}
