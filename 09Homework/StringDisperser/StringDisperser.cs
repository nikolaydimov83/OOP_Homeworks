using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace StringDisperser
{
    class StringDisperser : ICloneable, IComparable<StringDisperser>,IEnumerable<char>
    {
        private string string1;
        private string string2;
        private string string3;

        public StringDisperser(string str1, string str2, string str3)
        {
            this.String1 = str1;
            this.String2 = str2;
            this.String3 = str3;
        }

        public string String1
        {
            get { return string1; }
            set { string1 = value; }
        }

        public string String2
        {
            get { return string2; }
            set { string2 = value; }
        }

        public string String3
        {
            get { return string3; }
            set { string3 = value; }
        }

        public override bool Equals(object obj)
        {
            object objAsStringDisperser=obj as StringDisperser;
            if (objAsStringDisperser == null)
            {
                return false;
            }

            if ((this.string1 != ((StringDisperser)objAsStringDisperser).string1)||
               (this.string2!=((StringDisperser)objAsStringDisperser).string2)||
               (this.string3!=((StringDisperser)objAsStringDisperser).string3))
            {
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            return String.Format(this.string1+this.string2+this.string3);
        }

        public object Clone()
        {
            return new StringDisperser((string)this.string1.Clone(), (string)this.string2.Clone(), (string)this.string3.Clone());
        }

        public override int GetHashCode()
        {
            return this.string1.GetHashCode() ^ this.string2.GetHashCode() ^ this.string3.GetHashCode();
        }

        public static bool operator == (StringDisperser disperser1, StringDisperser disperser2)
        {
            return disperser1.Equals(disperser2);
        }
        public static bool operator !=(StringDisperser disperser1, StringDisperser disperser2)
        {
            return !(disperser1.Equals(disperser2));
        }

        public int CompareTo(StringDisperser other)
        {
            return this.ToString().CompareTo(other.ToString());
        }

        public IEnumerator<char> GetEnumerator()
        {

            foreach (var item in string1)
            {
                yield return item;
            }

            foreach (var item in string2)
            {
                yield return item;
            }

            foreach (var item in string3)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var item in string1)
            {
                yield return item;
            }

            foreach (var item in string2)
            {
                yield return item;
            }

            foreach (var item in string3)
            {
                yield return item;
            }
        }
    }
}
