using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_dict
{
    internal class dict<TKey, TValue>
    {
        public Dictionary<TKey, TValue> MyDictionary;

        public dict() { MyDictionary = new Dictionary<TKey, TValue>(); }

        public void Add(TKey key, TValue value) { MyDictionary[key] = value; }
        public TValue Get(TKey key) { return MyDictionary[key]; }
        public void Remove(TKey key) { MyDictionary.Remove(key); }
        public void Clear() { MyDictionary.Clear(); }
    }
}
