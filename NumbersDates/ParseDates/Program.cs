// Parsing date/times

string[] dateTimes = {
    "January 1, 2025 9:30 AM",
    "1/1/2025",
    "Jan 1, 2025 7:30PM",
    "Jan 1, 25",
    "1/2025",
    "1/1 7PM",
    "Jan 1 '15"
};

foreach (string dateStr in dateTimes) {
    DateTime result;
    if (DateTime.TryParse(dateStr, out result)) {
        System.Console.WriteLine($"{dateStr, -25} gets passed as: {result} ");
    }
    else {
        System.Console.WriteLine($"Could not parse: {dateStr}");
    }
}