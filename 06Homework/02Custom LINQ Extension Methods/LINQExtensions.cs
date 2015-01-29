using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02Custom_LINQ_Extension_Methods
{
    public static class LINQExtensions
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate) 
        {
            return collection.Where(x => predicate(x) == false);
        }

        public static IEnumerable<T> Repeat<T>(this IEnumerable<T> collection, int count) 
        {
            List<T> resultAsList = new List<T>();
            List<T> collectionAsList=collection.ToList();
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < collectionAsList.Count; j++)
                {
                    resultAsList.Add(collectionAsList[j]);
                }                
            }

            return (IEnumerable<T>)resultAsList;
        }

        public static IEnumerable<string> WhereEndsWith<T>(this IEnumerable<string> collection, IEnumerable<string> suffixes) 
        {
            List<string> result = new List<string>();
            foreach (var str in collection)
            {
                foreach (var sufix in suffixes)
                {
                    if (str.EndsWith(sufix))
                    {
                        if (result.Contains(str)==false||(result.Count()==0))
                        {
                        result.Add(str);
                        }
                    }
                }
            }
            return (IEnumerable<string>)result; 
        } 
    }
}
