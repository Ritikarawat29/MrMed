using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MrMed.Models
{
    public class Appointment
    {
        public int Patient_ID { get; set; }

        public string Patient_Name { get; set; }

        public int age { get; set; }

        public string department { set; get; }

        public string gender { set; get; }

        public DateTime date { get; set; }

        public int Insurance_No { get; set; }
    }
}