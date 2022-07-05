/*
 Lesson 2  OddOccurrencesInArray 
 https://app.codility.com/programmers/lessons/2-arrays/odd_occurrences_in_array/
 https://molchevskyi.medium.com/best-solutions-for-codility-lessons-lesson-2-arrays-5c3e3ee2299c
 */
 
// It based on a fact that XOR operation has a following property:
// N XOR N = 0   <-- Match the same number, reset itself to zero
// N XOR 0 = N   <-- Match zero (a different number?), leave the number as is
//
// Ex:   4, 3, 4, 2, 2
// 4 = 0100, 
// 3 = 0011
// 2 = 0010
//
// Iterations of the algorithm
// 0000 ^ 0100  = 0100  = 4
// 0100 ^ 0011  = 0111  = 7
// 0111 ^ 0100  = 0011  = 3  
// 0011 ^ 0010  = 0001  = 1
// 0001 ^ 0010  = 0011  = 3
int get_odd_occurrence(List<int> list) {
    int res = 0;
    foreach (var i in list) {
        res ^= i;
        Console.WriteLine($"\n--> i={i} res={res}");
        /*
        Console.WriteLine($"--> Binary i={0} res={1}"
          , Convert.ToString(i, 2).PadLeft(8, '0')
          , Convert.ToString(res, 2).PadLeft(8, '0')
        );
        */
        Console.WriteLine("--> Binary i\t=" + Convert.ToString(i, 2).PadLeft(8, '0'));
        Console.WriteLine("--> Binary res\t=" + Convert.ToString(res, 2).PadLeft(8, '0'));
    }
    return res;
}

var testList = new List<int>{4, 3, 4, 2, 2};
var result = get_odd_occurrence(testList);
Console.WriteLine($"--> result={result}");

var x = Math.Ceiling((double)5/2);
Console.WriteLine($"x={x}");

