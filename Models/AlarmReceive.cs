using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeeamONEReceiver.Models
{
    public class AlarmReceive
    {

        public string AlarmName { get; set; }
        public string ObjectName { get; set; }
        public string Information { get; set; }
        public string TriggeredOn { get; set; } //is a date time, will handle parsing in api if required, receive string for now.
        public string AlarmState { get; set; }
        public string AlarmPreviousState { get; set; }
        public int AlarmID { get; set; }




    }
}
