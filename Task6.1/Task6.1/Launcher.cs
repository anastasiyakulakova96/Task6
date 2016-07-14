using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6._1
{
    class Launcher
    {
        static void Main(string[] args)
        {
            FileWorker fw = new FileWorker();
            Controller controller = new Controller(fw);

            fw.WritePathToFile();
            controller.CheckNotEmptyFile();
            fw.ShowFirstLetters(); //строк
            controller.CheckNotFoundLines();

            Logger.GetLogger().Close();
            Console.ReadLine();

        }
    }
}
