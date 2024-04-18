using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList.Models
{
    public class GenericList<T>
    {
        public static T[] items;
        public GenericList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            Array.Resize(ref items, items.Length + 1);
            items[items.Length-1] = item;
        }
        public T FindItem(Predicate<T> predicate)
        {
            foreach (T item in items)
            {
                if (predicate(item))
                {
                    return item;
                }
            }
            return default(T); 
        }
        public List<T> FindAllItems(Predicate<T> predicate)
        {
            List<T> foundItems = new List<T>();

            foreach (T item in items)
            {
                if (predicate(item))
                {
                    foundItems.Add(item);
                }
            }

            return foundItems;
        }
        }

    }
