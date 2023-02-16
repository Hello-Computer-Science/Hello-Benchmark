using System;
using System.IO;
using ArrayProducer;

var ask = (string msg) =>
{
    Console.Write(msg);
    return Console.ReadLine();
};

int length = int.Parse(ask("Input array length: "));
(int, int) range = ask("Input element range: ").Split('-').ToIntInt();
Random random = new();
if (File.Exists("array.txt")) File.Delete("array.txt");
FileStream fs = new("array.txt", FileMode.OpenOrCreate, FileAccess.Write);
StreamWriter sw = new(fs);

for (int i = 0; i < length; ++i)
{
    sw.WriteLine(random.Next(range.Item1, range.Item2));
}

sw.Close();
fs.Close();
sw.Dispose();
fs.Dispose();

Console.WriteLine("Done!");
// Console.ReadKey();

