using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Desktop_Facebook
{
   public class AppSetting
    {
        public Point LastWindowLocation { get; set; }
        public Size LastWindowSize { get; set; }
        public bool RememberUser { get; set; }
        public string LastAccessToken { get; set; }
        
         public AppSetting()
        {
            LastWindowLocation = new Point(20, 50);
            LastWindowSize = new Size(1000, 500);
            RememberUser = false;
            LastAccessToken = null;

        }
        public void SaveToFile()
        {
            Stream stream = null;
            
            try
            {
                stream = new FileStream(@"C:\Users\itzik\source\repos\Desktop Facebook\Desktop Facebook\AppSetting.xml", FileMode.Truncate);
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            } 
            finally
            {
                stream.Dispose();
            }
        }

        public void LoadFromFile()
        {
             
        }
    }
}
