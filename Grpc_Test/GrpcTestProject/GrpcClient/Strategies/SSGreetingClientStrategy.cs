using Greeting;
using Grpc.Core;
using GrpcClient.Abstractions;
using GrpcClient.Handlers;
using System;
using System.Threading.Tasks;

namespace GrpcClient.Strategies {
  public class SSGreetingClientStrategy : ClientStrategy {
    public override async Task CallClientAsync() {
      await using var channelHandler = await ChannelHandler.GetChannelHandlerAsync();
      var client = new GreetingService.GreetingServiceClient(channelHandler.Channel);

      var callRequest = new GreetManyTimesRequest {
        Greeting = new Greeting.Greeting {
          FirstName = "Dima",
          LastName = "Palamarchuk"
        }
      };
      var callResponse = client.GreetManyTimes(callRequest);
      await PrintResponseAsync(callResponse.ResponseStream);
    }

    private async Task PrintResponseAsync(IAsyncStreamReader<GreetManyTimesResponse> responseStream) {
      while (await responseStream.MoveNext()) {
        Console.WriteLine($"Server responded: {responseStream.Current.Result}");
        await Task.Delay(200);
      }
    }
  }
}
