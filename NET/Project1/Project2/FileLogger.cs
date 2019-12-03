using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class FileLogger : ILogger
    {
        private StreamWriter writer;

        public FileLogger(String path)
        {
            writer = File.CreateText(path);
            writer.AutoFlush = true;
        }
        public void WriteLog(string message)
        {
            writer.WriteLine("{0}{1}", DateTime.Now.ToLocalTime(), message);
        }
    }
}
