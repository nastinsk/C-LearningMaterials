using System;
using System.Collections.Generic;

namespace Greedy
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }
        /*
         * 1. Write a function called FillRoomWithBoxes that takes in an int called roomSize, a List<int> called possibleSizes, and a List<int> called boxes.
            * a. The possibleSizes list should contain all possible box sizes. You can assume this list is sorted in descending order.
         * 2. The function should implement a greedy recursive algorithm to fill the room as full as it can get with the least number of boxes, and should store the size of each box used in the boxes list, one entry per box
            * a. For example, if your possible sizes list contained 7, 3, 1, and your roomSize was 25, the boxes list should contain 7, 7, 7, 3, 1 when your function exits
         * 3. Write a unit test and test this function
         */

        public static List<int> FillRoomWithBoxes(int roomSize, List<int> possibleSizes, List<int> boxes)
        {
            //take first element from possible Sizes list  from the roomsize value untill it is not < 0
            //take second element if possible the same way
            //repeat untill possible with all possiblesizes elements
            if(possibleSizes.Count == 0)
            {
                return boxes;
            }
            if(roomSize - possibleSizes[0] < 0)
            {
                return FillRoomWithBoxes(roomSize, possibleSizes.GetRange(1, possibleSizes.Count - 1), boxes);
            }
            else
            {
                roomSize = roomSize - possibleSizes[0];
                boxes.Add(possibleSizes[0]);
                return FillRoomWithBoxes(roomSize, possibleSizes, boxes);
            }


            
        }

    }
}
