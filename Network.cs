using System;
using System.Threading;
using System.Threading.Tasks;
namespace LearningDotNet
{
    class Network
    {
        public Network()
        {

        }
        static public Task Download(String fn)
        {
            return Task.Run(() => {
                Console.Write("Downloading {0}....", fn);
                Thread.Sleep(3000);
                Console.WriteLine("Download complete");
            }
            );
        }
    }
}

