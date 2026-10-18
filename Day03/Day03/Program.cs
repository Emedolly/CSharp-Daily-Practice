// See https://aka.ms/new-console-template for more information
using Day03;
GenericSwap _genericSwap = new GenericSwap();
//_genericSwap.Run();
GenericPrint _genericPrint = new GenericPrint();
//_genericPrint.PrintAll(new List<int>(){1,2,3,10});
GenericMax _genericMax = new GenericMax();
List<int> _numbers = new List<int>(){2,8,4};
//Console.WriteLine($"Max number {_genericMax.Max(_numbers)}");
Box<int> _box = new Box<int>(5);
//_box.show();
StudentMarks _studentMarks = new StudentMarks();
//_studentMarks.Run();
GroupByLength _groupByLength = new GroupByLength();
//_groupByLength.Run();
StackReverse _stack = new StackReverse();
_stack.Run();
Console.WriteLine("Hello, World!");