using Grpc.Core;
using GrpcClient.Abstractions;
using GrpcClient.Handlers;
using Sqrt;
using System;
using System.Threading.Tasks;

namespace GrpcClient.Strategies {
  public class URSqrtClientStrategy : ClientStrategy {
    public override async Task CallClientAsync() {
      await using var channelHandler = await ChannelHandler.GetChannelHandlerAsync();
      var client = new SqrtService.SqrtServiceClient(channelHandler.Channel);

      try {
        var callRequest = new SqrtRequest {
          //Number = 16
          Number = -1
        };
        var callResponse = await client.GetSqrtAsync(callRequest);
        PrintResponse(callResponse);
      }
      catch (RpcException re) {
        PrintRpcError(re);
      }
    }

    private void PrintResponse(SqrtResponse response) {
      Console.WriteLine($"Server responded: {response.SquareRoot}");
    }

    private void PrintRpcError(RpcException exception) {
      Console.WriteLine($"Server returned error: {exception.Status.Detail}");
    }
  }
}
