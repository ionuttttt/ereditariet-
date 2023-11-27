using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ereditarietà
{
    internal class Program
    {
        class quadrato
        {
            protected double lato { get; set; }


            public quadrato()
            {
                lato = 5;
            }
                
            public void perimetro()
            {
                double perimetr = lato * 4;
                Console.WriteLine("Il perimetro del quadrato è: " + perimetr);
            }

            public void area()
            {
                double are = lato * lato;
                Console.WriteLine("L'area del quadrato è: " + are);
            }

                 

        }

        class cubo : quadrato
        {

            public void superficie()
            {
                double sup = lato*lato * 6;
                Console.WriteLine("La superficie totale del cubo è: "+sup);
            }

            public void volume()
            {
               double vol = lato * lato * lato;
                Console.WriteLine("Il volume del cubo è:" + vol);
            }
        }

        static void Main(string[] args)
        {
            quadrato quadrato = new quadrato();
            cubo cubo = new cubo();
            quadrato.perimetro();
            quadrato.area();
            cubo.superficie();
            cubo.volume();
            Console.ReadLine();
        }
    }
}
