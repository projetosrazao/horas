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
            String connString = @"Driver={C:\\Program Files\\SQL Anywhere 16\\Bin32\\dbodbc16.dll};userid=userext;servername=envel;autostop=YES;integrated=NO;filedsn=C:\*****\*****.db.dsn;debug=NO;disablemultirowfetch=NO;commlinks='SharedMemory,TCPIP{host=192.168.1.209}';compress=NO;password=Razao@123";
            OdbcConnection myConnection = new OdbcConnection(connString);
            
           
            }
    }
}