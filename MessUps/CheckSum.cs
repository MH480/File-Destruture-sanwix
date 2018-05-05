using System.IO;

namespace File_Destruture_sanwix.MessUps
{
    public class CheckSum
    {
        public const string PATH0 = "(Charkraoen)", PATH1 = "Charkrado", PATH2 = "Charkraoenzeron", PATH3 = "Charkraoenozegh";
        public CheckSum()
        {

        }

        private bool IsDir(string path)
        {
            return string.IsNullOrEmpty(Path.GetExtension(path));
        }

        private bool DirExists(string path)
        {
            return IsDir(path) && !Directory.Exists(path);
        }
        public void checkDires(string pathToDir)
        {
            if (DirExists($"{pathToDir}/{PATH0}"))
            {
                Directory.CreateDirectory($"{pathToDir}/{PATH0}");
                Directory.CreateDirectory($"{pathToDir}/{PATH1}");
                Directory.CreateDirectory($"{pathToDir}/{PATH2}");
                Directory.CreateDirectory($"{pathToDir}/{PATH3}");
            }
        }

        public bool IsFileDeconstructed(string pathToFile)
        {
            return false;
        }

    }
}