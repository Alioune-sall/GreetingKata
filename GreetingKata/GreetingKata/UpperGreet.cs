using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingKata
{
    internal class UpperGreet : Approver
    {
        public string name;

        public bool IsAllUpper(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsLetter(input[i]) && !Char.IsUpper(input[i]))
                    return false;
            }
            return true;
        }

        public override void Greet(string name)
        {
            if (IsAllUpper(name))
            {
                Console.WriteLine("HELLO, " + name.ToUpper());
                base.Greet(name);
            }
            else
            {
                base.Greet(name);
            }
        }
    }
}
