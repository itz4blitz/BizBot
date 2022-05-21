using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot_Console.POCO
{
    public class Thread
    {
        public int no { get; set; }
        public bool sticky { get; set; }
        public bool closed { get; set; }
        public string now { get; set; }
        public string name { get; set; }
        public string sub { get; set; }
        public string com { get; set; }
        public string filename { get; set; }
        public string ext { get; set; }
        public int w { get; set; }
        public int h { get; set; }
        public int tn_w { get; set; }
        public int tn_h { get; set; }
        public int tim { get; set; }
        public string md5 { get; set; }
        public int fsize { get; set; }
        public int resto { get; set; }
        public string capcode { get; set; }
        public string semantic_url { get; set; }
        public int replies { get; set; }
        public int images { get; set; }
        public int omitted_posts { get; set; }
        public int omitted_images { get; set; }
        public List<LastReplies> last_replies { get; set; }
        public int last_modified { get; set; }

    }
}
