string str1 = "The quick brown fox jumps over the lazy dog.";
string str2 = "This is a string";
string str3 = "THIS is a STRING";
string[] strs = {"one", "two", "three", "four"};

// String length
// Console.WriteLine(str1.Length);

// Individual Chars
// Console.WriteLine(str1[14]);

// Iterate over string
// foreach (char ch in str1) {
//     Console.Write(ch);
//     if (ch == 'x') {
//         System.Console.WriteLine("");
//         break;
//     }
// }

// String concatenation
string outstr;
outstr = String.Concat(strs);
System.Console.WriteLine(outstr);

// Join strings
outstr = String.Join('.', strs);
System.Console.WriteLine(outstr);
outstr = String.Join("---", strs);
System.Console.WriteLine(outstr);

// String comparison
bool isEqual = str2.Equals(str3);
System.Console.WriteLine($"\n{isEqual}");

int res = String.Compare(str2, "This is a string");
System.Console.WriteLine($"{res}");

// Replacing
string outstr1 = str1.Replace("fox", "cat");
System.Console.WriteLine($"\n{outstr1}");