using System;
using System.Threading;
using System.Threading.Tasks;
namespace LearningDotNet
{
    class Program
    {
        static void Main(string[] args)
        {

            Network.Download("PizzaImage");
            Network.Download("FoxImage");
            Console.ReadLine();
        }

       
    }
}
