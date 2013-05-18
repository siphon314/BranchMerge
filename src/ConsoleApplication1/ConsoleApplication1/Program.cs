using ConsoleApplication1.Worker;
using ConsoleApplication1.Worker.Impl;
using System.Threading;

namespace ConsoleApplication1
{
    public class Program
    {
        public static IWorker Worker = new WriteNowWorker();

        public static void Main(string[] args)
        {
            while (true)
            {
                Worker.Work();
                Thread.Sleep(1000);
            }
        }
    }
}
