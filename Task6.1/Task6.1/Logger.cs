using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6._1
{
  class Logger
    {
        public string pathWithNameFile = Data.pathLog + @"\" + Data.nameLogFile;

        private static Logger logger;
        private StreamWriter writer;

        private Logger()
        {
            writer = new StreamWriter(File.Create(pathWithNameFile));
        }

        public static Logger GetLogger()
        {
            if (logger == null)
            {
                logger = new Logger();
            }
            return logger;
        }

        public void Log(String message)
        {
            writer.WriteLine(message);
        }

        public void Close()
        {
            writer.Close();
        }
    }
}
