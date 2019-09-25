using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening1
{
    interface ISubject
    {
        void AddObserver(IObserver observer);
        void RemoveObserver(IObserver observer);

        void UpdateObservers(PlayerAction action);
    }
}
