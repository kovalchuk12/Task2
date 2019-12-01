using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2
{
    public class Word : IWord
    {
        private char[] _vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };
        public string Value { get; private set; }

        public int GetIndexOfLine(ISentence current)
        {
            return current.IndexOfLine;
        }

        public bool IsAVowel()
        {
            foreach (var item in _vowels)
            {
                if (Value.ToLower().First() == item)
                {
                    return true;
                }
            }
            return false;
        }
    }
}