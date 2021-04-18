using System;

namespace WordEditor.Utils
{
    public static class FileUtils
    {
        public static string GetFileExtension(string fileName)
        {
            var lastDotIndex = fileName.LastIndexOf(".", StringComparison.Ordinal);
            return fileName.Substring(lastDotIndex + 1, fileName.Length - lastDotIndex - 1);
        }
    }
}