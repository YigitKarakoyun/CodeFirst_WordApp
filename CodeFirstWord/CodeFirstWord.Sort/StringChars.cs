using CodeFirstWord.Sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstWord.Sort
{
    public class StringChars
    {
        public static string Get_StringChars(string str)
        {
            if (str.Length>1)
            {
                return str[0] + "" + str[str.Length - 1];
            }
            return "";
        }
        public static string Get_StringChars_Sorted(string str)
        {
            string temp = StringSort.Get_SortedString(str);
            return Get_StringChars(temp);
        }
    }
}
