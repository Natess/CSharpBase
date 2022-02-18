using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    public class EnglishDictionaryItem
    {
        public EnglishDictionaryItem()
        {

        }

        public EnglishDictionaryItem(string word, string translate, DateTime addingDate, string[] themes)
        {
            Word = word;
            Translate = translate;
            Themes = themes;
            AddingDate = addingDate;
        }

        public string Word { get; set; }
        public string Translate { get; set; }

        public DateTime AddingDate { get; set; }

        public string[] Themes { get; set; }
    }
}
