using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04HTML_Dispatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Attribute> list =new List<Attribute>();
            list.Add(new Attribute("id", "page"));
            list.Add(new Attribute("class", "big"));
            ElementBuilder newElement = new ElementBuilder("div",list);
            newElement.AddContent("Here we go");
            string result = newElement * 2;
            Console.WriteLine(result);
            string displayImg=HTMLDispatcher.CreateImage("http:\\abv.bg", "Hello Kitty", "Title Hello Kitty");
            Console.WriteLine(displayImg);
        }
    }
}
