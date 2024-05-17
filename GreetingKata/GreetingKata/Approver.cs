using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingKata
{
    public abstract class Approver
    {
        protected Approver? Next;
        public Approver SetSuccessor(Approver next)
        {
            Next = next;
            return Next;
        }

        public virtual void Greet(string nome)
        {
            Next?.Greet(nome);
        }
    }
}
