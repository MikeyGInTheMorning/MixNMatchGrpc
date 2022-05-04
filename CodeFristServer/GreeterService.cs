using CodeFirstLib;
using System.Threading.Tasks;

namespace CodeFristServer
{
    public class GreeterService : Greeter
    {
        public Task<HelloReply> SayHelloAsync(HelloRequest req)
        {
            return Task.FromResult<HelloReply>(new() { Message = "Hello from Code First" });
        }
    }
}
