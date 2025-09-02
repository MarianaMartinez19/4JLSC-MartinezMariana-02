using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4JLSC_MartinezMariana_02
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    internal class Coche

    {
        private int gasolina;

        public Coche(int gasolina)
        {
            this.gasolina = gasolina;
            Console.WriteLine("Tenemos " + gasolina + " litros");
        }

        public void Arrancar()

        {
            if (gasolina > 0)
            {
                Console.WriteLine("Arranca");
            }
            else
            {
                Console.WriteLine("No arranca");
            }
        }

        public void Conducir()
        {

            if (gasolina > 0)
            {
                gasolina--;
                Console.WriteLine("Quedan " + gasolina + " litros");
            }
            else
            {
                Console.WriteLine("No se mueve");
            }
        }

        private string GetDebuggerDisplay()
        {
            return ToString();

        }
    }
}
     

       
