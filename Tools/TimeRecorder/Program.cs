
using System;
using System.Diagnostics;
using System.IO;

var ask = (string msg) =>{
    Console.Write(msg);
    return Console.ReadLine();
};

var filename = ask("Test program path: ");
var inputfile = ask("Data file path: ");
var sw = new System.Diagnostics.Stopwatch();
var psi = new ProcessStartInfo()
{
    FileName = Path.GetFullPath(filename),
    Arguments = Path.GetFullPath(inputfile),
    UseShellExecute = false,
    RedirectStandardOutput = false,
    RedirectStandardError = false,
    CreateNoWindow = true,
};
var process = new Process();
process.StartInfo = psi;
process.Start();
sw.Start();
process.WaitForExit();
sw.Stop();
Console.WriteLine(sw.Elapsed);


