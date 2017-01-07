using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace PROEKT2
{
    public class Settings
    {
        public static Settings GetSettings()
        {
            Settings settings = null;
            string Filename = Globals.settingsFile;
            if (File.Exists(Filename))
            {
                using (FileStream fs = new FileStream(Filename, FileMode.Open))
                {
                    XmlSerializer xser = new XmlSerializer(typeof(Settings));
                    settings = (Settings)xser.Deserialize(fs);
                    fs.Close();
                }
            }
            else settings = new Settings();
            return settings;

        }
        public void Save()
        {

            string Filename = Globals.settingsFile;
            if (File.Exists(Filename)) File.Delete(Filename);

            using (FileStream fs = new FileStream(Filename, FileMode.Create))
            {
                XmlSerializer xser = new XmlSerializer(typeof(Settings));
                xser.Serialize(fs, this);
                fs.Close();
            }

        }
        public string Направление_Подготовки { get; set; }
        public string Направленность { get; set; }
        public string Форма_обучения { get; set; }
        public string Тема_научно_квалификационной_работы { get; set; }
        public string Научный_руководитель { get; set; }
        public string Кафедра { get; set; }
        public string Срок_обучения { get; set; }
        public string Факультет { get; set; }
        public string Приказ_о_зачислении { get; set; }


    }
}
