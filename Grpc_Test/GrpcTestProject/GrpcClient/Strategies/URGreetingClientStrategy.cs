using Greeting;
using GrpcClient.Abstractions;
using GrpcClient.Handlers;
using System;
using System.Threading.Tasks;

namespace GrpcClient.Strategies {
  public class URGreetingClientStrategy : ClientStrategy {
    public override async Task CallClientAsync() {
      await using var channelHandler = await ChannelHandler.GetChannelHandlerAsync();
      var client = new GreetingService.GreetingServiceClient(channelHandler.Channel);

      var callRequest = new GreetingRequest {
        Greeting = new Greeting.Greeting {
          FirstName = "Dima",
          LastName = "Palamarchuk"
        }
      };
      var callResponse = await client.GreetAsync(callRequest);
      PrintResponse(callResponse);
    }

    private void PrintResponse(GreetingResponse response) {
      Console.WriteLine($"Server responded: {response.Result}");
    }
  }
}
