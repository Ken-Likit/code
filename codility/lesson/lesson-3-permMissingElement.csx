/*
 * Lesson 3 - Time Complexity - Perm Missing Element
 *
 *  https://app.codility.com/programmers/lessons/3-time_complexity/perm_missing_elem/
 *
 *  https://molchevskyi.medium.com/best-solutions-for-codility-lessons-lesson-3-time-complexity-f051a8661f90
 * 
 * RESULT :https://app.codility.com/demo/results/trainingXQABGM-EZ7/  (70% - Failed runtime large ranges)
 * 
 * RESULT: https://app.codility.com/demo/results/trainingCUQBWB-RG2/  (100%) using XOR method
 */

 class Solution { 

    // Here is an example of the calculation:
    // Lets say we have a sequence from 1 to 4 without one element [1,2,4].
    // We need to find the missing element.
    // 
    // * Sum of all elements of the full sequence 1..4 = (4 * (1 + 4)) / 2 = 20 / 2 = 10 <-- (N * (N+1))/2
    // * Then calculate sum of elements in the given array [1,2,4] = 1+2+4 = 7
    // * The missing element is 10–7 = 3
   public static int solution(int[] A) 
   {
     /*
     // Neutralize, ensure sorted 
      var max = A.Max();
      var min = A.Min();

      Console.WriteLine("\nBEFORE sort " + String.Join(", ", A));
      Console.WriteLine($"--> min={min}  max={max}");

      Array.Sort(A);
      Console.WriteLine("\nAFTER sort " + String.Join(", ", A));
      */

      // 1. Sum of elements of FULL sequence --> N * (N+1) / 2
      var arraySize = A.Count();
      var N = arraySize + 1;
      var sumFullElements = ( N * (N+1) ) / 2;

      // 2. Sum of all elements in the array
      var sumElements = A.Sum();

      // 3. Misising element/number
      var missingElement = sumFullElements - sumElements;

     return missingElement;
   }

    // Probably non-overlow solution from Sheng
    // https://codesays.com/2014/solution-to-perm-missing-elem-by-codility/
    public static int solutionII(int[] A) {
      var len = A.Count();
      var result = 0;

      // N = 4 (len) --> N + 1 = 5
      //
      // i    A[i]  --> result
      // 0    1         0 ^ 1 ^ 1   --> 0
      // 1    2         0 ^ 2 ^ 2   --> 0
      // 2    3         0 ^ 3 ^ 3   --> 0
      //   (4 is missing)
      // 3    5         0 ^ 5 ^ 4   --> 1 * * *
      // 
      // (out of for loop)
      // 
      // ( 1 ^ 5) --> 4
      for (int i = 0; i < len; ++i) {
        result = result ^ A[i] ^ (i+1);
      }

      result ^= len + 1;  // N + 1

      return result;
    }
}

var array = new int[] {1, 2, 3, 5};
Console.WriteLine($"solution(array) --> output={Solution.solution(array)}");
Console.WriteLine($"solution(array) --> output={Solution.solutionII(array)}");


