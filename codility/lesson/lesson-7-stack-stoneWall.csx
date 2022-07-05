/*
 * Lesson 7 - Stack & Queue - StoneWall
 *
 * https://app.codility.com/programmers/lessons/7-stacks_and_queues/stone_wall/
 *
 * https://molchevskyi.medium.com/best-solutions-for-codility-lessons-lesson-7-stacks-and-queues-ef1415898cb
 *
 */

 class Solution { 

   public int solution(int[] H) {

    var len = H.Count();
    var stack = new Stack<int>(len);
    var totalBlocks = 0;

    for (int i = 0; i < len; ++i) {

      var currentHeight = H[i];

      while (stack.Count() != 0 && currentHeight < stack.Peek()) {
        stack.Pop();
      }

      if (stack.Count() != 0 && currentHeight == stack.Peek()) {
        continue;  // same block as the previous  
      }

      ++totalBlocks;
       
       stack.Push(currentHeight);
     }

     return totalBlocks;
   }
 
}


var array =new int[] {  8, 8, 5, 7, 9, 8, 7, 4, 8 };
Console.WriteLine($"solution(array) --> output={Solution.solution(array)}");