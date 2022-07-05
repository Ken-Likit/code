 /*
   Concat 2 lists
   var a = List<int> { 1, 1, 1 };
   var b = List<int> { 2, 2, 2 };

  * AddRange modifies the list by adding the other items to it.

  * Concat returns a new sequence containing the list and the other items, without modifying the list.
  */
 class Solution { 
  public static List<int> solution(List<int> list1, List<int> list2) {
      // AddRange
      list1.AddRange(list2);
      Console.WriteLine($"--> list1  count={list1.Count()}");
      list1.ForEach(x => Console.WriteLine(x));

      // Concat
      var list3 = list1.Concat(list2).ToList();
      list3.Count();
      Console.WriteLine($"--> list3  count={list3.Count()}");
      list3.ForEach(x => Console.WriteLine(x));
      
      //foreach(var a in list3) {
      //  Console.WriteLine($"a={a}");
      //}
      return list1;
  }
}

var listOne = new List<int>{ 1, 2, 3 };
var listTwo = new List<int>{ 4, 5, 6 };


var output = Solution.solution(listOne, listTwo);

// output.ForEach(x => Console.WriteLine(x));
