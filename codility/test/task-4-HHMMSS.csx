using System.Net.Http.Headers;
/* 
  Q-2
  ===
  In this task we consider interesting patterns that could be observed on a digital clock. Such clock displays current time using the format "HH:MM:SS" where:
  leading zeros if needed.

  We say that a point in time is interesting if digital clock needs at most two distinct digits to display it. For example, 13:31:33 and 02:20:22 are both interesting, because digital clock can display it using only digits 1 and 3 in the first case, or 0 and 2 in the second one. 00:00:00 is interesting too, as it can be displayed using only 0, but 15:45:14 is not, due to the fact that more than two distinct digits are used.

  Note that delimiter character ":" is permanently printed onto clock's display and doesn't count as one of displayed digits.

  Your task is to count interesting points in time in a given period of time.

  Write a function:

  def solution(S, T)

  that, given strings S and T representing time in the format "HH:MM:SS", returns the number of interesting points in time between S and T (inclusive).

  For example, given "15:15:00" and "15:15:12", your function should return 1, because there is only one interesting point in time between these points (namely "15:15:11"), Given "22:22:21" and "22:22:23", your function should return 3; interesting points in time are "22:22:21", "22:22:22", and "22:22:23".

  Assume that:

  strings S and T follow the format "HH:MM:SS" strictly;
  string S describes a point in time before T on the same day.
  In your solution, focus on correctness. The performance of your solution will not be the focus of the assessment.``
  "HH" is the hour of the day (00 through 23), as two decimal digits;
  "MM" is the minute within the hour (00 through 59), as two decimal digits;
  "SS" is the second within the minute (00 through 59), as two decimal digits.
  Note that hour, minute and second are always represented as two digits, so the clock displays 


*/

// Helpers
class Util
{
  // Convert a string to a number
  public static int convertToNumber(String s)
  {
    int numVal = 0;  

    try
    {
        numVal = Int32.Parse(s);
    }
    catch (FormatException e)
    {
        Console.WriteLine(e.Message);  // Somehow it is not a number
        numVal = 0; // TODO\: default to zero
    }
    return numVal;
  }
}

// Represent time in Hour, Minute, Second
class TimeInNumber
{
  public int Hour { get; set; }
  public int Minute { get; set; }
  public int Second { get; set; }

  public String HourInString { get; set; }
  public String MinuteInString { get; set; }
  public String SecondInString { get; set; }

  public TimeInNumber()
  {} // Not used

  public TimeInNumber(int h, int m, int s)
  {
    Hour = h;
    Minute = m;
    Second = s;

    HourInString = h.ToString().PadLeft(2, '0');
    MinuteInString = m.ToString().PadLeft(2, '0');
    SecondInString = s.ToString().PadLeft(2, '0');
  }

  public TimeInNumber(String h, String m, String s)
  {
    HourInString = h;
    MinuteInString = m;
    SecondInString = s;
    setTimeInTime(h, m, s);
  }

  // Assumption: String is in the format of HH:MM:SS
  public TimeInNumber(String timeInString)
  {
    // HH:MM:SS
    HourInString = timeInString.Substring(0, 2);
    MinuteInString  = timeInString.Substring(3, 2);
    SecondInString = timeInString.Substring(6, 2);
    setTimeInTime(HourInString, MinuteInString, SecondInString);
  }

  private void setTimeInTime(String h, String m, String s)
  {
    Hour = Util.convertToNumber(h);
    Minute = Util.convertToNumber(m);
    Second = Util.convertToNumber(s); 
  }

  // All possible of the HH
  public static int getPossibleDistinctTimesForHH(TimeInNumber t, Boolean isBeforeOrEqual = true)
  {
    Console.WriteLine($"--> [getPossibleDistinctTimesForHH] -- t={t.ToString()}  isBeforeOrEqual={isBeforeOrEqual}");

    string distinctChars = new String(t.ToTimeInString().Distinct().ToArray());
    distinctChars = distinctChars.Replace(":", "");
    Console.WriteLine($"--> distinctChars={distinctChars}");

    // Special case: Hour is "00", then the only possible values 1; "00:00:00"
    // if (t.Hour == 0) return 1;

    // 1. Possible distinct hours
    // Original --> HH: ab
    // Possible combinations of ab
    // aa
    // ab
    // ba
    // bb
    // Valid hours: 00 - 23
    Char a = t.HourInString[0];
    Char b = t.HourInString[1];

    // 2. Possible distinct mins
    List<String> possibleCombinations = new List<String>();
    if (a == b)
    {
      // if there are more or equal than 2 unique numbers, grab the first 2
      if (distinctChars.Length >= 2)
      {
        a = distinctChars[0];
        b = distinctChars[1];
      }
    }

    // Still only one unique number
    if (a == b)
    {
      possibleCombinations = new List<String> 
      {
        (a.ToString() + a.ToString()) // Possible values: 00, 11, 22 (23 is the max hour)
      };
    }
    else 
    {
      possibleCombinations = new List<String> 
      {
        (a.ToString() + a.ToString()),  // aa
        (a.ToString() + b.ToString()),  // ab
        (b.ToString() + a.ToString()),  // ba
        (b.ToString() + b.ToString())   // bb
      };
    }
  
    Console.WriteLine("possibleCombinations=" + String.Join(", ", possibleCombinations));

    var possibleValidCombinations = 0;
    foreach(var minString in possibleCombinations)
    {
      var min = Util.convertToNumber(minString);
      if (min >= 0 && min <= 59)
      {
        var isValidMin = isBeforeOrEqual ? (min <= t.Minute) : (min >= t.Minute);
        if (isValidMin)
        {
          foreach(var secString in possibleCombinations)
          {
            var sec = Util.convertToNumber(secString);
            var isValidSec = isBeforeOrEqual ? (sec <= t.Second) : (sec >= t.Second);
            if (sec >= 0 && sec <= 59)
            {
              ++possibleValidCombinations;
            }
          }
        }
      }
    }
    return possibleValidCombinations;
  }

  public override string ToString()
  {
    return $"HH:MM:SS={Hour}:{Minute}:{Second} InString={HourInString}:{MinuteInString}:{SecondInString}";
  }

  public string ToTimeInString()
  {
    return $"{HourInString}:{MinuteInString}:{SecondInString}";
  }
}

class Solution
{

  //-------------------------------------------------------
  // Solution
  // Assumptions:
  // * S Time <= T Time
  // * Strings in the format of HH::MM:SS
  // * HH is a value b/w 00 - 23
  // * MM is a value b/w 00 - 59
  // * SS is a value b/w 00 - 59
  //-------------------------------------------------------
  public static int solution(String S, String T)
  {
    // Convert to number
    var startTime = new TimeInNumber(S);
    var endTime = new TimeInNumber(T);
    Console.WriteLine($"startTime={startTime}  endTime={endTime}");
    startTime.HourIn

    // Unique numbers are defined by HH b/w startHour and endHour; inclusively
    // Ex 
    // 00:xx:yy -> 00:aa:bb  ---- 1 possible unique number (00:..:..)
    // 00:xx:yy -> 01:aa:bb  ---- 2 possible unique number (00:..:.. and 01:..:..)
    int possibleHours = (endTime.Hour - startTime.Hour) + 1; // TODO: not used yet
    Console.WriteLine($"--> possibleHours={possibleHours}");

    int possibleCombinations = 0;
    for (int i = 0; i < possibleHours; ++i)
    {
      if (i == 0)
      {
        possibleCombinations += TimeInNumber.getPossibleDistinctTimesForHH(startTime, false);
      }
      else if (i == possibleHours - 1)
      {
        possibleCombinations += TimeInNumber.getPossibleDistinctTimesForHH(endTime, true);
      }
      else  // i is between start and end time
      {
        var t = new TimeInNumber(startTime.Hour + 1, 0, 0);
        possibleCombinations += TimeInNumber.getPossibleDistinctTimesForHH(startTime, false);
      }
    }

    return possibleCombinations; // TODO: update this
  }
}

var output = Solution.solution("00:01:00", "00:01:15");
Console.WriteLine($"--> output={output}");

output = Solution.solution("22:22:21", "22:22:21");
Console.WriteLine($"--> output={output}");