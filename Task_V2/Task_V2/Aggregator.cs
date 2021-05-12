using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_V2
{
    public sealed class Aggregator : IObservable<Coordinator>
    {
        private readonly List<IObserver<Coordinator>> observers;
        public Aggregator()
        {
            observers = new List<IObserver<Coordinator>>();
        }

        public void Notify(Coordinator data)
        {
            foreach (IObserver<Coordinator> observer in observers)
                observer.Update(data);
        }

        public void Subscribe(IObserver<Coordinator> observer)
        {
            observers.Add(observer);
        }

        public void Unsubscribe(IObserver<Coordinator> observer)
        {
            observers.Remove(observer);
        }
    }
}
