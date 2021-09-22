using System;
using System.Collections.Generic;

namespace Logic
{
    public class Storage
    {
        private List<Media> _media_list = new List<Media>();

        public void storage_add(Media media) {
            this._media_list.Add(media);
        }

        public override string ToString() {
            return string.Join("\n", this._media_list);;
        }
    }
}
