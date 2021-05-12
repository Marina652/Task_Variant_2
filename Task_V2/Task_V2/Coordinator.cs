using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_V2
{
    public sealed class Coordinator
    {
        public string Message { get; set; }

        public Coordinator(String message)
        {
            Message = message;
        }
    }
}

