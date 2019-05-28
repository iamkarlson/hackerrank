using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
using System.Reflection.Emit;

namespace HackerRank
{
    internal class Program
    {
        // Complete the checkMagazine function below.
        static void checkMagazine(string[] magazineArr, string[] noteArr)
        {
            if (noteArr.Length > magazineArr.Length)
            {
                Console.WriteLine("No");
                return;
            }

            Dictionary<String, int> note = noteArr.GroupBy(t => t).ToDictionary(g => g.Key, g => g.Count());

            Dictionary<String, int> magazine = magazineArr.GroupBy(t => t).ToDictionary(g => g.Key, g => g.Count());
            foreach (var word in note)
            {
                if ((!magazine.ContainsKey(word.Key))||word.Value > magazine[word.Key])
                {
                    Console.WriteLine("No");
                    return;
                }
            }

            Console.WriteLine("Yes");
        }

        static void Main(string[] args)
        {
            string[] mn = Console.ReadLine().Split(' ');

            int m = Convert.ToInt32(mn[0]);

            int n = Convert.ToInt32(mn[1]);

            string[] magazine = Console.ReadLine().Split(' ');

            string[] note = Console.ReadLine().Split(' ');

            checkMagazine(magazine, note);
        }
    }
}