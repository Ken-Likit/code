//
// Lesson 4 - Counting Elements - Max Counter
//
// https://app.codility.com/programmers/lessons/4-counting_elements/max_counters/
// 
// Task 3: https://molchevskyi.medium.com/lesson-4-counting-elements-83db29e71786
//
// https://codesays.com/2014/solution-to-max-counters-by-codility/
// https://app.codility.com/demo/results/demoDEYNRS-38A/  88% (key)
//
// RESULT: https://app.codility.com/demo/results/trainingTZWRBH-SAU/    77%
//
class Solution { 
  public static int[] solution(int N, int[] A)
   {
      Console.WriteLine("--> A = " + String.Join(", ", A));

      var len = A.Count();
      var counters = new int[N];

      // Ensure they are all zeroes
      Array.Clear(counters, 0, counters.Length);
      Console.WriteLine("--> counters = " + String.Join(", ", counters));

      for (int i = 0; i < len; ++i) {

        var currentVal = A[i];

        if (currentVal >= 1 && currentVal <= N) {
          ++counters[currentVal - 1];

        } else if (currentVal == N + 1) {
          var currentMax = counters.Max();
          Array.Fill(counters, currentMax);
          // Array.ConvertAll(counters, x => currentMax);
        }
      }

      Console.WriteLine("--> OUTPUT counters = " + String.Join(", ", counters));
      return counters;
   }


   public static int[] solutionII(int N, int[] A) {

      int[] counters = new int[N];

      var len = A.Count();
      int max = 0;
      int absMax = 0;

      for (int i = 0; i < len; i++) {

        // Rules:
        // case A: if A[K] = X, 1 ≤ X ≤ N,  --> operation K is increase(X),
        // case B: if A[K] = N + 1          --> operation K is --> max counter.

          if (A[i] == N+1) {
            // case B
            // i is the last element of A OR
            // i is BEFORE the one before the last and its value is NOT
            if  ((i == len-1) || (i < len-1 && A[i+1] != N+1)) {
                absMax += max;
                max = 0;
                counters = new int[N];  // reset all counters to zero while keeping absMax
            }
          } else {
            // Case A
            var at = A[i]-1;
            counters[at]++;
            if (max < counters[at]) max = counters[at];  // Save max if there is new max
          }
      }

      for (int i  =0; i < counters.Count(); i++)
          counters[i] += absMax;

      return counters;
   }
  
  public static int[] solutionIII(int N, int[] A) {  // best solution 77 %

    var len = A.Count();

    var counters = new int[N];
    var maxVal = 0;
    var maxChanged = false;
    
    for (int i = 0; i < len; ++i) {
      var X = A[i];
      var x = X - 1;  // Position of X at the counter; i.e. X - 1

      if (X >= 1 && X <= N) {
        counters[x] += 1;
        if (counters[x] > maxVal) {
          maxVal = counters[x];
          maxChanged = true;
        }
      } else if (maxChanged) {   // Assumption X != 0 and here would be N + 1
        // Array.Fill(counters, maxVal);
        counters = Enumerable.Range(0, N).Select(n => maxVal).ToArray();
      }
    }
 
    return counters;
  }
}

var array = new int[] { 3, 4, 4, 6, 1, 4, 4 };

Console.WriteLine($"solution(5, array) --> result={Solution.solution(5, array)}");