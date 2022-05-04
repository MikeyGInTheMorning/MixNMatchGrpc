using ProtoBuf;
using ProtoBuf.Grpc;
using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Threading.Tasks;

namespace CodeFirstLib
{
    [ProtoContract()]
    public partial class HelloRequest
    {
        [ProtoMember(1, Name = @"name")]
        public string Name { get; set; } = "";
    }

    [ProtoContract()]
    public partial class HelloReply
    {
        [ProtoMember(1, Name = @"message")]
        public string Message { get; set; } = "";

    }

    [ServiceContract(Name = @"greet.Greeter")]
    public partial interface IGreeter
    {
        Task<HelloReply> SayHelloAsync(HelloRequest value, CallContext context = default);
    }
}
