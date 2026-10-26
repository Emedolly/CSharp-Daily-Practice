// See https://aka.ms/new-console-template for more information
using Day06;

SimpleDelegate _delegate = new SimpleDelegate();
//_delegate.greet("Dolly");
FuncDemo _demo = new FuncDemo();
int funcAddResult = _demo.add(4, 5);
int funcMultiplyResult = _demo.multiply(4, 5);
//Console.WriteLine($"add: {funcAddResult}, multiply: {funcMultiplyResult}");
FilterNumbers filterNumbers = new FilterNumbers();
List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
List<int> evenNumbers = filterNumbers.Filter(numbers, n => n % 2 == 0);
List<int> Greaterthan5Numbers = filterNumbers.Filter(numbers, n => n >5);
//Console.WriteLine(string.Join(" ", evenNumbers));
//Console.WriteLine(string.Join(" ", Greaterthan5Numbers));
SimpleEvent simpleEvent = new SimpleEvent();
//simpleEvent.Run();
//Console.WriteLine("madam".IsPalindrome());   
List<int> numbers1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
ListExtensions.print(numbers1);
List<string> names = new List<string>(){"A","B","C","D","E","F"};
ListExtensions.print(names);
Console.ReadLine();
