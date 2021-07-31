using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method_Diagram
{
    class web_developer :subject
    {
        public override void computer_science()
        {
            Console.WriteLine("I want toBe web developer :\n");
            Console.WriteLine(" need computer science studying year 3 or over."+
                              "\n and then need html,css,javascript,typescript and angular framwork.");
        }
    }
}
