using System;

using R5T.T0150;
using R5T.T0175;


namespace R5T.T0172
{
    /// <summary>
    /// Represents the file path of the documention XML file that is generated for a project by the compiler.
    /// </summary>
    /// <remarks>
    /// Note: to get Visual Studio (or dotnet) to generate a documentation file for a project, you might have to add the &lt;GenerateDocumentationFile&gt; project property,
    /// and set it to true (<see href="https://learn.microsoft.com/en-us/dotnet/core/project-sdk/msbuild-props#generatedocumentationfile"/>).
    /// Be sure to also add some documentation to a member (type or method) in the assembly so that there is actually documentation for the documentation file.
    /// </remarks>
    [StrongTypeMarker]
    public interface IDocumentationXmlFilePath : IFilePath, IStrongTypeMarker
    {
    }
}