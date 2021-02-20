using System;
using System.Collections.Generic;
using System.Text;

namespace Stuck.Entity
{
    public class WatchList
    {
        public int Id { get; set; }
        public IEnumerable<Security> Securities { get; set; }
    }
}
