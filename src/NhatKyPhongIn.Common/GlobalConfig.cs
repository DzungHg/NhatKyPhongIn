﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace NhatKyPhongIn.Common
{
    public static class GlobalConfig
    {
        //TODO - Làm Tiếp connent
        public static void InitializeConnections()
        {
            SqlConnection sql = new SqlConnection();
        }
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
