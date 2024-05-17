using Microsoft.Extensions.DependencyInjection;
using System.Xml.Linq;
using Unity;
namespace GreetingKata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //{
            //    IUnityContainer container = new UnityContainer();
            //    container.RegisterType<Approver>();
            //    container.RegisterType<IGreet, Name>();
            //    container.RegisterType<IGreet, Names>();

            //    Approver obj = container.Resolve<Approver>();
            //    obj.Greet("Amy BRIAN Charlotte nbnbnb");


            var service = Container.CreateHostBuilder().Services;
            //var newTest = service.GetRequiredService<Test>();
            //newTest.DoWork();

            var newTest2 = service.GetRequiredService<Approver>();

            newTest2.Greet("Amy BRIAN Charlotte Ali");




            //var nome1 = new Name();
            //var nome2 = new EmptyName();
            //var nome3 = new UpperGreet();
            //var nome4 = new Names();
            //var nome5 = new NamesAnd();
            //var nome6 = new MixedName();

            //nome1.SetSuccessor(nome2)
            //.SetSuccessor(nome3)
            //.SetSuccessor(nome4)
            //.SetSuccessor(nome5)
            //.SetSuccessor(nome6);


            //nome1.Greet("Amy BRIAN Charlotte Ali");

            
        }
    }
}
