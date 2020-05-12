using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace LINQStuff
{
    class Solutions
    {
        public List<string> FoundATh(List<string> list)
        {
            var wordsWithTh = new List<string>();
            var th = "th";
            wordsWithTh = list.Where(x => x.Contains(th)).ToList();
            return wordsWithTh;
        }

        public List<string> NoDuplicates(List<string> list)
        {
            var noDupes = new List<string>();
            noDupes = list.Distinct().ToList();
            return noDupes;
        }
    }
}
