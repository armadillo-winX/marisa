namespace marisa
{
    internal class PathInfo
    {
        public static string? AppPath => Environment.ProcessPath;

        public static string? AppLocation => Path.GetDirectoryName(AppPath);

        public static string? ReplayFilesDirectory => $"{AppLocation}\\replay";

        public static string? PathConfigFile => $"{AppLocation}\\settings\\PathConfig.xml";

        public static string ShanghaiAliceAppData => $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\ShanghaiAlice";
    }
}
