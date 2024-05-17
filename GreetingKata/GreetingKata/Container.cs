using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingKata
{
    internal static class Container
    {
        public static IHost CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder().ConfigureServices(services => {
                //services.AddSingleton<Test>();
                //services.AddSingleton<Exam>();
                services.AddSingleton<Approver>((s ) =>
                {
                    var nome1 = new Name();
                    var nome2 = new EmptyName();
                    var nome3 = new UpperGreet();
                    var nome4 = new Names();
                    var nome5 = new NamesAnd();
                    var nome6 = new MixedName();

                    nome1.SetSuccessor(nome2)
                         .SetSuccessor(nome3)
                         .SetSuccessor(nome4)
                         .SetSuccessor(nome5)
                         .SetSuccessor(nome6);

                    return nome1;

                });

            }).Build();
        }


    }
}


public class Test
{
    public Exam _exam; 
    public Test(Exam exam)
    {
        this._exam = exam;
     }
    public void DoWork()
    {
        _exam.DoExam();
       
    }
}

public class Exam
{
    public void DoExam()
    {
        Console.WriteLine("Do my Exam");
    }
}

