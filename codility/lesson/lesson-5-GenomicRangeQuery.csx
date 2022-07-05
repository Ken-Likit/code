class Solution { 
  public struct Counters {
    public Counters(int a = 0, int c = 0, int g = 0, int t = 0) {
      A = a;
      C = c;
      G = g;
      T = t;
    }

    public int A { get; set; }
    public int C { get; set; }
    public int G { get; set; }
    public int T { get; set; }

    public override string ToString() {
      return $"Counters A={A} C={C} G={G} T={T}";
    }
  }
    
  public enum Factors: int{ A = 1, C = 2, G = 3, T = 4 };

  public static int[] solution(string S, int[] P, int[] Q) {

    var dnaLength = S.Length;
    var result = new int[P.Length];

    Console.WriteLine($"--> dnaLength={dnaLength}  result={result.Count()}");
    
    var cummulativeSums = new List<Counters>(dnaLength);
    var globalCounters = new Counters();

    for (int i = 0; i < dnaLength; ++i) {

      // Each position at dna sequence, there is a counter of factors
      // Ex: S = CAGCCTA
      // C 
      // A
      // G
      // C
      // C
      // T
      // A
      switch(S[i]) {
        case 'A': { globalCounters.A++; break; }
        case 'C': { globalCounters.C++; break; }
        case 'G': { globalCounters.G++; break; }
        case 'T': { globalCounters.T++; break; }
      }

      //var iCounters = new Counters();
      // iCounters = globalCounters;
      // cummulativeSums.Add(iCounters);

      // Add the "current" "globalCounts" at position "i"
      cummulativeSums.Add(globalCounters);
    }

    cummulativeSums.ForEach(x => Console.WriteLine(x.ToString()));
    Console.WriteLine($"--> cummulativeSums.size = {cummulativeSums.Count}");


    for (int i = 0; i < P.Length; ++i) {
      var from = P[i];
      var to = Q[i];

      Console.WriteLine($"--> i={i}  from={from}  to={to}");

      var counterAtTo = cummulativeSums.ElementAt(to);
      var counterAtFrom = cummulativeSums.ElementAt(from);

      Console.WriteLine($"--> counterAtTo=${counterAtTo} ");
      Console.WriteLine($"--> counterAtFrom=${counterAtFrom} ");
      
      Console.WriteLine($"--> (int)Factors.A={(int)Factors.A} ");

      if (cummulativeSums.ElementAt(to).A - cummulativeSums.ElementAt(from).A > 0) {
          result[i] = (int)Factors.A;
      }
      else if (cummulativeSums[to].C - cummulativeSums[from].C > 0) {
          result[i] = (int)Factors.C;
      }
      else if (cummulativeSums[to].G - cummulativeSums[from].G > 0) {
          result[i] = (int)Factors.G;
      }     
      else if (cummulativeSums[to].T - cummulativeSums[from].T > 0) 
          result[i] = (int)Factors.T;
      else {
        // that means from and to are of the same position
        if (cummulativeSums[from].A > 0) result[i] = (int)Factors.A;
        else if (cummulativeSums[from].C > 0) result[i] = (int)Factors.C;
        else if (cummulativeSums[from].G > 0) result[i] = (int)Factors.G;
        else result[i] = (int)Factors.T;
        
      }
    }


    Console.WriteLine(String.Join(",", result));
    return result.ToArray();
  }
}

var S = "CAGCCTA";
var P = new int[] { 2, 5, 0 };
var Q = new int[] { 4, 5, 6 };

// Console.WriteLine($"solution(array) --> output={Solution.solution(S, P, Q)}");

S = "A";
P = new int[] { 0 };
Q = new int[] { 0 };
// Console.WriteLine($"solution(array) --> output={Solution.solution(S, P, Q)}");

S = "AA";
P = new int[] { 0, 1 };
Q = new int[] { 1, 1 };
Console.WriteLine($"solution(array) --> output={Solution.solution(S, P, Q)}");