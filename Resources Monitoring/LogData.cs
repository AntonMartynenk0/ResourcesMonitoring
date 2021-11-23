using System;

namespace Resources_Monitoring
{
    public class LogData
    {
        public int num;
        public DateTime date;
        public double value;

        public LogData()
        {
            this.num = 0;
            this.date = DateTime.Now;
            this.value = 0;
        }

        public LogData(int num, DateTime date, double value)
        {
            this.num = num;
            this.date = date;
            this.value = value;
        }
    }
}