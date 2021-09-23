using System;
using System.IO;
using System.Linq;
using GlyphJsonToCsharp.Helpers;

namespace GlyphJsonToCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var glyphDir = Directory.GetDirectories(Directory.GetCurrentDirectory()).First(x => x.EndsWith("GlyphMaps"));
            var files = Directory.GetFiles(glyphDir);
            var exportPath = AssemblyHelper.EntryAssemblyDirectory;

            var codeWrite = new CodeWriter();

            foreach (var file in files)
            {
                var code = codeWrite.Write(file);
                File.WriteAllText(Path.Combine(exportPath, $"{Path.GetFileName(file).Replace("json","cs")}"), code);
            }
            
            OpenFileHelper.OpenAndSelect(exportPath);
        }
    }
}