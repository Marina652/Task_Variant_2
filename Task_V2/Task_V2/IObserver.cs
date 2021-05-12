using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_V2
{
    public interface IObserver<TypeDefinition>
    {
        void Update(TypeDefinition data);
    }
}
