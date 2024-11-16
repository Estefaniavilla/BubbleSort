using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    internal class Estudiante
    {
        public string Nombre { get; set; }
        public string NumeroID { get; set; }
        public int Calificacion { get; set; }


        public Estudiante(string nombre, string numeroID, int calificacion)
        {
            Nombre = nombre;
            NumeroID = numeroID;
            Calificacion = calificacion;
        }
    }
        