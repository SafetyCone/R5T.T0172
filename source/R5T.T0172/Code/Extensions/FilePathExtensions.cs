using System;

using R5T.T0180;


namespace R5T.T0172.Extensions
{
    public static class FilePathExtensions
    {
        public static IProjectFilePath AsProjectFilePath(this IFilePath filePath)
        {
            return Instances.FilePathOperator.AsProjectFilePath(filePath);
        }
    }
}
