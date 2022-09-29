const string dirName = "TestDir";

// Creating directories.

if (!Directory.Exists(dirName)) {
    Directory.CreateDirectory(dirName);
} else {
    Directory.Delete(dirName);
}

// Get directory path
string currentPath = Directory.GetCurrentDirectory();
// System.Console.WriteLine($"Current Directory: {currentPath}");

// Get directory info
// DirectoryInfo di = new DirectoryInfo(currentPath);
// System.Console.WriteLine($"{di.Name}");
// System.Console.WriteLine($"{di.Parent}");
// System.Console.WriteLine($"{di.CreationTime}");

// Enumerate contents of directories
System.Console.WriteLine("\n.............\n");
System.Console.WriteLine("Just directory content: ");
List<string> theDirs = new List<string>(Directory.EnumerateDirectories(currentPath));
foreach (string str in theDirs) {
    System.Console.WriteLine(str);
}
System.Console.WriteLine("\n.............\n");
System.Console.WriteLine("Just files content: ");

theDirs = new List<string>(Directory.EnumerateFiles(currentPath));
foreach (string str in theDirs) {
    System.Console.WriteLine(str);
}

System.Console.WriteLine("\n.............\n");
System.Console.WriteLine("All directory content: ");
theDirs = new List<string>(Directory.EnumerateFileSystemEntries(currentPath));
foreach (string str in theDirs) {
    System.Console.WriteLine(str);
}