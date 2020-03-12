using CodeFirstWord.Db;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;

namespace CodeFirstWord.Model
{
    public class WORD_ENTITIES : DbContext
    {
        public WORD_ENTITIES() : base("name=BAConnection")
        {

        }

        public DbSet<TBL_CHAR> TBL_CHARS { get; set; }
        public DbSet<TBL_WORD> TBL_WORDS { get; set; }
    }

}
