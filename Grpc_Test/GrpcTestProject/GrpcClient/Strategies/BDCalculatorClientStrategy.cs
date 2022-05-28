using Calculator;
using Grpc.Core;
using GrpcClient.Abstractions;
using GrpcClient.Handlers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GrpcClient.Strategies {
  public class BDCalculatorClientStrategy : ClientStrategy {
    public override async Task CallClientAsync() {
      await using var channelHandler = await ChannelHandler.GetChannelHandlerAsync();
      var client = new CalculatorService.CalculatorServiceClient(channelHandler.Channel);

      var stream = client.CalculateMaximumm();

      await WriteRequestAsync(stream.RequestStream);
      await PrintResponseAsync(stream.ResponseStream);
    }

    private async Task WriteRequestAsync(IClientStreamWriter<MaximumRequest> requestStreamWriter) {
      var numbers = new List<int> { 1, 5, 3, 6, 2, 20 };
      foreach (var number in numbers) {
        var request = new MaximumRequest {
          Number = number
        };

        await requestStreamWriter.WriteAsync(request);
      }

      await requestStreamWriter.CompleteAsync();
    }

    private async Task PrintResponseAsync(IAsyncStreamReader<MaximumResponse> responseStreamReader) {
      while (await responseStreamReader.MoveNext()) {
        Console.WriteLine($"Server responded: {responseStreamReader.Current.MaxNumber}");
      }
    }
  }
}
