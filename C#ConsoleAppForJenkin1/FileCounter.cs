using System;
using System.IO;

namespace C_ConsoleAppForJenkin1
{
    public static class FileCounter
    {

        public static int CountFile()
        {
            //string []filename=Directory.GetFiles(@"N:\CICDExample\C#ConsoleAppForJenkin1\bin\FileLocation");
            string []filename ={"C#","JAVA"};
            
            return filename.Length;
        }
    }
}