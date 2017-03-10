using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankObjects
{
    class AccountActivity
    {
        private readonly DateTime _timeStamp;
        //private TimeSpan _time;
        private readonly double _sum;

        public AccountActivity(DateTime timeStamp, double sum)
        {
            _timeStamp = timeStamp;
           // _date = date;
            //_time = time;
            _sum = sum;
        }

        public DateTime TimeStamp
        {
            get { return _timeStamp; }
            //set { _date = value; }
        }
        /*
        public TimeSpan Time
        {
            get { return _time; }
            set { _time = value; }
        }
        */
        public double Sum
        {
            get { return _sum; }
           // set { _sum = value; }
        }

        // public DateTime IncludeTimestamp(DateTime _date, TimeSpan _time, Double Sum)
        // {
        // var date = new DateTime(2017, 2, 1);
        // var time = new TimeSpan(9, 30, 0);
        //     date = _date + _time;
        //     return date;
        // }

        public override string ToString()
        {
            return _timeStamp.ToShortDateString() + "\t klo " + _timeStamp.ToLongTimeString() + ": \t" + Sum + "e";
            // return ActivityInfo();
            // return "Date: " + _timeStamp + ", " + ": " + "Sum: " + Sum;
        }
        /*
        private string ActivityInfo() // private is only called here
        {
           // DateTime timestamp = _date + _time;

            return "Date: " + timestamp + ", " + ": " + "Sum: " + Sum;
            // return "Date: " + date + ", " + " Time: " + _time + ": " + "Sum: " + Sum;
        }*/
    }
}
