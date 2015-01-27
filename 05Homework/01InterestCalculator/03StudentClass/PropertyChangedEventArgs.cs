using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03StudentClass
{
    public class PropertyChangedEventArgs:EventArgs
    {
        private string oldValue;
        private string newValue;

        private string propertyChanged;
     


        public string OldValue
        {
            get { return this.oldValue; }
            set { this.oldValue = value; }
        }

        public string NewValue
        {
            get { return this.newValue; }
            set { this.newValue = value; }
        }

        public string PropertyChanged
        {
            get { return this.propertyChanged; }
            set { this.propertyChanged = value; }
        }

      
        public PropertyChangedEventArgs(string oldValue, string newValue, string propertyChanged) : base() 
        {
            this.NewValue = newValue;
            this.OldValue = oldValue;
            this.PropertyChanged = propertyChanged;
        }
    }
}
