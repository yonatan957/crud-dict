using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_dict
{
    internal class dict
    {
        public Dictionary<string, string> mydict = new Dictionary<string, string>();

        public void Add(string key, string value) { mydict.Add(key, value); }
        public string Get(string key) { return mydict[key]; }
        public void Remove(string key) { mydict.Remove(key); }
        public void Clear()
        {
            mydict.Clear();
        }
        public void update(string key, string value)
        {
            mydict[key] = value;
        }
    }
}
