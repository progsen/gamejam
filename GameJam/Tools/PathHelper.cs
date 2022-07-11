using System.IO;

namespace GameJam.Tools
{
    public static class PathHelper
    {
        public static string ExeDir()
        {
            return new FileInfo(typeof(PathHelper).Assembly.Location).DirectoryName;
        }
    }
}



