using System;

using R5T.T0150;
using R5T.T0151;


namespace R5T.T0172
{
    /// <inheritdoc cref="IDocumentationXmlFilePath"/>
    [StrongTypeMarker]
    public class DocumentationXmlFilePath : TypedString, IStrongTypeMarker, IDocumentationXmlFilePath
    {
        public DocumentationXmlFilePath(string value)
            : base(value)
        {
        }
    }
}
