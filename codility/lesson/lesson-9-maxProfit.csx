/*
 * Max Profit
 *
 * https://app.codility.com/programmers/lessons/9-maximum_slice_problem/max_profit/
 *
 *
 * https://www.martinkysel.com/codility-maxprofit-solution/
 *
 */
 class Solution { 
   public static int solution(int[] A) {
      var len = A.Count();
      var maxProfit = 0;
      var minPrice = 200000;

      for (var i = 0; i < len; ++i) {
        minPrice = Math.Min(minPrice, A[i]);
        maxProfit = Math.Max(maxProfit, A[i] - minPrice);
      }
      return maxProfit;
   }
}

var array =new int[] { 23171, 21011, 21123, 21366, 21013, 21367 };  //17var var 
Console.WriteLine($"\nsolution(array) --> output={Solution.solution(array)}");