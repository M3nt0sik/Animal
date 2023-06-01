using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Wolf : Canine
    {
        public Wolf(bool belongToPack)
        {
            BelongsToPack = belongToPack;
        }
        public override void MakeNoise()
        {
            if (BelongsToPack)
                Console.WriteLine("Należe do stada.");
            Console.WriteLine("Auuuuuuuu!");
        }

        public void HuntInPack()
        {
            if (BelongsToPack)
            {
                Console.WriteLine("Wybieram się na polowanie z moim staem");

            }
            else
            {
                Console.WriteLine("Nie należe do stada.");
            }
        }

    }
}
