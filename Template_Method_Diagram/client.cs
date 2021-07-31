using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method_Diagram
{
    class client
    {
        static void Main(string[] args)
        {
            subject sok = new web_developer();
                sok.register();

            subject sovann = new teacher_computer();
                sovann.register();

            Console.ReadKey();
        }
    }
}
