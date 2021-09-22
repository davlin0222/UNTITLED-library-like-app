using System;

namespace Logic
{
    public class Sound_track : Media
    {
        public int Duration {get; set;}

        public Sound_track(string title, int duration) : base(title) {
            this.Duration = duration;
        }

        public override string ToString() {
            return $"{Title}\t Sound track\t{Duration} minutes";
        }
    }
}
