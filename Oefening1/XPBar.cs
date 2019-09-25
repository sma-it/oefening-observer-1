using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening1
{
    class XPBar : IObserver
    {
        public int currentXP { get; set; } = 0;

        public void update(PlayerAction action)
        {
            if (action == PlayerAction.PUNCH_ENEMY)
            {
                currentXP++;
                DrawXPBar();
            }
        }

        private void DrawXPBar()
        {
            Console.Write("XP: ");
            for(int x = 0; x < currentXP; x++)
            {
                Console.Write("%");
            }
            Console.WriteLine();
        }
    }
}
