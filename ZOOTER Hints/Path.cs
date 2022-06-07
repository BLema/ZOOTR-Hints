using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOOTR_Hints
{
    class Path
    {
        public string region { get; set; }
        public string boss { get; set; }
        public List<String> items;

        public Path()
        {
            items = new List<String>();
        }

        public Path(string Region, string Boss)
        {
            region = Region;
            boss = Boss;
            items = new List<String>();
        }
    }
}
