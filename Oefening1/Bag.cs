using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening1
{
    class Bag : IObserver
    {
        public int Items { get; set; } = 0;
        ISubject player;

        public Bag(ISubject player)
        {
            this.player = player;
            player.AddObserver(this);
        }

        public void DrawContents()
        {
            Console.WriteLine("The bag contains " + Items + " item(s)");
        }

        public void update(PlayerAction action)
        {
            switch(action)
            {
                case PlayerAction.PICK_UP_ITEM:
                    Items++;
                    DrawContents();
                    break;
                case PlayerAction.DROP_ITEM:
                    Items--;
                    DrawContents();
                    break;

            }
        }
    }
}
