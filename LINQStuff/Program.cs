using System;
using System.Collections;
using System.Collections.Generic;

namespace LINQStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            Solutions sln = new Solutions();

            //List<string> lst = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            //sln.FoundATh(lst);

            //List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            //sln.NoDuplicates(names);

            //List<string> classGrades = new List<string>()
            //{
            //"80,100,92,89,65",
            //"93,81,78,84,69",
            //"73,88,83,99,64",
            //"98,100,66,74,55"
            //};
            //Console.WriteLine(sln.ClassAverageAfterLowestGradeDropped(classGrades));

            string mrT = "Terrill";
            Console.WriteLine(sln.OrderedAndNumbered(mrT));
        }
    }
}
