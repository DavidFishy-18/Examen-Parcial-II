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
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<Serpientes> a = new List<Serpientes>();

            a = Leer();

            if(a == null) a = new List<Serpientes>();

            Serpientes aa = new Serpientes();

            aa.NombreP = TextBox1.Text; aa.Especie = TextBox2.Text; aa.TipoA = TextBox3.Text;
            aa.TiempoV = TextBox4.Text; aa.Venenosa = TextBox5.Text; aa.Longitud = TextBox6.Text;

            a.Add(aa); Grabar(a); TextBox1.Text = ""; TextBox2.Text = ""; TextBox3.Text = ""; TextBox4.Text = "";
            TextBox5.Text = ""; TextBox6.Text = ""; Response.Write("<script>alert('Serpiente registrada exitosamente')</script>");
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
    }
}