using System;
using System.IO;

namespace ExamFunc
{
    public class FileReaderService
    {
        public String[] FileReader(string path)
        {
            string[] TextRead = File.ReadAllLines(path);
            return TextRead;
        }
    }
}
