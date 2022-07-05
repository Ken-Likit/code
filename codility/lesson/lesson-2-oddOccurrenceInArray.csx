/*
 * Lesson 2 - Odd Occurrence In Array
 *
 * https://app.codility.com/programmers/lessons/2-arrays/odd_occurrences_in_array/
 *
 * https://molchevskyi.medium.com/best-solutions-for-codility-lessons-lesson-2-arrays-5c3e3ee2299c
 *
 * https://codesays.com/2015/solution-to-odd-occurrences-in-array-by-codility/
 *
 *
 * RESULT :https://app.codility.com/demo/results/trainingRC8GTJ-83C/
 *
 */

 class Solution { 
  public static int solution(int[] A) {

    // Assumptions
    // * array length is an odd number
    // * there is only one element that has NO pair
    var len = A.Count();
    var output = 0;

    // XOR
    // N XOR N  --> 0
    // N XOR 0  --> N 
    for (int i = 0; i < len; ++i) {
      output ^= A[i];
    }
    return output;
  }
}
 var array = new int[] { 9, 3, 9, 3, 9, 7, 9 };  // 7
Console.WriteLine($"solution(array) --> output={Solution.solution(array)}");

array = new int[] { 1, 5, 1, 3 };  // 5
Console.WriteLine($"solution(array) --> output={Solution.solution(array)}");