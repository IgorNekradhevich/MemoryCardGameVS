
using System;
using System.Collections.Generic;

namespace Memory.Model
{
    class TheGame
    {
        int _count;
        List<Card> cards;
        private int[] GetRandomArray()
        {
            int[] result = new int[_count];
            for (int i=0; i<_count;i++)
                result[i] = i % _count + 1;

            Random random = new Random();
            for (int i=0; i<_count;i++)
            {
                int index = random.Next(_count);
                int temp = result[index];
                result[index] = result[i];
                result[i] = temp;
            }
            return result;
        }
        public TheGame (int count)
        {
            _count = count;
            cards = new List<Card>();
            int[] IdArray = GetRandomArray();
            for (int i = 0; i < _count; i++)
                cards.Add(new Card(IdArray[i]));
        }
    }
}
