namespace marisa
{
    public class Program
    {
        private static readonly string? _appName = VersionInfo.AppName;
        private static readonly string? _appVersion = VersionInfo.AppVersion;
        private static readonly string? _osVersion = VersionInfo.OSVersion;
        private static readonly string? _dotNetVersion = VersionInfo.DotNetVersion;
        private static readonly string? _pathConfigFile = PathInfo.PathConfigFile;
        private static readonly string? _replayDirectory = PathInfo.ReplayFilesDirectory;

        public static void Main(string[] args)
        {
            Console.Title = $"Marisa ver{_appVersion}";

            Console.WriteLine("Marisa");
            Console.WriteLine($"{_appName} ver{_appVersion}");
            Console.WriteLine(_osVersion);
            Console.WriteLine(_dotNetVersion);
            Console.WriteLine("\n\n");
            
            if (File.Exists(_pathConfigFile))
            {
                try
                {
                    Replay.ConstitutePathConfigure();
                }
                catch (Exception ex) 
                {
                    Console.WriteLine($"エラー\n{ex.Message}\nパス設定の構成に失敗しました。\n何かキーを押すと終了します。\n");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }

            if (!Directory.Exists(_replayDirectory))
            {
                try
                {
                    Directory.CreateDirectory(_replayDirectory);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"エラー\n{ex.Message}\nreplayディレクトリの生成に失敗しました。\n何かキーを押すと終了します。\n");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                Console.WriteLine("replayフォルダにreplayファイルを入れてください。\n何かキーを押すと続行します。\n");
                Console.ReadKey();
            }

            try
            {
                string[] replayFiles = Directory.GetFiles(_replayDirectory, "*.rpy", SearchOption.AllDirectories);
                while (replayFiles.Length == 0)
                {
                    Console.WriteLine("replayフォルダにreplayファイルを入れてください。\n何かキーを押すと続行します。\n");
                    Console.ReadKey();
                    replayFiles = Directory.GetFiles(_replayDirectory, "*.rpy", SearchOption.AllDirectories);
                }

                foreach (string replayFile in replayFiles)
                {
                    Console.WriteLine(replayFile);
                }
                Console.WriteLine("これらのreplayファイルがインポートされます。続行するには何かキーを押してください。\n");
                Console.ReadKey();

                foreach (string replayFile in replayFiles)
                {
                    string message = Replay.Import(replayFile);
                    Console.WriteLine(message);
                }
                Console.WriteLine("\nreplayのインポートがすべて完了しました。何かキーを押すと終了します。");
                Console.ReadKey();
                Environment.Exit(0);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"エラー\n{ex.Message}\n何かキーを押すと終了します。");
                Console.ReadKey();
            }
        }
    }
}