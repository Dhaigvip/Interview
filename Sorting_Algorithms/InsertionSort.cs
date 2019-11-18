using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting_Algorithms
{
    public class InsertionSort: ISort
    {
        /*
         *  Let’s say that I have asked a class of students to turn in index
            card with their names, id numbers, and a short biographical sketch. The
            students return the cards in random order, but I want them to be alphabetized
            so I can build a seating chart.
            I take the cards back to my office, clear off my desk, and take the first card.
            The name on the card is Smith. I place it at the top left position of the desk
            and take the second card. It is Brown. I move Smith over to the right and
            put Brown in Smith’s place. The next card is Williams. It can be inserted at
            the right without having to shift any other cards. The next card is Acklin.
            It has to go at the beginning of the list, so each of the other cards must be
            shifted one position to the right to make room. That is how the Insertion sort works.
         */
        public int[] Sort(int[] array)
        {
            int inner, temp;
            int upper = array.Length;
            for (int outer = 1; outer <= upper; outer++)
            {
                temp = array[outer];
                inner = outer;
                while (inner > 0 && array[inner - 1] >= temp)
                {
                    array[inner] = array[inner - 1];
                    inner -= 1;
                }
                array[inner] = temp;
            }
            return array;
        }
    }
}
