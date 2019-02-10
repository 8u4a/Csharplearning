using System;

namespace SerializationTest
{
    public class NbaCard
    {
        public string Title { get; set; }
        public string Link { get; set; }

        public override string ToString()
        {
            return "Properties are: " + Title + " " + Link;
            //return base.ToString();
        }

    }
}
