using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening1
{
    class Achievements : IObserver
    {
        ISubject player;

        public Achievements(ISubject player)
        {
            this.player = player;
            player.AddObserver(this);
        }

        int cropsPlanted = 0;
        public int CropsPlanted { get => cropsPlanted; }

        int enemiesPunched = 0;
        public int EnemiesPunched { get => enemiesPunched; }

        int potionsQuaffed = 0;
        public int PotionsQuaffed { get => potionsQuaffed; }

        private void updateCrops()
        {
            cropsPlanted++;
            if(cropsPlanted == 10)
            {
                Console.WriteLine("Dirty Fingers Achievement (10 Crops Planted)");
            }
        }

        private void updatePunches()
        {
            enemiesPunched++;
            if(enemiesPunched == 20)
            {
                // also known as the Donald Trump Achievement
                Console.WriteLine("Low IQ Achievement (20 enemies hit instead of talking things out)");
            }
        }

        private void updateDrinks()
        {
            potionsQuaffed++;
            if(potionsQuaffed == 100)
            {
                Console.WriteLine("You have a drinking problem.");
            }
        }

        public void update(PlayerAction action)
        {
            switch(action)
            {
                case PlayerAction.DRINK_POTION: updateDrinks(); break;
                case PlayerAction.PUNCH_ENEMY: updatePunches(); break;
                case PlayerAction.PLANT_CROP: updateCrops(); break;
            }
        }
    }
}
