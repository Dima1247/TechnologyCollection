using GrpcClient.Abstractions;
using System;
using System.Threading.Tasks;

namespace GrpcClient.Strategies {
  public class EmptyClientStrategy : ClientStrategy {
    public override Task CallClientAsync() {
      // Just log a call of the method
      PrintWarning();
      return Task.CompletedTask;
    }

    private void PrintWarning() {
      Console.WriteLine($"{nameof(EmptyClientStrategy)} call");
    }
  }
}
