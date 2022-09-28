using System.Globalization;

DateTime AprFools = new DateTime(2025, 4, 1, 23, 30, 30);

// d : short date
System.Console.WriteLine($"{AprFools:d}");

// D : full date
System.Console.WriteLine($"{AprFools:D}");

// f : full date, short time
System.Console.WriteLine($"{AprFools:f}");

// F : full date, long time
System.Console.WriteLine($"{AprFools:F}");

// g : general date and time
System.Console.WriteLine($"{AprFools:g}");

// G: general date and time
System.Console.WriteLine($"{AprFools:G}");

// Format using spec. CultureInfo -> 'System.Globalization'
System.Console.WriteLine(AprFools.ToString("d", CultureInfo.CreateSpecificCulture("de-DE")));

// Custom formats
System.Console.WriteLine($"{AprFools:dddd, MMMM, d yyyy}");
System.Console.WriteLine($"{AprFools:ddd, h:mm:ss tt}");
System.Console.WriteLine($"{AprFools:dd, h:mm:ss tt}");
System.Console.WriteLine($"{AprFools:MMM d yyyy}");
