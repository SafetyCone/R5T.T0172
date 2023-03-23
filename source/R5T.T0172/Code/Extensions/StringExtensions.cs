using System;


namespace R5T.T0172.Extensions
{
    public static class StringExtensions
    {
        public static AssemblyFilePath ToAssemblyFilePath(this string value)
        {
            return Instances.StringOperator.ToAssemblyFilePath(value);
        }

        public static DocumentationXmlFilePath ToDocumentationXmlFilePath(this string value)
        {
            return Instances.StringOperator.ToDocumentationXmlFilePath(value);
        }

        public static ProjectFilePath ToProjectFilePath(this string value)
        {
            return Instances.StringOperator.ToProjectFilePath(value);
        }

        public static SolutionFilePath ToSolutionFilePath(this string value)
        {
            return Instances.StringOperator.ToSolutionFilePath(value);
        }
    }
}
