using Calculator;
using Grpc.Core;
using System;
using System.Threading.Tasks;

namespace GrpcServer.Services {
  public class CalculatorServiceImp : CalculatorService.CalculatorServiceBase {
    #region CalculateSum

    public override Task<SumResponse> CalculateSum(SumRequest request, ServerCallContext context) {
      return CalculateSumAsync(request.FirstNumber, request.SecondNumber);
    }

    private Task<SumResponse> CalculateSumAsync(int firstNumber, int secondNumber) {
      var sum = firstNumber + secondNumber;
      var response = new SumResponse {
        Sum = sum
      };

      return Task.FromResult(response);
    }

    #endregion

    #region CalculateDecomposition

    private IServerStreamWriter<DecompositionResponse> _decompositionResponseStream;

    public override Task CalculateDecomposition(DecompositionRequest request, IServerStreamWriter<DecompositionResponse> responseStream, ServerCallContext context) {
      _decompositionResponseStream = responseStream;

      return CalculateDecompositionAsync(request.PrimeNumber);
    }

    private async Task CalculateDecompositionAsync(int number) {
      var divider = 2;

      while (number > 1) {
        if (number % divider == 0) {
          await WriteDividerToStreamAsync(divider);
          number /= divider;
        }
        else {
          divider++;
        }
      }
    }

    private Task WriteDividerToStreamAsync(int divider) {
      var result = new DecompositionResponse {
        Divider = divider
      };

      return _decompositionResponseStream.WriteAsync(result);
    }

    #endregion

    #region CalculateAverage

    private IAsyncStreamReader<AverageRequest> _averageRequestStream;

    public override Task<AverageResponse> CalculateAverage(IAsyncStreamReader<AverageRequest> requestStream, ServerCallContext context) {
      _averageRequestStream = requestStream;

      return CalculateAverageAsync();
    }

    private async Task<AverageResponse> CalculateAverageAsync() {
      var sum = 0f;
      var count = 0;

      while (await _averageRequestStream.MoveNext()) {
        var number = _averageRequestStream.Current.Number;

        sum += number;
        count++;

        await WriteTextWithDelayAsync($"Received: {number}");
      }

      var averageNumber = sum / count;

      return new AverageResponse {
        AverageNumber = averageNumber
      };
    }

    #endregion

    #region ClaculateMaximum

    private IAsyncStreamReader<MaximumRequest> _maximumRequestStream;
    private IServerStreamWriter<MaximumResponse> _maximumResponseStream;

    public override Task CalculateMaximumm(IAsyncStreamReader<MaximumRequest> requestStream, IServerStreamWriter<MaximumResponse> responseStream, ServerCallContext context) {
      _maximumRequestStream = requestStream;
      _maximumResponseStream = responseStream;

      return CalculateMaximumAsync();
    }

    private async Task CalculateMaximumAsync() {
      var maximum = int.MinValue;

      while (await _maximumRequestStream.MoveNext()) {
        var number = _maximumRequestStream.Current.Number;
        await WriteTextWithDelayAsync($"Client requested: {number}");

        if (maximum >= number) {
          continue;
        }

        maximum = number;
        var response = new MaximumResponse {
          MaxNumber = maximum
        };

        await _maximumResponseStream.WriteAsync(response);
      }
    }

    #endregion

    #region Helpers

    private Task WriteTextWithDelayAsync(string text) {
      Console.WriteLine(text);
      return Task.Delay(1500);
    }

    #endregion
  }
}
