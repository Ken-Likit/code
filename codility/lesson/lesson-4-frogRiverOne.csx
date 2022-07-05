using System.ComponentModel;

// Lesson 4 - Counting Elements - FrogRiverOne
//
// https://app.codility.com/programmers/lessons/4-counting_elements/frog_river_one/
//
// https://molchevskyi.medium.com/lesson-4-counting-elements-83db29e71786
//
// RESULT: https://app.codility.com/demo/results/trainingPGJGDY-Z59/  (81% failed single element)
//
// RESULT: https://app.codility.com/demo/results/trainingYQMWFE-SCX/ (100%)
//
// 
class Solution {
  /*
  Actually we need to check if given array contains a permuted sequence of elements from 1 to X.
  The elements may repeat. The best way here is use a bit array to index the given array as it
  described in the previous solution and then check if given array is a sequence.

  For example, you are given integer X = 5 and array A such that:
  A[0] = 1
  A[1] = 3
  A[2] = 1
  A[3] = 4
  A[4] = 2
  A[5] = 3
  A[6] = 5
  A[7] = 4
  In second 6, a leaf falls into position 5. 
  This is the earliest time when leaves appear in every position across the river.
  */
  public static int solution(int X, int[] A) {
    var len = A.Count();
    
    if (X > len) return -1;

    if (X == 1 && len == 1 && A[0] != 1) return -1;

    var boolA = new bool[len+1];
    var total = X;

    // i = 0 --> A[0] = 1 --> boolA[1] = true --> total = 4
    // i = 1 --> A[1] = 3 --> boolA[3] = true --> total = 3
    // i = 2 --> A[2] = 1     (already true)
    // i = 3 --> A[3] = 4 --> boolA[4] = true --> total = 2
    // i = 4 --> A[4] = 2 --> boolA[2] = true --> total = 1
    // i = 5 --> A[5] = 3 --> (already true)
    // i = 6 --> A[6] = 5 --> boolA[5] = true --> total = 0  --> return i (6)
    for (int i = 0; i < len; ++i) {
        var currentVal = A[i];

        if (boolA[currentVal] == false) {
            boolA[currentVal] = true;
            --total;

            if (total == 0) return i;
        }
    }

    return -1;
  }
}

var array = new int[] { 1, 3, 1, 4, 2, 3, 5, 4 };
// Console.WriteLine($"solution(5, array) --> result={Solution.solution(5, array)}");


array = new int[] { 3 };
Console.WriteLine($"solution(5, array) --> result={Solution.solution(5, array)}");