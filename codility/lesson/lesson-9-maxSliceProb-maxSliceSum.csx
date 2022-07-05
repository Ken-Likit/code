/*
 * Max Slice Problem - Max Slice Sum
 *
 * https://app.codility.com/programmers/lessons/9-maximum_slice_problem/max_slice_sum/
 * 
 * https://www.martinkysel.com/codility-maxslicesum-solution-2/
 *
 */
class Solution { 
  
  public static int solution(int[] A) {
    
    var maxEndingSum = 0;
    var maxSliceSum = 0;

    // solution 1 - assume min value is zero BAD
    foreach(var a in A) {
      // var prevSum = maxEndingSum;
      var currentSum = maxEndingSum + a;

      maxEndingSum = Math.Max(0, currentSum);
      maxSliceSum = Math.Max(maxSliceSum, maxEndingSum);

      Console.WriteLine($"--> a={a}  currentSum={currentSum}  maxEndingSum={maxEndingSum}  maxSliceSum={maxSliceSum}");
    }
    // return maxSliceSum;


    var len = A.Count();
    var sum = 0;
    var result = 0;

    for (int i = 0; i < len; ++i) {
      sum = 0;
      for (int j = i; j < len; ++j) {
        var newSum = sum + A[j];
        result = Math.Max(result, newSum);
        sum = newSum;

        Console.WriteLine($"--> j={j} newSum={newSum} result={result}");
      }
    }
    return result;
  }

  // Best solution 
  public static int solutionII(int[] A) {
    var max_ending = -1000000;
    var max_slice = -1000000;
    foreach(var a in A) {
      max_ending = Math.Max(a, max_ending + a);
      max_slice = Math.Max(max_slice, max_ending);
    }    
    return max_slice;
  }
}

var array =new int[] { 5, -7, 3, 5, -2, 4, -1 };  // 10 ( 3 + 5 + -2 + 4 )
Console.WriteLine($"\nsolution(array) --> output={Solution.solution(array)}");
Console.WriteLine($"\nsolution(array) --> output={Solution.solutionII(array)}");

array =new int[] { 3, 2, -6, 4, 0 }; // 5
Console.WriteLine($"\nsolution(array) --> output={Solution.solutionII(array)}");

array =new int[] { -2, -4 }; // -2
Console.WriteLine($"\nsolution(array) --> output={Solution.solutionII(array)}");

