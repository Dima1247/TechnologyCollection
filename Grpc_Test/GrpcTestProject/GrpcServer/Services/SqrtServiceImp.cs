using Grpc.Core;
using Sqrt;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcServer.Services {
  public class SqrtServiceImp : SqrtService.SqrtServiceBase {
    public override Task<SqrtResponse> GetSqrt(SqrtRequest request, ServerCallContext context) {
      var number = request.Number;
      if (number >= 0) {
        var response = new SqrtResponse {
          SquareRoot = Math.Sqrt(number)
        };

        return Task.FromResult(response);
      }
      else {
        throw new RpcException(new Status(StatusCode.InvalidArgument, "number < 0"));
      }
    }

    public override async Task GetSqrtManyTimes(SqrtManyTimesRequest request, IServerStreamWriter<SqrtManyTimesResponse> responseStream, ServerCallContext context) {
      await Task.Delay(200);

      var number = request.Number;
      var response = new SqrtManyTimesResponse {
        SquareRoot = Math.Sqrt(number)
      };

      foreach (var _ in Enumerable.Range(1, 4)) {
        await responseStream.WriteAsync(response);
      }
    }
  }
}
