using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Dictionary
{
    class _Dictionary<TKey, TValue>
    {
        private int Capacity { get; set; }
        public TKey[] Keys { get; set; }
        public TValue[] Values { get; set; }
        public int Count { get => index; }

        private int index = 0;

        public _Dictionary()
        {
            Capacity = 4;
            Keys = new TKey[4];
            Values = new TValue[4];
        }

        public _Dictionary(int capacity)
        {
            Capacity = capacity;
            Keys = new TKey[Capacity];
            Values = new TValue[Capacity];
        }

        public void Add(TKey key, TValue value)
        {
            if (Keys.Contains(key))
            {
                throw new Exception($"{key} key already excist.");
            }
           
            if (Count != Capacity)
            {
                Keys[index] = key;
                Values[index++] = value;
            }
            else
            {
                Capacity = Capacity * 2;
                TKey[] newKeys = new TKey[Capacity];
                TValue[] newValues = new TValue[Capacity];
                
                for (int i = 0; i < Count; i++)
                {
                    newKeys[i] = Keys[i];
                    newValues[i] = Values[i];
                }

                Keys = newKeys;
                Values = newValues;
                Keys[index] = key;
                Values[index++] = value;
            }
        }

        public TValue this[TKey key]
        {
            get
            {
                int idx = Keys.ToList().IndexOf(key);
                return Values[idx];
            }
            set
            {
                int idx = Keys.ToList().IndexOf(key);
                Values[idx] = value;
            }
        }

    }
}
