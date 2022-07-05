using System.Transactions;
using System;

// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {

    public enum Days: int { Mon = 1, Tue = 2, Wed = 3, Thu = 4, Fri = 5, Sat = 6, Sun = 7 };

    public static string solution(string S, int K) {
        // From the question:
        // 0 <= K <= 500
        if (K < 0 || K > 500) return "";  // Exception: empty string

    Console.WriteLine($"--> [solution] S:{S}  K={K}");

        // TODO: Handle exception
        // var day = Enum.Parse(typeof(Days), S);
        try {
            var day = Enum.Parse(typeof(Days), S);
            var dayInInt = (int)day;

            // K days from the given day
            var kDaysFromGivenDay = (dayInInt + K) % 7;

            // * * * Missing Logic * * *
            if (kDaysFromGivenDay == 0) return Days.Sun.ToString();
            // * * * End of Missing Logic * * *

            // K days from the given day in ENUM
            var kDaysFromGivenDayInDaysEnum = Enum.ToObject(typeof(Days), kDaysFromGivenDay);

            Console.WriteLine($"--> dayReturned:{kDaysFromGivenDayInDaysEnum}  dayReturnedInString={kDaysFromGivenDayInDaysEnum.ToString()} ");

            // Enum -> String
            return kDaysFromGivenDayInDaysEnum.ToString();

        } catch (ArgumentException) {
            return ""; // Exception: empty string
        } catch (Exception) {
            return ""; // Exception: empty string
        }
    }
}

var day = "Tue";
var K = 12;

Console.WriteLine($"solution(array) --> dayReturned={Solution.solution(day, K)}");