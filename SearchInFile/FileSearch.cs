using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SearchInFile
{
    public class FileSearch
    {
       public static string Search(string str)
        {
            string fileContent = File.ReadAllText("D:\\Study\\CsharpTasks\\Task8\\SearchInFile\\SearchInFile\\bin\\Debug\\TextFile.txt");
            if (fileContent.Contains(str))
            {
                return "The "+str+" is founded in file TextFile.txt";
            }
            else
            {
                return String.Empty;
            }
        }
    }
}
