using System;
using System.IO;

namespace _3._1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i != 5)
            {
                string filename = @"C:\Users\ilyas\Desktop\C#\3.1.3\3.1.3\TEXT.txt";
                string tempfile = @"C:\Users\ilyas\Desktop\C#\3.1.3\3.1.3\tempTEXT.txt";

                using (StreamReader reader = new StreamReader(filename))
                {
                    using (StreamWriter writer = new StreamWriter(tempfile))
                    {
                        string line = reader.ReadLine();

                        while (!reader.EndOfStream)
                        {
                            writer.WriteLine(line);
                            line = reader.ReadLine();
                        }
                    }
                }
                File.Delete(filename);
                File.Move(tempfile, filename);
                i++;
            }
        }               
    }
}
    

