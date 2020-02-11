﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Apoteka
{
    class Konekcija
    {
        public static SqlConnection KreirajKonekciju()
        {
            SqlConnectionStringBuilder ccnSb = new SqlConnectionStringBuilder();
            ccnSb.DataSource = @"DESKTOP-S7T2MKP\SQLEXPRESS";
            ccnSb.InitialCatalog = @"Apoteka";
            ccnSb.IntegratedSecurity = true; 

            string con = ccnSb.ToString();

            SqlConnection konekcija = new SqlConnection(con);

            return konekcija;
        }
    }
}
