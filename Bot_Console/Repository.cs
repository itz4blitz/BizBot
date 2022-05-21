using Bot_Console.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot_Console
{
    public class Repository
    {
        private readonly List<Catalog> catalogRepository = new List<Catalog>();

        public List<Catalog> getCatalogRepo()
        {
            return catalogRepository;
        }

    }
}
