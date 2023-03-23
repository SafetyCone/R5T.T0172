using System;

using R5T.T0132;


namespace R5T.T0172
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        public AssemblyFilePath ToAssemblyFilePath(string value)
        {
            var output = new AssemblyFilePath(value);
            return output;
        }

        public DocumentationXmlFilePath ToDocumentationXmlFilePath(string value)
        {
            var output = new DocumentationXmlFilePath(value);
            return output;
        }

        public ProjectFilePath ToProjectFilePath(string value)
        {
            var output = new ProjectFilePath(value);
            return output;
        }

        public SolutionFilePath ToSolutionFilePath(string value)
        {
            var output = new SolutionFilePath(value);
            return output;
        }
    }
}
