using CodeFirstWord.Db;
using CodeFirstWord.Sort;
using CodeFirstWord.Tools;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeFirstWord.Model
{
   public class TOOLS_SELECT
    {
       
        public static ICollection<TBL_CHAR> Get_TBL_CHARS()
        {
            return TOOLS.db.TBL_CHARS.ToList();
        }
        public static ICollection<TBL_WORD> Get_TBL_WORDS()
        {
            return TOOLS.db.TBL_WORDS.ToList();
        }
        public static ICollection<TBL_WORD> Get_TBL_WORDS_SORTED()
        {
            var temp = (from x in TOOLS.db.TBL_WORDS
                        orderby x.LENGTH descending
                        select x).ToList();
            
            return temp;
        }
        public static TBL_WORD Get_TBL_WORD(string str)
        {
            str = str.ToUpper();
            var temp = (from x in TOOLS.db.TBL_WORDS
                        orderby x.LENGTH descending
                        where x.WORD == str
                        select x).FirstOrDefault();

            return temp;
        }
        public static TBL_WORD Get_TBL_WORD_SORTED(string str)
        {
            str = str.ToUpper().Trim();
            var car = StringChars.Get_StringChars_Sorted(str);
            var temp = (from x in TOOLS.db.TBL_WORDS
                        orderby x.LENGTH descending
                        where x.LENGTH==str.Length && x.SORTED_CHAR.CHARS == car
                        select x).FirstOrDefault();

            return temp;
        }

    }
}
