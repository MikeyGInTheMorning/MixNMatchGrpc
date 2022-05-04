using Grpc.Net.Client;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ProtosFirstClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CallProtosFirstServer().Wait();
        }

        private static async Task CallProtosFirstServer()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Greeter.GreeterClient(channel);

            var res = await client.SayHelloAsync(new() { Name = "From Protos First Client" });

            Console.WriteLine($"Hello - {res.Message}");
        }
    }
}
