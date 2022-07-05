/*
 * Lesson 5 - Parsing car
 *
 *
 *
 *
 *
 */
class Solution { 
  public static int solution(int[] A) {

    var size = A.Count();
    var eastCount = 0;      // 0: going east   1: going west
    var passingCount = 0;

    for (int i = 0; i < size; ++i) {
      if (A[i] == 0) ++eastCount;   // increment those going EAST 
      if (A[i] == 1) {
          passingCount += eastCount;  // one with going WEST will pass all those going EAST
          if (passingCount > 1000000000)
            return -1;
      }
    }
    return passingCount;
  }
}

var array = new int[] {0, 1, 0, 1, 1};
Console.WriteLine($"solution(array) --> output={Solution.solution(array)}");
