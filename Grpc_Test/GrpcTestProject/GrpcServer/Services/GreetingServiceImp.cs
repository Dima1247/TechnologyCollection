using Greeting;
using Grpc.Core;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Greeting.GreetingService;

namespace GrpcServer.Services {
  public class GreetingServiceImp : GreetingServiceBase {
    #region Greet

    public override Task<GreetingResponse> Greet(GreetingRequest request, ServerCallContext context) {
      return GreetAsync(request.Greeting.FirstName, request.Greeting.LastName);
    }

    private Task<GreetingResponse> GreetAsync(string firstName, string lastName) {
      var result = $"Hello {firstName} {lastName}";
      var response = new GreetingResponse {
        Result = result
      };

      return Task.FromResult(response);
    }

    #endregion

    #region GreetManyTimes

    private IServerStreamWriter<GreetManyTimesResponse> _greetResponseStream;

    public override Task GreetManyTimes(GreetManyTimesRequest request, IServerStreamWriter<GreetManyTimesResponse> responseStream, ServerCallContext context) {
      _greetResponseStream = responseStream;

      return GreetManyTimesAsync(request.Greeting.FirstName, request.Greeting.LastName);
    }

    private async Task GreetManyTimesAsync(string firstName, string lastName) {
      var result = $"Hello {firstName} {lastName}";
      var response = new GreetManyTimesResponse {
        Result = result
      };

      foreach (int _ in Enumerable.Range(1, 10)) {
        await _greetResponseStream.WriteAsync(response);
      }
    }

    #endregion

    #region LongGreet

    private IAsyncStreamReader<LongGreetRequest> _longGreetRequestStream;

    public override Task<LongGreetResponse> LongGreet(IAsyncStreamReader<LongGreetRequest> requestStream, ServerCallContext context) {
      _longGreetRequestStream = requestStream;

      return LongGreetAsync();
    }

    private async Task<LongGreetResponse> LongGreetAsync() {
      var result = new StringBuilder()
        .AppendLine("Response: ");

      while (await _longGreetRequestStream.MoveNext()) {
        var greeting = _longGreetRequestStream.Current.Greeting;
        var message = $"Hello {greeting.FirstName} {greeting.LastName}";

        result.AppendLine(message);
        await WriteTextWithDelayAsync($"Received: {greeting}");
      }

      return new LongGreetResponse {
        Result = result.ToString()
      };
    }

    #endregion

    #region GreetEveryone

    private IAsyncStreamReader<GreetEveryoneRequest> _greetEveryoneRequestStream;
    private IServerStreamWriter<GreetEveryoneResponse> _greetEveryoneResponseStream;

    public override Task GreetEveryone(IAsyncStreamReader<GreetEveryoneRequest> requestStream, IServerStreamWriter<GreetEveryoneResponse> responseStream, ServerCallContext context) {
      _greetEveryoneRequestStream = requestStream;
      _greetEveryoneResponseStream = responseStream;

      return GreetEveryoneAsync();
    }

    private async Task GreetEveryoneAsync() {
      while (await _greetEveryoneRequestStream.MoveNext()) {
        var greeting = _greetEveryoneRequestStream.Current.Greeting;
        var message = $"Hello {greeting.FirstName} {greeting.LastName}";
        var response = new GreetEveryoneResponse {
          Result = message
        };

        await WriteTextWithDelayAsync($"Received from client: {greeting} ({DateTime.Now.Second}.{DateTime.Now.Millisecond})");

        await _greetEveryoneResponseStream.WriteAsync(response);
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
