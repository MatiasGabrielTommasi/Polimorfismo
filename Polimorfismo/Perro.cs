using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Perro : Animal, IAnimal
    {
        public override string Hablar()
        {
            return "guau guau";
        }
        public override string Dormir()
        {
            return "Perro durmiendo";
        }

        public string LlamarDuenio(string Nombre)
        {
            return "Perro llamando a " + Nombre;
        }

        public string Comer()
        {
            return "Perro comiendo";
        }
    }
}
