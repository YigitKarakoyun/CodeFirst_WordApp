using CodeFirstWord.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstWord.Tools
{
    public class TOOLS
    {
        public static WORD_ENTITIES db { get; private set; } = new WORD_ENTITIES();
        public static string Get_CleanString(string str)
        {
            return str.ToUpper().Trim();
        }
    }
}
