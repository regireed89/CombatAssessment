using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace CombatForms
{
    
    public static class DataManagement<T> 
    {
        public static void Serialize(string filename, T data)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            Directory.CreateDirectory(Environment.CurrentDirectory + "../Saves/");
            TextWriter writter = new StreamWriter(Environment.CurrentDirectory + "../Saves/" + filename + ".xml");
            serializer.Serialize(writter, data);
            
           
        }

        public static T Deserialize(string filename)
        {
            T data;
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            TextReader reader = new StreamReader(Environment.CurrentDirectory+"../Saves/" + filename + ".xml");
            data = (T)serializer.Deserialize(reader);
            reader.Close();
            return data;
        }
    }
}
