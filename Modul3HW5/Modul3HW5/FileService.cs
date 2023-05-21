using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3HW5
{
    internal class FileService
    {
        public static async Task<string> ReadFile1()
        {
            var filecontains = await File.ReadAllTextAsync("Hello.txt");
            return filecontains;
        }

        public static Task<string> ReadFile2() => File.ReadAllTextAsync("world.txt");

        public static async Task<string> SummFiles()
        {
            var temp = ReadFile1();
            var temp2 = ReadFile2();
            await Task.WhenAll(temp, temp2);
            return $"{await temp} {await temp2}";
        }

        public static void Display()
        {
            var result = SummFiles().GetAwaiter().GetResult();
            Console.WriteLine(result);
        }
    }
}
