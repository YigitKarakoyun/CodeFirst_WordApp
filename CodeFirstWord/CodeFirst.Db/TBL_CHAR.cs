using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace CodeFirstWord.Db
{
    public class TBL_CHAR
    {
        public int TBL_CHARID { get; set; }

        [Required,MaxLength(2)]
        public string CHARS { get; set; }

        public virtual ICollection<TBL_WORD> WORDS { get; set; }
        public TBL_CHAR()
        {
            WORDS = new HashSet<TBL_WORD>();
        }

        public override string ToString()
        {
            return CHARS;
        }

    }

}
