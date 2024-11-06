using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTreeList.Models
{
    internal class Variable : IProjectVariable
    {
        public string Name { get; set; }    
        public string Scope { get; set; }
    }
}
