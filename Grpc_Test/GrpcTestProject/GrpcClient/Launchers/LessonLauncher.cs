using GrpcClient.Abstractions;
using GrpcClient.Enums;
using GrpcClient.Strategies;

namespace GrpcClient.Launchers {
  public class LessonLauncher : Launcher {
    protected override ClientStrategy GetClientStrategy(ClientStrategyType clientStrategyType) => clientStrategyType switch {
      ClientStrategyType.UnaryRequest => new URGreetingClientStrategy(),
      ClientStrategyType.ServerStreaming => new SSGreetingClientStrategy(),
      ClientStrategyType.ClientStreaming => new CSGreetingClientStrategy(),
      ClientStrategyType.BiDirectionalStreaming => new BDGreetingClientStrategy(),
      _ => new EmptyClientStrategy()
    };
  }
}
