/*
 * Lesson 10 - Prime and composite numbers
 * 
 * Count factors
 *
 * https://app.codility.com/programmers/lessons/10-prime_and_composite_numbers/count_factors/
 * https://codility.com/media/train/8-PrimeNumbers.pdf
 *
 *  https://www.martinkysel.com/codility-count-factors-solution/
 */

 class Solution { 
   public static int solution(int N) {
    var i = 1;
    var result = 0;

    while (i*i < N) {
      if (N % i == 0) {
        result += 2;
      }
      ++i;
    }

    if (i*i == N) {
       result += 1;
    }

    return result;
  }
}

Console.WriteLine($"\nsolution(array) --> output={Solution.solution(24)}");