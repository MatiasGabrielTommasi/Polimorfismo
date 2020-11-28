using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public abstract class Animal
    {
        public string Nombre { get; set; }
        public virtual string Hablar()
        {
            return "Animal hablando";
        }
        public virtual string Dormir()
        {
            return "Animal Durmiendo";
        }
    }
}
