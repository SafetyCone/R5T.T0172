using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0172
{
    /// <inheritdoc cref="IDocumentationXmlFilePath"/>
    [StrongTypeImplementationMarker]
    public class DocumentationXmlFilePath : TypedBase<string>, IStrongTypeMarker,
        IDocumentationXmlFilePath
    {
        public DocumentationXmlFilePath(string value)
            : base(value)
        {
        }
    }
}
