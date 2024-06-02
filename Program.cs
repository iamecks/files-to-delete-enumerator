string resultsfile = $"{DateTime.Now:yyyyMMddHHmmss} results.txt";
string folder = "";

// Create a new file to hold the results
using (StreamWriter sw = File.CreateText(resultsfile))
{
    sw.WriteLine("FullName,Name,Length,LastWriteTime");
}

Console.WriteLine("Enter File/s Directory:");
string? inputDirectotyPath = Console.ReadLine();

if (string.IsNullOrEmpty(inputDirectotyPath))
{
    Console.WriteLine("Invalid Directory Path");
    return;
}

if (Directory.Exists(inputDirectotyPath))
{
    folder = inputDirectotyPath;
    Console.WriteLine("Path: {0}", inputDirectotyPath);
}

// create a DirectoryInfo for the given folder
DirectoryInfo di = new(folder);

foreach (FileInfo fi in di.EnumerateFiles())
{
    // append to csv file, file name, size, and last modified date
    using StreamWriter sw = File.AppendText(resultsfile);
    sw.WriteLine($"{fi.FullName},{fi.Name},{Math.Floor(fi.Length / 1024.0 / 1024.0)} MB,{fi.LastWriteTime}");
}

Console.WriteLine("Log file complete.");
