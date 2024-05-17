using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GreetingKata
{
    public class MixedName : Approver
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

            string[] words = name.Split(' ');
            if (words.Length > 2)
            {
                string grande = string.Empty;

                List<string> nomii = new List<string>();

                for (int i = 0; i < words.Length; i++)
                {
                    if (IsAllUpper(words[i]))
                    {
                        grande = words[i];
                    }
                    else
                    {
                        nomii.Add(words[i]);
                    }
                }

                string[] nomi2 = nomii.ToArray();

                string saluto = "Hello";
                string lastword = $" and {nomi2[nomi2.Length-1]}. ";
                for (int i = 0; i < nomi2.Length-1; i++)
                {
                    saluto = $"{saluto} , {nomi2[i]}";
                }
                saluto = saluto + lastword;
                Console.Write(saluto);
                Console.WriteLine($"AND HELLO {grande}!");
                

                
               base.Greet(name);
            }
        }


    }
}
