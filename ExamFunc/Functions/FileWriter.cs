using System.IO;

namespace ExamFunc
{
    class FileWriter
    {
        public static void WriteToFile(string myobj)
        {
            string path = @"C:\Users\Kornelijus\source\repos\ExamFunc\ExamFunc\Files\OrderLog.txt";
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine($"\n{myobj}");
            }
        }
    }
}
