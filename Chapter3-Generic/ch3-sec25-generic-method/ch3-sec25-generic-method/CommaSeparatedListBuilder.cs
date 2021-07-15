using System;
using System.Collections.Generic;
using System.Text;

namespace ch3_sec25_generic_method
{
    public class CommaSeparatedListBuilder
    {
        private readonly StringBuilder storage = new();

        public void Add<T>(IEnumerable<T> items)
        {
            foreach (T item in items)
            {
                if (storage.Length > 0)
                {
                    storage.Append(',');
                }
                storage.Append('"');
                storage.Append(item.ToString());
                storage.Append('"');
            }
        }

        public override string ToString() => storage.ToString();
    }
}
