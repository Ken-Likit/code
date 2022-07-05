/*
 * Triangle
 *
 * https://app.codility.com/programmers/lessons/6-sorting/triangle/
 *
 * https://molchevskyi.medium.com/best-solutions-for-codility-lessons-lesson-6-sorting-770f931b65ad
 */

 class Solution { 
   public static int solution(int[] A) {

    var len = A.Count();

    Array.Sort(A);

    Console.WriteLine(String.Join(", ", A));
    
    // Just need to ensure A[P] + A[Q] > A[R]
    // OR A[P] > A[R] - A[Q]
    for (int i = 2; i < len; ++i) {

      var P = i - 2;
      var Q = i - 1;
      var R = i;

      if (A[P] > A[R] - A[Q]) {
        Console.WriteLine($"--> P={P}  Q={Q}  R={R}");
        Console.WriteLine($"--> A[P]={A[P]}  A[Q]={A[Q]}  A[R]={A[R]}");
        return 1;  // Found triangle
      }
    }

    return 0;
   }
}

var array =new int[] {  10, 2, 5, 1, 8, 20 };
Console.WriteLine($"solution(array) --> output={Solution.solution(array)}");

array =new int[] {  10, 50, 5, 1 };
Console.WriteLine($"solution(array) --> output={Solution.solution(array)}");