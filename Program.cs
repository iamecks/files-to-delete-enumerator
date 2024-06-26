﻿Console.WriteLine("Enter File/s Directory:");
string? inputDirectotyPath = Console.ReadLine();

if (string.IsNullOrEmpty(inputDirectotyPath))
{
    Console.WriteLine("Invalid Directory Path");
    return;
}

if (!Directory.Exists(inputDirectotyPath))
{
    Console.WriteLine("Invalid Directory Path");
    return;
}

// Create results file placeholder
string resultsfile = Path.Combine("output", $"{DateTime.Now:yyyyMMddHHmmss} Log.txt");
CreateResultsFile(resultsfile);

// Get all files in the directory and log them
LogFilesAndDirectories(inputDirectotyPath, resultsfile);
Console.WriteLine("Log file complete.");


static void CreateResultsFile(string resultsfile)
{
    string? directoryPath = Path.GetDirectoryName(resultsfile);
    if (directoryPath != null && !Directory.Exists(directoryPath))
    {
        Directory.CreateDirectory(directoryPath);
    }

    using StreamWriter sw = File.CreateText(resultsfile);
    sw.WriteLine("FullName,Name,Size,LastWriteTime");
}

static void LogFilesAndDirectories(string directoryPath, string resultsfile)
{
    DirectoryInfo di = new(directoryPath);
    using StreamWriter sw = File.AppendText(resultsfile);

    // Enumerate files in the directory
    foreach (FileInfo fi in di.EnumerateFiles())
    {
        sw.WriteLine($"{fi.FullName},{fi.Name},{Math.Floor(fi.Length / 1024.0 / 1024.0)} MB,{fi.LastWriteTime}");
    }

    // Enumerate folders in the directory
    foreach (DirectoryInfo dir in di.EnumerateDirectories())
    {
        sw.WriteLine($"{dir.FullName},{dir.Name},Directory,{dir.LastWriteTime}");
    }
}