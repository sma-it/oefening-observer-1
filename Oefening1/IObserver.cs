using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening1
{
    interface IObserver
    {
        void update(PlayerAction action);
    }
}
