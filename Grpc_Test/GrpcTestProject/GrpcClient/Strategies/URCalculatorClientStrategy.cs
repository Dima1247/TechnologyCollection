using Calculator;
using GrpcClient.Abstractions;
using GrpcClient.Handlers;
using System;
using System.Threading.Tasks;

namespace GrpcClient.Strategies {
  public class URCalculatorClientStrategy : ClientStrategy {
    public override async Task CallClientAsync() {
      await using var channelHandler = await ChannelHandler.GetChannelHandlerAsync();
      var client = new CalculatorService.CalculatorServiceClient(channelHandler.Channel);

      var callRequest = new SumRequest {
        FirstNumber = 1,
        SecondNumber = 2
      };
      var callResponse = await client.CalculateSumAsync(callRequest);
      PrintResponse(callResponse);
    }

    private void PrintResponse(SumResponse response) {
      Console.WriteLine($"Server responded: {response.Sum}");
    }
  }
}
