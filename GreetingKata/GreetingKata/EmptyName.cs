using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingKata
{
    internal class EmptyName : Approver
    {
        public string name;
        public override void Greet(string name)
        {
            if(name == string.Empty)
            {
               Console.WriteLine("Hello, my friend");
                base.Greet(name);
            }
            else
            {
               base.Greet(name);
            }
        }
    }
}
