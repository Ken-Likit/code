/*
 * Lesson 4 - Counting Elements - Missing integer
 *
 * https://www.martinkysel.com/codility-missinginteger-solution/
 * 
 * https://codesays.com/2014/solution-to-missing-integer-by-codility/
 * 
 * RESULT: https://app.codility.com/demo/results/trainingKQCNV3-Y9M/ (100%)
*/
static int smallestInt(int[] A)
{
  Array.Sort<int>(A);
  int min = 1;

  Console.WriteLine(String.Join(", ", A));

  for (int i = 0; i < A.Length; i++)
  {
    int currVal = A[i];
    
    if (currVal > 0) 
    {
      min = (currVal != min) ? min : min + 1;
    }
  }
  return min;

}

class Solution { 
  public int solution(int[] A) {    // Best solution 100%
    var len = A.Count();
    var occurrence = new bool[len+1];

    // We only care about the first N+1 positive integers.
    for (int i = 0; i < len; ++i) {

      var currentVal = A[i];  // Assumption: 1 <= currentVal <= N+1

      if (currentVal >= 1 && currentVal <= len+1) {
        occurrence[currentVal-1] = true;
      }
    }

    for (int i = 0; i < occurrence.Count(); ++i) {
      if (occurrence[i] == false) return i+1;
    }

    return -1; // should never be here
  }
}

var array = new int[] {4, 3, 2, 1, 6, 4};
Console.WriteLine($"solution(array) --> output={smallestInt(array)}");