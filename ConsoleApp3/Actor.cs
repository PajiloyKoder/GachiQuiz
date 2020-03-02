using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Actor
    {
        public string Name { get; set; }
    
        public int counter { get; set; } = 0;
        public Actor(string Name )
        {
            this.Name = Name;
        
        }
    }
}
