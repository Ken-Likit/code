/*
 * Leader 8 - Equi Leader
 *
 * https://app.codility.com/programmers/lessons/8-leader/equi_leader/
 *
 * https://www.martinkysel.com/codility-equileader-solution/
 *
 * RESULT: https://app.codility.com/demo/results/trainingTPF4JA-8CD/  solution II (100%)
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

    // DEBUG: To confirm if the leader is correctly, using linq instead
    /*
    var dominant = A
    .GroupBy(e => e)
    .Where(e => e.Count() > Math.Ceiling((decimal)len/2))
    .Select(e => e.FirstOrDefault());

    Console.WriteLine($"--> dominant={dominant.SingleOrDefault()}");
    */

    // Identify candidate if this is the leader
    var candidate = stack.Peek();
    var candidateCount = A.Count(i => i == candidate);
    var leader = (candidateCount > threshold) ? candidate : -1;
    Console.WriteLine($"--> candidate={candidate}  candidateCount={candidateCount}  threshold={threshold}  leader={leader}");

    //-----------------------------------------------------------------
    // 2. Count the number of equileaders
    //-----------------------------------------------------------------
    int leftPartition = 0;
    int rightPartition = candidateCount;
    int numberEquiLeaders = 0;

    for (int i = 0; i < len; ++i) {
        Console.WriteLine($"\n--> i={i}  A[i]={A[i]}  leader={leader}");

        if (A[i] == leader) {
          ++leftPartition;
          --rightPartition;
        
          var threshold1 = Math.Floor((double)(i+1)/2);     // lenth of left partition / 2
          var threshold2 = Math.Floor((double)(len-1-i)/2);   // length of right partition / 2 

          Console.WriteLine($"--> leftPartition={leftPartition}    threshold1={threshold1} ");
          Console.WriteLine($"--> rightPartition={rightPartition}  threshold2={threshold2}");

          if (leftPartition > threshold1 && rightPartition > threshold2) {
              ++numberEquiLeaders;
              Console.WriteLine($"--> numberEquiLeaders={numberEquiLeaders}");            
          }
        }
    }
    return numberEquiLeaders; // number of the equileaders (NOT THE INDEX)
  }

  public static int solutionII(int[] A) {

      //----------------------------------------------
      // 1. Find the leader
      //----------------------------------------------
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

      if (dominatorIdx == -1) return 0;

      var leader = A[dominatorIdx];

      //----------------------------------------------
      // 2. Find number of equi leaders
      //----------------------------------------------
      int leaderCount = dict[leader];

      // avoid searching if it's not a leader
      if (leaderCount < len/2) return 0;
            
        // search equi
        int currentLeaderCount = 0;
        int equi = 0;

        for (int i = 0; i < len; ++i) {

          if (A[i] == leader) {
            ++currentLeaderCount;
          }
          // the current leader count is > half of the so far slice 0 -> i AND
          // the number of leader count in the 2nd half is > half of the second slice
          if (currentLeaderCount > (i+1)/2  && 
              leaderCount - currentLeaderCount > (len-i-1)/2) {
            ++equi;
          }
        }  
        return equi;

  }
}

var array =new int[] { 6, 8, 4, 6, 8, 6, 6 };

array =new int[] { 4, 3, 4, 4, 4, 2 };  
Console.WriteLine($"solution(array) --> output={Solution.solution(array)}");


