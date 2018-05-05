using System;
using System.Collections.Generic;
using System.Linq;

namespace File_Destruture_sanwix.MessUps
{
    public class FileNames
    {
        private string GenerateName(int length)
        {
            Random rnd = new Random();
            string characters ="ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789-_";
            return new string(Enumerable.Repeat(characters.ToArray(), length)
            .Select(s => s[rnd.Next(length)]).ToArray());
        }
        public List<string> Generate()
        {
            string uniqe = Guid.NewGuid().ToString("n");
            
            return new List<string>();
        }

        
    }
}