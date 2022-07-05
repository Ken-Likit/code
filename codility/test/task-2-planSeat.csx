using System;
using System.Linq;

// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {

    // True if the searched seats are all available; i.e. all are not found from all reserved seats
    // False otherwise
    bool isAvailable(string[] allReservedSeats, string[] searchReservedSeats) {
        var len = searchReservedSeats.Count();
        var anyReserved = false;

        for (int i = 0; i <  len && !anyReserved; ++i) {
            anyReserved = allReservedSeats.Contains(searchReservedSeats[i]);
        }
        return anyReserved == false;
    }


    public int solution(int N, string S) {

        if (S.Length == 0) return N * 2;

        // 3 possible seating per each row
        // case A: BC DE
        // case B: DEFG
        // case C: FG HJ

        // Find all reserved seats
        string[] reservedSeats = S.Split(' ');  // From the question, separated by A SINGLE SPACE

        // Total number of 4-person family
        var total = 0;

        // Iterate each row, to find avilable seats
        for (int i = 0; i < N; i++) {
        
            // case A: BC DE
            var caseA = new string[4] { "B", "C", "D", "E"};
            caseA = caseA.Select(x => (i+1).ToString() + x).ToArray();

            // case B: DEFG
            var caseB = new string[4] { "D", "E", "F", "G"};
            caseB = caseB.Select(x => (i+1).ToString() + x).ToArray();

            // case C: FG HJ
            var caseC = new string[4] { "F", "G", "H", "J"};
            caseC = caseC.Select(x => (i+1).ToString() + x).ToArray();

            var isBCDEAvailable = isAvailable(reservedSeats, caseA);
            if (isBCDEAvailable) {
                ++total;

                var isFGHJAvailable = isAvailable(reservedSeats, caseC);
                if (isFGHJAvailable) {
                    ++total;
                }
            } else {

                var isDEFGAvailable = isAvailable(reservedSeats, caseB);
                if (isDEFGAvailable) {
                    ++total;
                } else {
                    var isFGHJAvailable = isAvailable(reservedSeats, caseC);
                    if (isFGHJAvailable) {
                        ++total;
                    }
                }
            }
        }
        return total;
    }
}
