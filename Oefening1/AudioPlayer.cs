using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening1
{
    class AudioPlayer: IObserver
    {
        ISubject player;

        public AudioPlayer(ISubject player)
        {
            this.player = player;
            player.AddObserver(this);
        }

        private void PlayPunchSound()
        {
            Console.WriteLine("  *** punch! ***");
        }

        private void PlayRustleLeaves()
        {
            Console.WriteLine("  .. rustle ..");
        }

        private void PlayDrinkingSound()
        {
            Console.WriteLine("  ^^QUAF^^");
        }

        public void update(PlayerAction action)
        {
            switch(action)
            {
                case PlayerAction.PUNCH_ENEMY: PlayPunchSound(); break;
                case PlayerAction.PLANT_CROP: PlayRustleLeaves(); break;
                case PlayerAction.DRINK_POTION: PlayDrinkingSound(); break;
            }
        }
    }
}
