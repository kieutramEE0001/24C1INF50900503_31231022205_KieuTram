using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24C1INF50900503_31231022205_KieuTram
{
    internal class Lesson_08
    {
        private static void Main(string[] args)
        {
            Vidu();
            
            // 1. Create a blank file named "a.txt"
            CreateBlankFile("a.txt");

            // 2. Remove a file named "b.txt"
            RemoveFile("b.txt");

            // 3. Create a file "c.txt" and add some text
            CreateFileWithText("c.txt", "Hello, world!");

            // 4. Create a text file "c.txt" and read it
            ReadFile("c.txt");

            // 5. Create a file "d.txt" and write an array of strings
            WriteArrayToFile("d.txt", new string[] { "Line1", "Line2", "Line3" });

            // 6. Append some text to "c.txt"
            AppendToFile("c.txt", "Appending new text!");

            // 7. Copy "c.txt" to "b.txt" and display content
            CopyFileAndDisplay("c.txt", "b.txt");

            // 8. Move "b.txt" to "a.txt"
            MoveFile("b.txt", "a.txt");

            // 9. Read the first line of "c.txt"
            ReadFirstLine("c.txt");

            // 10. Read the last line of "c.txt"
            ReadLastLine("c.txt");

            // 11. Read the last 2 lines of "d.txt"
            ReadLastNLines("d.txt", 2);

            // 12. Read the 2nd line from "d.txt"
            ReadSpecificLine("d.txt", 2);

            // 13. Count the number of lines in "d.txt"
            CountLines("d.txt");

            // 14. Print folder structure
            PrintFolderStructure(Directory.GetCurrentDirectory());

            // 15. Character and number statistics in "c.txt"
            CharacterStatistics("c.txt");
        }
        static void Vidu()
        {
            //char[] st = { 'h', 'e', '1', 'l', 'o' };
            //string s1 = "hello";
            //s1 = "world";
            //string? s2 = null; //Không cần kiểm tra
            string s = "Enumerates    and transforms a    sequence and procedures an immutable" +
                "sorted dictionary of its contents by using the   specified key and value comparers.";
            int len = CountWords(s);
            Console.WriteLine(len);
        }
    
        static int CountWords(string s)
        {
            int count = 0;
            //Bỏ khoảng trắng thừa có trong chuỗi
            s = s.Trim(); //bỏ khoảng trắng ở đầu và cuối chuỗi
            while (s.IndexOf("  ") != -1)
            {
                s = s.Replace("  ", " ");
            }
            string[] words = s.Split(' ');
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            count = words.Length;
            return count;
            //đếm
            //foreach (char c in s) 
            //    if (c == ' ')
            //        count++;
            //return count +1;
        }

static void CreateBlankFile(string fileName)
{
    File.Create(fileName).Close();
    Console.WriteLine($"{fileName} created.");
}

static void RemoveFile(string fileName)
{
    if (File.Exists(fileName))
    {
        File.Delete(fileName);
        Console.WriteLine($"{fileName} removed.");
    }
    else
    {
        Console.WriteLine($"{fileName} does not exist.");
    }
}

static void CreateFileWithText(string fileName, string text)
{
    File.WriteAllText(fileName, text);
    Console.WriteLine($"{fileName} created with text.");
}

static void ReadFile(string fileName)
{
    if (File.Exists(fileName))
    {
        string content = File.ReadAllText(fileName);
        Console.WriteLine($"Content of {fileName}:");
        Console.WriteLine(content);
    }
    else
    {
        Console.WriteLine($"{fileName} does not exist.");
    }
}

static void WriteArrayToFile(string fileName, string[] lines)
{
    File.WriteAllLines(fileName, lines);
    Console.WriteLine($"Array written to {fileName}.");
}

static void AppendToFile(string fileName, string text)
{
    File.AppendAllText(fileName, text + Environment.NewLine);
    Console.WriteLine($"Text appended to {fileName}.");
}

static void CopyFileAndDisplay(string sourceFile, string destinationFile)
{
    if (File.Exists(sourceFile))
    {
        File.Copy(sourceFile, destinationFile, true);
        Console.WriteLine($"{sourceFile} copied to {destinationFile}.");
        ReadFile(destinationFile);
    }
    else
    {
        Console.WriteLine($"{sourceFile} does not exist.");
    }
}

static void MoveFile(string sourceFile, string destinationFile)
{
    if (File.Exists(sourceFile))
    {
        File.Move(sourceFile, destinationFile);
        Console.WriteLine($"{sourceFile} moved to {destinationFile}.");
    }
    else
    {
        Console.WriteLine($"{sourceFile} does not exist.");
    }
}

static void ReadFirstLine(string fileName)
{
    if (File.Exists(fileName))
    {
        string firstLine = File.ReadLines(fileName).FirstOrDefault();
        Console.WriteLine($"First line of {fileName}: {firstLine}");
    }
    else
    {
        Console.WriteLine($"{fileName} does not exist.");
    }
}

static void ReadLastLine(string fileName)
{
    if (File.Exists(fileName))
    {
        string lastLine = File.ReadLines(fileName).LastOrDefault();
        Console.WriteLine($"Last line of {fileName}: {lastLine}");
    }
    else
    {
        Console.WriteLine($"{fileName} does not exist.");
    }
}

static void ReadLastNLines(string fileName, int n)
{
    if (File.Exists(fileName))
    {
        var lines = File.ReadLines(fileName).Reverse().Take(n).Reverse();
        Console.WriteLine($"Last {n} lines of {fileName}:");
        foreach (var line in lines)
        {
            Console.WriteLine(line);
        }
    }
    else
    {
        Console.WriteLine($"{fileName} does not exist.");
    }
}

static void ReadSpecificLine(string fileName, int lineNumber)
{
    if (File.Exists(fileName))
    {
        var lines = File.ReadLines(fileName).ToList();
        if (lineNumber - 1 < lines.Count)
        {
            Console.WriteLine($"Line {lineNumber} of {fileName}: {lines[lineNumber - 1]}");
        }
        else
        {
            Console.WriteLine($"Line {lineNumber} does not exist in {fileName}.");
        }
    }
    else
    {
        Console.WriteLine($"{fileName} does not exist.");
    }
}

static void CountLines(string fileName)
{
    if (File.Exists(fileName))
    {
        int count = File.ReadLines(fileName).Count();
        Console.WriteLine($"{fileName} contains {count} lines.");
    }
    else
    {
        Console.WriteLine($"{fileName} does not exist.");
    }
}

static void PrintFolderStructure(string folderPath)
{
    Console.WriteLine($"Folder structure of {folderPath}:");
    foreach (var dir in Directory.GetDirectories(folderPath))
    {
        Console.WriteLine($"[Directory] {dir}");
    }
    foreach (var file in Directory.GetFiles(folderPath))
    {
        Console.WriteLine($"[File] {file}");
    }
}

static void CharacterStatistics(string fileName)
{
    if (File.Exists(fileName))
    {
        string content = File.ReadAllText(fileName);
        var charCounts = content.GroupBy(c => c)
                                .ToDictionary(g => g.Key, g => g.Count());

        Console.WriteLine($"Character statistics for {fileName}:");
        foreach (var pair in charCounts)
        {
            Console.WriteLine($"'{pair.Key}': {pair.Value}");
        }
    }
    else
    {
        Console.WriteLine($"{fileName} does not exist.");
    }
}
    }
}
