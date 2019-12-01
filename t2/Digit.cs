using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2
{
    public class Digit : IDigit
    {
        public string Value { get; private set; }

        public Digit(string value)
        {
            Value = value;
        }

        public int GetIndexOfLine(ISentence current)
        {
            return current.IndexOfLine;
        }
    }
}
