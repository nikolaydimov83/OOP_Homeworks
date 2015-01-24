using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04HTML_Dispatcher
{
    class ElementBuilder
    {
        private string name;
        public string Name 
        
        {
            get { return this.name; }
            set { this.name = value; }
        }

        private List<Attribute> allAtributes;
        public List<Attribute> AllAtributes
        {
            get { return this.allAtributes; }
            set { this.allAtributes = value; }
        }

        private string text;
        public string Text
        {
            get { return this.text; }
            set { this.text = value; }
        }

        public ElementBuilder(string name, List<Attribute> allAtributes)
        {
            this.Name = name;
            this.AllAtributes = allAtributes;
        }

        public void AddAtribute(string type, string value) 
        { 
        allAtributes.Add(new Attribute (type,value));
        }

        public void AddContent(string content)
        {
            this.text = content;
        }

        public static string operator *(ElementBuilder element, int n)
        {
            string result="";
            for (int i = 0; i < n; i++)
            {
                result = result + "<" + element.Name;
                foreach (var item in element.AllAtributes)
                {
                    result = result + " " + item.AttributeType + " =" + "  \"" + item.AttributeValue+"\" ";
                }
                result = result + ">"+element.Text+"</"+element.Name+">";
            }
            return result;
        }

    }
}
