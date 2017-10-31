using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LearningDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Downloading file....");
            Download();
            Console.ReadLine();
        }

        private static void Download()
        {
            Task.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("Download complete");
            });
            
        }
    }
}
