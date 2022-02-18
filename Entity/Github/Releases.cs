using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace niushuai233Kit.Entity.Github
{
    public class Assets
    {
        public string url { get; set; }
        public long id { get; set; }
        public string node_id { get; set; }
        public string name { get; set; }
        public string label { get; set; }
        public string content_type { get; set; }
        public string state { get; set; }
        public long size { get; set; }
        public string browser_download_url { get; set; }
    }
    public class Releases
    {
        public string url { get; set; }
        public string assets_url { get; set; }
        public string tag_name { get; set; }
        public string name { get; set; }
        public DateTime published_at { get; set; }
        public List<Assets> assets { get; set; }
        public string body { get; set; }
    }
}
