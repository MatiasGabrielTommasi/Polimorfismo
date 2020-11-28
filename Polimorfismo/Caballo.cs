using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Caballo : IAnimal
    {
        public string Comer()
        {
            return "Caballo Comiendo";
        }

        public string LlamarDuenio(string Nombre)
        {
            return "Caballo llamando a " + Nombre;
        }
    }
}
