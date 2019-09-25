using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening1
{
    class Enemy : IObserver
    {
        ISubject player;

        public Enemy(ISubject player)
        {
            this.player = player;
            player.AddObserver(this);
        }

        public int Life { get; set; } = 10;

        public void update(PlayerAction action)
        {
            switch(action)
            {
                case PlayerAction.PUNCH_ENEMY:
                    Console.WriteLine("Enemy screams in pain. What are you doing?");
                    Life--;
                    break;
                case PlayerAction.KICK_ENEMY:
                    Console.WriteLine("Missed!");
                    break;
            }

            if(Life <= 0)
            {
                Console.WriteLine("The enemy is dead now");
                player.RemoveObserver(this);
            }
        }
    }
}
