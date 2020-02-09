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
            ////Console.WriteLine($"Main  {Thread.CurrentThread.ManagedThreadId}");
            ////Task.Run(() => Task1());
            ////Console.WriteLine($"Main  {Thread.CurrentThread.ManagedThreadId}");
            ////Console.WriteLine("Task22");
            //Console.WriteLine($"Main  {Thread.CurrentThread.ManagedThreadId}");
            //Console.WriteLine(DateTime.Now);
            //TplExample tpl = new TplExample();
            //Console.WriteLine("Completed start");
            //var rep2 =  tpl.getClient("https://data.taipei/opendata/datalist/apiAccess?scope=resourceAquire&rid=1f1aaba5-616a-4a33-867d-878142cac5c4");

            //Console.WriteLine(tpl.gogo());
            //Console.WriteLine($"Main  {Thread.CurrentThread.ManagedThreadId}");
            ////tpl.Task1();
            ////var task2 = tpl.Task2();
            //Console.WriteLine("Completed task");
            //Console.WriteLine($"Main  {Thread.CurrentThread.ManagedThreadId}");
            ////await task2;
            ////var rep = await tpl.getClient("https://data.taipei/opendata/datalist/apiAccess?scope=resourceAquire&rid=190796c8-7c56-42e0-8068-39242b8ec927");

            ////Console.WriteLine(rep.Dump<String>());
            ////Console.WriteLine($"Main  {Thread.CurrentThread.ManagedThreadId}");
            ////await task2;
            
            Console.WriteLine($"Main  {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine(DateTime.Now);
            TplExample tpl = new TplExample();
            Console.WriteLine("Start Cooking !!!");

            var makecoffee = await tpl.MakeCoffee();
            Console.WriteLine("making coffee......");

            var grilledtoast =  tpl.GrilledToast();
            Console.WriteLine("grilling toast......");

            

            var fryegg = tpl.FryEgg();
            Console.WriteLine("frying egg......");

            var frysteak = tpl.FrySteak();
            Console.WriteLine("frying steak......");
            await frysteak;
            await grilledtoast;
            Console.WriteLine("return  grilledtoast ");
            int result = await fryegg;
            Console.WriteLine(result);
            
            
            //await makecoffee;

            Console.WriteLine("Completed !!!");
            Console.WriteLine(DateTime.Now);
            Console.ReadLine();
        }

        //static async void Task1()
        //{
        //    TplExample tpl = new TplExample();
        //    var task1 = tpl.Task1();
        //    var task2 = tpl.Task2();
        //    Console.WriteLine("Completed task");
        //    await task2;
        //    await task1;

        //    Task.Delay(1000).Wait();
        //    Console.WriteLine("Task11");
        //}

    }
}
