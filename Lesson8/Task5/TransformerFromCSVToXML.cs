using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lesson8.Task5
{
    internal class TransformerFromCSVToXML<T>
        where T : class, IParser<T>, new()
    {
        public List<T> LoadFromFile(string fileName)
        {
            var res = new List<T>();

            var lines = File.ReadAllLines(fileName);
            foreach (var line in lines)
                try
                {
                    res.Add(new T().Parse(line, ';'));
                }
                catch
                {}
            return res;
        }

        public void SaveToXMLFile(string fileName, List<T> data)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));
            FileStream fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlSerializer.Serialize(fileStream, data);
            fileStream.Close();
        }

    }
}
