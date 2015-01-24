using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04HTML_Dispatcher
{
    static class HTMLDispatcher
    {
        public static string CreateImage(string source, string altText, string titleText) 
        {
            List<Attribute> listAttribute = new List<Attribute>();
            listAttribute.Add(new Attribute ("src", source));
            listAttribute.Add(new Attribute("alt", altText));
            listAttribute.Add(new Attribute("title", titleText));
            ElementBuilder element = new ElementBuilder("img", listAttribute);

            return element*1;
        }


        public static string CreateURL(string source, string titleText, string text)
        {
            List<Attribute> listAttribute = new List<Attribute>();
            listAttribute.Add(new Attribute("href", source));
            listAttribute.Add(new Attribute("title", titleText));
            ElementBuilder element = new ElementBuilder("a", listAttribute);
            element.AddContent(text);

            return element * 1;
        }

        public static string CreateInput(string type, string name, string value)
        {
            List<Attribute> listAttribute = new List<Attribute>();
            listAttribute.Add(new Attribute("type", type));
            listAttribute.Add(new Attribute("name", name));
            listAttribute.Add(new Attribute("value", value));
            ElementBuilder element = new ElementBuilder("input",listAttribute);

            return element * 1;
        }
    }
}
