using GrpcClient.Abstractions;
using GrpcClient.Enums;
using GrpcClient.Strategies;

namespace GrpcClient.Launchers {
  public class PracticeLauncher : Launcher {
    protected override ClientStrategy GetClientStrategy(ClientStrategyType clientStrategyType) => clientStrategyType switch {
      ClientStrategyType.UnaryRequest => new URCalculatorClientStrategy(),
      ClientStrategyType.ServerStreaming => new SSCalculatorClientStrategy(),
      ClientStrategyType.ClientStreaming => new CSCalculatorClientStrategy(),
      ClientStrategyType.BiDirectionalStreaming => new BDCalculatorClientStrategy(),
      _ => new EmptyClientStrategy()
    };
  }
}
