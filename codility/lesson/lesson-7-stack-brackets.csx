/*
 * Lessone 7 - Stack & Queue -- Brackets
 *
 * https://app.codility.com/programmers/lessons/7-stacks_and_queues/brackets/
 *
 * https://molchevskyi.medium.com/best-solutions-for-codility-lessons-lesson-6-sorting-770f931b65ad
 *
 * https://molchevskyi.medium.com/best-solutions-for-codility-lessons-lesson-7-stacks-and-queues-ef1415898cb
 *
 */
 class Solution {

  public static int solution(string S) {

    // Assumption:  
    // * there is no other characters than ), ], and }
    bool hasPair(Char c, Stack<char> stack) {
      if (stack.Count() == 0) return false;

      var x = stack.Pop();
      if (x == c) return true;

      return false;
    }

    var len = S.Length;
    var stackChars = new Stack<char>();

    for (int i = 0; i < len; ++i) {
      switch(S[i]) {
        case ')':
          if (hasPair('(', stackChars) == false) return 0;
          break;

        case ']':
          if (hasPair('[', stackChars) == false) return 0;
          break;

        case '}':
          if (hasPair('{', stackChars) == false) return 0;
          break;          

        default:
          stackChars.Push(S[i]);  // only (, [, and { will be in stack
          break;
      }
    }

    // 1: properly nested (has pairs)
    // 0: not nested
    return (stackChars.Count() == 0 ? 1: 0);
  }
}

var str1 = "{[()()]}";  //  1 = property nested
Console.WriteLine($"solution({str1}) --> output={Solution.solution(str1)}");

str1 = "([)()]";  //  0 = not nested
Console.WriteLine($"solution({str1}) --> output={Solution.solution(str1)}");
