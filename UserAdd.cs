using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    public class UserAdds : ICalc
    {
        public string Calculation(string str)
        {
            //write the logic
            int result=0;
            string[] allItems = str.Replace(' ', ',').Split(',');
            foreach (var _item in allItems)
            {
                int value;
                int.TryParse(_item, out value);
                result += value;
            }

            return result.ToString();
        }
    }
}
