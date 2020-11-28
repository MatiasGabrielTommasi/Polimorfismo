using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal objeto = new Animal();
            Gato objetoGato = new Gato();
            Perro objetoPerro = new Perro();

            Console.WriteLine(objetoGato.Hablar());
            Console.WriteLine(objetoPerro.Hablar());

            List<Perro> listadoPerros = new List<Perro>();
            List<Gato> listadoGatos = new List<Gato>();
            List<Animal> listadoAnimales = new List<Animal>();

            listadoPerros.Add(new Perro());
            //listadoPerros.Add(new Animal());
            //listadoPerros.Add(new Gato());

            listadoGatos.Add(new Gato());
            //listadoGatos.Add(new Perro());

            listadoAnimales.Add(new Perro());
            listadoAnimales.Add(new Gato());

            //ImprimirAnimales(listadoPerros, "Perros");

            Console.WriteLine("*********************** Listado Perros *****************************");
            foreach (Perro item in listadoPerros)
            {
                Console.Write(item.Hablar());
                Console.WriteLine("\n");
                Console.WriteLine(item.Dormir());
                Console.WriteLine("\n\n");
            }

            Console.WriteLine("*********************** Listado Gatos *****************************");
            foreach (Animal item in listadoGatos)
            {
                Console.Write(item.Hablar());
                Console.WriteLine("\n");
                Console.WriteLine(item.Dormir());
                Console.WriteLine("\n\n");
            }

            Console.WriteLine("*********************** Listado Animales *****************************");
            foreach (Animal item in listadoAnimales)
            {
                Console.Write(item.Hablar());
                Console.WriteLine("\n");
                Console.WriteLine(item.Dormir());
                Console.WriteLine("\n\n");
            }


            List<IAnimal> listadoInterfaz = new List<IAnimal>();
            listadoInterfaz.Add(new Perro());
            listadoInterfaz.Add(new Caballo());
            //listadoInterfaz.Add(new Gato());

            Console.WriteLine("*********************** Listado de cosas que implementan IAnimal *****************************");
            foreach (IAnimal item in listadoInterfaz)
            {
                Console.Write(item.Comer());
                Console.WriteLine("\n");
                Console.WriteLine(item.LlamarDuenio("Dueñazo"));
                Console.WriteLine("\n\n");
            }



            Console.ReadLine();
        }
        //public void ImprimirAnimales(List<Animal> listadoAnimales, string Titulo)
        //{
        //    Console.WriteLine("*********************** Listado " + Titulo + " *****************************");
        //    foreach (Animal item in listadoAnimales)
        //    {
        //        Console.Write(item.Hablar());
        //        Console.WriteLine("");
        //        Console.WriteLine(item.Dormir());
        //        Console.WriteLine("\n\n");
        //    }
        //}
    }
}