using System;

namespace Oefening1
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new Player();

            AudioPlayer audioPlayer = new AudioPlayer();
            XPBar xpBar = new XPBar();
            Achievements achievements = new Achievements();

            var menu = new SMUtils.Menu();
            menu.AddOption('1', "Punch the Enemy", () => player.PunchEnemy());
            menu.AddOption('2', "Pick up Rock", () => player.PickupItem());
            menu.AddOption('3', "Drink Health Potion", () => player.DrinkHealthPotion());
            menu.AddOption('4', "Drink Poison", () => player.DrinkPoison());
            menu.AddOption('5', "Plant Carrot", () => player.Plant("Carrot"));
            menu.AddOption('6', "Plant Avocado", () => player.Plant("Avocado"));

            menu.Start();
        }
    }
}
