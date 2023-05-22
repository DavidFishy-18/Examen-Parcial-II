using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen_Parcial_II
{
    public class Serpientes:Animales
    {
        string venenosa;
        string longitud;

        public string Venenosa { get => venenosa; set => venenosa = value; }
        public string Longitud { get => longitud; set => longitud = value; }
    }
}