using System;

namespace Logic
{
    public class Movie : Sound_track
    {
        public string Resolution { get; set; }

        public Movie(string title, int duration, string resolution) : base(title, duration) {
            this.Resolution = resolution;
        }

        public override string ToString() {
            return $"{Title}\t Movie\t{Duration} minutes\t{Resolution} resolution";
        }
    }
}
