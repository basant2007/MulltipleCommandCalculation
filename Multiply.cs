using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    public class Multiply : ICalc
    {
        public string Calculation(string str)
        {
            int result = 1;
            string[] allItems = str.Replace(' ', ',').Split(',');
            foreach (var _item in allItems)
            {
                int value;
                if(int.TryParse(_item, out value)) 
                    result *= value;
            }

            return result.ToString();
        }
    }
}
