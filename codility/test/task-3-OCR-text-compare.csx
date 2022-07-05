class Solution
{
  /*
  ** Q1
  Task description
  You are given two passages of text that have been scanned and passed through OCR software. (OCR stands for Optical Character Recognition, which is the conversion of printed text into machine-readable strings.) Unfortunately, the scans were of poor quality and some letters were not recognized by the OCR software. Write a program to check (based on the output from the OCR software) whether the two text sources might in fact be the same.

  We assume that each text passage consists only of English letters. The OCR output from each scan is given as a string in which unrecognized letters are marked as follows. Firstly, let us mark each unrecognized letter by "?". For example, if the OCR software didn't recognize the second and third letters of the text "AppLe", it would result in OCR output of "A??Le". Then, for brevity, every group of K consecutive "?" characters is replaced by the decimal representation of integer K (without leading zeros). Thus, the above OCR result would be represented as "A2Le". (For the sake of clarity, such numeric replacement is performed on groups of "?" characters that cannot be extended either to the left or to the right.)

  You are given two strings S and T consisting of N and M characters, respectively, and you would like to check whether they might have been obtained as OCR scans of the same text. For example, both strings "A2Le" and "2pL1" could have been obtained as scans of the word "AppLe" (but also as scans of the word "AmpLe"). Both strings "a10" and "10a" could have been obtained as scans of the word "abbbbbbbbba" (but also from many other strings of length 11, starting and ending with "a").

  a bbbbb bbbb a

  On the other hand, strings "ba1" and "1Ad" could not have been obtained from the same text, since the second letter of each text is different.

  Write a function:

  def solution(S, T)

  that, given two strings S and T consisting of N and M characters, respectively, determines whether strings S and T can be obtained as OCR output from the same text.

  For example, given "A2Le" and "2pL1", your function should return True, as explained above. Given "a10" and "10a", your function should return True, as explained above. Given "ba1" and "1Ad", your function should return False, as explained above. Given "3x2x" and "8", your function should return False, since they represent strings of different length.

  Assume that:

  N and M are integers within the range [1..100,000];
  lengths of texts before the OCR process are integers within the range [1..100,000];
  strings S and T consist only of alphanumerical characters (a−z and/or A−Z and/or 0−9);
  strings S and T contain neither single zeros (e.g. "abc0abc") nor integers with leading zeros (e.g. "abc012abc").
  In your solution, focus on correctness. The performance of your solution will not be the focus of the assessment.

  */

  public static String convertDigitToQuestionMark(String s)
  {
    String outS = String.Empty;
    try
    {
        int numVal = Int32.Parse(s);
        //Console.WriteLine(numVal);

        for (int j = 0; j < numVal; ++j)
        {
          outS += '?';
        }
    }
    catch (FormatException e)
    {
        Console.WriteLine(e.Message);
    }
    return outS;
  }

  public static String translateString(String inString)
  {
    //Console.WriteLine($"\n\n[translateString] inString={inString}");

    String outString = String.Empty;
    String tempString = String.Empty;

    for (int i = 0; i < inString.Length; ++i)
    {
      Char c = inString[i];
      // Console.WriteLine($"c={c}");

      if (Char.IsDigit(c))
      {
          tempString += c;

          // Digit(s) at the end 
          if (i == inString.Length-1)
          {
            String questionMarkString = convertDigitToQuestionMark(tempString);
            outString += questionMarkString;
          }
      }
      else
      {
        //Console.WriteLine($"tempString={tempString}");

        // If not found any digit previously, then append the current character to the output string
        if (tempString.Length > 0)
        {
          String questionMarkString = convertDigitToQuestionMark(tempString);
          outString += questionMarkString;

          // Clear string of digits
          tempString = String.Empty;
        }

        // Append 
        outString += c;
      }
    }

    //Console.WriteLine($"[translateString] outString={inString}");
    return outString;
  }

  public static Boolean isMatched(String s1, String s2)
  {
    Console.WriteLine($"[isMatched] [DEBUG] --> s1={s1}  s2={s2}");

    // case 0: if string lengths are not equal, then false (not the same word)
    // Cannot check here as there are digits

    var s1Temp = translateString(s1); 
    var s2Temp = translateString(s2); 
    Console.WriteLine($"[DEBUG] s1Temp={s1Temp}  s2Temp={s2Temp}");

    if (s1Temp.Length != s2Temp.Length) return false;

    for (int i = 0; i < s1Temp.Length; ++i)
    {
      if (s1Temp[i] == s2Temp[i])
      {
        continue; // characters match, proceed
      }
      else if (s1Temp[i] == '?' || s2Temp[i] == '?')
      {
        continue; // ? with any char, proceed
      }
      else
      {
        return false;
      }
    }
    
    return true; 
  }
}


var output = Solution.isMatched("a10", "10a");

// true
Console.WriteLine($"--> (a10, 10a) output={output}");

// A2Le" and "2pL1 --> true
Console.WriteLine($"\n--> (A2Le, 2pL1) output={Solution.isMatched("A2Le", "2pL1")}");

// ba1" and "1Ad --> false
Console.WriteLine($"\n--> (ba1, 1Ad) output={Solution.isMatched("ba1", "1Ad")}");