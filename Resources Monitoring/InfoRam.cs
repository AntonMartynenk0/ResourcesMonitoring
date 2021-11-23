using System;
using System.Management;

namespace Resources_Monitoring
{
    class InfoRam
    {
        private string ramName;
        private string ramClockSpeed;
        private string ramCountOfSockets;
        private string ramFormFactor;
        private double ramCapacity;
        private string[] formactor = { "Unknown", "Other", "SIP", "DOP", "ZIP", "SOJ", "Proprietary", "SIMM", "DIMM", "TSOP", "PGA" ,
        "RIMM", "SODIMM", "SRIMM", "SMD", "SSMP", "QFP", "TQFP", "SOIC", "LCC", "PLCC", "BGA", "FPBGA", "LGA"};

        public void setCpuName(string ramName)
        {
            this.ramName = ramName;
        }
        public void setRamClockSpeed(string ramClockSpeed)
        {
            this.ramClockSpeed = ramClockSpeed;
        }
        public void setRamCountOfSockets(string ramCountOfSockets)
        {
            this.ramCountOfSockets = ramCountOfSockets;
        }
        public void setRamFormFactor(string ramFormFactor)
        {
            this.ramFormFactor = ramFormFactor;
        }
        public void setRamCapacity(double ramCapacity)
        {
            this.ramCapacity = ramCapacity;
        }

        public string getRamName()
        {
            return this.ramName;
        }
        public string getRamClockSpeed()
        {
            return this.ramClockSpeed;
        }
        public string getRamCountOfSockets()
        {
            return this.ramCountOfSockets;
        }
        public string getRamFormFactor()
        {
            return this.ramFormFactor;
        }
        public double getRamCapacity()
        {
            return ramCapacity;
        }

        //общая информация о компонентах
        public InfoRam()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("Select * From Win32_PhysicalMemory");
            int countOfSockets = 0;
            double capacity = 0;
            string name = "";
            foreach (var item in searcher.Get())
            {
                name += item["Manufacturer"].ToString() + " " + item["PartNumber"].ToString() + "\n";
                capacity += (double)(UInt64)item["Capacity"];
                if (item["BankLabel"] != null)
                {
                    countOfSockets++;
                }
                this.setRamCountOfSockets(countOfSockets.ToString());
                this.setRamClockSpeed(item["ConfiguredClockSpeed"].ToString() + "МГц");
                this.setRamFormFactor(formactor[(int)(UInt16)item["FormFactor"]]);
            }
            this.setCpuName(name);
            this.setRamCapacity(capacity);
        }
    }
}