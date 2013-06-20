using System.IO;
using System.Collections.Generic;
using System;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            if (null == line)
                continue;
            var result = FindPermutations(line);
            Console.WriteLine(result);
        }
    }

    public static string FindPermutations(string line)
    {
        var ret = new List<string>();

        ret = PermuteString(line.ToCharArray(), 0);

        ret.Sort();

        return ret.Aggregate((s1, s2) => (s1 + "," + s2));
    }

    private static List<string> PermuteString(char [] line, int location)
    {
        var ret = new List<string>();
        if (line.Length == location)
        {
            ret.Add(new String(line));
            return ret;
        }

        char currentChar = line[location];

        for (int i = location; i < line.Length; i++)
        {
            //Swap char
            line[location] = line[i];
            line[i] = currentChar;

            ret.AddRange(PermuteString(line, location+1));

            //restore the char for the next iteration
            line[i] = line[location];
            line[location] = currentChar;
        }

        return ret;
    }
}