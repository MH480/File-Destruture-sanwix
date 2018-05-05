namespace File_Destruture_sanwix.MessUps
{
    public abstract class Mess
    {
        protected string PathToFile { get; set; }
        public Mess(string pathToFile)
        {
            PathToFile = pathToFile;
        }

        public abstract void ChangeFile();
        
    }
}