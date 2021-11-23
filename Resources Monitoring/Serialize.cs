using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

namespace Resources_Monitoring
{
    class Serialize
    {
        private double size;
        
        public Serialize()
        {
            size = 300000;
        }

        public Serialize(double size)
        {
            this.size = size;
        }

        public void setSize(double size)
        {
            this.size = size;
        }

        public double getSize()
        {
            return size;
        }

        //сериализация данных и сохранение в файл
        public void serializeLog(string path, List<LogData> datas)
        {
            XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(List<LogData>));
            FileStream file = System.IO.File.Create(path);
            writer.Serialize(file, datas);
            file.Close();
        }

        //десериализация данных и получение данных из файлов xml
        public List<LogData> deserializeLog(string path)
        {
            List<LogData> datas = new List<LogData>();
            if (File.Exists(path))
            {
                XmlSerializer reader = new XmlSerializer(typeof(List<LogData>));
                StreamReader logCPU = new StreamReader("logCPU.xml");
                datas = (List<LogData>)reader.Deserialize(logCPU);
                logCPU.Close();
            }
            return datas;
        }

        public void deleteLogs(LogControl logControl)
        {
            long fileSize = new System.IO.FileInfo("logCPU.xml").Length;
            long fileSize1 = new System.IO.FileInfo("logRam.xml").Length;
            if (fileSize > size)
            {
                logControl.listLogCPU = new List<LogData>();
                File.Delete("logCPU.xml");
            }
            if (fileSize1 > size)
            {
                logControl.listLogRam = new List<LogData>();
                File.Delete("logRam.xml");
            }
        }
    }
}
