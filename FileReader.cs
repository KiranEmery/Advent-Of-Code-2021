using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AOC2021
{
    public static class FileReader
    {
        public static List<string> ReadFile(string path){
            return File.ReadAllLines(path).ToList();
        }
    }
}