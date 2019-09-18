using System;
using System.IO;

namespace Project
{
    public class Log
    {
        public static DirectoryInfo directory = new DirectoryInfo("C:\\Users\\user\\Desktop\\ProjLogs");

        public static void Logs(object obj)
        {
            string fileName = directory + "\\logs.txt";
            int counter = 2;
            FileStream aFile = new FileStream(fileName, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(aFile);
            sw.Close();
            do
            {
                if (File.ReadAllBytes(fileName).Length > 1024 * 1024)
                {
                    fileName = directory + "\\logs" + counter + ".txt";
                    counter++;
                }
                else
                {
                    break;
                }
            }
            while (true);

            aFile = new FileStream(fileName, FileMode.OpenOrCreate);
            sw = new StreamWriter(aFile);

            aFile.Seek(0, SeekOrigin.End);
            sw.WriteLine($"{DateTime.Now}:\n{obj.ToString()}");
            sw.Close();
        }
    }
}
