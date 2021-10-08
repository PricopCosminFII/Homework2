using System;
using System.Collections.Generic;

namespace Persistance
{
    class FileExtractContent
    { public string Path { get; set; }
        public FileExtractContent(string Path)
        {
            this.Path = Path;
        }
        public List<List<string>> ImportData()
        {
            List<List<string>> data=new();
            string[] lines = System.IO.File.ReadAllLines(Path);
            for(int i=1;i<lines.Length;i++)
            {
                char[] separators = new char[] { ' ',  '*' };
                data.Add(new List<string>(lines[i].Split(separators, StringSplitOptions.RemoveEmptyEntries)));

            }
            return data;


        }

    }
}


