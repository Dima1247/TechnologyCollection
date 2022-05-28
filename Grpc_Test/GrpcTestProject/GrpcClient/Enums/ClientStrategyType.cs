namespace GrpcClient.Enums {
  public enum ClientStrategyType {
    None = 0,
    UnaryRequest = 1,
    ServerStreaming = 2,
    ClientStreaming = 3,
    BiDirectionalStreaming = 4
  }
}
