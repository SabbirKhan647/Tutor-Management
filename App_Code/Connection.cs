﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.Security;

/// <summary>
/// Summary description for Connection
/// </summary>
public static class Connection
{
    public static SqlConnection connect()
    {
        SqlConnection con = new SqlConnection("Data Source=NOEL\\SQLSERVER2012;Initial Catalog=Tutor;");
        return con;
    }

    public static int StudentID = 1;
    public static string RoleName { get; set; }

    public static string GitTry { get; set; }
    public static string GitTryHello { get; set; }

}