using System;

using R5T.T0178;
using R5T.T0180;


namespace R5T.T0172
{
    /// <summary>
    /// Strongly-types a string as a project-directory relative directory path.
    /// </summary>
    [StrongTypeMarker]
    public interface IProjectDirectoryRelativeDirectoryPath : IStrongTypeMarker,
        IProjectDirectoryRelativePath,
        IRelativeDirectoryPath
    {
    }
}
