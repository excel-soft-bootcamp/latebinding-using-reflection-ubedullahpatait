using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSecuritySolution
{
    class Program
    {
        static void Main(string[] args)
        {

            SecuritySytem _DoorSensor = new SecuritySytem();
            SensorHanlder _addressOfNotify = new SensorHanlder(_DoorSensor.update);

            DoorSensor status = new DoorSensor();
            status.OnSensor+=_addressOfNotify;

            status.open();
            status.close();






        }
    }
}
