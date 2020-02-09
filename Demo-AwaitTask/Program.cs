using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using ConsoleDump;

namespace Demo_AwaitTask
{
    class Program
    {
        static async Task Main(string[] args)
        {
            
            Console.WriteLine($"Main  {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine(DateTime.Now);
            TplExample tpl = new TplExample();
            Console.WriteLine("Start Cooking !!!");

            var makecoffee =  tpl.MakeCoffee();
            Console.WriteLine("making coffee......");

            var grilledtoast =  tpl.GrilledToast();
            Console.WriteLine("grilling toast......");

            var fryegg = await tpl.FryEgg();
            Console.WriteLine(fryegg);
            Console.WriteLine("frying egg......");

            var frysteak = tpl.FrySteak();
            Console.WriteLine("frying steak......");
            await frysteak;
            await grilledtoast;
            Console.WriteLine("return  grilledtoast ");

            await makecoffee;

            Console.WriteLine("Completed !!!");
            Console.WriteLine(DateTime.Now);
            Console.ReadLine();
        }

    }
}
