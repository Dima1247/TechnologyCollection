using Grpc.Core;
using System;
using System.Threading.Tasks;

namespace GrpcClient.Handlers {
  public class ChannelHandler : IAsyncDisposable {
    #region Private constants and variables

    private const int DEFAULT_CHANNEL_PORT = 50051;
    private const string DEFAULT_CHANNEL_HOST = "localhost";
    private readonly static ChannelCredentials DEFAULT_CHANNEL_CREDENTIALS = ChannelCredentials.Insecure;

    private Channel _channel;

    #endregion

    #region Constructors

    private ChannelHandler(Channel channel) {
      _channel = channel;
    }

    #endregion

    #region Public properties

    public Channel Channel => _channel;

    #endregion

    #region Static factory methods

    public static Task<ChannelHandler> GetChannelHandlerAsync() {
      return GetChannelHandlerAsync(DEFAULT_CHANNEL_HOST, DEFAULT_CHANNEL_PORT, DEFAULT_CHANNEL_CREDENTIALS);
    }

    public static async Task<ChannelHandler> GetChannelHandlerAsync(string host, int port, ChannelCredentials credentials) {
      var channel = new Channel(host, port, credentials);
      await channel.ConnectAsync();

      return new ChannelHandler(channel);
    }

    #endregion

    #region Dispose logic

    public async ValueTask DisposeAsync() {
      await DisposeAsyncCore();
      GC.SuppressFinalize(this);
    }

    protected virtual async ValueTask DisposeAsyncCore() {
      if (_channel != null) {
        await ShutdownChannelAsync();
      }

      _channel = null;
    }

    private Task ShutdownChannelAsync() {
      if (_channel.State == ChannelState.Shutdown) {
        return Task.CompletedTask;
      }

      return _channel.ShutdownAsync();
    }

    #endregion
  }
}
