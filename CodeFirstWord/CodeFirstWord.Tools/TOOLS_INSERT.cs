using CodeFirstWord.Db;
using CodeFirstWord.Sort;
using System;
using System.Linq;

namespace CodeFirstWord.Tools
{
    public class TOOLS_INSERT
    {
        public static TBL_CHAR Add_TBL_CHAR(string str)
        {
            TBL_CHAR car = null;
            var result = (from x in TOOLS.db.TBL_CHARS
                          where x.CHARS.Contains(str)
                          select x).FirstOrDefault();
            if (result != null)
            {
                car = result;
            }
            else
            {
                car = new TBL_CHAR();
                car.CHARS = str;
                TOOLS.db.TBL_CHARS.Add(car);
                TOOLS.db.SaveChanges();
            }

            return car;
        }
        public static TBL_WORD Add_TBL_WORD(string str)
        {
            TBL_WORD word = new TBL_WORD();
            word.WORD = str;
            word.LENGTH = str.Length;

            string car = StringChars.Get_StringChars(str);

            var ucar = TOOLS_INSERT.Add_TBL_CHAR(car);
            word.UNSORTED_CHAR = ucar;

            var scar = StringChars.Get_StringChars_Sorted(str);
            word.SORTED_CHAR = TOOLS_INSERT.Add_TBL_CHAR(scar);

            TOOLS.db.TBL_WORDS.Add(word);
            TOOLS.db.SaveChanges();

            return word;
        }

        public static TBL_WORD Add_TBL_WORD_WITH_CLEANSTRING(string str)
        {
            TBL_WORD word = null;
            if (str.Length < 2 || str.Length > 9)
            {
                return word;
            }
            str = TOOLS.Get_CleanString(str);

            if (str.Length < 10 && str.Length > 2)
            {
                var result = (from x in TOOLS.db.TBL_WORDS
                              where x.WORD == str
                              select x).FirstOrDefault();

                if (result == null)
                {

                    return Add_TBL_WORD(str);
                }

            }
            return word;
        }
    }
}
