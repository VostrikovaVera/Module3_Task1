using System;
using System.Collections.Generic;

namespace Module3_Task1.Helpers
{
    public class StringLengthComparer : IComparer<string>
    {
        public int Compare(string n1, string n2)
        {
            if (string.IsNullOrEmpty(n1) || n1.Length < n2.Length)
            {
                return -1;
            }
            else if (n1.Length > n2.Length)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
