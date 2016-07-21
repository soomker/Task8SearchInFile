using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Search;

namespace SearchInFile
{
    public class FileSearch:ISearch
    {
        /// <summary>
        /// Method returns results of search
        /// </summary>
        /// <param name="str">What to search</param>
        /// <param name="param">Path to folder</param>
        /// <returns></returns>
        public string Search(string str, string param = null)
        {
            string fileContent = String.Empty;
            if (String.IsNullOrEmpty(param))
            {
                fileContent = File.ReadAllText("D:\\Study\\CsharpTasks\\Task8\\SearchInFile\\SearchInFile\\bin\\Debug\\TextFile.txt");
                if (fileContent.Contains(str))
                {
                    return "The " + str + " is founded in file TextFile.txt";
                }
            }
            else
            {
                DirectoryInfo dirInf = new DirectoryInfo(param);
                FileInfo[] files = dirInf.GetFiles("*.txt");
                foreach (FileInfo fi in files)
                {
                    fileContent = File.ReadAllText(fi.FullName);
                    if (fileContent.Contains(str))
                    {
                        return "The " + str + " is founded in file "+fi.Name;
                    }
                }

            }
            
               return String.Empty;
        }
    }
}
