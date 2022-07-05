/*
 * Lesson 3 - Time Complexity - FrogJump
 *
 * https://app.codility.com/programmers/lessons/3-time_complexity/frog_jmp/
 *
 * https://molchevskyi.medium.com/best-solutions-for-codility-lessons-lesson-3-time-complexity-f051a8661f90
 * 
 * https://app.codility.com/programmers/lessons/3-time_complexity/frog_jmp/
 *
 * RESULT: https://app.codility.com/demo/results/trainingQG8WFT-K4C/ (solutionII below)
 *
 */

 class Solution { 
   public static int solution(int X, int Y, int D) {

    // start (X) and end (Y) are off the same spot, no jump
    if (X >= Y) return 0;

    // Total distance from start --> end
    var length = Y - X;

    // Total jumps from start --> end
    var jumps = length / D;

    // If there is any remainder distance (< D), add one more jump
    if (length % D > 0) { ++jumps; }

     return jumps;
   }


   public static int solutionII(int X, int Y, int D) {
    if (X >= Y) return 0;
    return (int)Math.Ceiling( (Y - X) / Convert.ToDouble(D) );
   }
}

var x = 5;
var y = 17;
var d = 2;

Console.WriteLine($"solution(10, 85, 30) --> jumps={Solution.solution(10, 85, 30)}");
Console.WriteLine($"solution(10, 85, 30) --> jumps={Solution.solutionII(10, 85, 30)}");