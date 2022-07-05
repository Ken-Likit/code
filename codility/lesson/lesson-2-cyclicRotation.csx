/*
CyclicRotation

https://app.codility.com/programmers/lessons/2-arrays/cyclic_rotation/

https://molchevskyi.medium.com/best-solutions-for-codility-lessons-lesson-2-arrays-5c3e3ee2299c
*/
List<int> rotate(List<int> list, int K) {

  var tempList = new List<int>(list);
  Console.WriteLine(String.Join(", ", tempList));

  var len = tempList.Count;
  var k = K;
  if (k > len) k = k % len;
  Console.WriteLine($"--> K={K} --> k={k}");


  // 1
  // Get the right part of size i
  // Get the left part of size len - K
  var rightList = tempList.GetRange(len - k, k);
  var leftList = tempList.GetRange(0, len - k);

  rightList.AddRange(leftList);
  Console.WriteLine(String.Join(", ", rightList));

  return rightList;
}

var inList = new List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9};  // count = 9
var outList = rotate(inList, 3);

var inListII = new List<int>{1, 2, 3, 4};  // count = 4
var outListII = rotate(inListII, 6);
