float f1 = 12.3f;
int i1 = 200;

// Spacing & Alignment 

Console.WriteLine("{0, -15} {1, 10}", "Float Val", "Int Val");
Console.WriteLine("{0, -15} {1, 10}", f1, i1);

// Spacing & Alignment Interpolation
Console.WriteLine("{0, -15} {1, 10}", "Float Val", "Int Val");
Console.WriteLine($"{f1, -15} {i1, 10}");