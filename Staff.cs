using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anatoly.Finanse
{
    class Staff
    {
        //HW3 Task 2 (Перевернуть строку)
        public static string ReverseString(string initialString)
        {
            char[] stringToCharArray = initialString.ToCharArray();
            return new string(stringToCharArray.Reverse().ToArray());
        }

        public static void AllocateMail(string initFilePath, string newFilePath)
        {
            if (File.Exists(initFilePath))
            {
                string fileText = File.ReadAllText(initFilePath);
                string[] wordsArray = fileText.Split(" ");

                if (File.Exists(newFilePath))
                {
                    File.Delete(newFilePath);
                }

                foreach (string word in wordsArray)
                {
                    if (word.Contains("@"))
                    {
                        File.AppendAllText(newFilePath, $"{word}\n");
                    }
                }
                
            }
        }

        
    }
}
