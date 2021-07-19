using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SIABANK.konfig
{
        abstract class KonfigServ
        {
            public abstract int eksekusiNonQuery(string query); //insert,update,delete
            public abstract DataTable eksekusiQuery(string query); //select
        }
}
