using System.IO;

namespace GlyphJsonToCsharp.Helpers
{
    public static class ResourcesHelper
    {
        public static string ReadResourceContent(string resourceName)
        {
            var assembly = typeof(ResourcesHelper).Assembly;
            using (var stream = assembly.GetManifestResourceStream(resourceName))
            {
                using (var reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
        }
    }
}
