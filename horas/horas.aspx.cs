using System;
using System.Data.Odbc;
using System.Data.SqlClient;
using iAnywhere;
using System.Data;
using iAnywhere.Data.SQLAnywhere;
using System.Data.Common;

namespace horas
{
    public partial class horas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
               

            }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string usuarioSelecionado = DropDownList1.ToString();
            string dataSelecionada = Calendar1.SelectedDate.ToString("YYYY-MM-DD");
            var connectionString = @"Driver={SQL Anywhere 16};DatabaseName=envel;EngineName=srvenvel;uid=userext;pwd=Razao@123;LINKs=tcpip(host=192.168.1.209)";
            using (var cn = new OdbcConnection(connectionString))
            {
                var cmd = new OdbcCommand("SELECT DISTINCT usua_log FROM bethadba.geloguser ORDER BY usua_log asc", cn);
                cn.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        for (var i = 0; i < reader.FieldCount; i++)
                        {
                            
                            
                              
                        }
                    }
                }
                cn.Close();
            }


        }

        protected void SqlDataSource1_Selecting(object sender, System.Web.UI.WebControls.SqlDataSourceSelectingEventArgs e)
        {

        }
    }
    }
