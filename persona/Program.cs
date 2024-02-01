using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persona
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona();
            int NumeroPersone=int.Parse(Console.ReadLine());
            List<Persona> persone = new List<Persona>();
            for(int i = 0; i < NumeroPersone; i++) 
            {
                p.nome = Console.ReadLine();
                p.eta=int.Parse(Console.ReadLine());
                if(p.eta > 17)
                {
                    persone.Add(p);
                }
                 
            }
           foreach(Persona persona in persone)
            {
                Console.WriteLine("{0},{1} anni", p.nome, p.eta);
            }
            Console.ReadLine();

        }
    }
}
