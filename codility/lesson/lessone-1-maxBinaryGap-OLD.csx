using System.ComponentModel;

/* 
 * OddOccurrences
 *
 * Find the max number of 0's b/w any 1's
 * https://app.codility.com/programmers/lessons/2-arrays/odd_occurrences_in_array/
*/
var arrayA = new int[] { 2, 3, 4 };

foreach(var i in arrayA) {
  Console.WriteLine(i);
}
Console.WriteLine($"--> array size={arrayA.Length}");


// Reverse string
{
  String reverseString(String inStr) {
    var charArray = inStr.ToCharArray();
    var outCharArray = charArray.Reverse();
    return new string(outCharArray.ToArray());
  }
  var inStr = "Hello World";
  var outStr = reverseString(inStr);

  Console.WriteLine($"--> inString={inStr}  outStr={outStr}");
}

// Max seq of 0's b/w 1's
{
  string convertInt32ToBignary(uint N) {
    return Convert.ToString(N, 2).PadLeft(32, '0'); // Assuming we are working on 32-bit int
  }

  // Then interate through the string, and find the max zero between 1's, starting from the right most
  // ..

  int max_gap(uint N) {
    var n = N;
    int max = 0;
    int count = 0;
  
    // 0000 0000
    // 0000 0001
    // 0000 0011
    // 0000 0100
    // 0000 0101  starting at 5, max is 1
    if (n <= 4) return 0;

    // %0 == 0 means this is an even number, the first bit is zero
    // /2 means shifting one bit to the right
    // Ex: n = 2503   --> 0000 1001 1100 0111
    //     n/2 1251   --> 0000 0100 1110 0011
    //      /2 625    --> 0000 0010 0111 0001
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
      // if the first bit of the N is 1 it means we reached the end of the current gap
      if (n % 2 == 1) {
        if (count > max) { max = count; }
        count = 0;
      } else {
        // if the first bit of the N is 0 just count the current bit to the current gap
        ++count;
      }
      n /= 2;
    }
    return max;
  }

  uint testNumber = 2503; // 1041;
  var testBinary = convertInt32ToBignary(testNumber);
  var testOne = max_gap(testNumber);
  Console.WriteLine($"--> testNumber={testNumber}  inBiary={testBinary}  maxBinGap={testOne}");
}