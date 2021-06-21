using System;
using System.IO;


namespace _3._1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            DirSearch(@"C:\Users\ilyas\Desktop\C#\3.1.3");
            Console.ReadKey();
        }

        static void DirSearch(string dir)
        {
            try
            {
                foreach (string f in Directory.GetFiles(dir))
                    Console.WriteLine(f);
                foreach (string d in Directory.GetDirectories(dir))
                {
                    Console.WriteLine(d);
                    DirSearch(d);
                }

            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

