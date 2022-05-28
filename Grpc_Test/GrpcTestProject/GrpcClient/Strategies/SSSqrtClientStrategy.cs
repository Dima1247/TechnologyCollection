using Grpc.Core;
using GrpcClient.Abstractions;
using GrpcClient.Handlers;
using Sqrt;
using System;
using System.Threading.Tasks;

namespace GrpcClient.Strategies {
  public class SSSqrtClientStrategy : ClientStrategy {
    public override async Task CallClientAsync() {
      await using var channelHandler = await ChannelHandler.GetChannelHandlerAsync();
      var client = new SqrtService.SqrtServiceClient(channelHandler.Channel);

      try {
        var callRequest = new SqrtManyTimesRequest {
          Number = 16
        };
        var deadlineTime = DateTime.UtcNow.AddMilliseconds(500);

        var callResponse = client.GetSqrtManyTimes(callRequest, deadline: deadlineTime);
        await PrintResponseAsync(callResponse.ResponseStream);
      }
      catch (RpcException re) when (re.StatusCode == StatusCode.DeadlineExceeded) {
        PrintRpcError(re);
      }
    }

    private async Task PrintResponseAsync(IAsyncStreamReader<SqrtManyTimesResponse> responseStream) {
      while (await responseStream.MoveNext()) {
        Console.WriteLine($"Server responded: {responseStream.Current.SquareRoot}");
        await Task.Delay(200);
      }
    }

    private void PrintRpcError(RpcException exception) {
      Console.WriteLine($"Server returned error: {exception.Status.Detail}");
    }
  }
}
