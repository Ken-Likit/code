/*
 * stack - Nesting  (not realy need stack actually)
 *
 * https://app.codility.com/programmers/lessons/7-stacks_and_queues/nesting/
 *
 * https://molchevskyi.medium.com/best-solutions-for-codility-lessons-lesson-7-stacks-and-queues-ef1415898cb
 *
 */

 class Solution {
  public static int solution(string S) {

    var len = S.Length;

    if (len == 0) return 1;       // 1 = properly nested; 0 not nested
    if (len % 2 != 0) return 0;   // not properly nested

    var countLeft = 0;

    for (int i = 0; i < len; ++i) {

      if (S[i] == '(') {
        ++countLeft;
      } 
      else if (S[i] == ')') {
        --countLeft;
      } 
      else {
        return 0;  // unexpected character -- not nested
      }

      // special case string = ")(" <-- is this a properly nested pair?
      // if negative at any point in time, that's not properly nested
      if (countLeft < 0) return 0;
    }

    Console.WriteLine($"--> countLeft left = {countLeft}");

    return (countLeft != 0 ? 0 : 1);
  }
}

var str1 = "(()(())())";  //  1 = property nested
Console.WriteLine($"solution({str1}) --> output={Solution.solution(str1)}");

str1 = ")(";  //  0 = property nested
Console.WriteLine($"solution({str1}) --> output={Solution.solution(str1)}");