using System;

using R5T.T0178;
using R5T.T0181;


namespace R5T.T0172
{
    /// <summary>
    /// Strongly-types a string as a .NET project file name.
    /// </summary>
    [StrongTypeMarker]
    public interface IProjectFileName : IStrongTypeMarker,
        IXmlFileName
    {
    }
}
