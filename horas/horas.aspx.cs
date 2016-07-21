using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace horas
{
    public partial class horas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var connectionString = @"Driver={C:\\Program Files\\SQL Anywhere 16\\Bin32\\dbodbc16.dll};DatabaseName=envel;EngineName=srvenvel;uid=userext;pwd=Razao@123;LINKs=tcpip(host=192.168.1.209)";
            using (var cn = new OdbcConnection(connectionString))
            {
                var cmd = new OdbcCommand("SELECT  *, ano = ?, mes = ?, dia = ? FROM bethadba.geloguser WHERE bethadba.geloguser.data_log = YMD(string(ano),string(mes),string(dia)) AND bethadba.geloguser.usua_log = ? ORDER BY usua_log ASC", cn);
                cn.Open();


            }
        }
    }
}