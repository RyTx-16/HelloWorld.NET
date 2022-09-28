string[] numbStrs = {"  1  ", "   1.45", "-100", "5e+04  "};

int testint;
float testfloat;
bool result;

// Parse method to turn string to number 
foreach (string s in numbStrs) {
    try {
        testfloat = float.Parse(s);
        System.Console.WriteLine($"Parsed no (f) is : {testfloat}");
        testint = int.Parse(s);
        System.Console.WriteLine($"Parsed no (i) is : {testint}");
    }
    catch (FormatException e) {
        System.Console.WriteLine($"Could not parse '{s}' : {e.Message}");
    }
}

// TryParse method returns true is success 
result = int.TryParse(numbStrs[0], out testint);
System.Console.WriteLine($"\n{result} -- '{numbStrs[0]}' : {testint}");

result = float.TryParse(numbStrs[1], out testfloat);
System.Console.WriteLine($"{result} -- '{numbStrs[1]}' : {testfloat}");

result = int.TryParse(numbStrs[2], out testint);
System.Console.WriteLine($"{result} -- '{numbStrs[2]}' : {testint}");

result = float.TryParse(numbStrs[3], out testfloat);
System.Console.WriteLine($"{result} -- '{numbStrs[3]}' : {testfloat}");


// WILL FAIL
result = int.TryParse(numbStrs[1], out testint);
System.Console.WriteLine($"\n{result} -- '{numbStrs[1]}' : {testint}");