using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;

namespace horas
{
    public class conectionFactory
    {
        public OdbcConnection string_dominio()
        {
            conectionFactory conn_dominio = new conectionFactory();
            conn_dominio.ConnectionString =
              "Dsn=envel;" +
              "Uid=userext;" +
              "Pwd=Razao@123;";
            return conn_dominio;

        }


    }
}