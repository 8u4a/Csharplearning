using System;
using System.Collections.Generic;
using System.Text;

namespace SerializationTest
{
    public class Card
    {
        public string Title { get; set; }
        public string Link { get; set; }

        public virtual string ShowCard()
        {
            return "This is the card";
        }
    }
}
