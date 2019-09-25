using System;

namespace Oefening1
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new Player();

            AudioPlayer audioPlayer = new AudioPlayer(player);
            XPBar xpBar = new XPBar(player);
            Achievements achievements = new Achievements(player);
            Bag bag = new Bag(player);
            Enemy enemy = new Enemy(player);

            var menu = new SMUtils.Menu();
            menu.AddOption('1', "Punch the Enemy", () => player.PunchEnemy());
            menu.AddOption('2', "Pick up Rock", () => player.PickupItem());
            menu.AddOption('3', "Drink Health Potion", () => player.DrinkHealthPotion());
            menu.AddOption('4', "Drink Poison", () => player.DrinkPoison());
            menu.AddOption('5', "Plant Carrot", () => player.Plant("Carrot"));
            menu.AddOption('6', "Plant Avocado", () => player.Plant("Avocado"));
            menu.AddOption('7', "Kick the Enemy", () => player.KickEnemy());
            menu.AddOption('8', "Plant Salad", () => player.Plant("Salad"));
            menu.AddOption('9', "Drop Rock", () => player.DropItem());

            menu.Start();
        }
    }
}
