using System.Drawing;
using System.Xml.Serialization;
using System.IO;

namespace Resources_Monitoring
{
    public class StateSettings
    {
        public int color;
        public double fileSize;

        public StateSettings()
        {
            this.color = (Color.DarkMagenta).ToArgb();
            this.fileSize = 3000000;
        }

        public StateSettings(int color, double size)
        {
            this.color = color;
            this.fileSize = size;
        }

        public void setColor(int color)
        {
            this.color = color;
        }

        public void setFileSize(double size)
        {
            this.fileSize = size;
        }

        public int getColor()
        {
            return this.color;
        }

        public double getFileSize()
        {
            return this.fileSize;
        }

        public void saveSettings()
        {
            XmlSerializer writer = new XmlSerializer(typeof(StateSettings));
            FileStream file = File.Create("Settings.xml");
            writer.Serialize(file, (StateSettings)this);
            file.Close();
        }

        public StateSettings restoreSettings()
        {
            StateSettings settings = new StateSettings();
            if (File.Exists("Settings.xml"))
            {
                XmlSerializer reader = new XmlSerializer(typeof(StateSettings));

                StreamReader stream = new StreamReader("Settings.xml");
                settings = (StateSettings)reader.Deserialize(stream);
                stream.Close();
            }
            return settings;
        }
    }
}