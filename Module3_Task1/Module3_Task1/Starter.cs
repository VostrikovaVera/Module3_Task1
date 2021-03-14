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
                var list = new CustomList<int>();

                list.Add(8);
                list.Add(3);
                list.Add(4);
                list.Add(5);
                list.RemoveAt(5);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
