using System;
using System.Collections.Generic;
using Module3_Task1.Helpers;

namespace Module3_Task1
{
    public class Starter
    {
        public void Run()
        {
            try
            {
                var list = new CustomList<string>();
                List<string> range = new List<string> { "rrrrr", "wwwwwwwwwwwwwwww", "qqqqqqqqqqqqqqqqqqqq", "222", "bbbbbb", "jjjjj", "kkkkk" };

                list.Add("aaaaaa");
                list.Add("fff");
                list.Add("yyyyyyyyy");
                list.Add("ooooo");
                list.Add("xxxxxx");
                list.Add("ttt");
                list.Remove("ttt");
                list.AddRange(range);
                list.Sort(new StringLengthComparer());

                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
