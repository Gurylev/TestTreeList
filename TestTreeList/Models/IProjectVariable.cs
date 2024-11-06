using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTreeList.Models
{
    public interface IProjectVariable : IBaseVariable 
    {
        string Scope { get; set; }  
    }
}
