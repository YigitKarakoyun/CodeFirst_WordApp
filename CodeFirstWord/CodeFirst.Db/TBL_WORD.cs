using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstWord.Db
{
    public class TBL_WORD
    {
        public int TBL_WORDID { get; set; }

        [Required,MinLength(2),MaxLength(9)]
        public string WORD { get; set; }
        public int LENGTH { get; set; }

        public virtual TBL_CHAR UNSORTED_CHAR { get; set; }        
        public virtual TBL_CHAR SORTED_CHAR { get; set; }

        public override string ToString()
        {
            return WORD;
        }

    }
    

}
