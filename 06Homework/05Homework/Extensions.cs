using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05omework
{
    public static class Extensions
    {
          public static String Substring(this StringBuilder str,int startIndex, int length)
            {
                if (str.Length < length-1-startIndex || startIndex < 0 || startIndex > length - 1) 
                {
                    throw new ArgumentException(String.Format("Argument out of range. Indexes must be 0 and {0}", length - 1));
                }
              String str1= str.ToString().Substring(startIndex,length);
              return str1;
            }

          public static StringBuilder RemoveString(this StringBuilder str, string text)
          {
              return str.Replace(text, string.Empty);             
          }

          public static StringBuilder AppendAll<T>(this StringBuilder str, IEnumerable<T> textToAppend)
          {
              foreach (var item in textToAppend)
              {
                  str.Append(item.ToString());
              }
              return str;
          } 
    }
}
