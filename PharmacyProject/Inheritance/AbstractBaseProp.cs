using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyProject.Inheritance
{
    abstract class AbstractBaseProp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsStatus { get; set; }
        public bool IsDelete { get; set; }

    }
}
