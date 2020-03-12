using System;

namespace CodeFirstWord.Sort
{
    public class StringSort
    {
        public static string Get_SortedString(string str)
        {
            var car = str.ToCharArray();
            Array.Sort(car);
            return new string(car);
        }
    }
}
