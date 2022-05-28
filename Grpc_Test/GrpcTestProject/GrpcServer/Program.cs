using GrpcServer.Handlers;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcServer {
  public static class Program {
    private static async Task Main() {
      try {
        await using var serverHandler = ServerHandler.GetDefaultServerHandler();
        var serverPort = serverHandler.Server.Ports.FirstOrDefault();
        Console.WriteLine($"The server is launched on the port: {serverPort.Port}");
        Console.ReadKey();
      }
      catch (IOException ioe) {
        Console.WriteLine($"The server failed to launch: {ioe.Message}");
      }
      catch (Exception ex) {
        Console.WriteLine($"An exception occurred: {ex.Message}");
      }
    }
  }
}
