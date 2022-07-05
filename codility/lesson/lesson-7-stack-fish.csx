/*
 * Lesson 7 - Stack and Queue - Fish
 *
 * https://app.codility.com/programmers/lessons/7-stacks_and_queues/fish/
 *
 * https://molchevskyi.medium.com/best-solutions-for-codility-lessons-lesson-7-stacks-and-queues-ef1415898cb
 *
 */

 class Solution { 

   public static int solution(int[] A, int[] B) {

      const int UPSTREAM = 0;  // 0 = upstream, 1 = downstream
      var totalFish = A.Count();
      var aliveFish = 0;
      var stack = new Stack<int>(totalFish);

      for (int i = 0; i < totalFish; ++i) {
        var currentFishSize = A[i];
        var currentFishDirection = B[i];

        if (currentFishDirection == UPSTREAM) { // 0 = UPSTREAM

          // Fish in the stack are those going DOWNSTREAM
          // if the current fish is bigger, it eats one in the stack (pop it out from stack)
          while (stack.Count() != 0 && stack.Peek() < currentFishSize) {
            stack.Pop();
          }

          // if we have no opposite fish which moves downstream 
          // just count our fish and leave it in the stream.
          if (stack.Count() == 0) {
            ++aliveFish; // the current fish added to the count
          }

        } else { // 1 = DOWNSREAM 
            stack.Push(currentFishSize);
        }
      }

      Console.WriteLine($"--> alive fish={aliveFish}  fish in stack={stack.Count()}");
      return aliveFish + stack.Count();
   }
}


var size = new int[]      { 4, 3, 2, 1, 5 };
var direction = new int[] { 0, 1, 0, 0, 0 }; 
Console.WriteLine($"solution(array) --> output={Solution.solution(size, direction)}");
