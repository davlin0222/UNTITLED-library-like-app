using System;
using System.Collections.Generic;

namespace Logic
{
    public class Storage
    {
        List<string> media = new List<string>();

        public void storage_add(string value) {
            media.Add(value);
        }

        public override string ToString() {
            return string.Join(",", media);;
        }
}
}
