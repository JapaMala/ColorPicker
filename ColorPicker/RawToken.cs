using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorPicker
{
    class RawToken : IList<string>
    {
        public string Token { get; set; }
        private List<string> properties = new List<string>();

        public int Count => ((IList<string>)properties).Count;

        public bool IsReadOnly => ((IList<string>)properties).IsReadOnly;

        public string this[int index] { get => ((IList<string>)properties)[index]; set => ((IList<string>)properties)[index] = value; }

        public RawToken(string token)
        {
            properties.Clear();
            var bits = token.Split(':');
            Token = bits[0];
            for (int i = 1; i < bits.Length; i++)
            {
                properties.Add(bits[i]);
            }
        }

        public int IndexOf(string item)
        {
            return ((IList<string>)properties).IndexOf(item);
        }

        public void Insert(int index, string item)
        {
            ((IList<string>)properties).Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            ((IList<string>)properties).RemoveAt(index);
        }

        public void Add(string item)
        {
            ((IList<string>)properties).Add(item);
        }

        public void Clear()
        {
            ((IList<string>)properties).Clear();
        }

        public bool Contains(string item)
        {
            return ((IList<string>)properties).Contains(item);
        }

        public void CopyTo(string[] array, int arrayIndex)
        {
            ((IList<string>)properties).CopyTo(array, arrayIndex);
        }

        public bool Remove(string item)
        {
            return ((IList<string>)properties).Remove(item);
        }

        public IEnumerator<string> GetEnumerator()
        {
            return ((IList<string>)properties).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IList<string>)properties).GetEnumerator();
        }
    }
}
