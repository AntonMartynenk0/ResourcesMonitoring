using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Resources_Monitoring
{
    class LogControl
    {
        public LogData logData;
        public Serialize serialize = new Serialize();
        public List<LogData> listLogCPU = new List<LogData>();
        public List<LogData> listLogRam = new List<LogData>();

        private PerformanceCounter cpucounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        private PerformanceCounter ramcounter = new PerformanceCounter("Memory", "% Committed Bytes In Use");

        private int i = 0, j = 0;
       
        public LogControl()
        {
           listLogCPU = serialize.deserializeLog("logCPU.xml");
           listLogRam = serialize.deserializeLog("logRAM.xml");
        }

        //обновление графиков
        public LogData getRamLoad()//ram load
        {
            logData = new LogData(listLogRam.Count, DateTime.Now, Math.Round((double)ramcounter.NextValue(), 2));
            listLogRam.Add(logData);
            serialize.serializeLog("logRAM.xml", listLogRam);
            j++;
            return logData;
        }

        public LogData getCpuLoad() //cpu load
        {
            logData = new LogData(listLogCPU.Count, DateTime.Now, Math.Round((double)cpucounter.NextValue(), 2));
            listLogCPU.Add(logData);
            serialize.serializeLog("logCPU.xml", listLogCPU);
            i++;
            return logData;
        }
    }
}