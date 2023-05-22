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
    public partial class Actualizar : System.Web.UI.Page
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

                int a = DropDownList1.SelectedIndex;

                TextBox1.Text = s[a].NombreP; TextBox2.Text = s[a].Especie; TextBox3.Text = s[a].TipoA;
                TextBox4.Text = s[a].TiempoV; TextBox5.Text = s[a].Venenosa; TextBox6.Text = s[a].Longitud;
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

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Serpientes> s = new List<Serpientes>(); s = Leer();

            int a = DropDownList1.SelectedIndex;

            TextBox1.Text = s[a].NombreP; TextBox2.Text = s[a].Especie; TextBox3.Text = s[a].TipoA;
            TextBox4.Text = s[a].TiempoV; TextBox5.Text = s[a].Venenosa; TextBox6.Text = s[a].Longitud;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}