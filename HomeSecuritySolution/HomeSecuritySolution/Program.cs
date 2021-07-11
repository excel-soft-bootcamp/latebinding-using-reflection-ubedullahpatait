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

             SecuritySytem securityRef = new SecuritySytem();
            SensorHanlder _addressOfNotify = new SensorHanlder(securityRef.AlertMessage);

            DoorSensor _doorSensor = new DoorSensor();
            _doorSensor.OnSensorStatus += _addressOfNotify;
            _doorSensor.open();
            _doorSensor.open();
            Console.ReadKey();






        }
    }
}
