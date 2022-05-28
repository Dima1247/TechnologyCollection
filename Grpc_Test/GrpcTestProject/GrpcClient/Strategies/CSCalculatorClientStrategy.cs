using Calculator;
using Grpc.Core;
using GrpcClient.Abstractions;
using GrpcClient.Handlers;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcClient.Strategies {
  public class CSCalculatorClientStrategy : ClientStrategy {
    public override async Task CallClientAsync() {
      await using var channelHandler = await ChannelHandler.GetChannelHandlerAsync();
      var client = new CalculatorService.CalculatorServiceClient(channelHandler.Channel);

      var callStream = client.CalculateAverage();

      await WriteRequestAsync(callStream.RequestStream);
      PrintResponse(await callStream.ResponseAsync);
    }

    private async Task WriteRequestAsync(IClientStreamWriter<AverageRequest> requestStreamWriter) {
      foreach (int i in Enumerable.Range(1, 4)) {
        var request = new AverageRequest {
          Number = i
        };

        await requestStreamWriter.WriteAsync(request);
        await Task.Delay(200);
      }

      await requestStreamWriter.CompleteAsync();
    }

    private void PrintResponse(AverageResponse response) {
      Console.WriteLine($"Server responded: {response.AverageNumber}");
    }
  }
}
