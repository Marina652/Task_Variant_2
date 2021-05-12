using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Task_V2
{
    public sealed class TrafficPolicePost : IObserver<Coordinator> 
    {
        private string Name { get; set; }

        public TrafficPolicePost(string name)
        {
            Name = name;
        }

        public void Update(Coordinator message)
        {
            MainWindow.ListBox().Items.Add("    " + Name + ": " + "сообщение получено");
        }
    }
}
