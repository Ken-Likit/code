/*
  https://app.codility.com/programmers/lessons/6-sorting/distinct/
 */

class Solution { 
  public static int solution(int[] A) {
    Array.Sort(A);

    var sortedADistinct = A.Distinct().ToArray();
    Console.WriteLine(String.Join(",", sortedADistinct));
    
    return A.Distinct().ToArray().Count();
  }
}

var array = new int[] { 4, 2, 2, 5, 1, 5, 8 };
Console.WriteLine($"solution(array) --> output={Solution.solution(array)}");