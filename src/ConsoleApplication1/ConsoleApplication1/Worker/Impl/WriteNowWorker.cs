using ConsoleApplication1.Worker;
using System;

namespace ConsoleApplication1.Worker.Impl
{
    public class WriteNowWorker : IWorker
    {
        public void Work()
        {
            Console.WriteLine(DateTime.Now);
        }
    }
}
