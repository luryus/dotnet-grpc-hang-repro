using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace GrpcHang
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Start a dummy test server
            var server = new Server
            {
                Ports = { new ServerPort("0.0.0.0", 10000, ServerCredentials.Insecure) }
            };
            server.Start();

            Console.Write("Testing ({0})...", DateTimeOffset.UtcNow);
            
            StartGcThread();

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
    }
}
