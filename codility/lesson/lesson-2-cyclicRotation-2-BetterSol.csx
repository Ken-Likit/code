using System.ComponentModel;
/*
 * Lesson 2 - Cyclic Rotation (a better solution)
 *
 * https://app.codility.com/programmers/lessons/2-arrays/cyclic_rotation/
 *
 * https://codesays.com/2016/solution-to-cyclic-rotation-by-codility/
 */

 class Solution { 
   
   public static int[] solution(int[] A, int K) {

      var len = A.Count();

      // Nothing to do, return the original array
      if (len == 0 || K == 0) return A;

      // Output array
      var output = new int[len];

      // the number of elements to be shifted
      // K < len  --> K
      // K == len --> 0; no shift
      // K > len  --> basically shift K % len
      var shiftDistance = K % len;

      for (var i = 0; i < len; ++i) {

        // when true: start rotate the chunk from the beginning till all shiftDistance done
        // when false: start moving from the beginning of the original array and append it to the result 
        if (i < shiftDistance)
            output[i] = A[ (len - shiftDistance) + i ];
        else
            output[i] = A [ System.Math.Abs( shiftDistance-i )];
      }

      return output;
   }
}