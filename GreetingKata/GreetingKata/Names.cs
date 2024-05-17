using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingKata
{
    public class Names : Approver
    {
        public string name;

        public override void Greet(string name)
        {
            string[] words = name.Split(' ');
            if (words.Length == 2)
            {
                string saluto = $"Hello, {words[0]} and {words[1]}";
                Console.WriteLine(saluto);
            }
            base.Greet(name);
        }
    }
}
