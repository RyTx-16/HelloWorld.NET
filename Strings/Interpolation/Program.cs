// Feature that enables the easy insertion of data
// and expression values into a string 

int a = 10;
float b = 25.0f;
string c = "c#";

// String output old version

Console.WriteLine("Values are {0}, {1}, {2}", a, b, c);

// String interpolation version - Easier to read

Console.WriteLine($"Values are {a}, {b}, {c}");

// Interpolated strings can contain expressions

Console.WriteLine($"(a + b)/b is: {(a + b)/b}");
Console.WriteLine($"{c} in uppercase: {c.ToUpper()}");