using System;

using R5T.T0178;
using R5T.T0180;


namespace R5T.T0172
{
    /// <summary>
    /// Represents the directory path of a .NET project.
    /// </summary>
    [StrongTypeMarker]
    public interface IProjectDirectoryPath : IStrongTypeMarker,
        IDirectoryPath
    {
    }
}
