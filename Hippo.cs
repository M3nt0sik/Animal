﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal class Hippo:Animal
    {
        public override void MakeNoise()
        {
            Console.WriteLine("Chrzakanie.");
        }
        public void Swim()
        {
            Console.WriteLine("Plusk! Ie popływać!");
        }

    }
}
