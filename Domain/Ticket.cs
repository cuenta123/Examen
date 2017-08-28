using LinqToSql;
using System;
using System.Collections.Generic;

namespace Domain
{
    public class Ticket 
    {
        public Guid id { get; set; }
        public Decimal precio { get; set; }      
    }
}
