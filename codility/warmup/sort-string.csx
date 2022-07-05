// Concat strings using LINQ and char[] solutions
// Revere string using char[] solution
public class Solution {
  
  // Solution 1
  // Use LINQ implementation
  public static string sortString(string s, bool removeDup = false) {
    Console.WriteLine($"--> [sortString] s={s}  len={s.Length}");
  
    if (removeDup) {
      return String.Concat(s.OrderBy(c => c).Distinct());
    } else {
      return String.Concat(s.OrderBy(c => c));
    }
  }

  // Solution 2
  // * Convert string to character array
  // * Use Array.Sort with character array
  public static string sortStringII(string s, bool removeDup = false) {

    Console.WriteLine($"--> [sortStringII] s={s}  len={s.Length}");
  
    char[] chars = s.ToCharArray();
    Array.Sort(chars);

    return (removeDup
      ? new string(chars.Distinct().ToArray()) 
      : new string(chars)
    );
  }

  // Reverse string
    public static string reverseString(string s, bool removeDup = false) {

    Console.WriteLine($"--> [reverseString] s={s}  len={s.Length}");
  
    char[] chars = s.ToCharArray();
    Array.Reverse(chars);

    return (removeDup
      ? new string(chars.Distinct().ToArray()) 
      : new string(chars)
    );
  }
}


var output = Solution.sortString("UZABCabc");
Console.WriteLine($"--> output={output}");

output = Solution.sortString("UZABCabccbaAB", true);
Console.WriteLine($"--> REMOVE DUP output={output}");

// Test char array 
var outputII = Solution.sortStringII("UZABCabc");
Console.WriteLine($"--> output={outputII}");

outputII = Solution.sortStringII("UZABCabccbaAB", true);
Console.WriteLine($"--> REMOVE DUP output={outputII}");


// Reverse char array 
var outputIII = Solution.reverseString("abcdefghijabc");
Console.WriteLine($"--> output={outputIII}");
