// int first = 2;
// string second = "4";
// string result = first + second;
// Console.WriteLine(result);

// int myInt = 3;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal = myInt; // This implicit conversion is handled automatically because the data type is "widened". This data type is being converted from a type that holds less to a type that is capable of holding more.
// Console.WriteLine($"decimal: {myDecimal}");

decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

int myInt = (int)myDecimal; //explicit conversion, must be done manually
Console.WriteLine($"int: {myInt}");