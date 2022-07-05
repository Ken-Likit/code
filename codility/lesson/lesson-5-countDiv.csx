/*
  CountDiv
  https://molchevskyi.medium.com/best-solutions-for-codility-lessons-lesson-5-prefix-sums-68b716f9d825

  https://app.codility.com/programmers/lessons/5-prefix_sums/count_div/

*/

class Solution { 
  public static int solution(int A, int B, int K) {
      var divisibleByBCount = B / K;
      var divisibleByBeforeACount = A - 1 / K;
      return divisibleByBCount - divisibleByBeforeACount;
    }
  }

  Console.WriteLine($"solution(0, 0, 11) --> output={Solution.solution(0, 0, 11)}");
  