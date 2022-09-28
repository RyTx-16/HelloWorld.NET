// General format is: {index[alignment],spacing:[format]}
// Types are: N (Number), G (General ), F (Fixed-point),
// E (Exponential), D (Decimal), P (Percent), X (Hexadecimal),
// C (Currency)


int[] quaters = {1, 2, 3, 4};
int[] sales = {10000, 150000, 200000, 225000};
double[] intlMixPct = {.386, .413, .421, .457};
int val1 = 1234;
decimal val2 = 1234.5678m;


// Index + Format
System.Console.WriteLine($"{val1:D}, {val1:N}, {val1:F}, {val1:G},");
System.Console.WriteLine($"{val2:E}, {val2:N}, {val2:F}, {val2:G},");

// Add number after format to spec. precision
System.Console.WriteLine($"{val1:D6}, {val1:N2}, {val1:F1}, {val1:G3},");

// Format with alignment + Spacing
System.Console.WriteLine("\nSales by Quater: ");
System.Console.WriteLine($"{quaters[0]} {quaters[1]} {quaters[2]} {quaters[3]}");
System.Console.WriteLine($"{sales[0]} {sales[1]} {sales[2]} {sales[3]}");
System.Console.WriteLine("International Sales:");
System.Console.WriteLine($"{intlMixPct[0]} {intlMixPct[1]} {intlMixPct[2]} {intlMixPct[3]}");


System.Console.WriteLine("\nSales by Quater: ");
System.Console.WriteLine($"{quaters[0],12} {quaters[1],12} {quaters[2],12} {quaters[3],12}");
System.Console.WriteLine($"{sales[0],12:C0} {sales[1],12:C0} {sales[2],12:C0} {sales[3],12:C0}");
System.Console.WriteLine("International Sales:");
System.Console.WriteLine($"{intlMixPct[0],12:P0} {intlMixPct[1],12:P0} {intlMixPct[2],12:P0} {intlMixPct[3],12:P0}");