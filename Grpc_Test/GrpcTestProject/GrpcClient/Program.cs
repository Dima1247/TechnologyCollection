using GrpcClient.Abstractions;
using GrpcClient.Enums;
using GrpcClient.Launchers;
using System;
using System.Threading.Tasks;

namespace GrpcClient {
  public static class Program {
    private static async Task Main() {
      while (true) {
        Console.WriteLine("Choose launcher:");
        PrintLauncherTypes();

        var launcherType = EnterLauncherType();
        var launcher = GetLauncher(launcherType);

        if (launcher.GetType() == typeof(EmptyLauncher)) {
          break;
        }

        await launcher.LaunchAsync();
      }
    }

    private static void PrintLauncherTypes() {
      foreach (var type in Enum.GetValues<LauncherType>()) {
        Console.WriteLine($"{(int)type} - {type}");
      }
    }

    private static LauncherType EnterLauncherType() {
      if (int.TryParse(Console.ReadLine(), out int launcherType)) {
        return (LauncherType)launcherType;
      }

      return LauncherType.None;
    }

    private static Launcher GetLauncher(LauncherType launcherType) => launcherType switch {
      LauncherType.Lesson => new LessonLauncher(),
      LauncherType.Advanced => new AdvancedLauncher(),
      LauncherType.Practice => new PracticeLauncher(),
      _ => new EmptyLauncher(),
    };
  }
}
