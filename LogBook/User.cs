using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogBook
{
    class User
    {
        public string FullName { get; set; }
        public DateTime AccessDate { get; set; }
        public bool IsTakePartIn { get; set; }
        public bool IsLate { get; set; }
        public bool IsAbsent { get; set; }
        public int CheckPoint { get; set; }
        public int ClassPoint { get; set; }
        public int DiamondCount { get; set; }
        public string Comment { get; set; }
    }
}
