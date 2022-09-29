// Read/Write to a file

const string fileName = "TestFile.txt";

// WriteAllText - overwrites a file with the given content.
if (!File.Exists(fileName)) {
    File.WriteAllText(fileName, "Text in file.");
// } else {
//     using(StreamWriter sw = File.CreateText(fileName)) {
//     sw.WriteLine("New text file.");
//     }
}

// ReadAllText - reads all the content from a file.
string content;
content = File.ReadAllText(fileName);
System.Console.WriteLine(content);

// AppendAllText - Adds text to an existing file
File.AppendAllText(fileName, "Text added to the file.");

// FileStream can be opened and written to until closed.
using (StreamWriter sw = File.AppendText(fileName)) {
    sw.WriteLine("Line 1");
    sw.WriteLine("Line 2");
    sw.WriteLine("Line 3");
}