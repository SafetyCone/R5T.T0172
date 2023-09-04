using System;

using R5T.T0132;


namespace R5T.T0172.Extensions
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        /// <inheritdoc cref="IAssemblyFileName"/>
        public IAssemblyFileName ToAssemblyFileName(string value)
        {
            var output = new AssemblyFileName(value);
            return output;
        }

        /// <inheritdoc cref="IAssemblyFilePath"/>
        public IAssemblyFilePath ToAssemblyFilePath(string value)
        {
            var output = new AssemblyFilePath(value);
            return output;
        }

        /// <inheritdoc cref="ICodeFilePath"/>
        public ICodeFilePath ToCodeFilePath(string value)
        {
            var output = new CodeFilePath(value);
            return output;
        }

        /// <inheritdoc cref="ICSharpFileName"/>
        public ICSharpFileName ToCSharpFileName(string value)
        {
            var output = new CSharpFileName(value);
            return output;
        }

        /// <inheritdoc cref="ICSharpFilePath"/>
        public ICSharpFilePath ToCSharpFilePath(string value)
        {
            var output = new CSharpFilePath(value);
            return output;
        }

        /// <inheritdoc cref="IDocumentationXmlFilePath"/>
        public IDocumentationXmlFilePath ToDocumentationXmlFilePath(string value)
        {
            var output = new DocumentationXmlFilePath(value);
            return output;
        }

        /// <inheritdoc cref="IProjectDirectoryPath"/>
        public IProjectDirectoryPath ToProjectDirectoryPath(string value)
        {
            var output = new ProjectDirectoryPath(value);
            return output;
        }

        /// <inheritdoc cref="IProjectFileName"/>
        public IProjectFileName ToProjectFileName(string value)
        {
            var output = new ProjectFileName(value);
            return output;
        }

        /// <inheritdoc cref="IProjectFilePath"/>
        public IProjectFilePath ToProjectFilePath(string value)
        {
            var output = new ProjectFilePath(value);
            return output;
        }

        /// <inheritdoc cref="IProjectDirectoryRelativeDirectoryPath"/>
        public IProjectDirectoryRelativeDirectoryPath ToProjectDirectoryRelativeDirectoryPath(string value)
        {
            var output = new ProjectDirectoryRelativeDirectoryPath(value);
            return output;
        }

        /// <inheritdoc cref="IProjectDirectoryRelativePath"/>
        public IProjectDirectoryRelativePath ToProjectDirectoryRelativePath(string value)
        {
            var output = new ProjectDirectoryRelativePath(value);
            return output;
        }

        /// <inheritdoc cref="ISolutionDirectoryPath"/>
        public ISolutionDirectoryPath ToSolutionDirectoryPath(string value)
        {
            var output = new SolutionDirectoryPath(value);
            return output;
        }

        /// <inheritdoc cref="ISolutionFileName"/>
        public ISolutionFileName ToSolutionFileName(string value)
        {
            var output = new SolutionFileName(value);
            return output;
        }

        /// <inheritdoc cref="ISolutionFilePath"/>
        public ISolutionFilePath ToSolutionFilePath(string value)
        {
            var output = new SolutionFilePath(value);
            return output;
        }
    }
}
