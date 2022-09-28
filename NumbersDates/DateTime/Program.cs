// DateTime.Now = current date/time
DateTime now = DateTime.Now;
System.Console.WriteLine(now);

// DateTime.Today = current date with time set to 00:00:00 
DateTime today = DateTime.Today;
System.Console.WriteLine(today);

// DateOnly/TimeOnly = just date/time
DateOnly date = DateOnly.FromDateTime(DateTime.Now);
TimeOnly time = TimeOnly.FromDateTime(DateTime.Now);
System.Console.WriteLine(date);
System.Console.WriteLine(time);

// Dates have properties
System.Console.WriteLine(today.DayOfWeek);
System.Console.WriteLine(today.DayOfYear);

// Methods to change values
System.Console.WriteLine();
now = now.AddDays(2);
System.Console.WriteLine(now);
now = now.AddMonths(1);
System.Console.WriteLine(now);
now = now.AddYears(5);
System.Console.WriteLine(now);
now = now.AddHours(12);
System.Console.WriteLine(now);

// TimeSpan represents a duration of time
DateTime AprilFools = new DateTime(now.Year, 4, 1);
DateTime NewYears = new DateTime(now.Year, 1, 1);
TimeSpan interval = AprilFools - NewYears;
System.Console.WriteLine(interval);

// Dates can be compared usinig regular expressions
System.Console.WriteLine($"{NewYears < AprilFools}");
System.Console.WriteLine($"{NewYears > AprilFools}");
