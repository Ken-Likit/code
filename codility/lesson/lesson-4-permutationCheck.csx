/*
  PermCheck = Permutation Check

  See codility-2 (OddOccurrencesInArray)

  https://app.codility.com/programmers/lessons/4-counting_elements/perm_check/
  https://molchevskyi.medium.com/lesson-4-counting-elements-83db29e71786

  A non-empty array A consisting of N integers is given.
  A permutation is a sequence containing each element from 1 to N once, and only once.

  For example, array A such that:
      A[0] = 4
      A[1] = 1
      A[2] = 3
      A[3] = 2
  is a permutation, but array A such that:
      A[0] = 4
      A[1] = 1
      A[2] = 3
  is not a permutation, because value 2 is missing.

  The goal is to check whether array A is a permutation.

  Write a function:
  object Solution { def solution(a: Array[Int]): Int }
  that, given an array A, returns 1 if array A is a permutation and 0 if it is not.

  For example, given array A such that:
      A[0] = 4
      A[1] = 1
      A[2] = 3
      A[3] = 2
  the function should return 1.

  Given array A such that:
      A[0] = 4
      A[1] = 1
      A[2] = 3
  the function should return 0.

  Write an efficient algorithm for the following assumptions:

  N is an integer within the range [1..100,000];
  each element of array A is an integer within the range [1..1,000,000,000].

*/
class Solution { 
  public static int solution(int[] A) 
  {
    // Notes;
    // At index  Index+1    Value 
    // ========  =======    =====   
    // 0         1          1     0000 0001
    // 1         2          2     0000 0010
    // 2         3          3     0000 0011
    // 3         4          4     0000 0100
 
    var len = A.Count();
    var xorSum = 0;
    for (int i = 0; i < len; ++i) {
      xorSum = (xorSum ^ (i+1)) ^ A[i];
    }

    // returns 1 if array A is a permutation and 0 if it is not.
    return xorSum == 0 ? 1 : 0;
  }

  // Handle array that looks like [4, 6, 7]; i.e. sequence numbers but not started with 1 but 4
  public static int solutionII(int[] A) 
  {
    Array.Sort(A);
    var min = A.Min();
    // if (min != 1) return 0;  // if Expected the first element to start at 1
    // var max = A.Max();

    var xorSum = 0;
    for (int i = 0; i < A.Count(); ++i)
    {
      xorSum = (xorSum ^ (i+min)) ^ A[i];
    }

    // returns 1 if array A is a permutation and 0 if it is not.
    return xorSum == 0 ? 1 : 0;
  }
}

var array = new int[] { 1, 2, 4, 3 };
Console.WriteLine($"solution(array) --> result={Solution.solution(array)}");

// SolutionII
array = new int[] { 4, 7, 5, 6, 3 };
Console.WriteLine($"solution(array) --> result={Solution.solutionII(array)}");

array = new int[] { 4, 7, 5, 4 };
Console.WriteLine($"solution(array) --> result={Solution.solutionII(array)}");
