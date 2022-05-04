using CodeFirstLib;
using ProtoBuf.Grpc;
using System.Threading.Tasks;

namespace CodeFristServer
{
    public class GreeterService : IGreeter
    {
        public ValueTask<HelloReply> SayHelloAsync(HelloRequest value, CallContext context = default)
        {
            return ValueTask.FromResult<HelloReply>(new() { Message = "Hello from Code First" });
        }
    }
}
