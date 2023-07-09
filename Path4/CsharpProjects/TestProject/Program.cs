Console.WriteLine("Signed integral types:");

System.Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
System.Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
System.Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
System.Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

System.Console.WriteLine();
System.Console.WriteLine("Unsigned integral types:");

System.Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
System.Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
System.Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
System.Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");


System.Console.WriteLine();
System.Console.WriteLine("Floating point types:");
System.Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
System.Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
System.Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

int[] data = new int[3];