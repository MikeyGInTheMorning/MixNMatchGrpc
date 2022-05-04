using CodeFirstLib;
using Grpc.Net.Client;
using ProtoBuf.Grpc.Client;
using System;

namespace CodeFirstClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = channel.CreateGrpcService<IGreeter>();

            var reply = client.SayHelloAsync(new()).Result;

            Console.WriteLine($"Greeting: {reply.Message}");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
