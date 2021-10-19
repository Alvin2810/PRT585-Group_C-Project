using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Services.Models.Theatre
{
    public class Theatre_ResultSet
    {
        public Int64 movie_id { get; set; }
        public String name { get; set; }
        public long Theatre_id { get; internal set; }
    }
}

