using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ConsoleApp5
{
    public class CalcFactory
    {
        public Dictionary<string, ICalc> CreateObject = new Dictionary<string, ICalc>();

        public CalcFactory()
        {
            CreateObject.Add("add", new UserAdds());
            CreateObject.Add("multiply", new Multiply());
        }

        //public void AddCommand(string command, List<ICalc> x)
        //{
        //    //Assembly ass = Assembly.LoadClass(registerClass);
        //    CreateObject.Add(command, x);
        //}

        public ICalc GetObject(string command)
        {
            try
            {
                return CreateObject[command.ToLower()];
            }
            catch (Exception er)
            {
                return null;
            }
        }

    }
}
