﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlihosonhansu.Connection
{
    internal class Connection
    {
        // :DDDDDDDDDDDDDD
        private static string 
        stringConnection = @"Data Source=pc;Initial Catalog=kwanlinhansu;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection); 
        }
        
    }
}
