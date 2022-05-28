using Calculator;
using Grpc.Core;
using GrpcClient.Abstractions;
using GrpcClient.Handlers;
using System;
using System.Threading.Tasks;

namespace GrpcClient.Strategies {
  public class SSCalculatorClientStrategy : ClientStrategy {
    public override async Task CallClientAsync() {
      await using var channelHandler = await ChannelHandler.GetChannelHandlerAsync();
      var client = new CalculatorService.CalculatorServiceClient(channelHandler.Channel);

      var callRequest = new DecompositionRequest {
        PrimeNumber = 120
      };
      var callResponse = client.CalculateDecomposition(callRequest);
      await PrintResponseAsync(callResponse.ResponseStream);
    }

    private async Task PrintResponseAsync(IAsyncStreamReader<DecompositionResponse> responseStream) {
      while (await responseStream.MoveNext()) {
        Console.WriteLine($"Server responded: {responseStream.Current.Divider}");
        await Task.Delay(200);
      }
    }
  }
}
