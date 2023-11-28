using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisions_Lib
{
    public class FileDetails
    {
        public string FileName { get; set; }
        public string FileExpectedName { get; set; }
        public int Version_ID { get; set; }
        public bool IsRevision { get; set; }
    }
}
