using System.Management;

namespace Resources_Monitoring
{
    class InfoCpu
    {
        private string cpuName; //название цп
        private string cpuClockSpeed;   //частота
        private string cpuSocket;   //название сокета
        private string cpuCores;    //кол-во ядер
        private string cpuLogicProcesses;   //кол-во лог. проц.
        private string cpuVirtualisation;   //виртуализация
        
        public void setCpuName(string cpuName)
        {
            this.cpuName = cpuName;
        }
        public void setCpuClockSpeed(string cpuClockSpeed)
        {
            this.cpuClockSpeed = cpuClockSpeed;
        }
        public void setCpuSocket(string cpuSocket)
        {
            this.cpuSocket = cpuSocket;
        }
        public void setCpuCores(string cpuCores)
        {
            this.cpuCores = cpuCores;
        }
        public void setCpuLogicProcesses(string cpuLogicProcesses)
        {
            this.cpuLogicProcesses = cpuLogicProcesses;
        }
        public void setCpuVirtualisation(string cpuVirtualisation)
        {
            this.cpuVirtualisation = cpuVirtualisation;
        }

        public string getСpuName()
        {
            return this.cpuName;
        }
        public string getCpuClockSpeed()
        {
            return this.cpuClockSpeed;
        }
        public string getCpuSocket()
        {
            return this.cpuSocket;
        }
        public string getCpuCores()
        {
            return this.cpuCores;
        }
        public string getCpuLogicProcesses()
        {
            return this.cpuLogicProcesses;
        }
        public string getCpuVirtualisation()
        {
            return cpuVirtualisation;
        }

        public InfoCpu()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(
      "select * from Win32_Processor");
            foreach (var item in searcher.Get())
            {
                this.setCpuName(item["Name"].ToString());
                this.setCpuClockSpeed(((double)(uint)item["MaxClockSpeed"] / 1000).ToString() + "Ггц");
                this.setCpuCores(item["NumberOfCores"].ToString());
                this.setCpuSocket(item["SocketDesignation"].ToString());
                this.setCpuLogicProcesses(item["NumberOfLogicalProcessors"].ToString());
                if ((bool)item["VirtualizationFirmwareEnabled"])
                    this.setCpuVirtualisation("Включено");
                else
                    this.setCpuVirtualisation("Выключено");
            }
        }
    }
}