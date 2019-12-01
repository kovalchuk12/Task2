using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2
{
   public class Parser
    {
        public static ISentence[] Parse(TextReader input)
        {
            string line;

            StringBuilder newLine = new StringBuilder();


            while ((line = input.ReadLine()) != null)
            {

                for (int i = 0; i < line.Length; i++)
                {
                    
           
                }
          
            }
            


        }

    }
}
