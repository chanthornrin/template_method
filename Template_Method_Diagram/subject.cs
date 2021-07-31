using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method_Diagram
{
    public abstract class subject
    {
        public void register ()
        {
            computer_science();
        }
        public abstract void computer_science();
    }
}
