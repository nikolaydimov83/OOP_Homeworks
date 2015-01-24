using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04HTML_Dispatcher
{
    class Attribute
    {
        private string attributeType;
        private string attributeValue;

        public string AttributeType 
        {
            get { return this.attributeType; }
            set{this.attributeType=value;}
        }

        public string AttributeValue
        {
            get { return this.attributeValue; }
            set { this.attributeValue = value; }
        }

        public Attribute(string attributeType, string attributeValue) 
        {
            this.AttributeType = attributeType;
            this.AttributeValue = attributeValue;
        }
    }
}
