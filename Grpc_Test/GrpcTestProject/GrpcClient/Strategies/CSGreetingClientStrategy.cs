using Greeting;
using Grpc.Core;
using GrpcClient.Abstractions;
using GrpcClient.Handlers;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcClient.Strategies {
  public class CSGreetingClientStrategy : ClientStrategy {
    public override async Task CallClientAsync() {
      await using var channelHandler = await ChannelHandler.GetChannelHandlerAsync();
      var client = new GreetingService.GreetingServiceClient(channelHandler.Channel);

      var stream = client.LongGreet();

      await WriteRequestAsync(stream.RequestStream);
      PrintResponse(await stream.ResponseAsync);
    }

    private async Task WriteRequestAsync(IClientStreamWriter<LongGreetRequest> requestStreamWriter) {
      var request = new LongGreetRequest {
        Greeting = new Greeting.Greeting {
          FirstName = "Dima",
          LastName = "Palamarchuk"
        }
      };

      foreach (int _ in Enumerable.Range(1, 10)) {
        await requestStreamWriter.WriteAsync(request);
      }

      await requestStreamWriter.CompleteAsync();
    }

    private void PrintResponse(LongGreetResponse response) {
      Console.WriteLine($"Server responded: {response.Result}");
    }
  }
}
