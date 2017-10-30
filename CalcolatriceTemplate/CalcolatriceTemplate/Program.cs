using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcolatriceTemplate
{
    class Program
    {
        static void Main(string[] args)
        {

            CalcolatriceStandard cst = new CalcolatriceStandard();
            cst.Calcola(3, 8);

            Console.WriteLine();

            CalcolatriceSomma cso = new CalcolatriceSomma();
            cso.Calcola(3, 8);

            Console.ReadLine();


        }
    }

    abstract class Calcolatrice : ICalcolatrice
    {
        protected abstract void Moltiplicazione(int val1, int val2);

        public void Calcola(int val1, int val2)
        {
            //Calcolo in modo normale
            Moltiplicazione(val1, val2);
        }
    }

    interface ICalcolatrice
    {

        void Calcola(int val1, int val2);
    }

    class CalcolatriceStandard : Calcolatrice
    {
        protected override void Moltiplicazione(int val1, int val2)
        {
            Console.WriteLine(val1 * val2);
        }
    }

    class CalcolatriceSomma : Calcolatrice
    {
        protected override void Moltiplicazione(int val1, int val2)
        {
            int molt = 0;

            for (int i = 0; i < val2; i++)
            {
                molt += val1;
            }

            Console.WriteLine(molt);
        }
    }
}
