using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Gato : Animal
    {
        public override string Hablar()
        {
            return "miau miau";
        }
        public override string Dormir()
        {
            return "Gato Durmiendo";
        }
    }
}
