using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lesson8
{
    public class EnglishDictionary
    {
        #region Поля

        private string fileName;
        private List<EnglishDictionaryItem> list;

        #endregion

        #region Свойства

        public int Count
        {
            get { return list.Count; }
        }

        public object List { get; }

        public EnglishDictionaryItem this[int index]
        {
            get { return list[index]; }
        }

        #endregion

        #region Конструкторы

        public EnglishDictionary(string fileName)
        {
            this.fileName = fileName;
            list = new List<EnglishDictionaryItem>();
        }

        public EnglishDictionary(string fileName, EnglishDictionary englishDictionary) : this(fileName)
        {
            list = englishDictionary.list;
        }

        #endregion

        #region Публичные методы

        public void Add(string word, string translate, DateTime addingDate, string[] themes)
        {
            list.Add(new EnglishDictionaryItem(word, translate, addingDate, themes));
        }

        public void Remove(int index)
        {
            if (list != null && index < list.Count && index >= 0)
                list.RemoveAt(index);
        }

        public void Load()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<EnglishDictionaryItem>));
            FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            list = (List<EnglishDictionaryItem>)xmlSerializer.Deserialize(fileStream);
            fileStream.Close();
        }

        public void Save()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<EnglishDictionaryItem>));
            FileStream fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlSerializer.Serialize(fileStream, list);
            fileStream.Close();
        }

        internal void Add(EnglishDictionaryItem newWord)
        {
            list.Add(newWord);
        }

        internal void Remove(EnglishDictionaryItem item)
        {
            list.Remove(item);
        }

        #endregion
    }
}
