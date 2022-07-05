using System.Dynamic;
/*
 * Leader 8 - Equi Leader
 *
 * https://app.codility.com/programmers/lessons/8-leader/equi_leader/
 *
 * https://www.martinkysel.com/codility-equileader-solution/
 *
 * RESULT: https://app.codility.com/demo/results/trainingNPX83E-JEE/  (100%)  solution II
 */

 class Solution { 
  public static int solution(int[] A) {

    var len = A.Count();
    var sortedA = (int[])A.Clone();

    Array.Sort(sortedA);

    Console.WriteLine(String.Join(", ", A));
    Console.WriteLine(String.Join(", ", sortedA));

    var stack = new Stack<int>(len);

    //-----------------------------------------------------------------
    // 1. Find the Leader
    //-----------------------------------------------------------------
    for (int i = 0; i < len; ++i) {
      var currentVal = sortedA[i];

      var stackCount = stack.Count();
      var isStackEmpty = stackCount == 0;

      if (!isStackEmpty) {
        if (stack.Peek() != currentVal) {
          stack.Pop();
          continue;
        }
      }
      stack.Push(currentVal);
    }

    var threshold = Math.Floor((decimal)len/2);
    Console.WriteLine($"--> stackCount={stack.Count()}  stackPeek={stack.Peek()}  threshold={threshold}");

    //foreach(int stackVal in stack) {
    //  Console.WriteLine($"--> stackVal={stackVal}");
    //}

    // Identify candidate if this is the leader
    var candidate = stack.Peek();
    var candidateCount = A.Count(i => i == candidate);
    var leader = (candidateCount > threshold) ? candidate : -1;
    Console.WriteLine($"--> candidate={candidate}  candidateCount={candidateCount}  threshold={threshold}  leader={leader}");


    // return the index of the leader
    var index = Array.FindIndex(A, i => i == leader);
    Console.WriteLine($"--> index={index}");

    return index;
  }


  // https://codesays.com/2014/solution-to-dominator-by-codility/  
  // https://app.codility.com/demo/results/trainingNPX83E-JEE/  100%
    public static int solutionII(int[] A) {
      
      var dict = new Dictionary<int, int>();
      var len = A.Count();
      int half = len/2;
      int dominatorNumOccurs = 0;
      int dominatorIdx = -1;

      for (int i = 0; i < len; i++) {
          int num = A[i];
          int occurs = 1;

          if (dict.ContainsKey(num)) {
              occurs = dict[num] + 1;
              dict[num] = occurs;
          } else {
            dict.Add(num, occurs);
          }

          if (occurs > half && occurs > dominatorNumOccurs){
              dominatorIdx = i;
              dominatorNumOccurs = occurs;
          }
      }
      return dominatorIdx;
  }
}

var array =new int[] { 6, 8, 4, 6, 8, 6, 6 };
Console.WriteLine($"\nsolution(array) --> output={Solution.solution(array)}");
Console.WriteLine($"\nsolution(array) --> output={Solution.solutionII(array)}");

/*
array =new int[] { 4, 3, 4, 4, 4, 2 };  
Console.WriteLine($"\nsolution(array) --> output={Solution.solution(array)}");

array =new int[] { 3, 4, 3, 2, 3, -1, 3, 3 };  
Console.WriteLine($"\nsolution(array) --> output={Solution.solution(array)}");


array =new int[] { -1, -2, 3, 3, -1, 3, 4, 3, 3 };  
Console.WriteLine($"\nsolution(array) --> output={Solution.solution(array)}");
*/