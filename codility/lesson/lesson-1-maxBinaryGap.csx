/*
 *
 *
 */


 class Solution { 
   public static int solution(int N) {

    Console.WriteLine($"--> solution({N}) binary=" + Convert.ToString(N, 2));

    var n = N;
    int max = 0;
    int count = 0;
  
    // 0000 0000  0
    // 0000 0001  1
    // 0000 0010  2
    // 0000 0011  3
    // 0000 0100  4
    // 0000 0101  starting at 5, max is 1
    if (n <= 4) return 0;    // return 0 if the binary does NOT contain binary gap

    // %0 == 0 means this is an even number, the first bit is zero
    // /2 means shifting one bit to the right
    // Ex: n = 2503   --> 0000 1001 1100 0111
    //     n/2 1251   --> 0000 0100 1110 0011
    //      /2 625    --> 0000 0010 0111 0001  <-- ..1 0001
    //      /2 312    --> 0000 0001 0011 1000  1
    //      /2 156    --> 0000 0000 1001 1100  2
    //      /2 78     --> 0000 0000 0100 1110  3
    //      /2 39     --> 0000 0000 0010 0111  count > max =>, max = 3, reset count to zero
    //
    // Division of N by 2 do the same as right shift operation that is move all the bits right to one position, 
    // but integer division operation exists in all programming languages when bit shift operations usually have
    // low level languages only so division by 2 is more general solution.
    // 
    // Thus this line means "repeat while the first bit is 0 right shift all the bits to one position.
    while (n % 2 == 0) {
      n /= 2;
    }

    while (n > 0) {
      Console.WriteLine($"\n[1]  n={n}");

      // if the first bit of the N is 1 it means we reached the end of the current gap
      if (n % 2 == 1) {
        if (count > max) { max = count; }
        count = 0;
        Console.WriteLine($"[2]  count={count} max={max}");

      } else {
        // if the first bit of the N is 0 just count the current bit to the current gap
        ++count;
        Console.WriteLine($"[3]  count={count} max={max}");
      }

      n /= 2;
    }
    return max;
  }
}

// Testing
var N = 5;
Console.WriteLine($"solution(array) --> output={Solution.solution(N)}");
