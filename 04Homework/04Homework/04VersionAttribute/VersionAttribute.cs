using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04VersionAttribute
{
    [AttributeUsage(AttributeTargets.Struct |
    AttributeTargets.Class | AttributeTargets.Interface,
    AllowMultiple = true)]
    public class VersionAttribute : System.Attribute
    {
        public int Major { get; private set; }
        public int Minor { get; private set; }

        public VersionAttribute(int major,int minor)
        {
            this.Major = major;
            this.Minor = minor;
        }
    }

}
