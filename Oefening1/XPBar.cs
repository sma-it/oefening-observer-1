using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening1
{
    class XPBar
    {
        public int currentXP { get; set; } = 0;

        private void DrawXPBar()
        {
            Console.WriteLine("XP: ");
            for(int x = 0; x < currentXP; x++)
            {
                Console.Write("%");
            }
            Console.WriteLine();
        }
    }
}
