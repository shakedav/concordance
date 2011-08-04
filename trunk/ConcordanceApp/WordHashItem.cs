using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace concordanceapConcordationDataSetTableAdaptersp
{
    class WordItem
    {
        public WordItem()
        {
            this.word = "";
            this.lineNum = 0;
            this.wordNum = 0;
        }

        public WordItem(String word, int wordNum, int lineNum)
        {
            this.word = word;
            this.wordNum = wordNum;
            this.lineNum = lineNum;            
        }

        /*public int AddCount()
        {
            Count = Count + 1;
            return Count;
        }*/

        public string word;
        public int lineNum;
        public int wordNum;
    }
}
