using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSecuritySolution
{
    class SecuritySytem
    {
            var time = System.DateTime.Now;
            String date = time.ToString("yyyy,MM,dd,hh");

            string message = $"Door {status} and time is {time} {date}";
            Console.WriteLine(message);
 
    }
}
