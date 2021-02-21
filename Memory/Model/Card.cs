using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory.Model
{
    class Card
    {
        public bool Front { get; private set; }
        public Uri BackImage { get; private set; }
        public Uri FrontImage { get; private set; }
        public int Id { get; private set; }

        public Card( int Id)
        {
            this.Id = Id;
            BackImage = UriList.GetUri(0);
            FrontImage = UriList.GetUri(Id);
            Front = false;
        }
        public void Reverse()
        {
            Front = !Front;
        }
    }
}
