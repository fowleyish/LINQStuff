﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

namespace LINQStuff
{
    class Solutions
    {
        public List<string> FoundATh(List<string> list)
        {
            var th = "th";
            var wordsWithTh = list.Where(x => x.Contains(th)).ToList();
            return wordsWithTh;
        }

        public List<string> NoDuplicates(List<string> list)
        {
            var noDupes = list.Distinct().ToList();
            return noDupes;
        }

        public double ClassAverageAfterLowestGradeDropped(List<string> list)
        {
            List<double> firstAverages = new List<double>();
            foreach(string item in list)
            {
                List<double> convertedGrades = new List<double>();
                var splitGrades = item.Split(',');
                foreach(string grade in splitGrades)
                {
                    convertedGrades.Add(double.Parse(grade));
                }
                firstAverages.Add(convertedGrades.Where(x => x > convertedGrades.Min()).Average());
            }
            return firstAverages.Average();
        }

        public string OrderedAndNumbered(string word)
        {
            word = word.ToUpper();
            var wordList = word.ToList();
            var distinctLetters = wordList.OrderBy(x => x).Distinct().ToList();
            var frequency = new List<int>();
            foreach(var letter in wordList)
            {
                frequency.Add(wordList.Where(x => x.Equals(letter)).Count());
            }
            string returnString = null;
            for (int i = 0; i < distinctLetters.Count; i++)
            {
                returnString += distinctLetters[i];
                returnString += frequency[i];
            }
            return returnString;
        }
    }
}
