using System;
using System.Collections.Generic;
using System.Text;

namespace SerializationTest
{
   public class NflCard: Card
    {
        public override string ShowCard()
        {


            return "Properties are: " + Title + " " + Link;

        }
    }
}
