using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening1
{
    class XPBar : IObserver
    {
        public int currentXP { get; set; } = 0;

        ISubject player;

        public XPBar(ISubject player)
        {
            this.player = player;
            player.AddObserver(this);
        }

        public void update(PlayerAction action)
        {
            if (action == PlayerAction.PUNCH_ENEMY || action == PlayerAction.KICK_ENEMY)
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
