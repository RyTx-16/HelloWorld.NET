const string fName = "TestFile.txt";

if (!File.Exists(fName)) {
    using (StreamWriter sw = File.CreateText(fName)) {
        sw.WriteLine("A text file.");
    }
}

// Get File Info
System.Console.WriteLine(File.GetCreationTime(fName));
System.Console.WriteLine(File.GetLastWriteTime(fName));
System.Console.WriteLine(File.GetLastAccessTime(fName));

File.SetAttributes(fName, FileAttributes.ReadOnly);
System.Console.WriteLine(File.GetAttributes(fName));

// General file info.

try {
    FileInfo fi = new FileInfo(fName);
    System.Console.WriteLine($"\n{fi.Length}");
    System.Console.WriteLine($"{fi.Directory}");
    System.Console.WriteLine($"{fi.IsReadOnly}\n");
} catch (Exception e) {
    System.Console.WriteLine($"Exception: {e}");
}

// Manipulate info
DateTime dt = new DateTime(2022, 7, 1);
File.SetCreationTime(fName, dt);
System.Console.WriteLine(File.GetCreationTime(fName));