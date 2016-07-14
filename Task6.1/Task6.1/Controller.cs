using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6._1
{
    class Controller
    {
        private Logger logger = Logger.GetLogger();
        FileWorker fw = new FileWorker();

        public void CheckNotEmptyFile()
        {
            try
            {
                fw.ReadFile();
            }
            catch (EmptyFileException e)
            {
                Console.WriteLine(e.Message);
                logger.Log("File is empty.Please enter any text");
                logger.Log(e.StackTrace);
            }
        }


        public void CheckNotFoundLines()
        {
            try
            {
                fw.CheckFileByEmptyLines();
            }
            catch (StringNotFoundException e)
            {
                Console.WriteLine(e.Message);
                logger.Log("File have empty line.Enter text");
                logger.Log(e.StackTrace);
            }
        }
    }
}
