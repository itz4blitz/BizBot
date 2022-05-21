using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot_Console.POCO
{
    public class Catalog
    {
        public int page { get; set; }
        public List<Thread> threads { get; set; }
        public string? last_modified{ get; set; }

    }
}
