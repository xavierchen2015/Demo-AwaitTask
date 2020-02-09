using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Http;
using System.IO;

namespace Demo_AwaitTask
{
    public class TplExample
    {
        public async void Task1()
        {
            Console.WriteLine($"Task1 : {Thread.CurrentThread.ManagedThreadId}");
            await Task.Delay(4000);
            Console.WriteLine($"Task1 : {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine("Task1");
        }

        public async Task Task2()
        {
            Console.WriteLine($"Task2 : {Thread.CurrentThread.ManagedThreadId}");
            await Task.Delay(2000);
            Console.WriteLine($"Task2 : {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine("Containue from Task1");
        }

        public string gogo()
        {
            return "gogo";
        }

        public async Task<String> getClient(string url)
        {
            await Task.Delay(10000);
            HttpClient _client = new HttpClient();
            
            HttpResponseMessage rep = await _client.GetAsync(url);
            rep.Content.Headers.ContentType.CharSet = "utf-8";
            string responseBody = await rep.Content.ReadAsStringAsync();
            var byteArray = rep.Content.ReadAsByteArrayAsync().Result;
            var result = Encoding.UTF8.GetString(byteArray, 0, byteArray.Length);
            Console.WriteLine(url);
            Console.WriteLine($"getClient : {Thread.CurrentThread.ManagedThreadId}");
            await Task.Delay(2000);
            using (StreamWriter sw = new StreamWriter("TestFile.TXT"))   //小寫TXT     
            {
                sw.Write(result);
            }
            return result;
        }

        public async Task<int> GrilledToast()
        {
            Console.WriteLine("=== Grilleding Toast ===");
            await Task.Delay(3000);
            Console.WriteLine($"MakeCoffee ManagedThreadId: {Thread.CurrentThread.ManagedThreadId}");

            Console.WriteLine("=== Grilleding Toast done ===");
            return 0;
        }

        public async Task<int> FryEgg()
        {
            Console.WriteLine("=== Frying Egg ===");
            await Task.Delay(2000);
            Console.WriteLine($"MakeCoffee ManagedThreadId: {Thread.CurrentThread.ManagedThreadId}");

            Console.WriteLine("=== Frying Egg done ===");
            return 0;
        }

        public async Task<int> MakeCoffee()
        {
            Console.WriteLine("=== Making Coffee ===");
            await Task.Delay(20000);
            Console.WriteLine($"MakeCoffee ManagedThreadId: {Thread.CurrentThread.ManagedThreadId}");

            Console.WriteLine("=== Making Coffee done ===");
            return 0;
        }
        public async Task<int> FrySteak()
        {
            Console.WriteLine("=== Frying Steak ===");
            await Task.Delay(8000);
            Console.WriteLine($"FrySteak ManagedThreadId: {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine("=== Frying Steak done ===");
            return 0;
        }
    }
}
