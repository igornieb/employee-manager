using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace lab3.Model
{
    public class Storage
    {
        private List<Pracownik> list = new List<Pracownik>();

        public void Add(Pracownik p)
        {
            list.Add(p);
        }

        public void Remove(Pracownik p)
        {
            list.Remove(p);
        }

        public Pracownik Get(int id)
        {
            try {
                return list[id];
            }
            catch (IndexOutOfRangeException) { 
                throw new IndexOutOfRangeException("index out of range");
            }
        }

        public void Set(int id, Pracownik p)
        {
            try
            {
                list[id]=p;
            }
            catch (IndexOutOfRangeException)
            {
                throw new IndexOutOfRangeException("index out of range");
            }
        }

        public void RemoveAt(int index)
        {
            try
            {
                list.RemoveAt(index);
            }
            catch (IndexOutOfRangeException)
            {
                throw new IndexOutOfRangeException("index out of range");
            }
        }

        public void Serialize(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(list.GetType(), new XmlRootAttribute("Pracownicy"));
            StreamWriter writer = new StreamWriter(filePath);
            serializer.Serialize(writer.BaseStream, list);
            writer.Close();
        }
        public List<Pracownik> Deserialize(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(list.GetType(), new XmlRootAttribute("Pracownicy"));
            StreamReader reader = new StreamReader(filePath);
            List<Pracownik> deserialzied_data;

            try
            {
                deserialzied_data = (List<Pracownik>)serializer.Deserialize(reader);
                return deserialzied_data.ToList();
            }
            catch (Exception)
            {
                throw new Exception("Error Detected in XML file");
            }
            finally
            {
                reader.Close();
            }
        }


    }
}
