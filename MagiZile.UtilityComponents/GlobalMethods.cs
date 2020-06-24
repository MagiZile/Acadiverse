using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagiZile.UtilityComponents
{
    public static class GlobalMethods
    {
        public static string[] ArrayFromFile(string path)
        {

            StreamReader objStreamReader = new StreamReader(path);
            string[] array = new string[File.ReadAllLines(path).Length];
            Debug.WriteLine("File length: " + File.ReadAllLines(path).Length + " lines.");
            Debug.WriteLine("Array size: " + array.Length);
            string line = "";
            int index = 0;
            while (line != null)
            {
                line = objStreamReader.ReadLine(); 
                Debug.WriteLine("Index: " + index);
                Debug.WriteLine("Line: " + line);
                if (line != null)
                {
                    array[index] = line;
                }
                index++;
            }
            objStreamReader.Close();
            objStreamReader.Dispose();
            return array;
        }
    }
}
