using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening1
{
    class Player : ISubject
    {
        List<IObserver> observers = new List<IObserver>();

        public void AddObserver(IObserver observer)
        {
            if(!observers.Contains(observer))
            {
                observers.Add(observer);
            }
            
        }

        public void RemoveObserver(IObserver observer)
        {
            if(observers.Contains(observer))
            {
                observers.Remove(observer);
            }
        }

        public void UpdateObservers(PlayerAction action)
        {
            observers.ForEach(observer => observer.update(action));
        }

        public void PickupItem()
        {
            Console.WriteLine("Player Picks Up an Item");
            UpdateObservers(PlayerAction.PICK_UP_ITEM);
        }

        public void PunchEnemy()
        {
            Console.WriteLine("Player Punches the Enemy");
            UpdateObservers(PlayerAction.PUNCH_ENEMY);
        }

        public void KickEnemy()
        {
            Console.WriteLine("Player Kicks the Enemy");
            UpdateObservers(PlayerAction.KICK_ENEMY);
        }

        public void DrinkHealthPotion()
        {
            Console.WriteLine("Player drinks a health potion");
            UpdateObservers(PlayerAction.DRINK_POTION);
        }

        public void DrinkPoison()
        {
            Console.WriteLine("Player drinks poison. Auch!");
            UpdateObservers(PlayerAction.DRINK_POTION);
        }

        public void Plant(string itemName)
        {
            Console.WriteLine("Player plants a " + itemName);
            UpdateObservers(PlayerAction.PLANT_CROP);
        }
    }
}
