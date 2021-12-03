using System.Collections.Generic;

namespace AOC2021
{
    public static class Day2
    {
        public static string Part1()
        {
            var Hor = 0;
            var Dep = 0;
            var input = FileReader.ReadFile(@"D:\Code Repos\AOC2021\Day2\day2Input.txt");
            var commands = new List<Command>();
            foreach (var line in input)
            {
                var comm = new Command
                {
                    Dir = line.Split(' ')[0],
                    Dist = int.Parse(line.Split(' ')[1])
                };
                commands.Add(comm);
            }

            foreach (var com in commands)
            {
                switch (com.Dir)
                {
                    case "forward":
                        Hor += com.Dist;
                        break;
                    case "down":
                        Dep += com.Dist;
                        break;
                    case "up":
                        Dep -= com.Dist;
                        break;
                }
            }
            return (Hor * Dep).ToString();
        }

        public static string Part2()
        {
            var Hor = 0;
            var Dep = 0;
            var Aim = 0;
            var input = FileReader.ReadFile(@"D:\Code Repos\AOC2021\day2Input.txt");
            var commands = new List<Command>();
            foreach (var line in input)
            {
                var comm = new Command
                {
                    Dir = line.Split(' ')[0],
                    Dist = int.Parse(line.Split(' ')[1])
                };
                commands.Add(comm);
            }

            foreach (var com in commands)
            {
                switch (com.Dir)
                {
                    case "forward":
                        Hor += com.Dist;
                        Dep += Aim * com.Dist;
                        break;
                    case "down":
                        Aim += com.Dist;
                        break;
                    case "up":
                        Aim -= com.Dist;
                        break;
                }
            }
            return (Hor * Dep).ToString();
        }
    }

    public class Command
    {
        public string Dir { get; set; }
        public int Dist { get; set; }
    }
}