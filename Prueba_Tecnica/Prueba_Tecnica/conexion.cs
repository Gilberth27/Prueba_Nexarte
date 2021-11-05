using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace PRUEBA   
{
    class conexion
    {   
        static void Main (String[ ] args)
        {
            var mensaje = ConfigurationManager.AppSettings[ "mensaje"];
            Console.WriteLine(mensaje);

            var builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"DESKTOP-MC99VBA\MSSQLSERVER01";
            builder.InitialCatalog = "PruebaTecnica";
            builder.IntegratedSecurity = true;

            var connectionString = builder.ToString();

            using (SqlConnection sql = new SqlConnection(connectionString))
            {
                sql.Open();
            }
            Console.Read();

        }
    }
}

