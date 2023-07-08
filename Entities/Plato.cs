using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Plato
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }

        public Plato(int id, string nombre, double precio) { 
            Id = id;
            Nombre = nombre;
            Precio = precio;
        }

    }
}
