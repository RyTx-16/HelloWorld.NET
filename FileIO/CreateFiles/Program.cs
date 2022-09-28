// Creating a file 

const string fileName = "TestFile.txt";

// 'Using' to auto close the file stream
// using(StreamWriter sw = File.CreateText(fileName)) {
//     sw.WriteLine("New text file.");
// }

// Determine if a file already exists
System.Console.WriteLine(File.Exists(fileName));
if (File.Exists(fileName)) {
    File.Delete(fileName);
} else {
    using(StreamWriter sw = File.CreateText(fileName)) {
    sw.WriteLine("New text file.");
    }
}
System.Console.WriteLine(File.Exists(fileName));
