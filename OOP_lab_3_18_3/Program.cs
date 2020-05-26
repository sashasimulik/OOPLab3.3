using System;
using System.IO;

namespace OOP_lab_3_18_3
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader file = new StreamReader("input.txt");

            string[] words = file.ReadToEnd().Split(new char[] { '\r', '\n', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; ++i)
            {
                if (words[i] == words[i].ToLower())
                {
                    words[i] = words[i].Remove(0);
                }
            }

            StreamWriter newFile = File.CreateText("output.txt");
            

            foreach (string word in words)
            {
                if (!string.IsNullOrWhiteSpace(word))
                {
                    newFile.Write("{0} ", word);
                }
            }

            newFile.Close();
        }
    }
}
