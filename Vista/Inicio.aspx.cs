using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RestSharp;

namespace Vista
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            consultar();
        }

        private void consultar()
        {
            var cliente = new RestClient();
            var peticion = new RestRequest("http://cataas.com/cat/gif?json=true", Method.Get);
            var respuesta = cliente.ExecuteAsync<datosimagen>(peticion);

            imagenConsumo.ImageUrl = "http://cataas.com"+respuesta.Result.Data.Url;
        }
    }
}