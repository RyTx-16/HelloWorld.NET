using System.Text.RegularExpressions;

string str1 = "The quick brown Fox jumps over the lazy Dog";
string str2 = "the quick brown fox jumps over the lazy dog";

// IsMath -- determines if conent of str results in a match with the regex.
Regex CapWords = new Regex (@"[A-Z]\w+");
System.Console.WriteLine(CapWords.IsMatch(str1));
System.Console.WriteLine(CapWords.IsMatch(str2));

System.Console.WriteLine("\n............\n");

Regex NoCase = new Regex (@"fox", RegexOptions.IgnoreCase);
System.Console.WriteLine(NoCase.IsMatch(str1));
System.Console.WriteLine(NoCase.IsMatch(str2));

System.Console.WriteLine("\n............\n");

// Match returns a single match at a time
Match m = CapWords.Match(str1);
while (m.Success) {
    System.Console.WriteLine($"'{m.Value}' found at position: {m.Index}");
    m = m.NextMatch();
}

System.Console.WriteLine("\n............\n");

// Matches returns a collection of Match objects

MatchCollection mc = CapWords.Matches(str1);
System.Console.WriteLine($"Found {mc.Count} matches:");
foreach (Match match in mc) {
    System.Console.WriteLine($"'{match.Value}' found at position: {match.Index}");
}