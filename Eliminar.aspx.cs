using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Examen_Parcial_II
{
    public partial class Eliminar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Serpientes> s = new List<Serpientes>();

                s = Leer();

                DropDownList1.DataSource = null;
                DropDownList1.DataValueField = "NombreP";
                DropDownList1.DataTextField = "NombreP";
                DropDownList1.DataSource = s;
                DropDownList1.DataBind();
            }
        }

        private List<Serpientes> Leer()
        {
            List<Serpientes> lista = new List<Serpientes>();
            string archivo = Server.MapPath("Animal.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            lista = JsonConvert.DeserializeObject<List<Serpientes>>(json);

            return lista;
        }

        private void Grabar(List<Serpientes> e)
        {
            string json = JsonConvert.SerializeObject(e);
            string archivo = Server.MapPath("Animal.json");
            System.IO.File.WriteAllText(archivo, json);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<Serpientes> s = new List<Serpientes>(); s = Leer(); int b = DropDownList1.SelectedIndex;

            s.RemoveAt(b); Grabar(s); Response.Write("<script>alert('Animal eliminado exitosamente')</script>");
        }
    }
}