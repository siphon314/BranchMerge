using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var worker = WorkerFactory.Create();

            while (true)
            {
                worker.Work();
                Thread.Sleep(1000);
            }
        }
    }

    public class WorkerFactory
    {
        public static IWorker Create()
        {
            return new WriteNowWorker();
        }
    }

    public interface IWorker
    {
        void Work();
    }

    public class WriteNowWorker : IWorker
    {
        public void Work()
        {
            Console.WriteLine(DateTime.Now);
        }
    }
}
