﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrgrms
{
    class Powerof2
    {
        public static void Power2()
        {

            int value = 2;
            for (int power = 0; power <= 32; power++)
                Console.WriteLine($"{value}^{power} = {(long)Math.Pow(value, power):N0}");

        }
    }
}
