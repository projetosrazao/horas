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
            string usuarioSelecionado = DropDownList1.SelectedValue.ToString();
            string dataSelecionadaano = Calendar1.SelectedDate.Year.ToString();
            string dataSelecionadames = Calendar1.SelectedDate.Month.ToString();
            string dataSelecionadadia = Calendar1.SelectedDate.Day.ToString();
            Double soma = 0;
            var connectionString = @"Driver={SQL Anywhere 16};DatabaseName=envel;EngineName=srvenvel;uid=userext;pwd=Razao@123;LINKs=tcpip(host=192.168.1.209)";
            using (var cn = new OdbcConnection(connectionString))
            {
                var cmdf9 = new OdbcCommand("SELECT codi_usu,ISNULL(DATEDIFF(minute,hori_atv,horf_atv),0) as F9  FROM bethadba.geatividades where fina_atv = 's' and bethadba.geatividades.codi_usu = "+usuarioSelecionado+"  and bethadba.geatividades.data_atv = YMD ("+ dataSelecionadaano + ", " + dataSelecionadames + ", " + dataSelecionadadia + ") ", cn);
            //  var cmdaut = new OdbcCommand("SELECT usua_log,ISNULL(DATEDIFF(minute,tini_log,tfim_log),0) FROM bethadba.geloguser WHERE bethadba.geloguser.data_log = "+dataSelecionada+" AND bethadba.geloguser.usua_log = "+usuarioSelecionado+" ", cn);

                cn.Open();

                using (var readerf9 = cmdf9.ExecuteReader())
                {
                    while (readerf9.Read())
                    {
                        for (var i = 0; i < readerf9.FieldCount; i++)
                        {

                            Double F9 = Convert.ToDouble(readerf9["F9"]);
                            soma = F9 + soma;

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
