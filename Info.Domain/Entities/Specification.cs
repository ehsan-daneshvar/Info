using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Info.Domain.Entities
{
    public class Specification
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public DateTime Birth { get; set; }
        public string Address { get; set; }

    }
}
