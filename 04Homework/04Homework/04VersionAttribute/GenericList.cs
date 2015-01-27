using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04VersionAttribute
{
    [Version(2, 11)]
    class GenericList<T> where T : IComparable<T>
    {
        private const int initialCapacity=16;
        private int curentCapacity = initialCapacity;
    
        private int count=0;
        private T[] items = new T[initialCapacity];
        private T[] itemsMirror = new T[initialCapacity];

        public int Count
        {
            get { return this.count; }
        }

        public T[] Items
        {
            get 
            {
                T[] result = new T[count];
                Array.Copy(this.items, 0, result, 0, count);
                return result; 
            }
            set { this.items=value; }
        }


        public void Add(T elementToAdd)
        {
            IncreaseArraySize();
            items[count] = elementToAdd;
            count++;
        }

        public T AccessByIndex(int index)
        {
            CheckForIndexRange(index);
            return this.items[index];

        }

        public T[] RemoveByIndex(int index)
        {
            IncreaseArraySize();
            T[] result = new T[curentCapacity];
            const int stratIndex=0;
            CheckForIndexRange(index);
            Array.Copy(this.items, 0, result, 0, (index - stratIndex));
            Array.Copy(this.items, index+1, result, index, (this.count-1-index ));
            this.items = result;
            this.count--;
            return this.items;
        }

        public T[] InsertAtIndex(int index,T value)
        {
            IncreaseArraySize();
            T[] result = new T[curentCapacity];
            CheckForIndexRange(index);
            Array.Copy(this.items, 0, result, 0, (index));
            result[index] = value;
            Array.Copy(this.items, index, result, index+1, (this.count - index));
            this.items = result;
            this.count++;
            return this.items;
        }

        public int FindIndexByValue(T value)
        {
           
            for (int i = 0; i < this.Count; i++)
            {
                if (this.items[i].Equals(value))
                {
                    return i;
                }
            } 
                      
            return -1;
        }

        public bool Contains(T value)
        {
            int numberOccurences = 0;

            for (int i = 0; i < this.Count; i++)
            {
                if (this.items[i].Equals(value))
                {
                    numberOccurences++;
                }
            }

            if (numberOccurences == 0)
            {
                return false;
            }
            else 
            {
                return true;
            }
        }

        public override string ToString()
        {
            string result=""; 
            for (int i = 0; i < this.count; i++)
			{
                result = result + "[" + i + "]: " + this.items[i] + Environment.NewLine;
               
			}
            return result;
        }

        public T[] Clear()
        {
            this.count = 0;
            this.items = new T[curentCapacity];
            return this.items;
        }

        public static T Min<B>(T first, T second)
       
        {
            
            if (first.CompareTo(second) <= 0)
                return first;
            else
                return second;
        }


        public T Min<B>()        
        {

            T result = this.items[0];
          
            for (int i = 1; i < this.count; i++)
            {
                int a=result.CompareTo(this.items[i]);
                if (a==1) 
                {
                    result = this.items[i];
                }
                
                
            }
            return result;
        }


        public T Max<B>()
        {

            T result = this.items[0];

            for (int i = 1; i < this.count; i++)
            {
                int a = result.CompareTo(this.items[i]);
                if (a == -1)
                {
                    result = this.items[i];
                }


            }
            return result;
        }

        public GenericList()
        { 
        
        }

        private void IncreaseArraySize() 
        {

            if (count >= items.Length)
            {
                items.CopyTo(itemsMirror, 0);
                items = new T[curentCapacity * 2];
                itemsMirror.CopyTo(items, 0);
                curentCapacity *= 2;

            }
        }

        private void CheckForIndexRange(int index)
        {
            if (index < 0 || index > count - 1)
            {
                throw new ArgumentOutOfRangeException("The index must be greater than zero and less than list size");
            }
        }



        
       
    }
}
