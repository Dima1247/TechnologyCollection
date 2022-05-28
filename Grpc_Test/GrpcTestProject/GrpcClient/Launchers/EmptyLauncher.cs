using GrpcClient.Abstractions;
using GrpcClient.Enums;
using GrpcClient.Strategies;
using System;

namespace GrpcClient.Launchers {
  public class EmptyLauncher : Launcher {
    protected override ClientStrategy GetClientStrategy(ClientStrategyType clientStrategyType) {
      // Just log a call of the method
      Console.WriteLine($"{nameof(EmptyLauncher)} call");
      return new EmptyClientStrategy();
    }
  }
}
