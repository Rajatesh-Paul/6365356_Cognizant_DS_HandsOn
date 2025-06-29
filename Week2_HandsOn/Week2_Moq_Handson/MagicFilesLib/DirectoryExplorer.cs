using System.Collections.Generic;
using System.IO;

public interface IDirectoryExplorer
{
    ICollection<string> GetFiles(string path);
}

namespace MagicFilesLib
{
    public class DirectoryExplorer : IDirectoryExplorer
    {
        public ICollection<string> GetFiles(string path)
        {
            string[] files = Directory.GetFiles(path);
            return files;
        }
    }
}

