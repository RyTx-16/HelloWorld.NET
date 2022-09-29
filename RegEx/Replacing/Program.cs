using System.Text.RegularExpressions;


string str1 = "The quick brown Fox jumps over the lazy Dog";

Regex CapWords = new Regex (@"[A-Z]\w+");

// Replace content in strings
string result = CapWords.Replace(str1, "***");
System.Console.WriteLine(str1);
System.Console.WriteLine(result);

System.Console.WriteLine("\n............\n");

// Replace text using MatchEvaluator 
string makeUpper(Match m) {
    string s = m.ToString();
    if (m.Index == 0) {
        return s;
    }
    return s.ToUpper();
}

string uprStr = CapWords.Replace(str1, new MatchEvaluator(makeUpper));
System.Console.WriteLine(str1);
System.Console.WriteLine(uprStr);
