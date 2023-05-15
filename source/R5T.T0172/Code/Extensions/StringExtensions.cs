using System;


namespace R5T.T0172.Extensions
{
    public static class StringExtensions
    {
        public static IAssemblyFilePath ToAssemblyFilePath(this string value)
        {
            return Instances.StringOperator.ToAssemblyFilePath(value);
        }

        public static ICodeFilePath ToCodeFilePath(this string value)
        {
            return Instances.StringOperator.ToCodeFilePath(value);
        }

        public static ICSharpFilePath ToCSharpFilePath(this string value)
        {
            return Instances.StringOperator.ToCSharpFilePath(value);
        }

        public static ICSharpFileName ToCSharpFileName(this string value)
        {
            return Instances.StringOperator.ToCSharpFileName(value);
        }

        public static IDocumentationXmlFilePath ToDocumentationXmlFilePath(this string value)
        {
            return Instances.StringOperator.ToDocumentationXmlFilePath(value);
        }

        public static IProjectDirectoryPath ToProjectDirectoryPath(this string value)
        {
            return Instances.StringOperator.ToProjectDirectoryPath(value);
        }

        public static IProjectFileName ToProjectFileName(this string value)
        {
            return Instances.StringOperator.ToProjectFileName(value);
        }

        public static IProjectFilePath ToProjectFilePath(this string value)
        {
            return Instances.StringOperator.ToProjectFilePath(value);
        }

        public static IProjectDirectoryRelativeDirectoryPath ToProjectDirectoryRelativeDirectoryPath(this string value)
        {
            return Instances.StringOperator.ToProjectDirectoryRelativeDirectoryPath(value);
        }

        public static IProjectDirectoryRelativePath ToProjectDirectoryRelativePath(this string value)
        {
            return Instances.StringOperator.ToProjectDirectoryRelativePath(value);
        }

        public static ISolutionDirectoryPath ToSolutionDirectoryPath(this string value)
        {
            return Instances.StringOperator.ToSolutionDirectoryPath(value);
        }

        public static ISolutionFileName ToSolutionFileName(this string value)
        {
            return Instances.StringOperator.ToSolutionFileName(value);
        }

        public static ISolutionFilePath ToSolutionFilePath(this string value)
        {
            return Instances.StringOperator.ToSolutionFilePath(value);
        }
    }
}
