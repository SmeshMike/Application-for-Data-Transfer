using System;
using System.IO;
using System.Text;

namespace UI.Logs
{
    class Logger
    {
        private static object sync = new object();
        private static string filename;

        public static void InitLogger()
        {
            lock (sync)
            {
                string pathToLog = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"..\\..\\..\\..\\", "Log");
                if (!Directory.Exists(pathToLog))
                    Directory.CreateDirectory(pathToLog);// Создаем директорию, если нужно

                filename = Path.Combine(pathToLog, "MainLog_" + DateTime.Now.ToString("yyyy.MM.dd  HH.mm.ss") + ".log");
            }
        }

        public static void Write(Exception ex)
        {
            try
            {
                string fullText = string.Format("[{0:yyyy.MM.dd  HH:mm:ss}] [{1}.{2}()] Exception Info: {3} {4}{4}{4}",
                        DateTime.Now, ex.TargetSite?.DeclaringType, ex.TargetSite?.Name, ex.ToString(), Environment.NewLine);
                Console.WriteLine(fullText);
                lock (sync)
                {
                    File.AppendAllText(filename, fullText, Encoding.UTF8);
                }
            }
            catch (Exception logError)
            {
                Console.WriteLine(logError.ToString());
                Console.WriteLine(ex.ToString());
            }
        }

        public static void WriteLine(string st)
        {
            try
            {
                string fullText = string.Format("{0:yyyy.MM.dd  HH:mm:ss} {1}{2}", DateTime.Now, st, Environment.NewLine);
                Console.Write(fullText);
                lock (sync)
                {
                    File.AppendAllText(filename, fullText, Encoding.UTF8);
                }
            }
            catch (Exception logError)
            {
                Console.WriteLine(logError.ToString());
                Console.WriteLine(st);
            }
        } 


    }
}
