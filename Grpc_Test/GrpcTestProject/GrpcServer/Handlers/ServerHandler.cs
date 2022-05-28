using Calculator;
using Greeting;
using Grpc.Core;
using Grpc.Reflection;
using Grpc.Reflection.V1Alpha;
using GrpcServer.Services;
using Sqrt;
using System;
using System.Threading.Tasks;

namespace GrpcServer.Handlers {
  public class ServerHandler : IAsyncDisposable {
    #region Private constants and variables

    private const int DEFAULT_SERVER_PORT = 50051;
    private const string DEFAULT_SERVER_HOST = "localhost";
    private readonly static ServerCredentials DEFAULT_SERVER_CREDENTIALS = ServerCredentials.Insecure;

    private Server _server;

    #endregion

    #region Constructors

    private ServerHandler(Server server) {
      _server = server;
    }

    #endregion

    #region Public properties

    public Server Server => _server;

    #endregion

    #region Static factory methods

    public static ServerHandler GetDefaultServerHandler() {
      var reflectionServiceImp = new ReflectionServiceImpl(GreetingService.Descriptor, ServerReflection.Descriptor);

      Action<Server.ServiceDefinitionCollection> configureDefaultServices = services => {
        services.Add(GreetingService.BindService(new GreetingServiceImp()));
        services.Add(ServerReflection.BindService(reflectionServiceImp));
        services.Add(CalculatorService.BindService(new CalculatorServiceImp()));
        services.Add(SqrtService.BindService(new SqrtServiceImp()));
      };

      Action<Server.ServerPortCollection> configureDefaultPorts = ports => {
        ports.Add(new ServerPort(DEFAULT_SERVER_HOST, DEFAULT_SERVER_PORT, DEFAULT_SERVER_CREDENTIALS));
      };

      return GetServerHandler(configureDefaultServices, configureDefaultPorts);
    }

    public static ServerHandler GetServerHandler(Action<Server.ServiceDefinitionCollection> configureServices, Action<Server.ServerPortCollection> configurePorts) {
      var server = new Server();
      configurePorts(server.Ports);
      configureServices(server.Services);
      server.Start();

      return new ServerHandler(server);
    }

    #endregion

    #region Dispose logic

    public async ValueTask DisposeAsync() {
      await DisposeAsyncCore();
      GC.SuppressFinalize(this);
    }

    protected virtual async ValueTask DisposeAsyncCore() {
      if (_server != null) {
        await ShutdownChannelAsync();
      }

      _server = null;
    }

    private Task ShutdownChannelAsync() {
      return _server.ShutdownAsync();
    }

    #endregion
  }
}
