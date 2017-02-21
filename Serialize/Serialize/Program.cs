using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace Serialize
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static void Serialize<T>(string fileName, T data)
        {
            var serializer = new XmlSerializer(typeof(T));
            string path = Environment.CurrentDirectory + "../Saves/";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            using (var writer = new StreamWriter(path + fileName + ".xml"))
                serializer.Serialize(writer, data);
        }

        public static T Deserialize<T>(string fileName) where T : new()
        {
            var serializer = new XmlSerializer(typeof(T));
            var path = Environment.CurrentDirectory + "../Saves/" + fileName + ".xml";
            using (var reader = new StreamReader(path))
                return (T)serializer.Deserialize(reader);
        }
    }
}
