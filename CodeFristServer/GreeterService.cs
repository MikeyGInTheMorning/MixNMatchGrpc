using CodeFirstLib;
using ProtoBuf.Grpc;
using System.Threading.Tasks;

namespace CodeFristServer
{
    public class GreeterService : IGreeter
    {
        public Task<HelloReply> SayHelloAsync(HelloRequest value, CallContext context = default)
        {
            return Task.FromResult<HelloReply>(new() { Message = "Hello from Code First" });
        }
    }
}
