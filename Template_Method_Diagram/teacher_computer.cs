using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method_Diagram
{
    class teacher_computer : subject
    {
        public override void computer_science()
        {
            Console.WriteLine(" ---------------------\n I want exam do a teacher computer :\n");
            Console.WriteLine(" need computer science studying year 1 or over." +
                              "\n and then Englist and General culture .");
        }
    }
}
