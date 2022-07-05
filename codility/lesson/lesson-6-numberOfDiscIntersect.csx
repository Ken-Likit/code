//
// NumberOfDiscIntersections
//
// https://app.codility.com/programmers/lessons/6-sorting/number_of_disc_intersections/
//
// https://molchevskyi.medium.com/best-solutions-for-codility-lessons-lesson-6-sorting-770f931b65ad
//
// http://www.lucainvernizzi.net/blog/2014/11/21/codility-beta-challenge-number-of-disc-intersections/
// 
class Solution { 

  public class Position {
    public Position(int x, int thickNess = 1) {
      X = x;
      Thickness = thickNess;
    }
    public int X { get; set; }
    public int Thickness { get; set; }

    public override string ToString() {
      return $"Position X={X} Thickness={Thickness}";
    }
  }

  public class StartEnd : IComparable<StartEnd> {
    public StartEnd(Position start, Position end) { 
      Start = start;
      End = end;
    }
    public Position Start { get; set; }
    public Position End { get; set; }
    public int CompareTo(StartEnd other)
    {
        if (this.Start.X < other.Start.X) return -1;
        else if (this.Start.X > other.Start.X) return 1;
        else return 0;
    }

    public override string ToString() {
      return $"Start={Start.ToString()} End={End.ToString()}";
    }
  }

  public static int solutionII(int[] A) {
    const int MAX_INTERSECTIONS = 10000000;

    var len = A.Count();
    Console.WriteLine($"--> len={len}");

    var events = new List<StartEnd>(len);
    
    for (int i = 0; i < len; ++i) {
      var radius = A[i];

      var startPos = new Position(i-radius, 1);  // start - thickness of +1
      var endPos = new Position(i+radius, -1);   // end - thickness of -1
      var startEnd = new StartEnd(startPos, endPos);
      
      events.Add(startEnd);
    }

    events.Sort();
    events.ForEach(x => Console.WriteLine(x.ToString()));

    var intersections = 0;
    var active_circles = 0;

    /*
    events.ForEach(e: StartEnd => {
        intersections += active_circles * (e. > 0)
        active_circles += circle_count_delta
    });
    */
    return -1;
  }
  public static int solution(int[] A) {
    const int MAX_INTERSECTIONS = 10000000;

    var len = A.Count();
    Console.WriteLine($"--> len={len}");

    var startCounts = new int[len];
    var endCounts = new int[len];

    for (int i = 0; i < len; ++i) {
      var radius = A[i];
      
      // start has min threshold of 0
      // end has max threshold of len-1
      var start = Math.Max(0, (i - radius));
      var end = Math.Min( (len - 1), (i + radius));

      startCounts[start]++;
      endCounts[end]++;
    }

    int active = 0;         // Number of "active" segments that is segments which intersect at the point i
    int intersections = 0;  // Total number of intersections.

    for (int i = 0; i < len; ++i) {

      /*
      Walk by the array and count the segments which contain the current point “i” on the axis.
      Whenever a new segment starts at location “i”, it intersects with all existing segment (disks) at that location.
      That's why we have “active * start[i]” part in the formula. We also need to add the number of intersections for all
      the segments that just started at location “i”, i.e., the number of intersections within themselves excluding whatever
      already existed “(start[i] * (start[i] - 1)) / 2”.  For example if started 5 segments (disks) in one point,
      it will increased by (1+2+3+4+5 intersections, or 5*(5-1) / 2.
      */
      intersections += (active * startCounts[i]) + (startCounts[i] * (startCounts[i] - 1)) / 2;

      if (intersections > MAX_INTERSECTIONS) {
          return -1;
      }

      active += startCounts[i] - endCounts[i];
    }

    return intersections;
  } 
}

var array =new int[] {  1, 5, 2, 1, 4, 0 };

Console.WriteLine($"solution(array) --> output={Solution.solution(array)}");