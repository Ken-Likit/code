using System;

//---------------------------------------------------------------------
// 1. Console with paramas
//---------------------------------------------------------------------
var a = 10;
Console.WriteLine($"Hello world a={a}");

//---------------------------------------------------------------------
// 2. foreach, Range, for
//---------------------------------------------------------------------
Console.WriteLine("\n\foreach, Range, for");
foreach (var i in Enumerable.Range(1, 10)) {
  Console.WriteLine($"--> i={i}");
}
for (int i = 0; i < 10; ++i) {
  Console.WriteLine($"--> i={i}");
}

//---------------------------------------------------------------------
// 3. factorial
//---------------------------------------------------------------------
Console.WriteLine("\n\nFactorial");
var N = 5;
{
  var factorial = 1;
  foreach (var i in Enumerable.Range(1, N)) {
    Console.WriteLine($"--> i={i}  factorial={factorial}");
    factorial *= i;
  }
  Console.WriteLine($"--> Factory of {N} is {factorial}");
}
{
  int factorial(int n) {
    if (n == 0) return 1;
    return n * factorial(n-1);
  }
  var result = factorial(N);
  Console.WriteLine($"--> RECURSIVE --- factorial({N})={result}");
}

//---------------------------------------------------------------------
// 4. Print * 
//---------------------------------------------------------------------
Console.WriteLine("\n\nPrint * * *");
var rows = 4;
for (var i = 0; i < rows; ++i) {
  for (var j = 0; j < i+1; ++j) {
    if (j > 0) Console.Write(" ");
    Console.Write("*");
  }
  Console.WriteLine("");
}

//---------------------------------------------------------------------
// 5. while loop
//---------------------------------------------------------------------
Console.WriteLine("\n\nwhile loop");
var max = 5;
while (max > 0) {
  Console.WriteLine($"max={max}");
  --max;
}

//---------------------------------------------------------------------
// 6. fibonacci numbers
//---------------------------------------------------------------------
void fib2(int max) {
  Console.WriteLine($"--> fib2 {max}");
  var a = 0;
  var b = 1;
  while (a <= max) {
    Console.Write($"{a} ");
    var c = a + b;
    a = b;
    b = c;
  }
  Console.WriteLine();
}
fib2(13);


//---------------------------------------------------------------------
// List
//---------------------------------------------------------------------
 Console.WriteLine("\n\n--> List");

var numList = new List<int>(Enumerable.Range(1, 10));
// numList.AddRange(Enumerable.Range(1, 10));

var numListII = new List<int>{1, 2, 3, 4, 5};

foreach(var i in numList) Console.WriteLine($"i={i}");
foreach(var i in numListII) Console.WriteLine($"i={i}");
numList.Add(100);


//---------------------------------------------------------------------
// Array
//---------------------------------------------------------------------
String[] days = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
var lenOfDays = days.Length;

foreach(var day in days) {
  Console.WriteLine($"--> day={day}");
}
