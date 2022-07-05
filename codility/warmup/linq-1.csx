class IntroToLINQ
{
    public static void Main()
    {
        // The Three Parts of a LINQ Query:
        // 1. Data source.
        int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

        // 2. Query creation.
        // numQuery is an IEnumerable<int>
        var numQuery =
            from num in numbers
            where (num % 2) == 0
            select num;

        // 3. Query execution.
        foreach (int num in numQuery)
        {
            Console.WriteLine("{0,1}", num);
        }

        //------------------------------------------------
        // Practice A
        var aList = new List<int>{1, 2, 3, 4, 5};
        Console.WriteLine("input list = " + String.Join(", ", aList));

        var listAQuery = 
          from num in aList
          where (num > 3)
          select num;

        foreach(var num in listAQuery)
        {
          Console.WriteLine($"num={num}");
        }

        // Ex: query -> ToArray
        var arrayA = listAQuery.ToArray();

        // Ex: query -> ToList
        var listA = listAQuery.ToList();

        // Ex: query -> Forcing immediate exeuction; Count, Max, Min, Average, First
        var countQuery = listAQuery.Count();
        var maxQuery = listAQuery.Max();
        var minQuery = listAQuery.Min();

        var first = arrayA.FirstOrDefault();

        // Print values in list
        listAQuery.ToList().ForEach(Console.WriteLine);

        // Print values in array
        Array.ForEach(listAQuery.ToArray(), Console.WriteLine);

        Console.WriteLine($"countQuery={countQuery}  first={first}");

    }
}

IntroToLINQ.Main();
