/*
  MinAvgTwoSlick

  https://app.codility.com/programmers/lessons/5-prefix_sums/min_avg_two_slice/

  https://molchevskyi.medium.com/best-solutions-for-codility-lessons-lesson-5-prefix-sums-68b716f9d825
 */

 class Solution { 
   public static int solution(int[] A) {

    double sum = (double)(A[0] + A[1]);
    double minAvg = (double)(A[0] + A[1]) / 2.0;
    double avgOfTwo = 0.0;
    double avgWithPrev = 0.0;
    int leftIndex = 0;
    int minLeftIndex = 0;
    double avgHere = 0;

    var size = A.Count();

    for (int i = 2; i < size; ++i) {
      sum += A[i];
      avgWithPrev = (double)sum / (i - leftIndex + 1);
      avgOfTwo = (double)(A[i] + A[i-1]) / 2.0;

      Console.WriteLine($"--> i={i}   A[i]={A[i]}  sum={sum} avgOfTwo={avgOfTwo} avgWithPrev={avgWithPrev} ");

      if (avgOfTwo < avgWithPrev) {
        avgHere = avgOfTwo;
        leftIndex = i - 1;
        sum = A[i] + A[i-1];
      } else {
        avgHere = avgWithPrev;
      }

      if (avgHere < minAvg) {
        minAvg = avgHere;
        minLeftIndex = leftIndex;
      }
    }
     return minLeftIndex;
   }
   
  }


var array = new int[] { 4, 2, 2, 5, 1, 5, 8 };
Console.WriteLine($"solution(array) --> output={Solution.solution(array)}");