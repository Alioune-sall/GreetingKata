using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingKata
{
    public  class Name : Approver
    {
        //public string name; 

        public override void Greet(string nome)
        {
            string[] words = nome.Split(' ');
            if (words.Length == 1)
            {
                Console.WriteLine("Hello, " + nome);
                
            }
          base.Greet(nome);
        }
    }
}
