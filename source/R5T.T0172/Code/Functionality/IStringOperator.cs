using System;

using R5T.T0132;


namespace R5T.T0172
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        public IAssemblyFilePath ToAssemblyFilePath(string value)
        {
            var output = new AssemblyFilePath(value);
            return output;
        }

        public ICodeFilePath ToCodeFilePath(string value)
        {
            var output = new CodeFilePath(value);
            return output;
        }

        public ICSharpFileName ToCSharpFileName(string value)
        {
            var output = new CSharpFileName(value);
            return output;
        }

        public ICSharpFilePath ToCSharpFilePath(string value)
        {
            var output = new CSharpFilePath(value);
            return output;
        }

        public IDocumentationXmlFilePath ToDocumentationXmlFilePath(string value)
        {
            var output = new DocumentationXmlFilePath(value);
            return output;
        }

        public IProjectDirectoryPath ToProjectDirectoryPath(string value)
        {
            var output = new ProjectDirectoryPath(value);
            return output;
        }

        public IProjectFileName ToProjectFileName(string value)
        {
            var output = new ProjectFileName(value);
            return output;
        }

        public IProjectFilePath ToProjectFilePath(string value)
        {
            var output = new ProjectFilePath(value);
            return output;
        }

        public IProjectDirectoryRelativeDirectoryPath ToProjectDirectoryRelativeDirectoryPath(string value)
        {
            var output = new ProjectDirectoryRelativeDirectoryPath(value);
            return output;
        }

        public IProjectDirectoryRelativePath ToProjectDirectoryRelativePath(string value)
        {
            var output = new ProjectDirectoryRelativePath(value);
            return output;
        }

        public ISolutionDirectoryPath ToSolutionDirectoryPath(string value)
        {
            var output = new SolutionDirectoryPath(value);
            return output;
        }

        public ISolutionFileName ToSolutionFileName(string value)
        {
            var output = new SolutionFileName(value);
            return output;
        }

        public ISolutionFilePath ToSolutionFilePath(string value)
        {
            var output = new SolutionFilePath(value);
            return output;
        }
    }
}
