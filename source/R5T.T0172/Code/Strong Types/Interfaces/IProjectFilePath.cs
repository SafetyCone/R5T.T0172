using System;

using R5T.T0178;
using R5T.T0181;


namespace R5T.T0172
{
    /// <summary>
    /// Strongly-types a string as a .NET project file path.
    /// </summary>
    [StrongTypeMarker]
    public interface IProjectFilePath : IStrongTypeMarker,
        IXmlFilePath
    {
    }
}
