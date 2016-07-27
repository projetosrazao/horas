using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data.SqlClient;
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
               

            }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string usuarioSelecionado = DropDownList1.ToString();
            string dataSelecionada = Calendar1.SelectedDate.ToString("YYYY-MM-DD");
            string conexao = "Dsn=envel";
            SqlConnection conecta = new SqlConnection(conexao);
            conecta.Open();
            string pesquisa = "SELECT  top 1  usua_log, tini_log, tfim_log FROM bethadba.geloguser WHERE bethadba.geloguser.data_log = dataSelecionada AND bethadba.geloguser.usua_log = usuarioSelecionado";
            
        }
    }
    }
