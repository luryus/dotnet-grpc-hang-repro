using System;
using System.Threading;
using System.Threading.Tasks;

namespace GrpcHang
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.Write("Testing ({0})...", DateTimeOffset.UtcNow);
            
            StartGcThread();
            //StartMemPressureThread();

            var caller = new RpcCaller();
            await caller.MakeCalls();
            
            Console.WriteLine("No freeze");
            System.Environment.Exit(1);
        }

        static void StartGcThread()
        {
            new Thread(() =>
            {
                while (true)
                {
                    System.GC.Collect(2);
                    Thread.Sleep(2);
                }
            }).Start();
        }

        static void StartMemPressureThread()
        {
            new Thread(() =>
            {
                while (true)
                {
                    var b = new byte[1000];
                    Thread.Sleep(2);
                }
            }).Start();
        }
    }
}
