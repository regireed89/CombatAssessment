using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace CombatForms
{
    public static class DataManagement<T>
    {
        public static void Serialize(string filename, T data)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            TextWriter writter = new StreamWriter(@"..\..\" + filename + ".xml");
            serializer.Serialize(writter, data);
            writter.Close();
        }

        public static T Deserialize(string filename)
        {
            T data;
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            TextReader reader = new StreamReader(@"..\..\" + filename + ".xml");
            data = (T)serializer.Deserialize(reader);
            reader.Close();
            return data;
        }
    }
}
