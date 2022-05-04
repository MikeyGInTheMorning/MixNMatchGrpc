using ProtoBuf;
using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Threading.Tasks;

namespace CodeFirstLib
{
    [ServiceContract]
    public interface Greeter
    {
        [OperationContract]
        Task<HelloReply> SayHelloAsync(HelloRequest req);
    }

    [ProtoContract]
    public class HelloRequest
    {
        [ProtoMember(1)]
        public string Name { get; set; }
    }

    [ProtoContract]
    public class HelloReply
    {
        [ProtoMember(1)]
        public string Message { get; set; }
    }
}
