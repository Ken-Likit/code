/*
 * Max Slice Problem - Max Slice Sum  100%
 *
 * https://app.codility.com/programmers/lessons/9-maximum_slice_problem/max_double_slice_sum/
 * 
 * https://www.martinkysel.com/codility-maxdoubleslicesum-solution/
 *
 * RESULT: https://app.codility.com/demo/results/trainingK2SR5S-Y7M/   100% correct
 *
 * https://rafal.io/posts/codility-max-double-slice-sum.html (explanation)

    A[0] = 3
    A[1] = 2
    A[2] = 6
    A[3] = -1
    A[4] = 4
    A[5] = 5
    A[6] = -1
    A[7] = 2
contains the following example double slices:

double slice (0, 3, 6), sum is 2 + 6 + 4 + 5 = 17,       <-- index: 1(0+1) -> 2(3-1) / 4(3+1) -> 5(6-1)
double slice (0, 3, 7), sum is 2 + 6 + 4 + 5 − 1 = 16,   <-- index: 1(0+1) -> 2(3-1) / 4(3+1) -> k(6-1)
double slice (3, 4, 5), sum is 0.                        <-- index: 1(0+1) -> 2(3-1) / 4(3+1) -> k(6-1)
 */
class Solution { 

  public static int solutionMaxSlice(int[] A) {
    var max_ending = -1000000;
    var max_slice = -1000000;
    
    foreach(var a in A) {
      max_ending = Math.Max(a, max_ending + a);
      max_slice = Math.Max(max_slice, max_ending);
    }    
    return max_slice;
  }

  public static int solution(int[] A) {

    const int MINVAL = 0;

    var len = A.Count();
    int[] leftSlice = new int[len];
    int[] rightSlice = new int[len];
    
    Console.WriteLine("--> A:" + String.Join(", ", A) + $"  len={len}");
    /*
    Console.WriteLine("--> leftSlice:" + String.Join(", ", leftSlice));
    Console.WriteLine("--> rightSlice:" + String.Join(", ", rightSlice));
    */

    // 0 < P < Q < R < N
    // index is never at 0 len-1
    // as 0 = index 0+1 =1
    for (int i = 1; i < len-1; ++i) {
      //Console.WriteLine($"--> i={i}  leftSlice.size={leftSlice.Count()}");
      leftSlice[i] = Math.Max(leftSlice[i-1]+A[i], MINVAL);
    }
    Console.WriteLine("--> leftSlice:" + String.Join(", ", leftSlice));

    for (int i = len-2; i > 0; i--){
      //Console.WriteLine($"--> i={i}  rightSlice.size={rightSlice.Count()}");
      rightSlice[i] = Math.Max(rightSlice[i+1]+A[i], MINVAL);
    }
    Console.WriteLine("--> rightSlice:" + String.Join(", ", rightSlice));

    var max = 0;
    for (int i = 1; i < len-1; ++i) {
      max = Math.Max((leftSlice[i-1]+rightSlice[i+1]), max);
    }
    return max;
  }
 
  // 100% correct here
  public static int solutionJava(int[] A) {

      const int MINVAL = 0;

      int N = A.Count();
      int[] K1 = new int[N];
      int[] K2 = new int[N];

      for(int i = 1; i < N-1; i++){
        K1[i] = Math.Max(K1[i-1] + A[i], MINVAL);
      }
      for(int i = N-2; i > 0; i--){
        K2[i] = Math.Max(K2[i+1]+A[i], MINVAL);
      }

      int max = MINVAL;
      for(int i = 1; i < N-1; i++){
        max = Math.Max(max, K1[i-1]+K2[i+1]);
      }

      return max;
  }
}

var array =new int[] { 3, 2, 6, -1, 4, 5, -1, 2 };  //17var var 
Console.WriteLine($"\nsolution(array) --> output={Solution.solution(array)}");
Console.WriteLine($"\nsolution(array) --> output={Solution.solutionJava(array)}");

/*
Console.WriteLine($"\nsolution(array) --> output={Solution.solution(array)}");

array =new int[] { 3, 2, -6, 4, 0 }; // 5
Console.WriteLine($"\nsolution(array) --> output={Solution.solution(array)}");

array =new int[] { -2, -4 }; // -2
Console.WriteLine($"\nsolution(array) --> output={Solution.solution(array)}");
*/