using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;



namespace Tyuiu.IvashkinaKE.Sprint6.Task6.V26.Lib
{
    public class DataService : ISprint6Task6V26
    {
        public int len = 0;
        public string CollectTextFromFile(string path)
        {
            string resStr = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(' ');
                    if (line.Length > 1)
                    {
                        resStr += words[words.Length - 1] + " ";
                    }
                    else
                    {
                        resStr += words[0] + " ";
                    }
                }
            }
            return resStr.Trim();



        }

    }
}

