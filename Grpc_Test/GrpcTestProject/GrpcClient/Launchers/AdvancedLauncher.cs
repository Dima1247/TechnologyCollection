using GrpcClient.Abstractions;
using GrpcClient.Enums;
using GrpcClient.Strategies;

namespace GrpcClient.Launchers {
  public class AdvancedLauncher : Launcher {
    protected override ClientStrategy GetClientStrategy(ClientStrategyType clientStrategyType) => clientStrategyType switch {
      ClientStrategyType.UnaryRequest => new URSqrtClientStrategy(), // Error handling
      ClientStrategyType.ServerStreaming => new SSSqrtClientStrategy(), // Deadline handling
      _ => new EmptyClientStrategy()
    };
  }
}
