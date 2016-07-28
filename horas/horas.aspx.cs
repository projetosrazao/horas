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
            string pesquisa1 = "SELECT codi_usu,ISNULL(DATEDIFF(minute,hori_atv,horf_atv),0) , FROM bethadba.geatividades where fina_atv = 's' and bethadba.geatividades.codi_usu = usuarioSelecionado and bethadba.geatividades.data_atv = dataSelecionada";
            conectionFactory conn = new conectionFactory();
            OdbcConnection conn_dom = conn.string_dominio();

            conn_dom.Open();

            OdbcCommand cmd = new OdbcCommand(pesquisa1, conn_dom);
            OdbcDataReader reader = cmd.ExecuteReader();
           
            reader.Read();
                //aqui colocar tudo que for ler do SQL, antes um while ++ para repetir o metodo, pois ele só pega o primeiro valor;
            reader.Close();

            conn_dom.Close();
        }
    }
    }
