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
        public event SensorHanlder OnSensorStatus;
        public void open()
        {
            
        }

        public void close()
        {
            
        }

        public void Add_Observer(SensorHanlder observer)
        {
            observers.Add(observer);
        }
        public void Remove_Observer(SensorHanlder observer)
        {

            observers.Remove(observer);
        }



    }
}
