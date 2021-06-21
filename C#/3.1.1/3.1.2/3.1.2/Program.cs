using System;
using System.IO;
using System.Threading.Tasks;

namespace _3._1._2
{
    class Program
    {
        static async Task Main(string[] args)
        {
            

  
            string path = @"C:\Users\ilyas\Desktop\C#\3.1.2\3.1.2\text.txt";

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }
                // асинхронное чтение
                using (StreamReader sr = new StreamReader(path))
                {
                    Console.WriteLine(await sr.ReadToEndAsync());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
