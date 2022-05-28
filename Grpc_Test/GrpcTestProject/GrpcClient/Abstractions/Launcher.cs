using GrpcClient.Enums;
using System;
using System.Threading.Tasks;

namespace GrpcClient.Abstractions {
  public abstract class Launcher {
    public async Task LaunchAsync() {
      try {
        Console.WriteLine("Choose client strategy:");
        PrintClientStrategyTypes();

        var clientStrategyType = EnterClientStrategyType();
        var clientStrategy = GetClientStrategy(clientStrategyType);

        await clientStrategy.CallClientAsync();
      }
      catch (Exception ex) {
        Console.WriteLine($"An exception occurred: {ex.Message}");
      }
    }

    private void PrintClientStrategyTypes() {
      foreach (var type in Enum.GetValues<ClientStrategyType>()) {
        Console.WriteLine($"{(int)type} - {type}");
      }
    }

    private ClientStrategyType EnterClientStrategyType() {
      if (int.TryParse(Console.ReadLine(), out var clientStrategyType)) {
        return (ClientStrategyType)clientStrategyType;
      }

      return ClientStrategyType.None;
    }

    protected abstract ClientStrategy GetClientStrategy(ClientStrategyType clientStrategyType);
  }
}
