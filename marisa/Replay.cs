using System.Xml;

namespace marisa
{
    internal class Replay
    {
        public static string? Th06 { get; set; }

        public static string? Th07 { get; set; }

        public static string? Th08 { get; set; }

        public static string? Th09 { get; set; }

        public static string? Th10 { get; set; }

        public static string? Th11 { get; set; }

        public static string? Th12 { get; set; }

        private static readonly string? _pathConfigFile = PathInfo.PathConfigFile;

        public static string Import(string replayFile)
        {
            string gameId = GetGameId(replayFile);
            string? replayDirectory = GetReplayDirectory(gameId);
            string replayName = Path.GetFileNameWithoutExtension(replayFile);
            if (Directory.Exists(replayDirectory))
            {
                try
                {
                    string newReplayFile = $"{replayDirectory}\\{replayName}.rpy";
                    int i = 0;
                    while (File.Exists(newReplayFile))
                    {
                        i++;
                        newReplayFile = $"{replayDirectory}\\{replayName}-{i}.rpy";
                    }

                    File.Move(replayFile, newReplayFile);
                    return $"成功:{newReplayFile}";
                }
                catch (Exception ex)
                {
                    return $"エラー:{ex.Message}";
                }
            }
            else
            {
                return $"インポート先ディレクトリが存在しませんでした。Game:{gameId}";
            }
        }

        public static string GetGameId(string replayFile)
        {
            string replayName = Path.GetFileNameWithoutExtension(replayFile);
            return replayName.Split('_')[0];
        }

        public static void ConstitutePathConfigure()
        {
            XmlDocument xmlDocument = new();
            if (!string.IsNullOrEmpty(_pathConfigFile))
            {
                xmlDocument.Load(_pathConfigFile);
                Th06 = xmlDocument.SelectSingleNode("//th6").InnerText;
                Th07 = xmlDocument.SelectSingleNode("//th7").InnerText;
                Th08 = xmlDocument.SelectSingleNode("//th8").InnerText;
                Th09 = xmlDocument.SelectSingleNode("//th9").InnerText;
                Th10 = xmlDocument.SelectSingleNode("//th10").InnerText;
                Th11 = xmlDocument.SelectSingleNode("//th11").InnerText;
                Th12 = xmlDocument.SelectSingleNode("//th12").InnerText;
            }
        }

        public static string? GetReplayDirectory(string gameId)
        {
            if (gameId == "th6")
            {
                return Th06;
            }
            else if (gameId == "th7")
            {
                return Th07;
            }
            else if (gameId == "th8")
            {
                return Th08;
            }
            else if (gameId == "th9")
            {
                return Th09;
            }
            else if (gameId == "th10")
            {
                return Th10;
            }
            else if (gameId == "th11")
            {
                return Th11;
            }
            else if (gameId == "th12")
            {
                return Th12;
            }
            else
            {
                return $"{PathInfo.ShanghaiAliceAppData}\\{gameId}\\replay";
            }
        }
    }
}
