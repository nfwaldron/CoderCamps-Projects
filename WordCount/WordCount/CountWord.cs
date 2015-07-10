using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    class CountWord
    {
        public int WordCounter(string strLine)
        {
            // Split String into an Array.
            var strSplit = strLine.Split(' ');
            var strLength = strSplit.Length;
            return strLength;
        }
    }
}
