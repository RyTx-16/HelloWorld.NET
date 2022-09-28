string teststr = "The quick brown Fox jumps over the lazy Dog";

// Contains
System.Console.WriteLine($"{teststr.Contains("fox")}");
System.Console.WriteLine($"{teststr.Contains("fox", StringComparison.CurrentCultureIgnoreCase)}");

// StartsWith and Endwith
System.Console.WriteLine($"{teststr.StartsWith("the")}");
System.Console.WriteLine($"{teststr.StartsWith("the", StringComparison.CurrentCultureIgnoreCase)}");

System.Console.WriteLine($"{teststr.EndsWith("dog")}");
System.Console.WriteLine($"{teststr.EndsWith("dog", StringComparison.CurrentCultureIgnoreCase)}");


// IndexOf, LastIndexOf
System.Console.WriteLine($"\n{teststr.IndexOf("the")}");
System.Console.WriteLine($"{teststr.IndexOf("the", StringComparison.CurrentCultureIgnoreCase)}");
System.Console.WriteLine($"{teststr.LastIndexOf("the")}");

// Empty, null or whitespace
string str4 = null;
string str5 = " ";
string str6 = String.Empty;
System.Console.WriteLine($"\n{String.IsNullOrEmpty(str4)}");
System.Console.WriteLine($"{String.IsNullOrEmpty(str6)}");
System.Console.WriteLine($"{String.IsNullOrWhiteSpace(str5)}");