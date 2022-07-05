using System.ComponentModel.DataAnnotations;
//
// Lesson 3 - Time Complixity -- TapeEquilibrium
// 
// https://app.codility.com/programmers/lessons/3-time_complexity/tape_equilibrium/
//
// https://molchevskyi.medium.com/best-solutions-for-codility-lessons-lesson-3-time-complexity-f051a8661f90
// 
// RESULT: https://app.codility.com/demo/results/trainingGKVJP2-JX3/  (84%)
// RESULT: https://app.codility.com/demo/results/trainingT9JQ5G-5KK/  (100%)  using IF instead of Math.Min
// 

class Solution { 
  public static int solution(int[] A) 
  {
      // Initial state:
      // Left sum = 0
      // Right sum = sum of all elements
      var leftSum = 0;
      var rightSum = A.Sum();
      var minDiff = Int32.MaxValue;
      Console.WriteLine($"\n--> START  minDiff={minDiff}  leftSum={leftSum}  rightSum={rightSum}");

      for (int i = 1; i < A.Length; ++i) 
      {
          var currentElement = A[i-1];

          leftSum += currentElement;
          rightSum -= currentElement;

          var currentDiff = Math.Abs(leftSum - rightSum);

          Console.WriteLine($"\n--> i={i}  currentVal={currentElement}  leftSum={leftSum}  rightSum={rightSum}");
          Console.WriteLine($"--> currentDiff={currentDiff} minDiff={minDiff}");

          if (currentDiff < minDiff) minDiff = currentDiff;  // 100% correct
        // minDiff = Math.Min(minDiff, currentDiff);             // 82% correct
      }

      return minDiff;
  } 
}

var array = new int[] { 3, 1, 2, 4, 3 };
Console.WriteLine($"solution(array) --> minDiff={Solution.solution(array)}");
