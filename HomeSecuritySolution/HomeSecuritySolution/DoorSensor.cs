using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSecuritySolution
{

    public delegate void SensorHanlder(string status);

    class DoorSensor
    {
         string doorStatus;

        public event SensorHanlder OnSensorStatus;
        public void open()
        {
            doorStatus = "opened";
            this.Notify();
        }

        public void close()
        {
            doorStatus = "closed";

            this.Notify();
        }

        public void Notify()
        {
           var time = System.DateTime.Now;
            String date = time.ToString("yyyy,MM,dd,hh");

            string message = $"Door {doorStatus} and time is {time} {date}";
            Console.WriteLine(message);
        }
      


    }
}
