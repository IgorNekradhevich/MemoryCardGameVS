using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory.Model
{
    static class UriList
    {
        static List<Uri> uriList = new List<Uri>()
        {
            new Uri("\\Images\\card.jpg"),
            new Uri("\\Images\\card1.jpg"),
            new Uri("\\Images\\card2.jpg"),
            new Uri("\\Images\\card3.jpg")
        };
        static public Uri GetUri(int index)
        {
            return uriList[index];
        }
    }
}
