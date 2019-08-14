using System;

namespace NetDiffExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "hello";
            string str2 = "heloworld!";
            var result = NetDiff.DiffUtil.Diff(str1, str2);
        }
    }
}
