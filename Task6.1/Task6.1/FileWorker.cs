using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6._1
{
    class FileWorker
    {
        string path;
        string[] allFile;
        IEnumerable<string> lines;
        public List<string> listFirstLetters;


        public void WritePathToFile()
        {
            do
            {
                Console.WriteLine(@"Please enter path to file. For example: d:\file.txt");
                path = Console.ReadLine();
            }
            while (!CheekPath() == true);
           // return path;
        }

        public bool CheekPath()
        {
            if (File.Exists(path))
            {
                return true;
            }
            return false;
        }

        public void ReadFile()
        {
            lines = File.ReadLines(path);
            allFile = File.ReadAllLines(path);

            if (allFile.Length == 0)
            {
                throw new EmptyFileException();
            }
        }

        public void ShowFirstLetters()
        {
            foreach (string s in lines)
            {
                listFirstLetters = new List<string>();

                if (String.IsNullOrEmpty(s))
                {
                    Console.WriteLine("empty line");
                }
                else
                {
                    listFirstLetters.Add(s[0].ToString());

                    foreach (string str in listFirstLetters)
                    {
                        Console.WriteLine(str);
                    }
                }
            }
        }

        public void CheckFileByEmptyLines()
        {
            foreach (string s in lines)
            {
                if (String.IsNullOrEmpty(s))
                {
                    throw new StringNotFoundException();
                }
            }
        }
    }
}
