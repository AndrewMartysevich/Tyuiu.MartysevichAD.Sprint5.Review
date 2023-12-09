using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SpirinIS.Sprint5.TaskReview.V15.Lib
{
    public class DataService : ISprint5Task7V15
    {
        public string LoadDataAndSave(string path)
        {
            string pathSave = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V15.txt";
            FileInfo fileInfo = new FileInfo(pathSave);
            bool fileExist = fileInfo.Exists;

            if (fileExist)
            {
                File.Delete(pathSave);
            }
            string word = File.ReadAllText(path);
            var newText = "";
            string[] words = word.Split(' ');
            for (int i = 0; i <= words.Length - 1; i++)
            {
                if(words[i].Length != 2)
                {
                    newText += words[i] + " ";
                    
                }
                
            }
            string res = Convert.ToString(newText);
            File.AppendAllText(pathSave, res);
            return pathSave;
        }
    }
}
