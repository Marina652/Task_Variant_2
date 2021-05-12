using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_V2
{
    interface IObservable<TypeDefinition>
    {
        void Subscribe(IObserver<TypeDefinition> observer);
        void Unsubscribe(IObserver<TypeDefinition> observer);
        void Notify(TypeDefinition data);
    }
}
