using Grpc.Core;
using System.Threading.Tasks;

namespace GrpcClient.Abstractions {
  public abstract class ClientStrategy {
    public abstract Task CallClientAsync();
  }
}
