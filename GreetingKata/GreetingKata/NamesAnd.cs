using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingKata
{
    internal class NamesAnd : Approver
    {
        public string name;

        public override void Greet(string name)
        {
            string[] words = name.Split(' ');
            if (words.Length > 2)
            {
                string saluto = "Hello";
                string lastword = $" and {words[words.Length - 1]}";
                for (int i = 0; i < words.Length-1; i++)
                {
                    saluto = $"{saluto} , {words[i]}";
                }
                saluto = saluto + lastword;
                Console.WriteLine(saluto);
            }
            base.Greet(name);
        }
    }
}
