using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    public class Postres
    {
        public string Nombre { get; }
        public List<string> Ingredientes { get; } = new List<string>();

        public Postres(string nombre, List<string> ingredientes)
        {
            Nombre = nombre;
            Ingredientes = ingredientes;
        }
    }
}
