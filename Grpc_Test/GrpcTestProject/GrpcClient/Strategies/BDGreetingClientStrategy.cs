using Greeting;
using Grpc.Core;
using GrpcClient.Abstractions;
using GrpcClient.Handlers;
using System;
using System.Threading.Tasks;

namespace GrpcClient.Strategies {
  public class BDGreetingClientStrategy : ClientStrategy {
    public override async Task CallClientAsync() {
      await using var channelHandler = await ChannelHandler.GetChannelHandlerAsync();
      var client = new GreetingService.GreetingServiceClient(channelHandler.Channel);

      var stream = client.GreetEveryone();

      await WriteRequestAsync(stream.RequestStream);
      await PrintResponseAsync(stream.ResponseStream);
    }

    private async Task WriteRequestAsync(IClientStreamWriter<GreetEveryoneRequest> requestStreamWriter) {
      foreach (var greeting in GenerateGreetings()) {
        var request = new GreetEveryoneRequest {
          Greeting = greeting
        };

        await requestStreamWriter.WriteAsync(request);
      }

      await requestStreamWriter.CompleteAsync();
    }

    private async Task PrintResponseAsync(IAsyncStreamReader<GreetEveryoneResponse> responseStreamReader) {
      while (await responseStreamReader.MoveNext()) {
        Console.WriteLine($"Received from service: {responseStreamReader.Current.Result} ({DateTime.Now.Second}.{DateTime.Now.Millisecond})");
      }
    }

    private Greeting.Greeting[] GenerateGreetings() {
      return new Greeting.Greeting[] {
        new Greeting.Greeting {
          FirstName = "Dima",
          LastName = "Palamarchuk"
        },
        new Greeting.Greeting {
          FirstName = "John",
          LastName = "Smith"
        },
        new Greeting.Greeting{
          FirstName = "Beth",
          LastName = "Clarcson"
        },
        new Greeting.Greeting {
          FirstName = "Josh",
          LastName = "Brandson"
        },
        new Greeting.Greeting{
          FirstName = "Ketty",
          LastName = "Fisher"
        }
      };
    }
  }
}
