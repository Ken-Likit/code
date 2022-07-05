// 
// MaxProductOfThree
//
// https://app.codility.com/programmers/lessons/6-sorting/max_product_of_three/
// 
// https://molchevskyi.medium.com/best-solutions-for-codility-lessons-lesson-6-sorting-770f931b65ad
//
// RESULT: https://app.codility.com/demo/results/training2DX9M2-6VW/
//
//
class Solution { 
  public static int solution(int[] A) {
    var len = A.Count();
    
    // 2 lists
    // maxThree
    // NegTwo
    var maxThree = new int[3] { -1000, -1000, -1000 };
    var minNegTwo = new int[2] { 0, 0 };

    for (int i = 0; i < len; ++i) {
      var curVal = A[i];
      
      // Negative value
      if (curVal < minNegTwo[0]) {
        minNegTwo[1] = minNegTwo[0];
        minNegTwo[0] = curVal;
      } else if (curVal < minNegTwo[1]) {
        minNegTwo[1] = curVal;
      }
      
      if (curVal > maxThree[0]) {
        maxThree[2] = maxThree[1];
        maxThree[1] = maxThree[0];
        maxThree[0] = curVal;
      } else if (curVal > maxThree[1]) {
        maxThree[2] = maxThree[1];
        maxThree[1] = curVal;
      } else if (curVal > maxThree[2]) {
        maxThree[2] = curVal;
      }
    }

    var maxThreeProduct = maxThree[0] * maxThree[1] * maxThree[2];
    var maxAndMinNegProduct = maxThree[0] * minNegTwo[0] * minNegTwo[1];

    var result = Math.Max(maxThreeProduct, maxAndMinNegProduct);
    return result;
  }
}

var A = new int[6] { -3, 1, 2, -2, 5, 6 };
Console.WriteLine($"solution(0, 0, 11) --> output={Solution.solution(A)}");