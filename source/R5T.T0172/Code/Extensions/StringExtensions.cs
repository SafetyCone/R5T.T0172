using System;


namespace R5T.T0172.Extensions
{
    public static class StringExtensions
    {
        /// <inheritdoc cref="IStringOperator.ToAssemblyFileName(string)"/>
        public static IAssemblyFileName ToAssemblyFileName(this string value)
        {
            return Instances.StringOperator_Extensions.ToAssemblyFileName(value);
        }

        /// <inheritdoc cref="IStringOperator.ToAssemblyFilePath(string)"/>
        public static IAssemblyFilePath ToAssemblyFilePath(this string value)
        {
            return Instances.StringOperator_Extensions.ToAssemblyFilePath(value);
        }

        /// <inheritdoc cref="IStringOperator.ToCodeFilePath(string)"/>
        public static ICodeFilePath ToCodeFilePath(this string value)
        {
            return Instances.StringOperator_Extensions.ToCodeFilePath(value);
        }

        /// <inheritdoc cref="IStringOperator.ToCSharpFilePath(string)"/>
        public static ICSharpFilePath ToCSharpFilePath(this string value)
        {
            return Instances.StringOperator_Extensions.ToCSharpFilePath(value);
        }

        /// <inheritdoc cref="IStringOperator.ToCSharpFileName(string)"/>
        public static ICSharpFileName ToCSharpFileName(this string value)
        {
            return Instances.StringOperator_Extensions.ToCSharpFileName(value);
        }

        /// <inheritdoc cref="IStringOperator.ToDocumentationXmlFilePath(string)"/>
        public static IDocumentationXmlFilePath ToDocumentationXmlFilePath(this string value)
        {
            return Instances.StringOperator_Extensions.ToDocumentationXmlFilePath(value);
        }

        /// <inheritdoc cref="IStringOperator.ToProjectDirectoryPath(string)"/>
        public static IProjectDirectoryPath ToProjectDirectoryPath(this string value)
        {
            return Instances.StringOperator_Extensions.ToProjectDirectoryPath(value);
        }

        /// <inheritdoc cref="IStringOperator.ToProjectFileName(string)"/>
        public static IProjectFileName ToProjectFileName(this string value)
        {
            return Instances.StringOperator_Extensions.ToProjectFileName(value);
        }

        /// <inheritdoc cref="IStringOperator.ToProjectFilePath(string)"/>
        public static IProjectFilePath ToProjectFilePath(this string value)
        {
            return Instances.StringOperator_Extensions.ToProjectFilePath(value);
        }

        /// <inheritdoc cref="IStringOperator.ToProjectDirectoryRelativeDirectoryPath(string)"/>
        public static IProjectDirectoryRelativeDirectoryPath ToProjectDirectoryRelativeDirectoryPath(this string value)
        {
            return Instances.StringOperator_Extensions.ToProjectDirectoryRelativeDirectoryPath(value);
        }

        /// <inheritdoc cref="IStringOperator.ToProjectDirectoryRelativePath(string)"/>
        public static IProjectDirectoryRelativePath ToProjectDirectoryRelativePath(this string value)
        {
            return Instances.StringOperator_Extensions.ToProjectDirectoryRelativePath(value);
        }

        /// <inheritdoc cref="IStringOperator.ToSolutionDirectoryPath(string)"/>
        public static ISolutionDirectoryPath ToSolutionDirectoryPath(this string value)
        {
            return Instances.StringOperator_Extensions.ToSolutionDirectoryPath(value);
        }

        /// <inheritdoc cref="IStringOperator.ToSolutionFileName(string)"/>
        public static ISolutionFileName ToSolutionFileName(this string value)
        {
            return Instances.StringOperator_Extensions.ToSolutionFileName(value);
        }

        /// <inheritdoc cref="IStringOperator.ToSolutionFilePath(string)"/>
        public static ISolutionFilePath ToSolutionFilePath(this string value)
        {
            return Instances.StringOperator_Extensions.ToSolutionFilePath(value);
        }
    }
}
